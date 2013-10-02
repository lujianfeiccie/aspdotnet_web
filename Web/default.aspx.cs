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
using BLL;
using DBUtility;
using Global;


 
    public partial class _default : System.Web.UI.Page
    {
        Model.tb_user model_user = new Model.tb_user();
        BLL.tb_user bll_user = new BLL.tb_user();

        protected void Page_Load(object sender, EventArgs e)
        {
             if (!Page.IsPostBack)
            {
              
            }

            if (Session["UserName"] != null)
            {
                Session["UserName"] = null;

            }
            //  tbUser.Attributes.Add("onkeypress", "EnterTextBox('tbUser')");
            // tbUser.Focus();
      
            //tbPassWord.Attributes.Add("OnFocus", "if(this.value=='请输入密码') {this.value=''}   ");
            //tbPassWord.Attributes.Add("OnBlur", "if(this.value==''){this.value='请输入密码'}");

             
        }
     
         



        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" )
            {
                JScript.Alert("用户名不能为空，请输入用户名");
                return;
            }
            if (txtPassWord.Text.Trim() == "" )
            {
                JScript.Alert("密码不能为空，请输入密码！");
                return;
            }
            if (txtValid.Text.Trim().ToLower() != Session["VNum"].ToString().ToLower())
            {
                JScript.Alert("验证码输入错误!");
                txtValid.Text = "";
                return;
            }
        
            

           // DBUtility.JScript.Alert(bll_user.Exists(model_user.UserName, model_user.PassWord).ToString(), this.Page);
        
            
            if (bll_user.Exists(txtUser.Text.Trim(),txtPassWord.Text.Trim()) == true)
            {
                model_user = bll_user.GetModel(txtUser.Text.Trim(), txtUser.Text.Trim());
                Session["UserName"] = model_user.UserName;
                Session["UserID"] = model_user.ID;
                Session["RoleID"] = model_user.RoleID;
                
                Response.Redirect("Main.aspx");

            }
            else
            {
                DBUtility.JScript.Alert("用户不存在或密码错误", this.Page);
            }
         
        }
}
 