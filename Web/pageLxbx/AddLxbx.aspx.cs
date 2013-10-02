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

public partial class AddLxbx : System.Web.UI.Page
{


    Model.tb_lxbx lxbx = new Model.tb_lxbx();
    BLL.tb_lxbx bll_lxbx=new BLL.tb_lxbx();
    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();
  
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
    }

    private void init()
    {
        DataSet dataSet=null;
        
        //性别
        dataSet = new BLL.TB_SEX().GetAllList();
        ddlSex.DataSource = dataSet;
        ddlSex.DataTextField = "Name";
        ddlSex.DataValueField = "ID";
        ddlSex.DataBind();

        //民族
        dataSet = new BLL.TB_Nationality().GetAllList();
        ddlNationality.DataSource = dataSet;
        ddlNationality.DataTextField = "Name";
        ddlNationality.DataValueField = "ID";
        ddlNationality.DataBind();

        //婚姻状况
        dataSet = new BLL.TB_MarriageStatus().GetAllList();
        ddlMarriageStatus.DataSource = dataSet;
        ddlMarriageStatus.DataTextField = "Name";
        ddlMarriageStatus.DataValueField = "ID";
        ddlMarriageStatus.DataBind();

        //文化程度
        dataSet = new BLL.TB_Education().GetAllList();
        ddlEducation.DataSource = dataSet;
        ddlEducation.DataTextField = "Name";
        ddlEducation.DataValueField = "ID";
        ddlEducation.DataBind();

        //国籍
        dataSet = new BLL.TB_Citizenship().GetAllList();
        ddlCitizenship.DataSource = dataSet;
        ddlCitizenship.DataTextField = "Name";
        ddlCitizenship.DataValueField = "ID";
        ddlCitizenship.DataBind();


        //可能感染途径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

        //接触史
        dataSet = new BLL.TB_ContactHistory().GetAllList();
        ddlContactHistory.DataSource = dataSet;
        ddlContactHistory.DataTextField = "Name";
        ddlContactHistory.DataValueField = "ID";
        ddlContactHistory.DataBind();

        //职业特征
        dataSet = new BLL.TB_JobCharacter().GetAllList();
        ddlJobCharacter.DataSource = dataSet;
        ddlJobCharacter.DataTextField = "Name";
        ddlJobCharacter.DataValueField = "ID";
        ddlJobCharacter.DataBind();

        //检测分类
        dataSet = new BLL.TB_DetectionClass().GetAllList();
        ddlDetectionClass.DataSource = dataSet;
        ddlDetectionClass.DataTextField = "Name";
        ddlDetectionClass.DataValueField = "ID";
        ddlDetectionClass.DataBind();

        //户籍情况
        dataSet = new BLL.TB_HouseholdRegister().GetAllList();
        ddlHouseholdRegister.DataSource = dataSet;
        ddlHouseholdRegister.DataTextField = "Name";
        ddlHouseholdRegister.DataValueField = "ID";
        ddlHouseholdRegister.DataBind();

        //现况
        dataSet = new BLL.TB_CurrentSituation().GetAllList();
        ddlCurrentSituation.DataSource = dataSet;
        ddlCurrentSituation.DataTextField = "Name";
        ddlCurrentSituation.DataValueField = "ID";
        ddlCurrentSituation.DataBind();

        //籍贯
        dataSet = new BLL.TB_Province().GetAllList();
        ddlProvince.DataSource = dataSet;
        ddlProvince.DataTextField = "Name";
        ddlProvince.DataValueField = "Name";
        ddlProvince.DataBind();

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

        //检测情况1
        /*
        dataSet = new BLL.TB_DetectionStatement().GetAllList();
        ddlDetectionStatement1.DataSource = dataSet;
        ddlDetectionStatement1.DataTextField = "Name";
        ddlDetectionStatement1.DataValueField = "ID";
        ddlDetectionStatement1.DataBind();   
         * */
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlSpouse_AntibodyDetection.DataSource = dataSet;
        ddlSpouse_AntibodyDetection.DataTextField = "Name";
        ddlSpouse_AntibodyDetection.DataValueField = "ID";
        ddlSpouse_AntibodyDetection.DataBind();
       

        //检测情况2
        /*
        dataSet = new BLL.TB_DetectionStatement().GetAllList();
        ddlDetectionStatement2.DataSource = dataSet;
        ddlDetectionStatement2.DataTextField = "Name";
        ddlDetectionStatement2.DataValueField = "ID";
        ddlDetectionStatement2.DataBind();
        */
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlChildren_AntibodyDetection.DataSource = dataSet;
        ddlChildren_AntibodyDetection.DataTextField = "Name";
        ddlChildren_AntibodyDetection.DataValueField = "ID";
        ddlChildren_AntibodyDetection.DataBind();

        DataSet ds=new DataSet();//用于存放配置文件信息
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
        txtDirectReportNumber1.Attributes.Add("onkeypress","if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber2.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber3.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber4.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");

        txtDirectReportNumber1.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber2')");
        txtDirectReportNumber2.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber3')");
        txtDirectReportNumber3.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber4')");

        txtConfirmationNumber1.Attributes.Add("onkeyup", "checkLen(this,'txtConfirmationNumber2')");
       
        
        //阳性判定时间
        txtPositiveDecisionDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //转AIDS时间
        txtToAidsDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //出生日期
        txtBirthDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        UpContextData();
    }
   



    
    private void UpContextData()
    {
             
    }



    protected void btnWrite_Click(object sender, EventArgs e)
    {
        lxbx.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        lxbx.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
        lxbx.Name = txtName.Text;
        lxbx.FK_Sex = int.Parse(ddlSex.SelectedValue);
        lxbx.FK_Nationality = int.Parse(ddlNationality.SelectedValue);
        lxbx.BirthDate = txtBirthDate.Text;
        lxbx.FK_Education = int.Parse(ddlEducation.SelectedValue);
        lxbx.FK_Citizenship = int.Parse(ddlCitizenship.SelectedValue);
        lxbx.FK_HouseholdRegister = int.Parse(ddlHouseholdRegister.SelectedValue);
        lxbx.FK_District = int.Parse(ddlDistrict.SelectedValue);
        lxbx.DetailedAddress = txtDetailedAddress.Text;
        lxbx.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        lxbx.County = txtCounty.Text;
        lxbx.FK_JobCharacter = int.Parse(ddlJobCharacter.SelectedValue);
        lxbx.Province = ddlProvince.SelectedValue;
        lxbx.PositiveDecisionDate = txtPositiveDecisionDate.Text;
        lxbx.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        lxbx.ToAidsDate = txtToAidsDate.Text;
        lxbx.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        lxbx.FK_MarriageStatus = int.Parse(ddlMarriageStatus.SelectedValue);
        lxbx.CensorshipUnit = txtCensorshipUnit.Text;
        lxbx.Spouse = txtSpouse.Text;
        lxbx.FK_Spouse = int.Parse(ddlSpouse_AntibodyDetection.SelectedValue);
        lxbx.FK_ContactHistory = int.Parse(ddlContactHistory.SelectedValue);
        lxbx.Children = txtChildren.Text;
        lxbx.FK_Children = int.Parse(ddlChildren_AntibodyDetection.SelectedValue);
        lxbx.FK_DetectionClass = int.Parse(ddlDetectionClass.SelectedValue);
        lxbx.Id_card = txtIDCard.Text.Trim();
        if(Session["RoleID"].ToString()=="" || Session["RoleID"]==null ||
            Session["UserID"].ToString()=="" || Session["UserID"]==null)
        return;

        int RoleID=int.Parse(Session["RoleID"].ToString());
        string Authority=new BLL.tb_role().GetModel(RoleID).name;

        if (Authority == "系统管理员")
            lxbx.FK_Flag = Global.InfoState.Verified;
        else
            lxbx.FK_Flag = Global.InfoState.UnVerified;

        lxbx.FK_User = int.Parse(Session["UserID"].ToString());
        lxbx.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

       int directReportNumSize=txtDirectReportNumber1.MaxLength+txtDirectReportNumber2.MaxLength+txtDirectReportNumber3.MaxLength+txtDirectReportNumber4.MaxLength;
       int confirmNumSize=txtConfirmationNumber1.MaxLength+txtConfirmationNumber2.MaxLength;

       bool A = (lxbx.DirectReportNumber.Length - 3 == directReportNumSize); //DirectReportNumber长度减3，前面加了3个字符‘-’
       bool B = (lxbx.ConfirmationNumber.Length-2 == confirmNumSize);
       bool C=(txtName.Text.Trim().Length!=0);
       bool D=(txtBirthDate.Text.Trim().Length!=0);
       bool E=(txtToAidsDate.Text.Trim().Length!=0);
       bool F=(bll_lxbx.GetList(" DirectReportNumber='"+lxbx.DirectReportNumber+"' ").Tables[0].Rows.Count==0);
       bool G = (bll_lxbx.GetList(" ConfirmationNumber='" + lxbx.ConfirmationNumber+"' ").Tables[0].Rows.Count == 0);
       bool I = (lxbx.Id_card.Length == 18);
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
       if (!E)
       {
           JScript.Alert("转AIDS日期为空");
           return;
       }
       if (!F)
       {
           JScript.Alert("直报号已存在");
           return;
       }
       if (!G)
       {
           JScript.Alert("确认号已存在");
           return;
       }
       if (!I)
       {
           JScript.Alert("身份证号长度不正确！");
           return;
       }
           bll_lxbx.Add(lxbx);
           log.FK_User = int.Parse(Session["UserID"].ToString());
           log.OperatingPosition = "HIV/AIDS病例报告管理";
           log.Operation = "添加信息";
           log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
           bll_log.Add(log);
           JScript.Alert("成功添加", this.Page);

       
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        BLL.Draft_lxbx draft_lxbx = new BLL.Draft_lxbx();
        Model.Draft_lxbx d_lxbx = new Model.Draft_lxbx();
        d_lxbx.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        d_lxbx.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
        d_lxbx.Name = txtName.Text;
        d_lxbx.FK_Sex = int.Parse(ddlSex.SelectedValue);
        d_lxbx.FK_Nationality = int.Parse(ddlNationality.SelectedValue);
        d_lxbx.BirthDate = txtBirthDate.Text;
        d_lxbx.FK_Education = int.Parse(ddlEducation.SelectedValue);
        d_lxbx.FK_Citizenship = int.Parse(ddlCitizenship.SelectedValue);
        d_lxbx.FK_HouseholdRegister = int.Parse(ddlHouseholdRegister.SelectedValue);
        d_lxbx.FK_District = int.Parse(ddlDistrict.SelectedValue);
        d_lxbx.DetailedAddress = txtDetailedAddress.Text;
        d_lxbx.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        d_lxbx.County = txtCounty.Text;
        d_lxbx.FK_JobCharacter = int.Parse(ddlJobCharacter.SelectedValue);
        d_lxbx.Province = ddlProvince.SelectedValue;
        d_lxbx.PositiveDecisionDate = txtPositiveDecisionDate.Text;
        d_lxbx.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        d_lxbx.ToAidsDate = txtToAidsDate.Text;
        d_lxbx.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        d_lxbx.FK_MarriageStatus = int.Parse(ddlMarriageStatus.SelectedValue);
        d_lxbx.CensorshipUnit = txtCensorshipUnit.Text;
        d_lxbx.Spouse = txtSpouse.Text;
        d_lxbx.FK_Spouse = int.Parse(ddlSpouse_AntibodyDetection.SelectedValue);
        d_lxbx.FK_ContactHistory = int.Parse(ddlContactHistory.SelectedValue);
        d_lxbx.Children = txtChildren.Text;
        d_lxbx.FK_Children = int.Parse(ddlChildren_AntibodyDetection.SelectedValue);
        d_lxbx.FK_DetectionClass = int.Parse(ddlDetectionClass.SelectedValue);
        d_lxbx.Id_card = txtIDCard.Text.Trim();
        d_lxbx.Operator_id = int.Parse(Session["UserID"].ToString());
        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
            Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;

        if (Authority == "系统管理员")
            d_lxbx.FK_Flag = Global.InfoState.Verified;
        else
            d_lxbx.FK_Flag = Global.InfoState.UnVerified;

        d_lxbx.FK_User = int.Parse(Session["UserID"].ToString());
        d_lxbx.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");



        draft_lxbx.Add(d_lxbx);
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理";
        log.Operation = "保存信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        JScript.Alert("保存成功", this.Page);


    }
    protected void btnBatchWrite_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddBatchLxbx.aspx");
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lxbx.aspx");
    }
}
