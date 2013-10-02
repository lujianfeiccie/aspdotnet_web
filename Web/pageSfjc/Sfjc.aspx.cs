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
using DBUtility;
using System.Collections.Generic;
using Global;
using System.IO;

public partial class Sfjc : System.Web.UI.Page
{
    BLL.tb_sfjc bll_sfjc = new BLL.tb_sfjc();
    BLL.temp_tb_sfjc bll_temp_sfjc = new BLL.temp_tb_sfjc();

    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();

    int PageSize = 5;
    static string strWhere = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["UserID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
                return;
            }
            if (Request.UrlReferrer != null)  // 
            {
                UrlReferrer = Request.UrlReferrer.ToString();


                init();
                BinData();
            }

        }

    }

    private void BinData()
    {

        if (Request.Params["DirectReportNumber"] == null || Request.Params["DirectReportNumber"] == "")
        {
            if (!strWhere.Equals(""))
            {
                strWhere += " AND ";
            }
            strWhere += " [DirectReportNumber] IN ( SELECT DISTINCT [DirectReportNumber] FROM [CDC].[dbo].[tb_sfjc])AND [ConfirmationNumber] IN ( SELECT DISTINCT [ConfirmationNumber] FROM [CDC].[dbo].[tb_sfjc])AND [SendingTime] IN ( SELECT MAX([SendingTime]) FROM [CDC].[dbo].[tb_sfjc] GROUP BY [DirectReportNumber])";
        }
        else
        {
            if (!strWhere.Equals(""))
            {
                strWhere += " AND ";
            }

            strWhere += " DirectReportNumber='" + Request.Params["DirectReportNumber"].ToString() + "'";
        }
        Repeater1.DataSource = bll_sfjc.GetViewList(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex, strWhere);
        Repeater1.DataBind();

        LabelTotalInput.Text = bll_sfjc.GetAllList().Tables[0].Rows.Count.ToString();
        LabelTodayInput.Text = bll_sfjc.GetList(" cast(SendingTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ").Tables[0].Rows.Count.ToString();
        GetCount();
        strWhere = "";
    }

    private void init()
    {


        DataSet dataSet = null;

        //地区
        dataSet = new BLL.TB_District().GetAllList();
        ddlDistrict.DataSource = dataSet;
        ddlDistrict.DataTextField = "Name";
        ddlDistrict.DataValueField = "ID";
        ddlDistrict.DataBind();

        ddlDistrict.Items.Insert(0, new ListItem("地区", "0"));

        //日期

        ddlDate.Items.Insert(0, new ListItem("日期类型", "0"));
        ddlDate.Items.Insert(1, new ListItem("出生日期", "BirthDate"));
        ddlDate.Items.Insert(2, new ListItem("转AIDS日期", "ToAidsDate"));
        ddlDate.Items.Insert(3, new ListItem("录入日期", "SendingTime"));
        ddlDate.Items.Insert(4, new ListItem("审核日期", "VerifyDate"));

        //感染路径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

        ddlInfectionWay.Items.Insert(0, new ListItem("感染路径", "0"));

        ////接触史
        //dataSet = new BLL.TB_ContactHistory().GetAllList();
        //ddlContactHistory.DataSource = dataSet;
        //ddlContactHistory.DataTextField = "Name";
        //ddlContactHistory.DataValueField = "ID";
        //ddlContactHistory.DataBind();

        //ddlContactHistory.Items.Insert(0, new ListItem("接触史", "0"));



        //状态
        dataSet = new BLL.TB_Flag().GetAllList();
        ddlState.DataSource = dataSet;
        ddlState.DataTextField = "Name";
        ddlState.DataValueField = "ID";
        ddlState.DataBind();

        ddlState.Items.Insert(0, new ListItem("状态", "0"));

        //日期开始时间
        txtDateStart.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        //日期结束时间
        txtDateEnd.Attributes.Add("onclick", "javascript:new Calendar().show(this);");





        AspNetPager1.PageSize = PageSize;
        AspNetPager1.RecordCount = bll_sfjc.GetViewAllList().Tables[0].Rows.Count;


    }



    //删除
    protected void lbtnDelete_Click(object sender, EventArgs e)
    {

        int id = int.Parse(((LinkButton)sender).CommandArgument);
        Model.tb_sfjc sfjc = bll_sfjc.GetModel(id);
        bll_sfjc.Delete(id);
        bll_temp_sfjc.Add(sfjc);
        BinData();
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS随访信息管理";
        log.Operation = "删除信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
    }

    //分页
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BinData();
        this.RePopulateValue();
        // BinData();
    }



    //跳转到高级查询
    protected void BtnAdvancedSearch_Click(object sender, EventArgs e)
    {
        // Response.Redirect("SearchLxbx.aspx");
        Response.Write("<script>window.location='SearchSfjc.aspx'</script>");
    }




    //查询
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        bool DistrictSelected = (ddlDistrict.SelectedIndex != 0);
        bool DateTypeSelected = (ddlDate.SelectedIndex != 0);
        bool InfoStateSelected = (ddlState.SelectedIndex != 0);

        string whereDistrictSelected = " FK_District='" + ddlDistrict.SelectedItem.Text + "'";
        string whereDateTypeSelected = " cast(" + ddlDate.SelectedValue + " as datetime) between '" + txtDateStart.Text + " 0:0:0' And '" + txtDateEnd.Text + " 23:59:59' ";
        string whereInfoStateSelected = " FK_Flag='" + ddlState.SelectedValue + "'";
        string whereInfectionWaysSelected = " FK_InfectionWay='" + ddlInfectionWay.SelectedValue + "'";
        //string whereContactHistorySelected = " FK_ContactHistory='" + ddlContactHistory.SelectedValue + "'";
        string where = " ID != -100";

        if (DistrictSelected)
        {
            where += (" AND " + whereDistrictSelected + " ");
        }
        else
            if (DateTypeSelected)
            {
                where += (" AND " + whereDateTypeSelected + " ");
            }
            else
                if (InfoStateSelected)
                {
                    where += (" AND " + whereInfoStateSelected + " ");
                }
                else
                    if (ddlInfectionWay.SelectedIndex != 0)
                    {
                        where += (" AND " + whereInfectionWaysSelected + " ");
                    }
                    //else
                    //    if (ddlContactHistory.SelectedIndex != 0)
                    //    {
                    //        where += (" AND " + whereContactHistorySelected + " ");
                    //    }
        strWhere = where;


        BinData();
    }

    protected void BtnVerify_Click(object sender, EventArgs e)
    {
        List<string> IDs = new List<string>();
        string delId = "";
        //先遍历取得选中项 
        for (int i = 0; i < this.Repeater1.Items.Count; i++)
        {
            CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("cbx");
            string id = cbx.Attributes["key"];

            if (cbx != null)
            {
                if (cbx.Checked)
                {
                    IDs.Add(id);

                }
            }
        }
        ////去掉最后一个, 
        delId = (delId + ")").Replace(",)", "");


        if (IDs.Count == 0)
        {
            JScript.Alert("没有选中项", this.Page);
        }
        else
        {
            for (int i = 0; i < IDs.Count; i++)
            {
                Model.tb_sfjc sfjc = bll_sfjc.GetModel(int.Parse(IDs[i]));
                sfjc.FK_Flag = Global.InfoState.Verified;
                bll_sfjc.Update(sfjc);
            }
            JScript.Alert("审核成功", this.Page);
        }
        DataBind();
    }
    protected void BtnShowToday_Click(object sender, EventArgs e)
    {
        strWhere = " cast(SendingTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ";
        BinData();

    }
    protected void BtnShowTotal_Click(object sender, EventArgs e)
    {
        strWhere = "";
        BinData();


    }
    //protected override void OnPreRender(EventArgs e)
    //{
    //    Response.AppendHeader("P3P", "CP=\"CAO PSA OUR\"");
    //    base.OnPreRender(e);
    //}



    private void Export(string FileType, string FileName)
    {
        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.UTF7;
        //输出标题
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8).ToString());
        Response.ContentType = FileType;  //文件的类型
        this.EnableViewState = false;
        StringWriter tw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(tw);
        //this.GVCheapMaterialLib.RenderControl(hw);
        this.Repeater1.RenderControl(hw);
        Response.Write(tw.ToString());
        Response.End();

    }
    //加一个空方法使
    public override void VerifyRenderingInServerForm(Control control)
    {
        //base.VerifyRenderingInServerForm(control);
    }
    private string UrlReferrer
    {
        set
        {
            ViewState["UrlReferrer"] = value;

        }
        get
        {
            if (ViewState["UrlReferrer"] != null)
            {
                return ViewState["UrlReferrer"].ToString();
            }
            else
            {
                return "";
            }
        }
    }

    protected void BtnFlag_Click(object sender, EventArgs e)
    {
        this.RememberOldValues();
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        Export("随访记录表");
    }

    private void Export( string FileName)
    {
        ArrayList al = null;
        DataTable dt = new DataTable();
        dt.Columns.Add("直报号");
        dt.Columns.Add("确认ID");
        dt.Columns.Add("姓名");
        dt.Columns.Add("身份证");
        dt.Columns.Add("确认日期");
        dt.Columns.Add("性别");
        dt.Columns.Add("可能感染途径");
        dt.Columns.Add("出生日期");
        dt.Columns.Add("现住区域");
        dt.Columns.Add("现况");
        dt.Columns.Add("治疗类型");
        dt.Columns.Add("加入时间");
        dt.Columns.Add("治疗号");
        dt.Columns.Add("维持状况");
        dt.Columns.Add("首次随访");
        dt.Columns.Add("随访干预");
        dt.Columns.Add("CD4");
        dt.Columns.Add("病毒载量");
        dt.Columns.Add("配偶抗体检测情况");
        dt.Columns.Add("配偶是否当年检测");
        dt.Columns.Add("子女检测情况");
        dt.Columns.Add("是否死亡");
        dt.Columns.Add("备注");
        DataSet ds = bll_sfjc.GetList(strWhere);
        if (Session["checked_items"] != null)
        {
            al = (ArrayList)Session["checked_items"];
        }
        if (al == null || al.Count == 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                DataRow dr = dt.NewRow();
                dr[0] = ds.Tables[0].Rows[i]["DirectReportNumber"].ToString();
                dr[1] = ds.Tables[0].Rows[i]["ConfirmationNumber"].ToString();
                dr[2] = ds.Tables[0].Rows[i]["Name"].ToString();
                dr[3] = ds.Tables[0].Rows[i]["Id_card"].ToString();
                dr[4] = ds.Tables[0].Rows[i]["ConfirmationDate"].ToString();
                dr[5] = ds.Tables[0].Rows[i]["FK_Sex"].ToString();
                dr[6] = ds.Tables[0].Rows[i]["FK_InfectionWay"].ToString();
                dr[7] = ds.Tables[0].Rows[i]["BirthDate"].ToString();
                dr[8] = ds.Tables[0].Rows[i]["FK_District"].ToString();
                dr[9] = ds.Tables[0].Rows[i]["FK_CurrentSituation"].ToString();
                dr[10] = ds.Tables[0].Rows[i]["FK_TypeOfTreatment"].ToString();
                dr[11] = ds.Tables[0].Rows[i]["AddingTime"].ToString();
                dr[12] = ds.Tables[0].Rows[i]["TreatmentNumber"].ToString();
                dr[13] = ds.Tables[0].Rows[i]["FK_MaintainStatus"].ToString();
                dr[14] = ds.Tables[0].Rows[i]["FK_FirstFollowUpVisit"].ToString();
                dr[15] = ds.Tables[0].Rows[i]["FK_FollowUpIntervention"].ToString();
                dr[16] = ds.Tables[0].Rows[i]["CD4"].ToString();
                dr[17] = ds.Tables[0].Rows[i]["ViralLoad"].ToString();
                dr[18] = ds.Tables[0].Rows[i]["FK_Spouse_AntibodyDetection"].ToString();
                dr[19] = ds.Tables[0].Rows[i]["FK_DetectBefore"].ToString();
                dr[20] = ds.Tables[0].Rows[i]["FK_Children_AntibodyDetection"].ToString();
                dr[21] = ds.Tables[0].Rows[i]["FK_IsDead"].ToString();
                dr[22] = ds.Tables[0].Rows[i]["Remark"].ToString();      
                dt.Rows.Add(dr);

            }

        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {


                string id = ds.Tables[0].Rows[i]["ID"].ToString();

                if (al.Contains(id))
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = ds.Tables[0].Rows[i]["DirectReportNumber"].ToString();
                    dr[1] = ds.Tables[0].Rows[i]["ConfirmationNumber"].ToString();
                    dr[2] = ds.Tables[0].Rows[i]["Name"].ToString();
                    dr[3] = ds.Tables[0].Rows[i]["Id_card"].ToString();
                    dr[4] = ds.Tables[0].Rows[i]["ConfirmationDate"].ToString();
                    dr[5] = ds.Tables[0].Rows[i]["FK_Sex"].ToString();
                    dr[6] = ds.Tables[0].Rows[i]["FK_InfectionWay"].ToString();
                    dr[7] = ds.Tables[0].Rows[i]["BirthDate"].ToString();
                    dr[8] = ds.Tables[0].Rows[i]["FK_District"].ToString();
                    dr[9] = ds.Tables[0].Rows[i]["FK_CurrentSituation"].ToString();
                    dr[10] = ds.Tables[0].Rows[i]["FK_TypeOfTreatment"].ToString();
                    dr[11] = ds.Tables[0].Rows[i]["AddingTime"].ToString();
                    dr[12] = ds.Tables[0].Rows[i]["TreatmentNumber"].ToString();
                    dr[13] = ds.Tables[0].Rows[i]["FK_MaintainStatus"].ToString();
                    dr[14] = ds.Tables[0].Rows[i]["FK_FirstFollowUpVisit"].ToString();
                    dr[15] = ds.Tables[0].Rows[i]["FK_FollowUpIntervention"].ToString();
                    dr[16] = ds.Tables[0].Rows[i]["CD4"].ToString();
                    dr[17] = ds.Tables[0].Rows[i]["ViralLoad"].ToString();
                    dr[18] = ds.Tables[0].Rows[i]["FK_Spouse_AntibodyDetection"].ToString();
                    dr[19] = ds.Tables[0].Rows[i]["FK_DetectBefore"].ToString();
                    dr[20] = ds.Tables[0].Rows[i]["FK_Children_AntibodyDetection"].ToString();
                    dr[21] = ds.Tables[0].Rows[i]["FK_IsDead"].ToString();
                    dr[22] = ds.Tables[0].Rows[i]["Remark"].ToString();      

                    dt.Rows.Add(dr);
                }
            }
        }
        DBUtility.FileHelper.DataTableToExcel(dt, FileName);

    }


    //标记选中的复选框
    private void RememberOldValues()
    {
        ArrayList al = null; //声明集合
        //创建一个Session并检查是否为空，这个Session用来保存集合
        //这里是判断是否是第一次进行分页
        if (Session["checked_items"] != null)
        {
            al = (ArrayList)Session["checked_items"];
        }
        else
        {
            al = new ArrayList();
        }

        for (int i = 0; i < this.Repeater1.Items.Count; i++)
        {
            CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("CheckBox1");
            string id = cbx.Attributes["key"];
            bool result = cbx.Checked;
            if (result)
            {
                if (!al.Contains(id))
                {
                    al.Add(id);
                }
            }
            else
            {
                if (al.Contains(id))
                {
                    al.Remove(id);
                }
            }
        }
        if (al != null && al.Count > 0)
        {
            Session["checked_items"] = al;
        }

    }
    //恢复选中的复选框
    private void RePopulateValue()
    {
        ArrayList al = (ArrayList)Session["checked_items"];
        if (al != null && al.Count > 0)
        {
            for (int i = 0; i < this.Repeater1.Items.Count; i++)
            {
                CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("CheckBox1");
                string id = cbx.Attributes["key"];

                if (al.Contains(id))
                {
                    cbx.Checked = true;
                }
            }
        }
    }

    private void GetCount()
    {
        for (int i = 0; i < this.Repeater1.Items.Count; i++)
        {
            CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("CheckBox1");
            string id = cbx.Attributes["key"];
            DataSet ds  = bll_sfjc.GetList("id='" + id + "'");
            string directNumber = ds.Tables[0].Rows[0]["DirectReportNumber"].ToString();
            Label label = (Label)Repeater1.Items[i].FindControl("Count");
            label.Text = bll_sfjc.GetList("DirectReportNumber='" + directNumber + "'").Tables[0].Rows.Count.ToString();
        }
       
    }
}
