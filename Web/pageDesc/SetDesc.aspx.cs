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
using System.Reflection;


public partial class SetLxbx : System.Web.UI.Page
{
    string type = "";
 //   BLL.tb_desc desc = new BLL.tb_desc();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["RoleID"] == null)
        //{
        //    Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        //}
        //else
        {
            if (Request.Params["type"].ToString() != null)
            {
                type = Request.Params["type"].ToString();
            }
            //if (type != "")
            //{
            //    Button1.Visible = true;
            //    Model.tb_zdms zd = new BLL.tb_zdms().GetModel(type);
            //    if (zd.zdms.Equals("抗体检测情况") || zd.zdms.Equals("是否当年检测"))
            //    {
            //        zd.zdms = "配偶" + zd.zdms;
            //    }
            //    Label1.Text = zd.zdms;
            //}
            //else
            //{
            //    Label1.Text = "全部";
            //}
            //AspNetPager1.RecordCount = new BLL.tb_log().GetModelList("").Count;
            //AspNetPager1.AlwaysShow = true;
            //AspNetPager1.PageSize = 8;

            BinData();
        }
    }

    private void BinData()
    {
        //DataSet ds = desc.GetList(type);
        //Repeater1.DataSource = ds;
        //Repeater1.DataBind();

      //  AspNetPager1.RecordCount = new Assembly.Load("cdc").CreateInstance("cdc."+ type, false, BindingFlags.Default, null, args, null, null).Tables[0]; //取得记录数
        DataSet ds = null;

        if (type == "TB_AntibodyDetection") ds = new BLL.TB_AntibodyDetection().GetList("");
        else
            if (type == "TB_Citizenship") ds = new BLL.TB_Citizenship().GetList("");
            else
                if (type == "TB_ContactHistory") ds = new BLL.TB_ContactHistory().GetList("");
                else
                    if (type == "TB_CurrentSituation.cs") ds = new BLL.TB_CurrentSituation().GetList("");
                    else
                        if (type == "TB_DetectBefore") ds = new BLL.TB_DetectBefore().GetList("");
                        else
                            if (type == "TB_DetectionClass") ds = new BLL.TB_DetectionClass().GetList("");
                            else
                                if (type == "TB_DetectionStatement") ds = new BLL.TB_DetectionStatement().GetList("");
                                else
                                    if (type == "TB_District") ds = new BLL.TB_District().GetList("");
                                    else
                                        if (type == "TB_Education") ds = new BLL.TB_Education().GetList("");
                                        else
                                            if (type == "TB_Epidemiology") ds = new BLL.TB_Epidemiology().GetList("");
                                            else
                                                if (type == "TB_FirstFollowUpVisit") ds = new BLL.TB_FirstFollowUpVisit().GetList("");
                                                else
                                                    if (type == "TB_FollowUpIntervention") ds = new BLL.TB_FollowUpIntervention().GetList("");
                                                    else
                                                        if (type == "TB_HouseholdRegister") ds = new BLL.TB_HouseholdRegister().GetList("");
                                                        else
                                                            if (type == "TB_InfectionWay") ds = new BLL.TB_InfectionWay().GetList("");
                                                            else
                                                                if (type == "TB_IsDead") ds = new BLL.TB_IsDead().GetList("");
                                                                else
                                                                    if (type == "TB_JobCharacter") ds = new BLL.TB_JobCharacter().GetList("");
                                                                    else
                                                                        if (type == "TB_MaintainStatus") ds = new BLL.TB_MaintainStatus().GetList("");
                                                                        else
                                                                            if (type == "TB_MarriageStatus") ds = new BLL.TB_MarriageStatus().GetList("");
                                                                            else
                                                                            if (type == "TB_Nationality") ds = new BLL.TB_Nationality().GetList("");
                                                                            else
                                                                                if (type == "TB_SEX") ds = new BLL.TB_SEX().GetList("");
                                                                                else
                                                                                    if (type == "TB_TypeOfTreatment") ds = new BLL.TB_TypeOfTreatment().GetList("");
                                                                                    else
                                                                                        ds = null;


        Repeater1.DataSource = ds;
      //  AspNetPager1.PageSize = 8;

        Repeater1.DataBind(); 
    }
   

   
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BinData();
    }
}
