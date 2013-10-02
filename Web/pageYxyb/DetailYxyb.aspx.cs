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

public partial class DetailYxyb : System.Web.UI.Page
{
    static int ID = 0;
    static string rID = "";
    BLL.tb_yxyb bll_yxyb = new BLL.tb_yxyb();
    BLL.temp_tb_yxyb bll_temp_yxyb = new BLL.temp_tb_yxyb();

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
                //  rID = Request.Params["rID"].ToString();
                init();

            }
        }
    }

    private void init()
    {


        DataSet ds = null;

        if (UrlReferrer.Contains("t_Yxyb.aspx"))
        {
            ds = bll_temp_yxyb.GetDetailedViewByID(ID);

        }
        else
        {
            ds = bll_yxyb.GetDetailedViewByID(ID);
        }
        
        DataRow dr = ds.Tables[0].Rows[0];
        lblPreservePosition.Text = dr["PreservePosition"].ToString();
        lblDirectReportNumber.Text = dr["DirectReportNumber"].ToString();
        lblConfirmationNumber.Text = dr["ConfirmationNumber"].ToString();
        lblConfirmationDate.Text = dr["ConfirmationDate"].ToString();
        lblFlowNumber.Text = dr["FlowNumber"].ToString();
        lblSamplingDate.Text = dr["SamplingDate"].ToString();
        lblName.Text = dr["Name"].ToString();
        lblSex.Text = dr["FK_Sex"].ToString();
        lblIDCard.Text = dr["Id_Card"].ToString(); 
        lblBirthDate.Text = dr["BirthDate"].ToString();
        lblInfectionWay.Text = dr["FK_InfectionWay"].ToString();
        lblSampleType.Text = dr["FK_SampleType"].ToString();
        lblSampleSize.Text = dr["FK_SampleSize"].ToString();
        lblCD4.Text = dr["CD4"].ToString();
        lblViralLoad.Text = dr["ViralLoad"].ToString();
        lblHCV.Text = dr["HCV"].ToString();
        lblHBV.Text = dr["HBV"].ToString();
        lblTB.Text = dr["TB"].ToString();
        lblSyphilis.Text = dr["Syphilis"].ToString();
        lblOthers.Text = dr["Others"].ToString();
        
      
    }

    protected void btnQd_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateYxyb.aspx?ID=" + ID + "&rID=" + rID);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect(UrlReferrer);
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        Response.Redirect("UpdateYxyb.aspx?ID=" + ID);
       
  
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
