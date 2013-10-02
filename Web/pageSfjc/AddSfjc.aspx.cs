using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DBUtility;

public partial class AddSfjc : System.Web.UI.Page
{
   

    Model.tb_sfjc sfjc = new Model.tb_sfjc();
    BLL.tb_sfjc bll_sfjc = new BLL.tb_sfjc();
    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();
    Model.tb_yxyb yxyb = new Model.tb_yxyb();
    BLL.tb_yxyb bll_yxyb = new BLL.tb_yxyb();
    Model.tb_lxbx lxbx = new Model.tb_lxbx();
    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
    int directReportNumSize = 0;
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

        }
        directReportNumSize = txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + txtDirectReportNumber3.MaxLength + txtDirectReportNumber4.MaxLength;
    }
    
    private void init()
    {

        
        DataSet dataSet = null;

        //性别
        dataSet = new BLL.TB_SEX().GetAllList();
        ddlSex.DataSource = dataSet;
        ddlSex.DataTextField = "Name";
        ddlSex.DataValueField = "ID";
        ddlSex.DataBind();

       

        //可能感染途径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

       
        
        //现况
        dataSet = new BLL.TB_CurrentSituation().GetAllList();
        ddlCurrentSituation.DataSource = dataSet;
        ddlCurrentSituation.DataTextField = "Name";
        ddlCurrentSituation.DataValueField = "ID";
        ddlCurrentSituation.DataBind();

        //现住区域
        dataSet = new BLL.TB_District().GetAllList();
        ddlDistrict.DataSource = dataSet;
        ddlDistrict.DataTextField = "Name";
        ddlDistrict.DataValueField = "ID";
        ddlDistrict.DataBind();

        //是否死亡
        dataSet = new BLL.TB_IsDead().GetAllList();
        ddlIsDead.DataSource = dataSet;
        ddlIsDead.DataTextField = "Name";
        ddlIsDead.DataValueField = "ID";
        ddlIsDead.DataBind();

        //治疗类型
        dataSet = new BLL.TB_TypeOfTreatment().GetAllList();
        ddlTypeOfTreatment.DataSource = dataSet;
        ddlTypeOfTreatment.DataTextField = "Name";
        ddlTypeOfTreatment.DataValueField = "ID";
        ddlTypeOfTreatment.DataBind();

        //首次随访
        dataSet = new BLL.TB_FirstFollowUpVisit().GetAllList();
        ddlFirstFollowUpVisit.DataSource = dataSet;
        ddlFirstFollowUpVisit.DataTextField = "Name";
        ddlFirstFollowUpVisit.DataValueField = "ID";
        ddlFirstFollowUpVisit.DataBind();

        //随访干预
        dataSet = new BLL.TB_FollowUpIntervention().GetAllList();
        ddlFollowUpIntervention.DataSource = dataSet;
        ddlFollowUpIntervention.DataTextField = "Name";
        ddlFollowUpIntervention.DataValueField = "ID";
        ddlFollowUpIntervention.DataBind();

        //维持状况
        dataSet = new BLL.TB_MaintainStatus().GetAllList();
        ddlMaintainStatus.DataSource = dataSet;
        ddlMaintainStatus.DataTextField = "Name";
        ddlMaintainStatus.DataValueField = "ID";
        ddlMaintainStatus.DataBind();

        //配偶检测情况
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlSpouse_AntibodyDetection.DataSource = dataSet;
        ddlSpouse_AntibodyDetection.DataTextField = "Name";
        ddlSpouse_AntibodyDetection.DataValueField = "ID";
        ddlSpouse_AntibodyDetection.DataBind();

        //是否当年检测
        dataSet = new BLL.TB_DetectBefore().GetAllList();
        ddlDetectBefore.DataSource = dataSet;
        ddlDetectBefore.DataTextField = "Name";
        ddlDetectBefore.DataValueField = "ID";
        ddlDetectBefore.DataBind();

        //维持状况
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlChildren_AntibodyDetection.DataSource = dataSet;
        ddlChildren_AntibodyDetection.DataTextField = "Name";
        ddlChildren_AntibodyDetection.DataValueField = "ID";
        ddlChildren_AntibodyDetection.DataBind();

        DataSet ds = new DataSet();//用于存放配置文件信息
        ds.ReadXml(Server.MapPath(@"..\XMLFile.xml"));

        //////////////////////////////////ToolTips////////////////////////////////

        txtDirectReportNumber1.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber1"].ToString();
        txtDirectReportNumber2.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber2"].ToString();
        txtDirectReportNumber3.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber3"].ToString();
        txtDirectReportNumber4.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber4"].ToString();

        txtConfirmationNumber1.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfConfirmationNumber1"].ToString();
        txtConfirmationNumber2.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfConfirmationNumber2"].ToString();

        //////////////////////////////////MaxLength////////////////////////////////
        txtDirectReportNumber1.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber1"].ToString());
        txtDirectReportNumber2.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber2"].ToString());
        txtDirectReportNumber3.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber3"].ToString());
        txtDirectReportNumber4.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber4"].ToString());

        txtConfirmationNumber1.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfConfirmationNumber1"].ToString());
        txtConfirmationNumber2.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfConfirmationNumber2"].ToString());




        //////////////////////////////////Add JS////////////////////////////////
        txtDirectReportNumber1.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber2.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber3.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber4.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");

        txtDirectReportNumber1.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber2')");
        txtDirectReportNumber2.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber3')");
        txtDirectReportNumber3.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber4')");

        txtConfirmationNumber1.Attributes.Add("onkeyup", "checkLen(this,'txtConfirmationNumber2')");


        //确认日期
        txtConfirmationDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        //出生日期
        txtBirthDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //加入时间
        txtAddingTime.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        UpContextData();
    }





    private void UpContextData()
    {

    }



    protected void btnWrite_Click(object sender, EventArgs e)
    {
        sfjc.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        sfjc.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
        sfjc.Name = txtName.Text;
        sfjc.FK_Sex = int.Parse(ddlSex.SelectedValue);
        sfjc.ConfirmationDate = txtConfirmationDate.Text;
        sfjc.BirthDate = txtBirthDate.Text;
        sfjc.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        sfjc.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        sfjc.FK_District = int.Parse(ddlDistrict.SelectedValue);
        sfjc.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        sfjc.FK_TypeOfTreatment = int.Parse(ddlTypeOfTreatment.SelectedValue);
        sfjc.FK_FirstFollowUpVisit = int.Parse(ddlFirstFollowUpVisit.SelectedValue);
        sfjc.AddingTime = txtAddingTime.Text;
        sfjc.FK_FollowUpIntervention = int.Parse(ddlFollowUpIntervention.SelectedValue);
        sfjc.TreatmentNumber = txtTreatmentNumber.Text;
        sfjc.CD4 = txtCD4.Text;
        sfjc.FK_MaintainStatus = int.Parse(ddlMaintainStatus.SelectedValue);
        sfjc.ViralLoad = txtViralLoad.Text;
        sfjc.FK_Spouse_AntibodyDetection = int.Parse(ddlSpouse_AntibodyDetection.SelectedValue);
        sfjc.FK_DetectBefore = int.Parse(ddlDetectBefore.SelectedValue);
        sfjc.FK_Children_AntibodyDetection = int.Parse(ddlChildren_AntibodyDetection.SelectedValue);
        sfjc.Remark = txtRemark.Text;
        sfjc.Id_card = txtIDCard.Text;




        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
            Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            sfjc.FK_Flag = Global.InfoState.Verified;
        else
            sfjc.FK_Flag = Global.InfoState.UnVerified;


        sfjc.FK_User = int.Parse(Session["UserID"].ToString());
        sfjc.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


        int confirmNumSize = txtConfirmationNumber1.MaxLength + txtConfirmationNumber2.MaxLength;

        bool A = (sfjc.DirectReportNumber.Length - 3 == directReportNumSize); //DirectReportNumber长度减3，前面加了3个字符‘-’
        bool B = (sfjc.ConfirmationNumber.Length - 2 == confirmNumSize);
        bool C = (txtName.Text.Trim().Length != 0);
        bool D = (txtBirthDate.Text.Trim().Length != 0);


        bool F = (bll_yxyb.GetList(" DirectReportNumber='" + sfjc.DirectReportNumber + "' ").Tables[0].Rows.Count == 0);
        bool G = (bll_yxyb.GetList(" ConfirmationNumber='" + sfjc.ConfirmationNumber + "' ").Tables[0].Rows.Count == 0);

        bool H = (bll_lxbx.GetList(" DirectReportNumber='" + sfjc.DirectReportNumber + "' ").Tables[0].Rows.Count == 0);
        bool I = (bll_lxbx.GetList(" ConfirmationNumber='" + sfjc.ConfirmationNumber + "' ").Tables[0].Rows.Count == 0);
        bool J = (sfjc.Id_card.Length == 18);
        if (!A)
        {
            JScript.Alert("直报号的长度不够");
            return;
        }
        if (!B)
        {
            JScript.Alert("确认号的长度不够");
            return;
        }
        if (!C)
        {
            JScript.Alert("姓名为空");
            return;
        }
        if (!D)
        {
            JScript.Alert("出生日期为空");
            return;
        }
        if (!J)
        {
            JScript.Alert("身份证号长度不正确");
            return;
        }
        //随访那条记录在其他表里面不存在，提示一个是否输入有误
        if (F && H)
        {
            JScript.Alert("直报号不存在，请确认后重新输入！");
            return;
        }

        if (G && I)
        {
            JScript.Alert("确认号不存在，请确认后重新输入！");
            return;
        }

        //判断随访记录表是否全部重复，如果全部重复的话，弹出一个提示
        string sfjcsql = " DirectReportNumber = '" + sfjc.DirectReportNumber + "' and ConfirmationNumber ='" + sfjc.ConfirmationNumber + "' and Name = '"
            + sfjc.Name + "' and FK_Sex = '" + sfjc.FK_Sex + "' and ConfirmationDate = '" + sfjc.ConfirmationDate + "' and BirthDate = '" +
            sfjc.BirthDate + "' and FK_InfectionWay = '" + sfjc.FK_InfectionWay + "' and FK_CurrentSituation = '" + sfjc.FK_CurrentSituation +
            "' and FK_District = '" + sfjc.FK_District + "' and FK_IsDead = '" + sfjc.FK_IsDead + "' and FK_TypeOfTreatment = '" + sfjc.FK_TypeOfTreatment +
            "' and FK_FirstFollowUpVisit ='" + sfjc.FK_FirstFollowUpVisit + "' and AddingTime ='" + sfjc.AddingTime + "' and FK_FollowUpIntervention ='" +
            sfjc.FK_FollowUpIntervention + "' and TreatmentNumber ='" + sfjc.TreatmentNumber + "' and CD4 = '" + sfjc.CD4 + "' and FK_MaintainStatus ='" +
            sfjc.FK_MaintainStatus + "' and ViralLoad='" + sfjc.ViralLoad + "' and FK_Spouse_AntibodyDetection ='" + sfjc.FK_Spouse_AntibodyDetection +
            "' and FK_DetectBefore ='" + sfjc.FK_DetectBefore + "' and FK_Children_AntibodyDetection ='" + sfjc.FK_Children_AntibodyDetection +
            "' and Remark ='" + sfjc.Remark + "' and Id_card='" + sfjc.Id_card + "'";
        List<Model.tb_sfjc> list_sfjc = bll_sfjc.GetModelList(sfjcsql);
        //随访记录表存在该条记录，提示并返回
        if (list_sfjc.Count > 0)
        {
            JScript.Alert("插入的数据已经存在，请重新输入！");
            return;
        }
        //阳性样表

        //取出存在表中的数据
        string strsql = " ConfirmationNumber = '" + sfjc.ConfirmationNumber + "' and DirectReportNumber ='" + sfjc.DirectReportNumber + "'";
        List<Model.tb_yxyb> list_yxyb = bll_yxyb.GetModelList(strsql);
        Model.tb_yxyb temp_yxyb = null;

        //若list中的总数大于0表明阳性样表表中存在该直报号和确认号
        if (list_yxyb.Count > 0)
        {
            temp_yxyb = list_yxyb.ToArray()[0];
            //为模型赋值
            yxyb.ConfirmationDate = sfjc.ConfirmationDate;
            yxyb.Name = sfjc.Name;
            yxyb.FK_Sex = sfjc.FK_Sex;
            yxyb.BirthDate = sfjc.BirthDate;
            yxyb.FK_InfectionWay = sfjc.FK_InfectionWay;
            yxyb.CD4 = sfjc.CD4;
            yxyb.ViralLoad = sfjc.ViralLoad;
            yxyb.FK_User = sfjc.FK_User;

            //yxyb.ID = temp_yxyb.ID;
            //yxyb.HBV = temp_yxyb.HBV;
            //yxyb.HCV = temp_yxyb.HCV;
            //yxyb.Others = temp_yxyb.Others;
            //yxyb.ConfirmationNumber = temp_yxyb.ConfirmationNumber;
            //yxyb.DirectReportNumber = temp_yxyb.DirectReportNumber;
            //yxyb.FK_Flag = temp_yxyb.FK_Flag;
            //yxyb.PreservePosition = temp_yxyb.PreservePosition;
            //yxyb.FlowNumber = temp_yxyb.FlowNumber;
            //yxyb.SamplingDate = temp_yxyb.SamplingDate;
            //yxyb.TB = temp_yxyb.TB;

            //yxyb.Syphilis = temp_yxyb.Syphilis;

            //yxyb.SendingTime = temp_yxyb.SendingTime;
            //yxyb.showToUser = temp_yxyb.showToUser;
            //yxyb.VerifyDate = temp_yxyb.VerifyDate;
            //yxyb.FK_SampleType = temp_yxyb.FK_SampleType;
            //yxyb.FK_SampleSize = temp_yxyb.FK_SampleSize;
            yxyb.Id_card = sfjc.Id_card;
            //插入阳性样表
            bll_yxyb.Add(yxyb);
        }
        //病例样例
        List<Model.tb_lxbx> list_lxbx = bll_lxbx.GetModelList(strsql);
        Model.tb_lxbx temp_lxbx = null;

        //若list中的总数大于0表明病例样例表中存在该直报号和确认号
        if (list_lxbx.Count > 0)
        {
            temp_lxbx = list_lxbx.ToArray()[0];
            //为模型赋值

            lxbx.ConfirmationNumber = sfjc.ConfirmationNumber;
            lxbx.DirectReportNumber = sfjc.DirectReportNumber;
            lxbx.Name = sfjc.Name;
            lxbx.FK_Sex = sfjc.FK_Sex;
            lxbx.BirthDate = sfjc.BirthDate;
            lxbx.FK_InfectionWay = sfjc.FK_InfectionWay;
            lxbx.FK_CurrentSituation = sfjc.FK_CurrentSituation;
            lxbx.FK_District = sfjc.FK_District;
            lxbx.FK_IsDead = sfjc.FK_IsDead;
            lxbx.Remark = sfjc.Remark;
            lxbx.SendingTime = sfjc.SendingTime;
            lxbx.FK_Spouse = sfjc.FK_Spouse_AntibodyDetection;
            lxbx.FK_Children = sfjc.FK_Children_AntibodyDetection;
            lxbx.FK_User = sfjc.FK_User;

            lxbx.ID = temp_lxbx.ID;
            lxbx.FK_Nationality = temp_lxbx.FK_Nationality;
            lxbx.FK_MarriageStatus = temp_lxbx.FK_MarriageStatus;
            lxbx.FK_Education = temp_lxbx.FK_Education;
            lxbx.FK_Citizenship = temp_lxbx.FK_Citizenship;
            lxbx.Province = temp_lxbx.Province;
            lxbx.County = temp_lxbx.County;
            lxbx.FK_ContactHistory = temp_lxbx.FK_ContactHistory;
            lxbx.FK_JobCharacter = temp_lxbx.FK_JobCharacter;
            lxbx.FK_DetectionClass = temp_lxbx.FK_DetectionClass;
            lxbx.FK_HouseholdRegister = temp_lxbx.FK_HouseholdRegister;
            lxbx.PositiveDecisionDate = temp_lxbx.PositiveDecisionDate;
            lxbx.ToAidsDate = temp_lxbx.ToAidsDate;
            lxbx.DetailedAddress = temp_lxbx.DetailedAddress;
            lxbx.CensorshipUnit = temp_lxbx.CensorshipUnit;
            lxbx.FK_DetectionStatement = temp_lxbx.FK_DetectionStatement;
            lxbx.FK_Flag = temp_lxbx.FK_Flag;
            lxbx.FK_ShowToUser = temp_lxbx.FK_ShowToUser;
            lxbx.VerifyDate = temp_lxbx.VerifyDate;
            lxbx.Spouse = temp_lxbx.Spouse;
            lxbx.Children = temp_lxbx.Children;

            //更新病例样例
            bll_lxbx.Update(lxbx);

            bll_lxbx.Add(temp_lxbx);


        }





        bll_sfjc.Add(sfjc);
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS随访信息管理";
        log.Operation = "添加信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        DBUtility.JScript.Alert("成功添加", this.Page);
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        BLL.Draft_sfjc draf_sfjc = new BLL.Draft_sfjc();
        Model.Draft_sfjc model_sfjc = new Model.Draft_sfjc();
        model_sfjc.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        model_sfjc.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
        model_sfjc.Name = txtName.Text;
        model_sfjc.FK_Sex = int.Parse(ddlSex.SelectedValue);
        model_sfjc.ConfirmationDate = txtConfirmationDate.Text;
        model_sfjc.BirthDate = txtBirthDate.Text;
        model_sfjc.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        model_sfjc.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        model_sfjc.FK_District = int.Parse(ddlDistrict.SelectedValue);
        model_sfjc.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        model_sfjc.FK_TypeOfTreatment = int.Parse(ddlTypeOfTreatment.SelectedValue);
        model_sfjc.FK_FirstFollowUpVisit = int.Parse(ddlFirstFollowUpVisit.SelectedValue);
        model_sfjc.AddingTime = txtAddingTime.Text;
        model_sfjc.FK_FollowUpIntervention = int.Parse(ddlFollowUpIntervention.SelectedValue);
        model_sfjc.TreatmentNumber=txtTreatmentNumber.Text;
        model_sfjc.CD4=txtCD4.Text;
        model_sfjc.FK_MaintainStatus = int.Parse(ddlMaintainStatus.SelectedValue);
        model_sfjc.ViralLoad = txtViralLoad.Text;
        model_sfjc.FK_Spouse_AntibodyDetection = int.Parse(ddlSpouse_AntibodyDetection.SelectedValue);
        model_sfjc.FK_DetectBefore = int.Parse(ddlDetectBefore.SelectedValue);
        model_sfjc.FK_Children_AntibodyDetection = int.Parse(ddlChildren_AntibodyDetection.SelectedValue);
        model_sfjc.Remark = txtRemark.Text;
        model_sfjc.Id_card = txtIDCard.Text;
        model_sfjc.Operator_id = int.Parse(Session["UserID"].ToString());
       
   
        

        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
            Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            model_sfjc.FK_Flag = Global.InfoState.Verified;
        else
            model_sfjc.FK_Flag = Global.InfoState.UnVerified;


        model_sfjc.FK_User = int.Parse(Session["UserID"].ToString());
        model_sfjc.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


        draf_sfjc.Add(model_sfjc);
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS随访信息管理";
        log.Operation = "添加信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        DBUtility.JScript.Alert("保存成功", this.Page);

       
    }
    
    protected void btnBatchWrite_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddBatchsfjc.aspx");
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("sfjc.aspx");
    }
    protected void btnIfExist_Click(object sender, EventArgs e)
    {
        string str = txtDirectReportNumber1.Text.Trim() + "-" + txtDirectReportNumber2.Text.Trim() + "-" + txtDirectReportNumber3.Text.Trim() + "-" + txtDirectReportNumber4.Text.Trim();
        if (str.Length == directReportNumSize + 3)
        {
            string where = "DirectReportNumber = '" + txtDirectReportNumber1.Text + txtDirectReportNumber2.Text + txtDirectReportNumber3.Text + txtDirectReportNumber4.Text + "'";
            lblTimes.Text = "第 " + bll_sfjc.GetModelList(where).Count.ToString() + " 次随访信息" ;
        }
        else
        {
            JScript.Alert("直报号的长度不够");
        }
        

    }
}
