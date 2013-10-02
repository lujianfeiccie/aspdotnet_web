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
using System.IO;
using System.Text;

public partial class Rpt_InfectionWayDistrict : System.Web.UI.Page
{
    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
    BLL.TB_InfectionWay bbl_InfectionWay = new BLL.TB_InfectionWay();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }

        DataTable dt;
        dt = getTableShow();



      
        GridView1.DataSource = dt;
        GridView1.DataBind();


       
       
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        DataTable dt = getTableShow();
       

        string[] colname=new string[]{"地区","异性传播","异性传播%","同性/双性传播","同性/双性传播%","注射毒品","注射毒品%",
                                      "采血(浆)","采血(浆)%","输血/血制品","输血/血制品%","母婴传播","母婴传播%",
                                     "性接触+注射毒品","性接触+注射毒品%","职业暴露","职业暴露%","其他","其他%","不详","不详%",
                                     "合计"};
               

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
          SaveToExcel(dt,"传播途径分区统计.xls");
       
    }

    private string mapping(string cbID)
    {
        string str=string.Empty;
        switch (cbID)
        {
            case "cbDistrict": str = "地区"; break;
            case "cbOppositeSex": str = "异性传播"; break;
            case "cbOppositeSexPer": str = "异性传播%"; break;
            case "cbSameSexOrBigender": str = "同性/双性传播"; break;
            case "cbSameSexOrBigenderPer": str = "同性/双性传播%"; break;
            case "cbInjection": str = "注射毒品"; break;
            case "cbInjectionPer": str = "注射毒品%"; break;
            case "cbBloodCollection": str = "采血(浆)"; break;
            case "cbBloodCollectionPer": str = "采血(浆)%"; break;
            case "cbBloodTransfusion": str = "输血/血制品"; break;
            case "cbBloodTransfusionPer": str = "输血/血制品%"; break;
            case "cbMotherToBaby": str = "母婴传播"; break;
            case "cbMotherToBabyPer": str = "母婴传播%"; break;
            case "cbSexualContactAndInjection": str = "性接触+注射毒品"; break;
            case "cbSexualContactAndInjectionPer": str = "性接触+注射毒品%"; break;
            case "cbOccupationalExposure": str = "职业暴露"; break;
            case "cbOccupationalExposurePer": str = "职业暴露%"; break;
            case "cbOthers": str = "其他"; break;
            case "cbOthersPer": str = "其他%"; break;
            case "cbUnknown": str = "不详"; break;
            case "cbUnknownPer": str = "不详%"; break;
            case "cbAmount": str = "合计"; break;

        }
        return str;
    }
   
    private DataTable getTableShow()
    {
        Model.tb_lxbx lxbx = new Model.tb_lxbx();
        BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

        DataTable dt = new DataTable();


        DataColumn dc;
        dc = new DataColumn("地区", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("异性传播", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("异性传播%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("同性/双性传播", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("同性/双性传播%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("注射毒品", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("注射毒品%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("采血(浆)", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("采血(浆)%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("输血/血制品", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("输血/血制品%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("母婴传播", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("母婴传播%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("性接触+注射毒品", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("性接触+注射毒品%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("职业暴露", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("职业暴露%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("其他", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("其他%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("不详", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("不详%", typeof(string));
        dt.Columns.Add(dc);
        dc = new DataColumn("合计", typeof(string));
        dt.Columns.Add(dc);



        string[] district ={ "深圳", "罗湖", "福田", "南山", "盐田", "宝安", "龙岗", "光明新区", "坪山新区" };

        int TotalNum = district.Length;


        float total, num;
       
        for (int i = 0; i < TotalNum; i++)
        {
             string strWhere=" FK_District='" + district[i]+"' ";
            DataRow dr = dt.NewRow();
            dr["地区"] = district[i];
            if(district[i] == "深圳")
                dr["异性传播"] = getNumberOfOppositeSex("");
            else
                dr["异性传播"] = getNumberOfOppositeSex(strWhere);

            num = Convert.ToSingle(dr["异性传播"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["异性传播%"] = (num/total)*100;
            dr["同性/双性传播"] = getNumberOfSameSexOrBigender(strWhere);

            num = Convert.ToSingle(dr["同性/双性传播"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["同性/双性传播%"] = (num / total) * 100;
            dr["注射毒品"] = getNumberOfInjection(strWhere);

            num = Convert.ToSingle(dr["注射毒品"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["注射毒品%"] = (num / total) * 100;
            dr["采血(浆)"] = getNumberOfBloodCollection(strWhere);

            num = Convert.ToSingle(dr["采血(浆)"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["采血(浆)%"] = (num / total) * 100;

            dr["输血/血制品"] = getNumberOfBloodTransfusion(strWhere);

            num = Convert.ToSingle(dr["输血/血制品"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["输血/血制品%"] = (num / total) * 100;
            dr["母婴传播"] = getNumberOfMotherToBaby(strWhere);

            num = Convert.ToSingle(dr["母婴传播"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["母婴传播%"] = (num / total) * 100;
            dr["性接触+注射毒品"] = getNumberOfSexualContactAndInjection(strWhere);

            num = Convert.ToSingle(dr["性接触+注射毒品"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["性接触+注射毒品%"] = (num / total) * 100;

            dr["职业暴露"] = getNumberOfOccupationalExposure(strWhere);

            num = Convert.ToSingle(dr["职业暴露"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["职业暴露%"] = (num / total) * 100;
            dr["其他"] = getNumberOfOthers(strWhere);

            num = Convert.ToSingle(dr["其他"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["其他%"] = (num / total) * 100;
            dr["不详"] = getNumberOfUnknown(strWhere);

            num = Convert.ToSingle(dr["不详"].ToString());
            total = Convert.ToSingle(bll_lxbx.GetList("").Tables[0].Rows.Count);
            dr["不详%"] = (num / total) * 100;

            if (district[i] == "深圳")
                dr["合计"] = bll_lxbx.GetViewList("").Tables[0].Rows.Count;
            else
                dr["合计"] = bll_lxbx.GetViewList(strWhere).Tables[0].Rows.Count;
            
         
            dt.Rows.Add(dr);



        }
        
        return dt;
    }
    //异性传播例数 
    private int getNumberOfOppositeSex(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='异性传播' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    // 同性/双性传播例数 
    private int getNumberOfSameSexOrBigender(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='同性/双性传播' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //注射毒品例数 
    private int getNumberOfInjection(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='注射毒品' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //采血(浆)例数 
    private int getNumberOfBloodCollection(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='采血(浆)' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //输血/血制品例数 
    private int getNumberOfBloodTransfusion(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='输血/血制品' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //母婴传播例数 
    private int getNumberOfMotherToBaby(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='母婴传播' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //性接触+注射毒品例数 
    private int getNumberOfSexualContactAndInjection(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='性接触+注射毒品' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //职业暴露例数 
    private int getNumberOfOccupationalExposure(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='职业暴露' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //其他例数 
    private int getNumberOfOthers(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='其它' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //不详例数 
    private int getNumberOfUnknown(string strWhere)
    {
        StringBuilder sqlSql = new StringBuilder();
        sqlSql.Append("  FK_InfectionWay='不详' ");
        if (strWhere.Trim() != "")
        {
            sqlSql.Append(" AND " + strWhere);
        }
        return bll_lxbx.GetDetailedViewList(sqlSql.ToString()).Tables[0].Rows.Count;
    }
    //合计 

    protected void cbSettings_CheckedChanged(object sender, EventArgs e)
    {
        if (cbSettings.Checked == true)
            Panel1.Visible = true;
        else
            Panel1.Visible = false;
    }
    protected void cbSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox[] cbxs ={ cbDistrict,
             cbOppositeSex,
            cbOppositeSexPer,
            cbSameSexOrBigender,
            cbSameSexOrBigenderPer, 
            cbInjection, 
            cbInjectionPer, 
            cbBloodCollection,
            cbBloodCollectionPer,
            cbBloodTransfusion,
            cbBloodTransfusionPer,
            cbMotherToBaby,
            cbMotherToBabyPer,
            cbSexualContactAndInjection,
            cbSexualContactAndInjectionPer,
            cbOccupationalExposure,
            cbOccupationalExposurePer,
            cbOthers,
            cbOthersPer,
            cbUnknown,
            cbUnknownPer,
            cbAmount
        };
         
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
