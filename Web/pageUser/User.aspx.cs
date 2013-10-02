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

public partial class User : System.Web.UI.Page
{
    BLL.tb_user bll_user = new BLL.tb_user();
    Model.tb_user user = new Model.tb_user();
    static string strWhere = "";
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
                
                BinData();
            }
        }
    }

    private void init()
    {
        //用户类型
        DataSet dataSet = null;
        //类别
        dataSet = new BLL.tb_role().GetAllList();
        ddlUserRoleType.DataSource = dataSet;
        ddlUserRoleType.DataTextField = "Name";
        ddlUserRoleType.DataValueField = "ID";
        ddlUserRoleType.DataBind();
    }

    private void BinData()
    {
         
        Repeater1.DataSource = bll_user.GetList(strWhere);
        Repeater1.DataBind();
         
        strWhere = "";
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (tbUserName.Text == "")
            strWhere = "";
        else
        strWhere = " UserName='"+tbUserName.Text+"' ";

        BinData();
    }

    protected void lbtnDelete_Click(object sender, EventArgs e)
    {
        int id = Int32.Parse(((LinkButton)sender).CommandArgument);
        bll_user.Delete(id);
        Response.Write("<Script Language=javascript>alert(\"删除成功！\");</Script>");
        BinData();
    }
}
