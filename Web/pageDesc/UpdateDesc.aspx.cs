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

public partial class ModifyDesc : System.Web.UI.Page
{
    static  string rID = "";
    static int id = 0;
    string nr = "";
//    BLL.tb_desc desc = new BLL.tb_desc();
  //  Model.tb_desc de = new Model.tb_desc();

    protected void Page_Load(object sender, EventArgs e)
    {
        //id = Convert.ToInt32(Request.Params["ID"].ToString());
        //if (!IsPostBack) 
        //{
        //     if (Session["login_name"] == null)
        //     {
        //          Response.Redirect("~/"+ConfigurationManager.AppSettings["HomePage"].ToString());
        //     }
        //     else
        //    {
        //        BLL.tb_zdms zdms = new BLL.tb_zdms();
        //        Model.tb_zdms zd = new Model.tb_zdms();
            
        //        de = desc.GetModel(id);

        //        zd = zdms.GetModel(de.zdmc);
        //        if (zd.zdms.Equals("抗体检测情况") || zd.zdms.Equals("是否当年检测"))
        //        {
        //            zd.zdms = "配偶" + zd.zdms;
        //        }
        //        Label1.Text = zd.zdms;
        //        if (de != null)
        //        {
        //            tb_ID.Text = de.zID.ToString();
        //            tb_nr.Text = de.zdz;
        //        }
        //        else
        //        {
        //            tb_ID.Text = "";
        //            tb_nr.Text = "";
        //        }
        //     }        
        //}
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //string zid = tb_ID.Text.ToString();
        //nr = tb_nr.Text.ToString();

        //de.ID = id;
        //de.zID = Convert.ToInt32(zid);
        //de.zdz = nr;

        //desc.Update(de);

        ////日志增加
        ////Model.tb_log log = new Model.tb_log();
        ////log.userName = Session["login_name"].ToString();
        ////log.czwz = "参数设置";
        ////log.cz = "修改"+ zd.zdms ;
        ////log.czDate = DateTime.Now.ToLocalTime();
        ////new BLL.tb_log().Add(log);

        //Response.Write("<Script Language=javascript>alert(\"信息添加成功！\");window.location.href='SetDesc.aspx?type='</Script>");
        ////Response.Redirect("SetDesc.aspx?type=" + de.zdmc);

    }
}
