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
using Global;

public partial class UpdateLxbx : System.Web.UI.Page
{

   // DesignPattern.Lxbx.UpdatePage context = new DesignPattern.Lxbx.UpdatePage();

    static  int ID = 0;


    static Model.Draft_lxbx lxbx = new Model.Draft_lxbx();
    static Model.tb_lxbx tlxbx = new Model.tb_lxbx();
    BLL.Draft_lxbx bll_lxbx = new BLL.Draft_lxbx();


    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();

    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

          

            if (Session["UserID"] == null)
            {
                Response.Redirect("~/"+ConfigurationManager.AppSettings["HomePage"].ToString());
            }

            if (Request.UrlReferrer != null)  // 
            {
                UrlReferrer = Request.UrlReferrer.ToString();

                ID = Int32.Parse(Request.Params["ID"].ToString());


                init();
                UpDateControlData();
            }
        }
        
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

        //籍贯
        dataSet = new BLL.TB_Province().GetAllList();
        ddlProvince.DataSource = dataSet;
        ddlProvince.DataTextField = "Name";
        ddlProvince.DataValueField = "Name";
        ddlProvince.DataBind();

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
        dataSet = new BLL.TB_DetectionStatement().GetAllList();
        ddlDetectionStatement1.DataSource = dataSet;
        ddlDetectionStatement1.DataTextField = "Name";
        ddlDetectionStatement1.DataValueField = "ID";
        ddlDetectionStatement1.DataBind();

        //检测情况2
        dataSet = new BLL.TB_DetectionStatement().GetAllList();
        ddlDetectionStatement2.DataSource = dataSet;
        ddlDetectionStatement2.DataTextField = "Name";
        ddlDetectionStatement2.DataValueField = "ID";
        ddlDetectionStatement2.DataBind();

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


        //阳性判定时间
        txtPositiveDecisionDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //转AIDS时间
        txtToAidsDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //出生日期
        txtBirthDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        
    }

  
    private void UpDateControlData()
    {
        
        Model.Draft_lxbx temp = bll_lxbx.GetModel(ID);
        if (!temp.DirectReportNumber.Equals("---"))
        {
            if (temp.DirectReportNumber.Length > 4)
            {
                txtDirectReportNumber1.Text = temp.DirectReportNumber.Substring(0, txtDirectReportNumber1.MaxLength);
                if (temp.DirectReportNumber.Length > 10)
                {
                    txtDirectReportNumber2.Text = temp.DirectReportNumber.Substring(txtDirectReportNumber1.MaxLength + 1, txtDirectReportNumber2.MaxLength);
                    if (temp.DirectReportNumber.Length > 15)
                    {
                        txtDirectReportNumber3.Text = temp.DirectReportNumber.Substring(txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + 2, txtDirectReportNumber1.MaxLength);
                        if (temp.DirectReportNumber.Length >= 21)
                        {
                            txtDirectReportNumber4.Text = temp.DirectReportNumber.Substring(txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + txtDirectReportNumber3.MaxLength + 3, txtDirectReportNumber4.MaxLength);
                        }
                        else
                        {
                            txtDirectReportNumber4.Text = temp.DirectReportNumber.Substring(txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + txtDirectReportNumber3.MaxLength + 3, temp.DirectReportNumber.Length - 16);
                        }
                    }
                    else
                    {
                        txtDirectReportNumber3.Text = temp.DirectReportNumber.Substring(txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + 2, temp.DirectReportNumber.Length - 11);
                    }
                }
                else
                {
                    txtDirectReportNumber2.Text = temp.DirectReportNumber.Substring(txtDirectReportNumber1.MaxLength + 1, temp.DirectReportNumber.Length - 5);
                }
            }
            else
            {
                txtDirectReportNumber1.Text = temp.DirectReportNumber.Substring(0, temp.DirectReportNumber.Length);
            }
        }

        if (!temp.ConfirmationNumber.Equals("sz"))
        {
            if (temp.ConfirmationNumber.Length >= 6)
            {
                txtConfirmationNumber1.Text = temp.ConfirmationNumber.Substring(2, txtConfirmationNumber1.MaxLength);
                if (temp.ConfirmationNumber.Length >= 10)
                {
                    txtConfirmationNumber2.Text = temp.ConfirmationNumber.Substring(txtConfirmationNumber1.MaxLength + 2, txtConfirmationNumber2.MaxLength);
                }
                else
                {
                    txtConfirmationNumber2.Text = temp.ConfirmationNumber.Substring(txtConfirmationNumber1.MaxLength + 2, temp.ConfirmationNumber.Length - 6);
                }
            }
            else
            {
                txtConfirmationNumber1.Text = temp.ConfirmationNumber.Substring(2, temp.ConfirmationNumber.Length - 2);
            }
          
        }
        

        txtName.Text = temp.Name;
        ddlSex.Items.FindByValue(temp.FK_Sex.ToString());
        ddlNationality.Items.FindByValue(temp.FK_Nationality.ToString());
        txtBirthDate.Text = temp.BirthDate;
        ddlEducation.Items.FindByValue(temp.FK_Education.ToString());
        ddlCitizenship.Items.FindByValue(temp.FK_Citizenship.ToString());
        ddlHouseholdRegister.Items.FindByValue(temp.FK_HouseholdRegister.ToString());
        ddlDistrict.Items.FindByValue(temp.FK_District.ToString());
        txtDetailedAddress.Text = temp.DetailedAddress;
        ddlInfectionWay.Items.FindByValue(temp.FK_InfectionWay.ToString());
        txtCounty.Text = temp.County;
        ddlJobCharacter.Items.FindByValue(temp.FK_JobCharacter.ToString());
        ddlProvince.SelectedValue = temp.Province;
        txtPositiveDecisionDate.Text = temp.PositiveDecisionDate;
        ddlIsDead.Items.FindByValue(temp.FK_IsDead.ToString());
        txtToAidsDate.Text = temp.ToAidsDate;
        ddlCurrentSituation.Items.FindByValue(temp.FK_CurrentSituation.ToString());
        ddlMarriageStatus.Items.FindByValue(temp.FK_MarriageStatus.ToString());
        txtCensorshipUnit.Text = temp.CensorshipUnit;
        ddlDetectionStatement1.Items.FindByValue(temp.FK_Spouse.ToString());
        txtSpouse.Text=temp.Spouse;
        ddlContactHistory.Items.FindByValue(temp.FK_ContactHistory.ToString());
        ddlDetectionStatement2.Items.FindByValue(temp.FK_Children.ToString());
        txtChildren.Text = temp.Children;
        ddlDetectionClass.Items.FindByValue(temp.FK_DetectionClass.ToString());
        txtRemark.Text = temp.Remark;
        txtIDCard.Text = temp.Id_card;
    }
    private void UpContextData()
    {
        Model.Draft_lxbx temp = lxbx;
        temp.ID = ID;
        temp.Remark = txtRemark.Text;
        temp.BirthDate=txtBirthDate.Text;
        temp.FK_Citizenship= int.Parse(ddlCitizenship.SelectedValue);
        temp.FK_InfectionWay=int.Parse(ddlInfectionWay.SelectedValue);
        temp.FK_HouseholdRegister = int.Parse(ddlHouseholdRegister.SelectedValue);
        temp.FK_MarriageStatus=int.Parse(ddlMarriageStatus.SelectedValue);
        temp.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        temp.FK_DetectionClass = int.Parse(ddlDetectionClass.SelectedValue);
        temp.FK_ContactHistory = int.Parse(ddlContactHistory.SelectedValue);
        temp.FK_Nationality = int.Parse(ddlNationality.SelectedValue);
        temp.Spouse = txtSpouse.Text;
        temp.FK_Spouse = int.Parse(ddlDetectionStatement1.SelectedValue);
        temp.Children = txtChildren.Text;
        temp.FK_Children = int.Parse(ddlDetectionStatement2.SelectedValue);
        temp.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text.Trim() + txtConfirmationNumber2.Text.Trim();
        temp.Province = ddlProvince.SelectedValue;
        temp.CensorshipUnit = txtCensorshipUnit.Text;
        temp.ToAidsDate = txtToAidsDate.Text;
        temp.FK_Education= int.Parse(ddlEducation.SelectedValue);
        temp.County = txtCounty.Text;
        temp.FK_Sex = int.Parse(ddlSex.SelectedValue);

        temp.Name=txtName.Text;
        temp.DetailedAddress=txtDetailedAddress.Text ;
        temp.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        temp.FK_District= int.Parse(ddlDistrict.SelectedValue);
        temp.PositiveDecisionDate=txtPositiveDecisionDate.Text;
        temp.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        temp.FK_JobCharacter=int.Parse(ddlJobCharacter.SelectedValue);
        temp.Id_card = txtIDCard.Text.Trim();
 

        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
           Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            temp.FK_Flag = Global.InfoState.Verified;

        temp.FK_User = int.Parse(Session["UserID"].ToString());
    }

    private void AddContextData()
    {
        Model.tb_lxbx temp = tlxbx;
        temp.ID = ID;
        temp.Remark = txtRemark.Text;
        temp.BirthDate = txtBirthDate.Text;
        temp.FK_Citizenship = int.Parse(ddlCitizenship.SelectedValue);
        temp.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        temp.FK_HouseholdRegister = int.Parse(ddlHouseholdRegister.SelectedValue);
        temp.FK_MarriageStatus = int.Parse(ddlMarriageStatus.SelectedValue);
        temp.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        temp.FK_DetectionClass = int.Parse(ddlDetectionClass.SelectedValue);
        temp.FK_ContactHistory = int.Parse(ddlContactHistory.SelectedValue);
        temp.FK_Nationality = int.Parse(ddlNationality.SelectedValue);
        temp.Spouse = txtSpouse.Text;
        temp.FK_Spouse = int.Parse(ddlDetectionStatement1.SelectedValue);
        temp.Children = txtChildren.Text;
        temp.FK_Children = int.Parse(ddlDetectionStatement2.SelectedValue);
        temp.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text.Trim() + txtConfirmationNumber2.Text.Trim();
        temp.Province = ddlProvince.SelectedValue;
        temp.CensorshipUnit = txtCensorshipUnit.Text;
        temp.ToAidsDate = txtToAidsDate.Text;
        temp.FK_Education = int.Parse(ddlEducation.SelectedValue);
        temp.County = txtCounty.Text;
        temp.FK_Sex = int.Parse(ddlSex.SelectedValue);

        temp.Name = txtName.Text;
        temp.DetailedAddress = txtDetailedAddress.Text;
        temp.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        temp.FK_District = int.Parse(ddlDistrict.SelectedValue);
        temp.PositiveDecisionDate = txtPositiveDecisionDate.Text;
        temp.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        temp.FK_JobCharacter = int.Parse(ddlJobCharacter.SelectedValue);
        temp.Id_card = txtIDCard.Text.Trim();


        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
           Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            temp.FK_Flag = Global.InfoState.Verified;

        temp.FK_User = int.Parse(Session["UserID"].ToString());
        
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        AddContextData();
        BLL.tb_lxbx bll = new BLL.tb_lxbx();

        tlxbx.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

        int directReportNumSize = txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + txtDirectReportNumber3.MaxLength + txtDirectReportNumber4.MaxLength;
        int confirmNumSize = txtConfirmationNumber1.MaxLength + txtConfirmationNumber2.MaxLength;

        bool A = (tlxbx.DirectReportNumber.Length - 3 == directReportNumSize); //DirectReportNumber长度减3，前面加了3个字符‘-’
        bool B = (tlxbx.ConfirmationNumber.Length - 2 == confirmNumSize);
        bool C = (txtName.Text.Trim().Length != 0);
        bool D = (txtBirthDate.Text.Trim().Length != 0);
        bool E = (txtToAidsDate.Text.Trim().Length != 0);
        bool F = (bll.GetList(" DirectReportNumber='" + tlxbx.DirectReportNumber + "' ").Tables[0].Rows.Count == 0);
        bool G = (bll.GetList(" ConfirmationNumber='" + tlxbx.ConfirmationNumber + "' ").Tables[0].Rows.Count == 0);
        bool I = (tlxbx.Id_card.Length == 18);
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

        if (bll.Add(tlxbx) != 0)
        {
            JScript.Alert("提交成功！");
            log.FK_User = int.Parse(Session["UserID"].ToString());
            log.OperatingPosition = "HIV/AIDS病例报告管理";
            log.Operation = "提交信息";
            log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            bll_log.Add(log);
        }
        else
        {
            JScript.Alert("提交失败！");
        }

        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpContextData();
        bll_lxbx.Update(lxbx);
        JScript.Alert("已保存");

        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理";
        log.Operation = "保存";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect(UrlReferrer);
    }
    //首先要获取URL，如下所示：

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
}
