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

public partial class DetailLxbx : System.Web.UI.Page
{
   
     static int ID = 0;
     static string rID="";
    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
    BLL.temp_tb_lxbx bll_temp_lxbx = new BLL.temp_tb_lxbx();
    
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
        DataSet ds=null;
        //DBUtility.JScript.Alert(UrlReferrer, Page);
        if (UrlReferrer.Contains("t_Lxbx.aspx"))
        {
            ds = bll_temp_lxbx.GetDetailedViewByID(ID);
            
        }
        else 
        {
            ds = bll_lxbx.GetDetailedViewByID(ID);
        }
        DataRow dr=ds.Tables[0].Rows[0];
        lblDirectReportNumber.Text = dr["DirectReportNumber"].ToString();
        lblConfirmationNumber.Text = dr["ConfirmationNumber"].ToString();
        lblName.Text = dr["Name"].ToString();
        lblSex.Text = dr["FK_Sex"].ToString();
        lblNationality.Text = dr["FK_Nationality"].ToString();
        lblBirthDate.Text = dr["BirthDate"].ToString();
        lblEducation.Text = dr["FK_Education"].ToString();
        lblCitizenship.Text = dr["FK_Citizenship"].ToString();
        lblHouseholdRegister.Text = dr["FK_HouseholdRegister"].ToString();
        lblProvince.Text = dr["Province"].ToString();
        lblCounty.Text = dr["County"].ToString();
        lblInfactionWay.Text = dr["FK_InfectionWay"].ToString();
        lblDistrict.Text = dr["FK_District"].ToString();
        lblJobCharacter.Text = dr["FK_JobCharacter"].ToString();
        lblCurrentSituation.Text = dr["FK_CurrentSituation"].ToString();
        lblMarriageStatus.Text = dr["FK_MarriageStatus"].ToString();
        lblIsDead.Text = dr["FK_IsDead"].ToString();
        lblPositiveDecisionDate.Text = dr["PositiveDecisionDate"].ToString();
        lblCensorshipUnit.Text = dr["CensorshipUnit"].ToString();
        lblToAidsDate.Text = dr["ToAidsDate"].ToString();
        lblContactHistory.Text = dr["FK_ContactHistory"].ToString();
        lblSpouse.Text = dr["FK_Spouse"].ToString() + " " + dr["Spouse"].ToString();
        lblChildren.Text = dr["FK_Children"].ToString() + " " + dr["Children"].ToString();
        lblDetectionClass.Text = dr["FK_DetectionClass"].ToString();
        lblRemark.Text = dr["Remark"].ToString();
        lbID_Card.Text = dr["Id_card"].ToString();
        


        
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {

        Response.Redirect(UrlReferrer);
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
       
       Response.Redirect("UpdateLxbx.aspx?ID="+ID);
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
