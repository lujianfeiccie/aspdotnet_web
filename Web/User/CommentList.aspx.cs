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

public partial class CommentList: System.Web.UI.Page
{

    BLL.tb_comments bll_comments = new BLL.tb_comments();
    int PageSize = 5;
    static string strWhere = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["RoleID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }

        if (!this.IsPostBack)
        {
               BindData();
        }
        if (bll_comments.GetList("  cast(addTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  ").Tables[0].Rows.Count != 0)
        {
            lbtnUnread.Text = "今天有" + bll_comments.GetList("  cast(addTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  ").Tables[0].Rows.Count.ToString() + "条未读信息";
            lbtnUnread.Visible = true;
        }
        else
            lbtnUnread.Visible = false;

    }

    private void BindData()
    {
        AspNetPager1.PageSize = 5;
        AspNetPager1.RecordCount = new BLL.tb_comments().GetModelList("").Count;
        rpt1.DataSource = new BLL.tb_comments().GetList(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex,strWhere);
        rpt1.DataBind();
    }

    protected void OnReplyClick(object sender, EventArgs e)
    {
        int Id = int.Parse(((LinkButton)sender).Attributes["key"]);
        //Response.Write("<script>alert('ID为" + Id.ToString() + "')</script>");

    }
    protected void addly_Click(object sender, EventArgs e)
    {
        bool A = txtName.Text.Length!=0;
        bool B = txtqq.Text.Length != 0;
        bool C = txtEmail.Text.Length != 0;
        bool D = txtContent.Text.Length != 0;


        if (!A)
        {
            JScript.Alert("姓名不能为空",Page);
            return;
        }
        if (!B)
        {
            JScript.Alert("QQ不能为空", Page);
            return;
        }
        if (!C)
        {
            JScript.Alert("Email不能为空", Page);
            return;
        }
        if (!D)
        {
            JScript.Alert("留言不能为空", Page);
            return;
        }
        Model.tb_comments model = new Model.tb_comments();
        model.addTime = DateTime.Now.ToLocalTime().ToString();
        model.content = txtContent.Text;
        model.email = txtEmail.Text.Trim();
        model.name = txtName.Text;
        model.qq = txtqq.Text.Trim();



        new BLL.tb_comments().Add(model);

        JScript.AlertAndRedirect("成功留言", "CommentList.aspx",this.Page);
         
    }
    protected string showrely(bool isrely, string reply)
    {
        if (isrely)
        {
            return "<br><br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<font color='#2CB421'>管理员回复:&nbsp;&nbsp;</font><font color='#000099'>" + Server.HtmlEncode(reply) + "</font>";
        }
        else
        {
            return null;
        }
    }
    protected string showbody(string str_body)
    {
        
            return "<br>"+str_body.Replace("\r\n", "<br>");
   
    }
    protected string show_admin(int id)
    {
        if (Int32.Parse(Session["RoleID"].ToString())==Global.Role.Admin)
        {
            return "<a href=ReplyComment.aspx?id=" + id + ">回复</a>" + "&nbsp;&nbsp;&nbsp;<a href=DeleteComment.aspx?id=" + id + ">删除</a>";
        }
        else
        {
            return null;
        }
    }
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BindData();
    }
    protected void lbtnUnread_Click(object sender, EventArgs e)
    {
        strWhere = "  cast(addTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  ";
        DataRowCollection drs=bll_comments.GetList(strWhere).Tables[0].Rows;
        int rowsCount = drs.Count;
        for(int i=0;i<rowsCount;i++)
        {
            int id = int.Parse(drs[i]["ID"].ToString());
            Model.tb_comments comment=bll_comments.GetModel(id);
            comment.unread = false;
            bll_comments.Update(comment);
        }
        BindData();
    }
    protected void lbtnAll_Click(object sender, EventArgs e)
    {
        strWhere = "";
        BindData();
    }
}
