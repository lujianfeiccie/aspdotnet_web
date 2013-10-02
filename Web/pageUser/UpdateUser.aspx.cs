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
public partial class UpdateUser : System.Web.UI.Page
{
    BLL.tb_user bll_user = new BLL.tb_user();
    Model.tb_user user = new Model.tb_user();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["RoleID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
                
            }
                init();

         }
        
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {

        bool A = (bll_user.GetModel(int.Parse(Request["ID"].ToString())).UserName == txtUserName.Text);
        bool B= (bll_user.GetList(" UserName='"+txtUserName.Text+"' ").Tables[0].Rows.Count!=0);
        if (!A && B)
       {

          JScript.Alert("该用户已存在",Page);
           return;
       }
        user=bll_user.GetModel(int.Parse(Request["ID"].ToString()));
       
       user.UserName = txtUserName.Text;
       user.TrueName = txtTrueName.Text;
       user.RoleID = int.Parse(ddlUserRoleType.SelectedValue);
       bll_user.Update(user);
       JScript.AlertAndRedirect("更新成功", "User.aspx", Page);
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

        Model.tb_user temp = bll_user.GetModel(int.Parse(Request["ID"].ToString()));
        txtUserName.Text = temp.UserName;

        ddlUserRoleType.Items.FindByValue(temp.RoleID.ToString());
        txtTrueName.Text = temp.TrueName;


    }
}
