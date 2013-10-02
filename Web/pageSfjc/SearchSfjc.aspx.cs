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
using System.IO;

public partial class SearchSfjc : System.Web.UI.Page
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
        GetCount();
        strWhere = "";
    
    }

    private void init()
    {


        DataSet dataSet = null;
      
        ddlLogicalConfirmationNumber.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalConfirmationNumber.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalDirectReportNumber.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalDirectReportNumber.Items.Insert(1, new ListItem("包括", "TRUE"));


        ddlLogicalDate.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalDate.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalName.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalName.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalSex.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalSex.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlInfectionWay.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlInfectionWay.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalState.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalState.Items.Insert(1, new ListItem("包括", "TRUE"));

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


        //性别
        dataSet = new BLL.TB_SEX().GetAllList();
        ddlSex.DataSource = dataSet;
        ddlSex.DataTextField = "Name";
        ddlSex.DataValueField = "ID";
        ddlSex.DataBind();

        ddlSex.Items.Insert(0, new ListItem("性别", "0"));

        //感染途径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

        ddlSex.Items.Insert(0, new ListItem("性别", "0"));

        //状态
        dataSet = new BLL.TB_Flag().GetAllList();
        ddlState.DataSource = dataSet;
        ddlState.DataTextField = "Name";
        ddlState.DataValueField = "ID";
        ddlState.DataBind();

        ddlState.Items.Insert(0, new ListItem("状态", "0"));

        //现况
        dataSet = new BLL.TB_CurrentSituation().GetAllList();
        ddlCurrentSituation.DataSource = dataSet;
        ddlCurrentSituation.DataTextField = "Name";
        ddlCurrentSituation.DataValueField = "ID";
        ddlCurrentSituation.DataBind();

        ddlCurrentSituation.Items.Insert(0, new ListItem("现况", "0"));

        //是否死亡
        dataSet = new BLL.TB_IsDead().GetAllList();
        ddlIsDead.DataSource = dataSet;
        ddlIsDead.DataTextField = "Name";
        ddlIsDead.DataValueField = "ID";
        ddlIsDead.DataBind();
        ddlIsDead.Items.Insert(0, new ListItem("是否死亡", "0"));

        //治疗类型
        dataSet = new BLL.TB_TypeOfTreatment().GetAllList();
        ddlTypeOfTreatment.DataSource = dataSet;
        ddlTypeOfTreatment.DataTextField = "Name";
        ddlTypeOfTreatment.DataValueField = "ID";
        ddlTypeOfTreatment.DataBind();
        ddlTypeOfTreatment.Items.Insert(0, new ListItem("治疗类型", "0"));

        //首次随访
        dataSet = new BLL.TB_FirstFollowUpVisit().GetAllList();
        ddlFirstFollowUpVisit.DataSource = dataSet;
        ddlFirstFollowUpVisit.DataTextField = "Name";
        ddlFirstFollowUpVisit.DataValueField = "ID";
        ddlFirstFollowUpVisit.DataBind();
        ddlFirstFollowUpVisit.Items.Insert(0, new ListItem("首次随访", "0"));
        //随访干预
        dataSet = new BLL.TB_FollowUpIntervention().GetAllList();
        ddlFollowUpIntervention.DataSource = dataSet;
        ddlFollowUpIntervention.DataTextField = "Name";
        ddlFollowUpIntervention.DataValueField = "ID";
        ddlFollowUpIntervention.DataBind();
        ddlFollowUpIntervention.Items.Insert(0, new ListItem("随访干预", "0"));
        //维持状况
        dataSet = new BLL.TB_MaintainStatus().GetAllList();
        ddlMaintainStatus.DataSource = dataSet;
        ddlMaintainStatus.DataTextField = "Name";
        ddlMaintainStatus.DataValueField = "ID";
        ddlMaintainStatus.DataBind();
        ddlMaintainStatus.Items.Insert(0, new ListItem("维持状况", "0"));
        //配偶检测情况
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlSpouse_AntibodyDetection.DataSource = dataSet;
        ddlSpouse_AntibodyDetection.DataTextField = "Name";
        ddlSpouse_AntibodyDetection.DataValueField = "ID";
        ddlSpouse_AntibodyDetection.DataBind();
        ddlSpouse_AntibodyDetection.Items.Insert(0, new ListItem("配偶检测情况", "0"));
        //是否当年检测
        dataSet = new BLL.TB_DetectBefore().GetAllList();
        ddlDetectBefore.DataSource = dataSet;
        ddlDetectBefore.DataTextField = "Name";
        ddlDetectBefore.DataValueField = "ID";
        ddlDetectBefore.DataBind();
        ddlDetectBefore.Items.Insert(0, new ListItem("是否当年检测", "0"));
      
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
        Response.Write("<script>window.location='SearchLxbx.aspx'</script>");
    }




    //查询
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        bool DistrictSelected = (ddlDistrict.SelectedIndex != 0);
        bool ConfirmationNumberSelected = (ddlLogicalConfirmationNumber.SelectedValue == "TRUE");
        bool DirectReportNumberSelected = (ddlLogicalDirectReportNumber.SelectedValue == "TRUE");
        bool DateTypeSelected = (ddlDate.SelectedValue == "TRUE");
        bool NameSelected = (ddlLogicalName.SelectedValue == "TRUE");
        bool SexSelected = (ddlLogicalSex.SelectedValue == "TRUE");
        bool VerifySelected = (ddlLogicalState.SelectedValue == "TRUE");

        string whereDistrictSelected = " FK_District='" + ddlDistrict.SelectedItem.Text + "'";
        string whereConfirmationNumberSelected = " ConfirmationNumber like '%" + txtConfirmationNumber.Text.Trim() + "%'";
        string whereDirectReportNumberSelected = " DirectReportNumber like '%" + txtDirectReportNumber.Text.Trim() + "%'";
        string whereDateTypeSelected = " cast(" + ddlDate.SelectedValue + " as datetime) between '" + txtDateStart.Text + " 0:0:0' And '" + txtDateEnd.Text + " 23:59:59' ";
        string whereNameSelected = " [Name] like '%" + txtName.Text + "%' ";
        string whereSexSelected = " FK_Sex = '" + ddlSex.SelectedItem.Text + "'";
        string whereVerifySelected = " FK_Flag= '" + ddlState.SelectedItem.Text + "'";
        string whereInfectionWaysSelected = " FK_InfectionWay='" + ddlInfectionWay.SelectedValue + "'";

        string whereCurrentSituationSelected = " FK_CurrentSituation='" + ddlCurrentSituation.SelectedValue + "'";
        string whereIsDeadSelected = " FK_IsDead='" + ddlIsDead.SelectedValue + "'";
        string whereTypeOfTreatmentSelected = " FK_TypeOfTreatment='" + ddlTypeOfTreatment.SelectedValue + "'";
        string whereFirstFlollowUpVistSelected = " FK_FirstFollowUpVisit='" + ddlFirstFollowUpVisit.SelectedValue + "'";
        string whereFlollowUpInterventionSelected = " FK_FollowUpIntervention='" + ddlFollowUpIntervention.SelectedValue + "'";
        string whereMaintainStatusSelected = " FK_MaintainStatus='" + ddlMaintainStatus.SelectedValue + "'";
        string whereSpouseAntibodyDetectionSelected = " FK_Spouse_AntibodyDetection='" + ddlSpouse_AntibodyDetection.SelectedValue + "'";
        string whereDetectBeforeSelected = " FK_DetectBefore='" + ddlDetectBefore.SelectedValue + "'";
        string whereTreatmentNumberSelected = " TreatmentNumber like '%" + txtTreatmentNumber.Text + "%'";
        string where = " ID!=-100 ";
        if (DistrictSelected)
        {
            where += (" AND " + whereDistrictSelected + " ");

        }
        if (ConfirmationNumberSelected)
        {
            where += (" AND " + whereConfirmationNumberSelected + " ");

        }
        if (DirectReportNumberSelected)
        {
            where += (" AND " + whereDirectReportNumberSelected + " ");

        }
        if (DateTypeSelected)
        {
            where += (" AND " + whereDateTypeSelected + " ");
        }
        if (NameSelected)
        {
            where += (" AND " + whereNameSelected + " ");
        }
        if (SexSelected)
        {
            where += (" AND " + whereSexSelected + " ");
        }
        if (VerifySelected)
        {
            where += (" AND " + whereVerifySelected + " ");
        }
        if (ddlInfectionWay.SelectedIndex != 0)
        {
            where += (" AND " + whereInfectionWaysSelected + " ");
        }
        if (ddlCurrentSituation.SelectedIndex != 0)
        {
            where += (" AND " + whereCurrentSituationSelected + " ");
        }
        if (ddlIsDead.SelectedIndex != 0)
        {
            where += (" AND " + whereIsDeadSelected + " ");
        }
        if (ddlTypeOfTreatment.SelectedIndex != 0)
        {
            where += (" AND " + whereTypeOfTreatmentSelected + " ");
        }
        if (ddlFirstFollowUpVisit.SelectedIndex != 0)
        {
            where += (" AND " + whereFirstFlollowUpVistSelected + " ");
        }
        if (ddlFollowUpIntervention.SelectedIndex != 0)
        {
            where += (" AND " + whereFlollowUpInterventionSelected + " ");

        }
        if (ddlMaintainStatus.SelectedIndex != 0)
        {
            where += (" AND " + whereMaintainStatusSelected + " ");
        }
        if (ddlSpouse_AntibodyDetection.SelectedIndex != 0)
        {
            where += (" AND " + whereSpouseAntibodyDetectionSelected + " ");
        }
        if (ddlDetectBefore.SelectedIndex != 0)
        {
            where += (" AND " + whereDetectBeforeSelected + " ");
        }
        if (txtTreatmentNumber.Text.Trim().Length != 0)
        {
            where += (" AND " + whereTreatmentNumberSelected + " ");
        }
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
                // dataVerify.Request(Int32.Parse(IDs[i]));
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

    protected void btnExport_Click(object sender, EventArgs e)
    {
        Export( "随访记录表");
    }
    protected void BtnFlag_Click(object sender, EventArgs e)
    {
        this.RememberOldValues();
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
            DataSet ds = bll_sfjc.GetList("id='" + id + "'");
            string directNumber = ds.Tables[0].Rows[0]["DirectReportNumber"].ToString();
            Label label = (Label)Repeater1.Items[i].FindControl("Count");
            label.Text = bll_sfjc.GetList("DirectReportNumber='" + directNumber + "'").Tables[0].Rows.Count.ToString();
        }

    }
}
