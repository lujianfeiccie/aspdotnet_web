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

public partial class AddUser : System.Web.UI.Page
{
    BLL.tb_user bll_user = new BLL.tb_user();
    Model.tb_user user = new Model.tb_user();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["RoleID"] == null)
            {
                Response.Redirect("~/"+ConfigurationManager.AppSettings["HomePage"].ToString());
            }
            else
            {
                init();
            }
        }
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        bool A = (bll_user.GetList(" UserName ='" + txtUserName.Text + "' ").Tables[0].Rows.Count!=0);
         
        if (A)
        {
            Response.Write("<Script Language=javascript>alert(\"此用户已经存在！\");</Script>");
        }
        else
        {
          
            user.UserName = txtUserName.Text;
            user.PassWord = txtPassword.Text;
            user.RoleID = int.Parse(ddlUserRoleType.SelectedValue);
            user.TrueName = txtTrueName.Text;
            bll_user.Add(user);
            Response.Write("<Script Language=javascript>alert(\"用户添加成功！\");window.location.href='User.aspx'</Script>");
        }
    }

    private void init()
    {
        DataSet dataSet = null;

        //类别
        dataSet = new BLL.tb_role().GetAllList();
        ddlUserRoleType.DataSource = dataSet;
        ddlUserRoleType.DataTextField = "Name";
        ddlUserRoleType.DataValueField = "ID";
        ddlUserRoleType.DataBind();
    }
}
