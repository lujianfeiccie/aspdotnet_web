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

public partial class ReplyComment : System.Web.UI.Page
{
    static int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["RoleID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }
        if (Request.QueryString["id"].ToString() != null)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            txtName.Text = new BLL.tb_comments().GetModel(id).name;
        }
     　
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Model.tb_comments model = new Model.tb_comments();

        model = new BLL.tb_comments().GetModel(id);
        model.isreply = true;
        model.reply = txtContent.Text;


        try
        {
            new BLL.tb_comments().Update(model);
            JScript.AlertAndRedirect("成功回复", "CommentList.aspx", this.Page);
        }
        catch
        {
        
        }
         

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtContent.Text="";
        
            

    }
    public string ConvertContent(string content)
    {
        if (content == "" || content == null)
        {
            content = "";
        }
        else
        {
            content = "回复:" + content;
        }
        return content;
    }
    protected void ButtonReturn_Click(object sender, EventArgs e)
    {
        JScript.GoHistory(-1, this.Page);
    }
}
