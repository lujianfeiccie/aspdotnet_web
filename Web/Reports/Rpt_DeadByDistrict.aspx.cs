using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;

public partial class Rpt_DeadByDistrict : System.Web.UI.Page
{

    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }

        DataTable dt = getTableShow();



        GridView1.DataSource = dt;
        GridView1.DataBind();

      
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        DataTable dt = getTableShow();


        string[] colname = new string[] { "地区", "HIV本年", "AIDS本年", "本年死亡", "HIV", "AIDS", "死亡" };
        DataRow dr = dt.NewRow();

        for (int i = 0; i < colname.Length; i++)
            dr[colname[i]] = GridView1.Columns[i].HeaderText;

     



        if (cbSettings.Checked == true) //高级设置
        {

            foreach (Control con in this.Panel1.Controls)
            {
                if (con is CheckBox)
                {
                    if (((CheckBox)con).Checked == false)
                        dt.Columns.Remove(mapping(((CheckBox)con).UniqueID.Trim()));
                    //Response.Write("<script>alert('" + mapping(((CheckBox)con).ID) + "')</script>");  
                }
            }


        }
        SaveToExcel(dt, "按分区统计感染与死亡例数.xls");
    }
    private string mapping(string cbID)
    {
        string str = string.Empty;
        switch (cbID)
        {
            case "cbDistrict": str = "地区"; break;
            case "cbHivThisYear": str = "HIV本年"; break;
            case "cbAidsThisYear": str = "AIDS本年"; break;
            case "cbDiedThisYear": str = "本年死亡"; break;
            case "cbHiv": str = "HIV"; break;
            case "cbAids": str = "AIDS"; break;
            case "cbDeath": str = "死亡"; break;
           

        }
        return str;
    }
   
    protected void  cbSettings_CheckedChanged(object sender, EventArgs e)
    {
        if(cbSettings.Checked==true)
        {
           Panel1.Visible=true;
        }
        else
        {
           Panel1.Visible=false;
        }
    }
    private DataTable getTableShow()
    {
        Model.tb_lxbx lxbx = new Model.tb_lxbx();
        BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

        DataTable dt = new DataTable();


        DataColumn dc;
        dc = new DataColumn("地区", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV本年", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS本年", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("本年死亡", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("死亡", typeof(string));
        dt.Columns.Add(dc);


        string[] district ={ "深圳", "罗湖", "福田", "南山", "盐田", "宝安", "龙岗", "光明新区", "坪山新区" };

        for (int i = 0; i < district.Length; i++)
        {
            string strWhere=string.Empty;
            DataRow dr = dt.NewRow();

            if (district[i] == "深圳")
                strWhere = "";
            else
                strWhere = " FK_District='" + district[i] + "' ";

            dr["地区"] = district[i];
            dr["HIV本年"] = getNumberOfHIVthisYear(strWhere);
            dr["AIDS本年"] = getNumberOfAIDSthisYear(strWhere); 
            dr["本年死亡"] = getNumberOfDeaththisYear(strWhere); 
            dr["HIV"] = getNumberOfHIV(strWhere); 
            dr["AIDS"] = getNumberOfAIDS(strWhere); 
            dr["死亡"] = getNumberOfDeath(strWhere); 

            dt.Rows.Add(dr);
        }
        return dt;

    }
//今年感染HIV例数
    private int getNumberOfHIVthisYear(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" SUBSTRING(ToAidsDate,1,4) = Year(GETDATE()) AND  FK_CurrentSituation='HIV' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //今年感染AIDS例数
    private int getNumberOfAIDSthisYear(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" SUBSTRING(ToAidsDate,1,4) = Year(GETDATE()) AND  FK_CurrentSituation='AIDS' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //今年死亡例数
    private int getNumberOfDeaththisYear(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" SUBSTRING(ToAidsDate,1,4) = Year(GETDATE()) AND  FK_IsDead='是' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //累积感染HIV例数
    private int getNumberOfHIV(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" FK_CurrentSituation='HIV' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //累积感染AIDS例数
    private int getNumberOfAIDS(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" FK_CurrentSituation='AIDS' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //累积死亡例数
    private int getNumberOfDeath(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" FK_IsDead='是' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    protected void cbSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox[] cbxs ={cbDistrict,cbHivThisYear,cbAidsThisYear,cbDiedThisYear,cbHiv,cbAids,cbDeath};

        if (((CheckBox)sender).Checked)
        {

            for (int i = 0; i < cbxs.Length; i++)
                cbxs[i].Checked = true;
        }
        else
        {
            for (int i = 0; i < cbxs.Length; i++)
                cbxs[i].Checked = false;
        }
    }
    /// <summary>
    /// 导出Excel方法
    /// </summary>
    /// <param name="gv"></param>
    /// <param name="FileType"></param>
    /// <param name="FileName"></param>
    private void SaveToExcel(GridView gv, string FileName)
    {

        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.UTF7;
        //输出标题
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8).ToString());
        Response.ContentType = "application/ms-excel";  //文件的类型
        this.EnableViewState = false;
        StringWriter tw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(tw);
        gv.RenderControl(hw);

        Response.Write(tw.ToString());
        Response.End();

    }
    private void SaveToExcel(DataTable objTable, string FileName)
    {
        int CountR = objTable.Rows.Count;//行数
        int CountC = objTable.Columns.Count;//列数
        Response.Clear();
        Response.Buffer = true;
        //设置Http的头信息,编码格式
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8).ToString());
        Response.ContentType = "application/ms-excel";

        //设置编码
        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
        //写表头
        for (int i = 0; i < CountC; i++)
        {
            Response.Write(objTable.Columns[i].ColumnName + "\t");
        }
        Response.Write("\n");
        //写表内容
        for (int RowNo = 0; RowNo <= CountR - 1; RowNo++)
        {
            string RowContent = "";
            for (int CloumnNo = 0; CloumnNo <= CountC - 1; CloumnNo++)
            {
                RowContent += Convert.ToString(objTable.Rows[RowNo][CloumnNo]) + "\t";
            }
            RowContent += "\n";
            Response.Write(RowContent);
        }
        Response.End();
    }
}
