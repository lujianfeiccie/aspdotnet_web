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

public partial class UpdateSfjc : System.Web.UI.Page
{
    static int ID = 0;


    static Model.tb_sfjc sfjc = new Model.tb_sfjc();
    BLL.tb_sfjc bll_sfjc = new BLL.tb_sfjc();
    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();

    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {



            if (Session["UserID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
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

       
        //配偶抗体检测情况
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlSpouse_AntibodyDetection.DataSource = dataSet;
        ddlSpouse_AntibodyDetection.DataTextField = "Name";
        ddlSpouse_AntibodyDetection.DataValueField = "ID";
        ddlSpouse_AntibodyDetection.DataBind();

        //配偶是否当年检测
        dataSet = new BLL.TB_DetectBefore().GetAllList();
        ddlDetectBefore.DataSource = dataSet;
        ddlDetectBefore.DataTextField = "Name";
        ddlDetectBefore.DataValueField = "ID";
        ddlDetectBefore.DataBind();
        //子女抗体检测情况
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


    private void UpDateControlData()
    {

        Model.tb_sfjc temp = bll_sfjc.GetModel(ID);

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

        txtConfirmationDate.Text = temp.ConfirmationDate;
        txtBirthDate.Text = temp.BirthDate;

        txtAddingTime.Text = temp.AddingTime;
        txtTreatmentNumber.Text = temp.TreatmentNumber;
        ddlDistrict.Items.FindByValue(temp.FK_District.ToString());
        
        ddlInfectionWay.Items.FindByValue(temp.FK_InfectionWay.ToString());

        ddlCurrentSituation.Items.FindByValue(temp.FK_CurrentSituation.ToString());

        ddlIsDead.Items.FindByValue(temp.FK_IsDead.ToString());


        ddlTypeOfTreatment.Items.FindByValue(temp.FK_TypeOfTreatment.ToString());

        ddlFirstFollowUpVisit.Items.FindByValue(temp.FK_FirstFollowUpVisit.ToString());

        ddlFollowUpIntervention.Items.FindByValue(temp.FK_FollowUpIntervention.ToString());

        ddlMaintainStatus.Items.FindByValue(temp.FK_MaintainStatus.ToString());

        ddlSpouse_AntibodyDetection.Items.FindByValue(temp.FK_Spouse_AntibodyDetection.ToString());

        ddlDetectBefore.Items.FindByValue(temp.FK_DetectBefore.ToString());

        ddlChildren_AntibodyDetection.Items.FindByValue(temp.FK_Children_AntibodyDetection.ToString());
      
        txtRemark.Text = temp.Remark;
        txtIDCard.Text = temp.Id_card;
    }
    private void UpContextData()
    {
        Model.tb_sfjc temp = sfjc;
        temp.ID = ID;
        temp.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        temp.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
        temp.Name = txtName.Text;
        temp.FK_Sex = int.Parse(ddlSex.SelectedValue);
        temp.ConfirmationDate = txtConfirmationDate.Text;
        temp.BirthDate = txtBirthDate.Text;
        temp.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        temp.FK_CurrentSituation = int.Parse(ddlCurrentSituation.SelectedValue);
        temp.FK_District = int.Parse(ddlDistrict.SelectedValue);
        temp.FK_IsDead = int.Parse(ddlIsDead.SelectedValue);
        temp.FK_TypeOfTreatment = int.Parse(ddlTypeOfTreatment.SelectedValue);
        temp.FK_FirstFollowUpVisit = int.Parse(ddlFirstFollowUpVisit.SelectedValue);
        temp.AddingTime = txtAddingTime.Text;
        temp.FK_FollowUpIntervention = int.Parse(ddlFollowUpIntervention.SelectedValue);
        temp.TreatmentNumber = txtTreatmentNumber.Text;
        temp.CD4 = txtCD4.Text;
        temp.FK_MaintainStatus = int.Parse(ddlMaintainStatus.SelectedValue);
        temp.ViralLoad = txtViralLoad.Text;
        temp.FK_Spouse_AntibodyDetection = int.Parse(ddlSpouse_AntibodyDetection.SelectedValue);
        temp.FK_DetectBefore = int.Parse(ddlDetectBefore.SelectedValue);
        temp.FK_Children_AntibodyDetection = int.Parse(ddlChildren_AntibodyDetection.SelectedValue);
        temp.Remark = txtRemark.Text;
        temp.Id_card = txtIDCard.Text;
     
      

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
        UpContextData();
        bll_sfjc.Update(sfjc);
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS随访信息管理";
        log.Operation = "添加信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);

        JScript.Alert("已修改");
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
