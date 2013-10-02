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

public partial class MakeComment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["RoleID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }
     　
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Model.tb_comments model = new Model.tb_comments();
        model.addTime = DateTime.Now.ToLocalTime().ToString();
        model.content = txtbig.Text;
        model.email = txtEmail.Text.Trim();
        model.name = txtName.Text;
        model.qq = txtqq.Text.Trim();
        model.isreply = false;
        model.unread = true;
        try
        {
            new BLL.tb_comments().Add(model);
            JScript.Alert("提交成功",this.Page);
        }
        catch
        { 
        
        }

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtbig.Text="";
        txtEmail.Text = "";
        txtName.Text = "";
        txtqq.Text = "";

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
}
