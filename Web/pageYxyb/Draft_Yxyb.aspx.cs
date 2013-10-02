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
using System.Collections.Generic;
using DBUtility;
using Global;

public partial class Yxyb : System.Web.UI.Page
{


    BLL.Draft_yxyb bll_yxyb = new BLL.Draft_yxyb();
    

    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();


    int PageSize = 5;
    static string strWhere = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["UserID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
                return;
            }
            if (Request.UrlReferrer != null)  // 
            {
                UrlReferrer = Request.UrlReferrer.ToString();


                init();
                BinData();
            }

        }
    }

    private void BinData()
    {

       
        Repeater1.DataSource = bll_yxyb.GetViewList(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex, strWhere);
        Repeater1.DataBind();

        LabelTotalInput.Text = bll_yxyb.GetAllList().Tables[0].Rows.Count.ToString();
        LabelTodayInput.Text = bll_yxyb.GetList(" cast(SendingTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ").Tables[0].Rows.Count.ToString();
        strWhere = "";

    }

  
    //跳转到高级查询
    protected void BtnAdvancedSearch_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.location='SearchYxyb.aspx'</script>");
    }
    //删除
    protected void lbtnDelete_Click(object sender, EventArgs e)
    {

        int id = int.Parse(((LinkButton)sender).CommandArgument);
        Model.Draft_yxyb yxyb = bll_yxyb.GetModel(id);
        bll_yxyb.Delete(id);
        
        BinData();
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS阳性样本管理";
        log.Operation = "删除信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
    }

    private void init()
    {
        DataSet dataSet = null;
        strWhere = " Operator_id='" + Session["UserID"].ToString() + "'";

    

        //日期

        ddlDate.Items.Insert(0, new ListItem("日期类型", "0"));
        ddlDate.Items.Insert(1, new ListItem("出生日期", "BirthDate"));
        ddlDate.Items.Insert(2, new ListItem("转AIDS日期", "ToAidsDate"));
        ddlDate.Items.Insert(3, new ListItem("录入日期", "SendingTime"));
        ddlDate.Items.Insert(4, new ListItem("审核日期", "VerifyDate"));

        //感染路径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

        ddlInfectionWay.Items.Insert(0, new ListItem("感染路径", "0"));

        ////接触史
        //dataSet = new BLL.TB_ContactHistory().GetAllList();
        //ddlContactHistory.DataSource = dataSet;
        //ddlContactHistory.DataTextField = "Name";
        //ddlContactHistory.DataValueField = "ID";
        //ddlContactHistory.DataBind();

        //ddlContactHistory.Items.Insert(0, new ListItem("接触史", "0"));



        //状态
        dataSet = new BLL.TB_Flag().GetAllList();
        ddlState.DataSource = dataSet;
        ddlState.DataTextField = "Name";
        ddlState.DataValueField = "ID";
        ddlState.DataBind();

        ddlState.Items.Insert(0, new ListItem("状态", "0"));

        //日期开始时间
        txtDateStart.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        //日期结束时间
        txtDateEnd.Attributes.Add("onclick", "javascript:new Calendar().show(this);");





        AspNetPager1.PageSize = PageSize;
        AspNetPager1.RecordCount = bll_yxyb.GetViewAllList().Tables[0].Rows.Count;
   
    }

    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BinData();
    }
     
   
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
      
        bool DateTypeSelected = (ddlDate.SelectedIndex != 0);
        bool InfoStateSelected = (ddlState.SelectedIndex != 0);

        string whereDateTypeSelected = " cast(" + ddlDate.SelectedValue + " as datetime) between '" + txtDateStart.Text + " 0:0:0' And '" + txtDateEnd.Text + " 23:59:59' " + " and  Operator_id='" + Session["UserID"].ToString() + "'";;
        string whereInfoStateSelected = " FK_Flag='" + ddlState.SelectedValue + "'";
        string whereInfectionWaysSelected = " FK_InfectionWay='" + ddlInfectionWay.SelectedValue + "'";
        //string whereContactHistorySelected = " FK_ContactHistory='" + ddlContactHistory.SelectedValue + "'";
        string where = " ID != -100";

       
            if (DateTypeSelected)
            {
                where += (" AND " + whereDateTypeSelected + " ");
            }
            else
                if (InfoStateSelected)
                {
                    where += (" AND " + whereInfoStateSelected + " ");
                }
                else
                    if (ddlInfectionWay.SelectedIndex != 0)
                    {
                        where += (" AND " + whereInfectionWaysSelected + " ");
                    }
                    //else
                    //    if (ddlContactHistory.SelectedIndex != 0)
                    //    {
                    //        where += (" AND " + whereContactHistorySelected + " ");
                    //    }
            strWhere = " Operator_id='" + Session["UserID"].ToString() + "' and " + where;


        BinData();
    }
    protected void BtnVerify_Click(object sender, EventArgs e)
    {
        List<string> IDs = new List<string>();
        string delId = "";
        //先遍历取得选中项 
        for (int i = 0; i < this.Repeater1.Items.Count; i++)
        {
            CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("cbx");
            string id = cbx.Attributes["key"];

            if (cbx != null)
            {
                if (cbx.Checked)
                {
                    IDs.Add(id);

                }
            }
        }
        ////去掉最后一个, 
        delId = (delId + ")").Replace(",)", "");


        if (IDs.Count == 0)
        {
            JScript.Alert("没有选中项", this.Page);
        }
        else
        {
            for (int i = 0; i < IDs.Count; i++)
            {
                Model.Draft_yxyb yxyb = bll_yxyb.GetModel(int.Parse(IDs[i]));
                yxyb.FK_Flag = Global.InfoState.Verified;
                bll_yxyb.Update(yxyb);
            }
            JScript.Alert("审核成功", this.Page);
        }
        DataBind();
    }
    protected void BtnShowToday_Click(object sender, EventArgs e)
    {
        strWhere = " cast(SendingTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ";
        BinData();
    }
    protected void BtnShowTotal_Click(object sender, EventArgs e)
    {
        strWhere = "";
        BinData();
         
    }
    private string UrlReferrer
    {
        set
        {
            ViewState["UrlReferrer"] = value;

        }
        get
        {
            if (ViewState["UrlReferrer"] != null)
            {
                return ViewState["UrlReferrer"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {

    }
}
