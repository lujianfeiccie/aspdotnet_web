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

public partial class top : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

      
      if (Session["UserID"] == null)
      {
          Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
      }
        else
        {
            int roleID = Int32.Parse(Session["RoleID"].ToString());
             
            Label1.Text = new BLL.tb_role().GetModel(roleID).name;
          
        }       
       
    }
    //protected override void OnPreRender(EventArgs e)
    //{
    //    Response.AppendHeader("P3P", "CP=\"CAO PSA OUR\"");
    //    base.OnPreRender(e);
    //}
     
}
