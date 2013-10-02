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

public partial class DetailSfjc : System.Web.UI.Page
{

    static int ID = 0;
  
    BLL.tb_sfjc bll_sfjc = new BLL.tb_sfjc();
    BLL.temp_tb_sfjc bll_temp_sfjc = new BLL.temp_tb_sfjc();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack) //第一次加载
        {



            if (Session["UserID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
                //Response.Write("<script type='text/javascript'>window.parent.location.href='" + "~/" + ConfigurationManager.AppSettings["HomePage"].ToString() + "';</script>");
            }

            if (Request.UrlReferrer != null)  // 
            {
                UrlReferrer = Request.UrlReferrer.ToString();



                ID = Int32.Parse(Request.Params["ID"].ToString());

                init();

            }
        }

    }

    private void init()
    {

        //  detailPage.Request(ID,rID,this.Page);
        DataSet ds = null;
        //DBUtility.JScript.Alert(UrlReferrer, Page);
        if (UrlReferrer.Contains("t_Sfjc.aspx"))
        {
            ds = bll_temp_sfjc.GetDetailedViewByID(ID);

        }
        else
        {
            ds = bll_sfjc.GetDetailedViewByID(ID);
        }
        DataRow dr = ds.Tables[0].Rows[0];
        lblDirectReportNumber.Text = dr["DirectReportNumber"].ToString();
        lblConfirmationNumber.Text = dr["ConfirmationNumber"].ToString();
        lblName.Text = dr["Name"].ToString();
        lblSex.Text = dr["FK_Sex"].ToString();
        lblConfirmationDate.Text = dr["ConfirmationDate"].ToString();
        lblBirthDate.Text = dr["BirthDate"].ToString();
        lblInfectionWay.Text = dr["FK_InfectionWay"].ToString();
        lblCurrentSituation.Text = dr["FK_CurrentSituation"].ToString();
        lblDistrict.Text = dr["FK_District"].ToString();
        lblTypeOfTreatment.Text = dr["FK_TypeOfTreatment"].ToString();
        lblFirstFollowUpVisit.Text = dr["FK_FirstFollowUpVisit"].ToString();
        lblAddingTime.Text = dr["AddingTime"].ToString();
        lblFollowUpIntervention.Text = dr["FK_FollowUpIntervention"].ToString();
        lblTreatmentNumber.Text = dr["TreatmentNumber"].ToString();
        lblCD4.Text = dr["CD4"].ToString();
        lblMaintainStatus.Text = dr["FK_MaintainStatus"].ToString();
        lblViralLoad.Text = dr["ViralLoad"].ToString();
        lblSpouse_AntibodyDetection.Text = dr["FK_Spouse_AntibodyDetection"].ToString();
        lblDetectBefore.Text = dr["FK_DetectBefore"].ToString();
        lblChildren_AntibodyDetection.Text = dr["FK_Children_AntibodyDetection"].ToString();
        lblIsDead.Text = dr["FK_IsDead"].ToString();
        lblRemark.Text = dr["Remark"].ToString();
        lblIDCard.Text = dr["Id_card"].ToString();
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {

        Response.Redirect(UrlReferrer);
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        Response.Redirect("UpdateSfjc.aspx?ID=" + ID);
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
