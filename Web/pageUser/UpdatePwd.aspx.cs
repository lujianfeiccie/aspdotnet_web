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
public partial class UpdatePwd : System.Web.UI.Page
{
    BLL.tb_user bll_user = new BLL.tb_user();
    Model.tb_user user = new Model.tb_user();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["RoleID"] == null)
        {
            Response.Redirect("~/"+ConfigurationManager.AppSettings["HomePage"].ToString());
        }
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
         
        bool A=(bll_user.GetList(" PassWord='"+txtOldPassword.Text+"' AND ID="+int.Parse(Session["UserID"].ToString())).Tables[0].Rows.Count!=0);
        if (!A)
        {
            JScript.Alert("旧密码错误", Page);
            return;
        }
        user = bll_user.GetModel(int.Parse(Session["UserID"].ToString()));
        user.PassWord = txtNewPassword.Text;
        bll_user.Update(user);
        JScript.AlertAndRedirect("更新成功", "Main.aspx", Page);
    }
}
