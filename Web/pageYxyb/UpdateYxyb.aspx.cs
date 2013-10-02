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

public partial class UpdateYxyb : System.Web.UI.Page
{
    static int ID = 0;
   

    static Model.tb_yxyb yxyb = new Model.tb_yxyb();
    BLL.tb_yxyb bll_yxyb = new BLL.tb_yxyb();
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

                ID = Int32.Parse(Request.Params["ID"].ToString());


                init();
                UpDateControlData();
            }
        }
        
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        UpContextData();
        bll_yxyb.Update(yxyb);
        JScript.Alert("已修改");
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理";
        log.Operation = "修改信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        
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


        //样本类型
        dataSet = new BLL.TB_SampleType().GetAllList();
        ddlSampleType.DataSource = dataSet;
        ddlSampleType.DataTextField = "Name";
        ddlSampleType.DataValueField = "ID";
        ddlSampleType.DataBind();

        //样本量
        dataSet = new BLL.TB_SampleSize().GetAllList();
        ddlSampleSize.DataSource = dataSet;
        ddlSampleSize.DataTextField = "Name";
        ddlSampleSize.DataValueField = "ID";
        ddlSampleSize.DataBind();

       
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlHBV.DataSource = dataSet;
        ddlHBV.DataTextField = "Name";
        ddlHBV.DataValueField = "ID";
        ddlHBV.DataBind();
      

        ddlSyphilis.DataSource = dataSet;
        ddlSyphilis.DataTextField = "Name";
        ddlSyphilis.DataValueField = "ID";
        ddlSyphilis.DataBind();
      

        ddlTB.DataSource = dataSet;
        ddlTB.DataTextField = "Name";
        ddlTB.DataValueField = "ID";
        ddlTB.DataBind();
        

        ddlHCV.DataSource = dataSet;
        ddlHCV.DataTextField = "Name";
        ddlHCV.DataValueField = "ID";
        ddlHCV.DataBind();
      
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
        txtConfirmationDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //采样时间
        txtSamplingDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //出生日期
        txtBirthDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");


      

       
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect(UrlReferrer);
    }
    //给控件赋值
    private void UpDateControlData()
    {

        Model.tb_yxyb temp = bll_yxyb.GetModel(ID);
        txtPreservePosition.Text = temp.PreservePosition;

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
        
        txtConfirmationDate.Text = temp.ConfirmationDate;
        txtFlowNumber.Text = temp.FlowNumber;
        txtSamplingDate.Text = temp.SamplingDate;
        txtName.Text = temp.Name;
        ddlSex.Items.FindByValue(temp.FK_Sex.ToString()).Selected = true;
        txtBirthDate.Text = temp.BirthDate;
        txtIDCard.Text = temp.Id_card;
        ddlInfectionWay.Items.FindByValue(temp.FK_InfectionWay.ToString()).Selected = true;
        ddlSampleType.Items.FindByValue(temp.FK_SampleType.ToString()).Selected = true;
        ddlSampleSize.Items.FindByValue(temp.FK_SampleSize.ToString()).Selected = true;
        txtCD4.Text = temp.CD4;
        txtOthers.Text = temp.Others;
        ddlHCV.Items.FindByValue(temp.HCV.ToString()).Selected = true;
        txtViralLoad.Text = temp.ViralLoad;
        ddlTB.Items.FindByValue(temp.TB.ToString()).Selected = true;
        ddlHBV.Items.FindByValue(temp.HBV.ToString()).Selected = true;
        ddlSyphilis.Items.FindByValue(temp.Syphilis.ToString()).Selected = true;
       
      
    }

    private void UpContextData()
    {
        Model.tb_yxyb temp = yxyb;
        temp.PreservePosition = txtPreservePosition.Text;
        temp.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        temp.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
        temp.ConfirmationDate = txtConfirmationDate.Text;
        temp.FlowNumber = txtFlowNumber.Text;
        temp.SamplingDate = txtSamplingDate.Text;
        temp.Name = txtName.Text;
        temp.FK_Sex = int.Parse(ddlSex.SelectedValue);
        temp.BirthDate=txtBirthDate.Text;
        temp.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        temp.FK_SampleType = int.Parse(ddlSampleType.SelectedValue);
        temp.FK_SampleSize = int.Parse(ddlSampleSize.SelectedValue);
        temp.HCV = int.Parse(ddlHCV.SelectedValue);
        temp.CD4 = txtCD4.Text;
        temp.TB = int.Parse(ddlTB.SelectedValue);
        temp.ViralLoad = txtViralLoad.Text;
        temp.Syphilis= int.Parse(ddlSyphilis.SelectedValue);
        temp.HBV = int.Parse(ddlHBV.SelectedValue);
        temp.Others = txtOthers.Text;
        temp.Id_card = txtIDCard.Text;

        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
           Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            temp.FK_Flag = Global.InfoState.Verified;
        

        temp.FK_User = int.Parse(Session["UserID"].ToString());

        yxyb = temp;
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
}
