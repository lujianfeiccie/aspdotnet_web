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

public partial class Rpt_SampleSource : System.Web.UI.Page
{
    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }

        DataTable dt = new DataTable();
        dt = getTableShow();

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
    private DataTable getTableShow()
    {
        Model.tb_lxbx lxbx = new Model.tb_lxbx();
        BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

        DataTable dt = new DataTable();


        DataColumn dc;
        dc = new DataColumn("样本来源", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("HIV%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("AIDS%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("合计", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("合计%", typeof(string));
        dt.Columns.Add(dc);


        string[] trans ={ "术前检查", "受血(制品)前检测", "性病门诊", "其他就诊者检测", "婚前检查(含涉外婚检)", 
                          "孕产期检查", "检测咨询", "阳性者配偶或性伴检测", "女性阳性者子女检测", "职业暴露检测" ,
                         "娱乐场所人员体检","有偿供血(浆)人员检测","无偿献血人员检测","出入境人员体检", "新兵体检", 
                          "强制/劳教戒毒人员检测","妇教所/女劳收教人员检测","其他羁押人员体检","专题调查(请注明人群)","其他","不详"};
        float total, num;
        for (int i = 0; i < trans.Length; i++)
        {
            string strWhere = string.Empty;
            strWhere = " FK_DetectionClass='" + trans[i] + "' ";
           
            DataRow dr = dt.NewRow();
            dr["样本来源"] = trans[i];
            dr["HIV"] = getNumberOfHIV(strWhere);
            total = Convert.ToSingle(getAmount(strWhere));
            num = Convert.ToSingle(dr["HIV"].ToString());
            
            dr["HIV%"] = (num==0?0:(num / total) * 100);
           
            dr["AIDS"] = getNumberOfAIDS(strWhere);
            total = Convert.ToSingle(getAmount(strWhere));
            num = Convert.ToSingle(dr["AIDS"].ToString());
            dr["AIDS%"] = (num == 0 ? 0 : (num / total) * 100);
            dr["合计"] = getAmount(strWhere);
            total = Convert.ToSingle(getAmount(strWhere));
            num = Convert.ToSingle(dr["合计"].ToString());
            dr["合计%"] = (num == 0 ? 0 : (num / total) * 100);


            dt.Rows.Add(dr);
        }
       

        return dt;
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        DataTable dt = getTableShow();


        string[] colname = new string[]{"样本来源","HIV","HIV%","AIDS","AIDS%","合计","合计%"};
        DataRow dr = dt.NewRow();

        for (int i = 0; i < colname.Length; i++)
            dr[colname[i]] = colname[i];

       



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
        SaveToExcel(dt, "样本来源统计.xls");

    }
    private string mapping(string cbID)
    {
        string str = string.Empty;
        switch (cbID)
        {
            case "cbSampleSource": str = "样本来源"; break;
            case "cbHiv": str = "HIV"; break;
            case "cbHivPer": str = "HIV%"; break;
            case "cbAids": str = "AIDS"; break;
            case "cbAidsPer": str = "AIDS%"; break;
            case "cbAmount": str = "合计"; break;
            case "cbAmountPer": str = "合计%"; break;
            
          

        }
        return str;
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
        CheckBox[] cbxs ={ cbSampleSource, cbAids, cbAidsPer, cbHiv, cbHivPer, cbAmount, cbAmountPer };
        
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
    //感染HIV例数
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
    //感染AIDS例数
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
    //合计例数
    private int getAmount(string strWhere)
    {
        return bll_lxbx.GetDetailedViewList(strWhere).Tables[0].Rows.Count;
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
