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

public partial class AddDesc : System.Web.UI.Page
{
    //string type = "";
    //string id = "";
    //string nr = "";
    //BLL.tb_desc desc = new BLL.tb_desc();
    //Model.tb_desc de = new Model.tb_desc();
    //BLL.tb_zdms zdms = new BLL.tb_zdms();
    //Model.tb_zdms zd = new Model.tb_zdms();

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["login_name"] == null)
        //{
        //    Response.Redirect("~/"+ConfigurationManager.AppSettings["HomePage"].ToString());
        //}
        //else
        //{
        //    type = Request.Params["type"].ToString();            
        //    zd = zdms.GetModel(type);
        //    if (zd.zdms.Equals("抗体检测情况") || zd.zdms.Equals("是否当年检测"))
        //    {
        //        zd.zdms = "配偶" + zd.zdms;
        //    }
        //    Label1.Text = zd.zdms;
        //}
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //id = tb_ID.Text.Trim().ToString();
        //nr = tb_nr.Text.Trim().ToString();
        //    if (desc.Exists(id, type))
        //    {
        //        Response.Write("<Script Language=javascript>alert(\"此编号已经存在！\")</Script>");
        //    }
        //    else 
        //    {
        //        de.zdmc = type;
        //        de.zID = Convert.ToInt32(id);
        //        de.zdz = nr;
        //        //desc.Add(de);

        //        //日志增加
        //        //Model.tb_log log = new Model.tb_log();
        //        //log.userName = Session["login_name"].ToString();
        //        //log.czwz = "参数设置";
        //        //log.cz = "添加"+ zd.zdms ;
        //        //log.czDate = DateTime.Now.ToLocalTime();
        //        //new BLL.tb_log().Add(log);

        //        Response.Write("<Script Language=javascript>alert(\"信息添加成功！\");window.location.href='SetDesc.aspx?type='</Script>");
        //    }

    }
}
