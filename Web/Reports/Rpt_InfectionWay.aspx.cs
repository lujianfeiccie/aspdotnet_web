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

public partial class Rpt_InfectionWay : System.Web.UI.Page
{

    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
    BLL.TB_InfectionWay bbl_InfectionWay = new BLL.TB_InfectionWay();

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = getTableShow();



        GridView1.DataSource = dt;
        GridView1.DataBind();
       
    }


    protected void btnExport_Click(object sender, EventArgs e)
    {
       // Export(GridView1,"application/ms-excel", "导出数据.xls");

        DataTable dt = getTableShow();

     

        if (cbSettings.Checked == true) //高级设置
        {

            foreach (Control con in this.Panel1.Controls)
            {
                if (con is CheckBox)
                {
                    if (((CheckBox)con).Checked == false)
                        dt.Columns.Remove(mapping(((CheckBox)con).UniqueID.Trim()));
                
                }
            }


        }
        SaveToExcel(dt,"传播统计.xls");
      
    }

    private string mapping(string cbID)
    {
        string str = string.Empty;
        switch (cbID)
        {
            case "cbInfectionWay": str = "传播途径"; break;
            case "cbHivThisYear": str = "HIV本年"; break;
            case "cbHivPerThisYear": str = "HIV本年%"; break;
            case "cbAidsThisYear": str = "AIDS本年"; break;
            case "cbAidsPerThisYear": str = "AIDS本年%"; break;
            case "cbHiv": str = "HIV"; break;
            case "cbHivPer": str = "HIV%"; break;
            case "cbAids": str = "AIDS"; break;
            case "cbAidsPer": str = "AIDS%"; break;
             

        }
        return str;
    }





    private DataTable getTableShow()
    {
        #region 算法
//--已知数：
//--
//--HIV今年例数
//--AIDS今年例数
//--今年总数
//--
//--HIV例数
//--AIDS例数
//--总数
//--
//--
//--未知数
//--
//--HIV今年比例
//--AIDS今年比例
//--HIV比例
//--AIDS比例
//--
//--未知数与已知数的关系:
//--
//--HIV今年比例 = HIV今年例数/今年总数
//--AIDS今年比例 = AIDS今年例数/今年总数
//--
//--HIV比例 = HIV例数/总数
        //--AIDS比例 = AIDS例数/总数
        #endregion
        Model.tb_lxbx lxbx = new Model.tb_lxbx();
        BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

        DataTable dt = new DataTable();


        DataColumn dc;
        dc = new DataColumn("传播途径", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV本年", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV本年%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS本年", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS本年%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS%", typeof(string));
        dt.Columns.Add(dc);


        string[] InfectionWayName ={ "注射毒品", "异性传播", "同性/双性传播", "性接触+注射毒品", "采血(浆)", "输血/血制品", "母婴传播", "职业暴露", "其他", "不详" };
       
        int Length=bbl_InfectionWay.GetAllList().Tables[0].Rows.Count;
        float total, num;
        for (int i = 0; i <Length; i++)
        {
           
            DataRow dr = dt.NewRow();
            dr["传播途径"] = InfectionWayName[i];
            dr["HIV本年"] = getNumberOfHIVthisYear(" FK_InfectionWay='" + InfectionWayName[i]+"' ");
            
            num = Convert.ToSingle(dr["HIV本年"].ToString());
            total = Convert.ToSingle(getNumberOfthisYear());
            dr["HIV本年%"] = (num / total)*100;

            dr["AIDS本年"] = getNumberOfAIDSthisYear(" FK_InfectionWay='" + InfectionWayName[i]+"' ");
           
            num = Convert.ToSingle(dr["AIDS本年"].ToString());
            total = Convert.ToSingle(getNumberOfthisYear());
            dr["AIDS本年%"] = (num / total) * 100;


            dr["HIV"] = getNumberOfHIV(" FK_InfectionWay='" + InfectionWayName[i]+"' ");

            num = Convert.ToSingle(dr["HIV"].ToString());
            total = Convert.ToSingle(getNumber());
            dr["HIV%"] = (num / total) * 100;
             
            dr["AIDS"] = getNumberOfAIDS(" FK_InfectionWay='" + InfectionWayName[i]+"' ");

            num = Convert.ToSingle(dr["AIDS"].ToString());
            total = Convert.ToSingle(getNumber());
            dr["AIDS%"] = (num / total) * 100;
            
            dt.Rows.Add(dr);
        }

        DataRow lastRow = dt.NewRow();
        lastRow["传播途径"] = "合计";
        lastRow["HIV本年"] = getNumberOfHIVthisYear("");
        num = Convert.ToSingle(lastRow["HIV本年"].ToString());
        total = Convert.ToSingle(getNumberOfthisYear());

        lastRow["HIV本年%"] = (num/total)*100;
        lastRow["AIDS本年"] =getNumberOfAIDSthisYear("");

        num = Convert.ToSingle(lastRow["AIDS本年"].ToString());
        total = Convert.ToSingle(getNumberOfthisYear());
        lastRow["AIDS本年%"] = (num / total) * 100;
        lastRow["HIV"] = getNumberOfHIV("");

        num = Convert.ToSingle(lastRow["HIV"].ToString());
        total = Convert.ToSingle(getNumber());
        lastRow["HIV%"] = (num / total) * 100;
        lastRow["AIDS"] = getNumberOfAIDS("");

        num = Convert.ToSingle(lastRow["AIDS"].ToString());
        total = Convert.ToSingle(getNumber());

        lastRow["AIDS%"] = (num / total) * 100;

        dt.Rows.Add(lastRow);
        return dt;

    }
    //HIV今年例数
    private int getNumberOfHIVthisYear(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" SUBSTRING(ToAidsDate,1,4) = Year(GETDATE()) AND FK_CurrentSituation='HIV' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //AIDS今年例数
    private int getNumberOfAIDSthisYear(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" SUBSTRING(ToAidsDate,1,4) = Year(GETDATE()) AND FK_CurrentSituation='AIDS' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //今年总数
    private int getNumberOfthisYear()
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append(" SUBSTRING(ToAidsDate,1,4) = Year(GETDATE()) ");
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //HIV例数
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
    //AIDS例数
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
    //总数
    private int getNumber()
    {
        return bll_lxbx.GetDetailedViewList("").Tables[0].Rows.Count;
    }

   

  
    protected void cbSettings_CheckedChanged(object sender, EventArgs e)
    {
        if (cbSettings.Checked == true)
            Panel1.Visible = true;
        else
            Panel1.Visible = false;
    }
    protected void cbSelectAll_CheckedChanged(object sender, EventArgs e)
    {

        CheckBox[] cbxs ={ cbInfectionWay, cbHivThisYear, cbHivPerThisYear, cbAidsThisYear, cbAidsPerThisYear, cbHiv, cbHivPer, cbAids, cbAidsPer };

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
    //加一个空方法使
    public override void VerifyRenderingInServerForm(Control control)
    {
        //base.VerifyRenderingInServerForm(control);
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
