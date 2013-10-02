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
using System.Data.OleDb;
using DBUtility;

using System.Collections.Generic;
using Global;

public partial class SearchLxbx : System.Web.UI.Page
{
    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
    BLL.temp_tb_lxbx bll_temp_lxbx = new BLL.temp_tb_lxbx();

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

            init();
            BinData();


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
            strWhere += " [DirectReportNumber] IN ( SELECT DISTINCT [DirectReportNumber] FROM [CDC].[dbo].[tb_lxbx]) AND [ConfirmationNumber] IN ( SELECT DISTINCT [ConfirmationNumber] FROM [CDC].[dbo].[tb_lxbx]) AND [SendingTime] IN ( SELECT MAX([SendingTime]) FROM [CDC].[dbo].[tb_lxbx] GROUP BY [DirectReportNumber])";
        }
        else
        {
            if (!strWhere.Equals(""))
            {
                strWhere += " AND ";
            }

            strWhere += " DirectReportNumber='" + Request.Params["DirectReportNumber"].ToString() + "'";
        }
        //Response.Write("Start:"+AspNetPager1.StartRecordIndex.ToString() + " End:" + AspNetPager1.EndRecordIndex.ToString());
        Repeater1.DataSource = bll_lxbx.GetViewList(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex, strWhere);
        Repeater1.DataBind();
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

        //性别
        dataSet = new BLL.TB_SEX().GetAllList();
        ddlSex.DataSource = dataSet;
        ddlSex.DataTextField = "Name";
        ddlSex.DataValueField = "ID";
        ddlSex.DataBind();
        ddlSex.Items.Insert(0, new ListItem("性别", "0"));

        //日期

        ddlDate.Items.Insert(0, new ListItem("日期类型", "0"));
        ddlDate.Items.Insert(1, new ListItem("出生日期", "BirthDate"));
        ddlDate.Items.Insert(2, new ListItem("转AIDS日期", "ToAidsDate"));
        ddlDate.Items.Insert(3, new ListItem("录入日期", "SendingTime"));
        ddlDate.Items.Insert(4, new ListItem("审核日期", "VerifyDate"));

        //状态
        dataSet = new BLL.TB_Flag().GetAllList();
        ddlState.DataSource = dataSet;
        ddlState.DataTextField = "Name";
        ddlState.DataValueField = "ID";
        ddlState.DataBind();

        ddlState.Items.Insert(0, new ListItem("状态", "0"));


        //民族
        dataSet = new BLL.TB_Nationality().GetAllList();
        ddlNationality.DataSource = dataSet;
        ddlNationality.DataTextField = "Name";
        ddlNationality.DataValueField = "ID";
        ddlNationality.DataBind();

        ddlNationality.Items.Insert(0, new ListItem("民族", "0"));
        //婚姻状况
        dataSet = new BLL.TB_MarriageStatus().GetAllList();
        ddlMarriageStatus.DataSource = dataSet;
        ddlMarriageStatus.DataTextField = "Name";
        ddlMarriageStatus.DataValueField = "ID";
        ddlMarriageStatus.DataBind();

        ddlMarriageStatus.Items.Insert(0, new ListItem("婚姻状况", "0"));

        //文化程度
        dataSet = new BLL.TB_Education().GetAllList();
        ddlEducation.DataSource = dataSet;
        ddlEducation.DataTextField = "Name";
        ddlEducation.DataValueField = "ID";
        ddlEducation.DataBind();
        ddlEducation.Items.Insert(0, new ListItem("文化程度", "0"));

        //国籍
        dataSet = new BLL.TB_Citizenship().GetAllList();
        ddlCitizenship.DataSource = dataSet;
        ddlCitizenship.DataTextField = "Name";
        ddlCitizenship.DataValueField = "ID";
        ddlCitizenship.DataBind();

        ddlCitizenship.Items.Insert(0, new ListItem("国籍", "0"));

        //可能感染途径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

        ddlInfectionWay.Items.Insert(0, new ListItem("可能感染途径", "0"));

        //接触史
        dataSet = new BLL.TB_ContactHistory().GetAllList();
        ddlContactHistory.DataSource = dataSet;
        ddlContactHistory.DataTextField = "Name";
        ddlContactHistory.DataValueField = "ID";
        ddlContactHistory.DataBind();

        ddlContactHistory.Items.Insert(0, new ListItem("接触史", "0"));


        //职业特征
        dataSet = new BLL.TB_JobCharacter().GetAllList();
        ddlJobCharacter.DataSource = dataSet;
        ddlJobCharacter.DataTextField = "Name";
        ddlJobCharacter.DataValueField = "ID";
        ddlJobCharacter.DataBind();

        ddlJobCharacter.Items.Insert(0, new ListItem("职业特征", "0"));


        //检测分类
        dataSet = new BLL.TB_DetectionClass().GetAllList();
        ddlDetectionClass.DataSource = dataSet;
        ddlDetectionClass.DataTextField = "Name";
        ddlDetectionClass.DataValueField = "ID";
        ddlDetectionClass.DataBind();

        ddlDetectionClass.Items.Insert(0, new ListItem("检测分类", "0"));

        //户籍情况
        dataSet = new BLL.TB_HouseholdRegister().GetAllList();
        ddlHouseholdRegister.DataSource = dataSet;
        ddlHouseholdRegister.DataTextField = "Name";
        ddlHouseholdRegister.DataValueField = "ID";
        ddlHouseholdRegister.DataBind();

        ddlHouseholdRegister.Items.Insert(0, new ListItem("户籍情况", "0"));

        //现况
        dataSet = new BLL.TB_CurrentSituation().GetAllList();
        ddlCurrentSituation.DataSource = dataSet;
        ddlCurrentSituation.DataTextField = "Name";
        ddlCurrentSituation.DataValueField = "ID";
        ddlCurrentSituation.DataBind();

        ddlCurrentSituation.Items.Insert(0, new ListItem("现况", "0"));

        //籍贯
        dataSet = new BLL.TB_Province().GetAllList();
        ddlProvince.DataSource = dataSet;
        ddlProvince.DataTextField = "Name";
        ddlProvince.DataValueField = "Name";
        ddlProvince.DataBind();

        ddlProvince.Items.Insert(0, new ListItem("籍贯", "0"));

       

        //是否死亡
        dataSet = new BLL.TB_IsDead().GetAllList();
        ddlIsDead.DataSource = dataSet;
        ddlIsDead.DataTextField = "Name";
        ddlIsDead.DataValueField = "ID";
        ddlIsDead.DataBind();
        ddlIsDead.Items.Insert(0, new ListItem("是否死亡", "0"));

        ddlLogicalConfirmationNumber.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalConfirmationNumber.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalDirectReportNumber.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalDirectReportNumber.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalName.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalName.Items.Insert(1, new ListItem("包括", "TRUE"));


        ddlLogicalSex.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalSex.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalState.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalState.Items.Insert(1, new ListItem("包括", "TRUE"));

        ddlLogicalDate.Items.Insert(0, new ListItem("无", "FALSE"));
        ddlLogicalDate.Items.Insert(1, new ListItem("包括", "TRUE"));



        //日期开始时间
        txtDateStart.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        //日期结束时间
        txtDateEnd.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        AspNetPager1.PageSize = PageSize;
        AspNetPager1.RecordCount = bll_lxbx.GetViewAllList().Tables[0].Rows.Count;

    }



    //删除
    protected void lbtnDelete_Click(object sender, EventArgs e)
    {

        int id = int.Parse(((LinkButton)sender).CommandArgument);
        Model.tb_lxbx lxbx = bll_lxbx.GetModel(id);
        bll_lxbx.Delete(id);
        bll_temp_lxbx.Add(lxbx);
        BinData();

        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理";
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
    }



  
    //查询
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        bool DistrictSelected=(ddlDistrict.SelectedIndex!=0);
        bool ConfirmationNumberSelected = (ddlLogicalConfirmationNumber.SelectedValue == "TRUE");
        bool DirectReportNumberSelected = (ddlLogicalDirectReportNumber.SelectedValue == "TRUE");
        bool DateTypeSelected = (ddlDate.SelectedValue == "TRUE");
        bool NameSelected = (ddlLogicalName.SelectedValue == "TRUE");
        bool SexSelected = (ddlLogicalSex.SelectedValue == "TRUE");
        bool VerifySelected = (ddlLogicalState.SelectedValue == "TRUE");

        string whereDistrictSelected = " FK_District='" + ddlDistrict.SelectedItem.Text + "'";
        string whereConfirmationNumberSelected= " ConfirmationNumber like '%"+txtConfirmationNumber.Text.Trim()+"%'";
        string whereDirectReportNumberSelected= " DirectReportNumber like '%"+txtDirectReportNumber.Text.Trim()+"%'";
        string whereDateTypeSelected=" cast(" + ddlDate.SelectedValue + " as datetime) between '" + txtDateStart.Text + " 0:0:0' And '" + txtDateEnd.Text + " 23:59:59' ";
        string whereNameSelected=" [Name] like '%"+txtName.Text+"%' ";
        string whereSexSelected=" FK_Sex = '"+ddlSex.SelectedItem.Text+"'";
        string whereVerifySelected = " FK_Flag= '" + ddlState.SelectedItem.Text + "'";

        string whereNationalitySelected = " FK_Nationality='" + ddlNationality.SelectedValue + "'";
        string whereMarriageStatusSelected = " FK_MarriageStatus='" + ddlMarriageStatus.SelectedValue + "'";
        string whereEducationSelected = " FK_Education='" + ddlMarriageStatus.SelectedValue + "'";
        string whereCitizenshipSelected = " FK_Citizenship='" + ddlCitizenship.SelectedValue + "'";
        string whereInfectionWaysSelected = " FK_InfectionWay='" + ddlInfectionWay.SelectedValue + "'";
        string whereContactHistorySelected = " FK_ContactHistory='" + ddlContactHistory.SelectedValue + "'";
        string whereJobCharacterSelected = " FK_JobCharacter='" + ddlJobCharacter.SelectedValue + "'";
        string whereDetectionClassSelected = " FK_DetectionClass='" + ddlDetectionClass.SelectedValue + "'";
        string whereHouseholdRegisterSelected = " FK_HouseholdRegister='" + ddlHouseholdRegister.SelectedValue + "'";
        string whereCurrentsituationSelected = " FK_CurrentSituation='" + ddlCurrentSituation.SelectedValue + "'";
        string whereProvinceSelected = " Province='" + ddlProvince.SelectedValue + "'";
        string whereIsDeadSelected = " FK_IsDead='" + ddlIsDead.SelectedValue + "'";
        string where=" ID!=-100 "; 
        if (DistrictSelected)
        {
            where+=(" AND "+whereDistrictSelected+" ");
          
        }
        if (ConfirmationNumberSelected)
        {
            where+=(" AND "+whereConfirmationNumberSelected+" ");
          
        }
        if (DirectReportNumberSelected)
        {
            where+=(" AND "+whereDirectReportNumberSelected+" ");
          
        }
        if(DateTypeSelected)
        {
            where +=(" AND "+whereDateTypeSelected+" ");
        }
        if(NameSelected)
        {
           where +=(" AND "+whereNameSelected+" ");
        }
        if(SexSelected)
        {
           where +=(" AND "+whereSexSelected+" ");
        }
        if(VerifySelected)
        {
           where +=(" AND "+whereVerifySelected+" ");
        }
        if (ddlNationality.SelectedIndex != 0)
        {
            where += (" AND " + whereNationalitySelected + " ");
        }
        if (ddlMarriageStatus.SelectedIndex != 0)
        {
            where += (" AND " + whereMarriageStatusSelected + " ");
        }
        if (ddlEducation.SelectedIndex != 0)
        {
            where += (" AND " + whereEducationSelected + " ");
        }
        if (ddlCitizenship.SelectedIndex != 0)
        {
            where += (" AND " + whereCitizenshipSelected + " ");
        }
        if (ddlInfectionWay.SelectedIndex != 0)
        {
            where += (" AND " + whereInfectionWaysSelected + " ");

        }
        if (ddlContactHistory.SelectedIndex != 0)
        {
            where += (" AND " + whereContactHistorySelected + " ");
        }
        if (ddlJobCharacter.SelectedIndex != 0)
        {
            where += (" AND " + whereJobCharacterSelected + " ");
        }
        if (ddlDetectionClass.SelectedIndex != 0)
        {
            where += (" AND " + whereDetectionClassSelected + " ");
        }
        if (ddlHouseholdRegister.SelectedIndex != 0)
        {
            where += (" AND " + whereHouseholdRegisterSelected + " ");
        }
        if (ddlCurrentSituation.SelectedIndex != 0)
        {
            where += (" AND " + whereCurrentsituationSelected + " ");
        }
        if (ddlProvince.SelectedIndex != 0)
        {
            where += (" AND " + whereProvinceSelected + " ");
        }
        if (ddlIsDead.SelectedIndex != 0)
        {
            where += (" AND " + whereIsDeadSelected + " ");
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

    protected void BtnFlag_Click(object sender, EventArgs e)
    {
        this.RememberOldValues();
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        Export("流行性病例表");
    }

    private void Export(string FileName)
    {
        ArrayList al = null;
        DataTable dt = new DataTable();

        dt.Columns.Add("直报号");
        dt.Columns.Add("确认ID");
        dt.Columns.Add("姓名");
        dt.Columns.Add("身份证");
        dt.Columns.Add("性别");
        dt.Columns.Add("民族");
        dt.Columns.Add("文化程度");
        dt.Columns.Add("出生日期");
        dt.Columns.Add("户籍情况");
        dt.Columns.Add("国籍");
        dt.Columns.Add("可能感染途径");
        dt.Columns.Add("户籍地址");
        dt.Columns.Add("职业特性");
        dt.Columns.Add("现住区域");
        dt.Columns.Add("婚姻状况");
        dt.Columns.Add("现况");
        dt.Columns.Add("阳性判定日期");
        dt.Columns.Add("是否死亡");
        dt.Columns.Add("转AIDS日期");
        dt.Columns.Add("送检单位");
        dt.Columns.Add("配偶");
        dt.Columns.Add("接触史");
        dt.Columns.Add("小孩");
        dt.Columns.Add("检测分类");
        dt.Columns.Add("备注");
        dt.Columns.Add("状态");

        DataSet ds = bll_lxbx.GetList(strWhere);
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
                dr[4] = ds.Tables[0].Rows[i]["FK_Sex"].ToString();
                dr[5] = ds.Tables[0].Rows[i]["FK_Nationality"].ToString();
                dr[6] = ds.Tables[0].Rows[i]["FK_Education"].ToString();
                dr[7] = ds.Tables[0].Rows[i]["BirthDate"].ToString();
                dr[8] = ds.Tables[0].Rows[i]["FK_HouseholdRegister"].ToString();
                dr[9] = ds.Tables[0].Rows[i]["FK_Citizenship"].ToString();
                dr[10] = ds.Tables[0].Rows[i]["FK_InfectionWay"].ToString();
                dr[11] = ds.Tables[0].Rows[i]["Province"].ToString();
                dr[12] = ds.Tables[0].Rows[i]["FK_JobCharacter"].ToString();
                dr[13] = ds.Tables[0].Rows[i]["FK_District"].ToString();
                dr[14] = ds.Tables[0].Rows[i]["FK_MarriageStatus"].ToString();
                dr[15] = ds.Tables[0].Rows[i]["FK_CurrentSituation"].ToString();
                dr[16] = ds.Tables[0].Rows[i]["PositiveDecisionDate"].ToString();
                dr[17] = ds.Tables[0].Rows[i]["FK_IsDead"].ToString();
                dr[18] = ds.Tables[0].Rows[i]["ToAidsDate"].ToString();
                dr[19] = ds.Tables[0].Rows[i]["CensorshipUnit"].ToString();
                dr[20] = ds.Tables[0].Rows[i]["FK_Spouse"].ToString();
                dr[21] = ds.Tables[0].Rows[i]["FK_ContactHistory"].ToString();
                dr[22] = ds.Tables[0].Rows[i]["FK_Children"].ToString();
                dr[23] = ds.Tables[0].Rows[i]["FK_DetectionClass"].ToString();
                dr[24] = ds.Tables[0].Rows[i]["Remark"].ToString();
                dr[25] = ds.Tables[0].Rows[i]["FK_Flag"].ToString();      
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
                    dr[4] = ds.Tables[0].Rows[i]["FK_Sex"].ToString();
                    dr[5] = ds.Tables[0].Rows[i]["FK_Nationality"].ToString();
                    dr[6] = ds.Tables[0].Rows[i]["FK_Education"].ToString();
                    dr[7] = ds.Tables[0].Rows[i]["BirthDate"].ToString();
                    dr[8] = ds.Tables[0].Rows[i]["FK_HouseholdRegister"].ToString();
                    dr[9] = ds.Tables[0].Rows[i]["FK_Citizenship"].ToString();
                    dr[10] = ds.Tables[0].Rows[i]["FK_InfectionWay"].ToString();
                    dr[11] = ds.Tables[0].Rows[i]["Province"].ToString();
                    dr[12] = ds.Tables[0].Rows[i]["FK_JobCharacter"].ToString();
                    dr[13] = ds.Tables[0].Rows[i]["FK_District"].ToString();
                    dr[14] = ds.Tables[0].Rows[i]["FK_MarriageStatus"].ToString();
                    dr[15] = ds.Tables[0].Rows[i]["FK_CurrentSituation"].ToString();
                    dr[16] = ds.Tables[0].Rows[i]["PositiveDecisionDate"].ToString();
                    dr[17] = ds.Tables[0].Rows[i]["FK_IsDead"].ToString();
                    dr[18] = ds.Tables[0].Rows[i]["ToAidsDate"].ToString();
                    dr[19] = ds.Tables[0].Rows[i]["CensorshipUnit"].ToString();
                    dr[20] = ds.Tables[0].Rows[i]["FK_Spouse"].ToString();
                    dr[21] = ds.Tables[0].Rows[i]["FK_ContactHistory"].ToString();
                    dr[22] = ds.Tables[0].Rows[i]["FK_Children"].ToString();
                    dr[23] = ds.Tables[0].Rows[i]["FK_DetectionClass"].ToString();
                    dr[24] = ds.Tables[0].Rows[i]["Remark"].ToString();
                    dr[25] = ds.Tables[0].Rows[i]["FK_Flag"].ToString();      

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
}
