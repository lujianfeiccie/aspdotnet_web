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
using System.IO;
using System.Data.OleDb;
using DBUtility;

using System.Collections.Generic;
using Global;
public partial class Lxbx : System.Web.UI.Page
{
    BLL.Draft_lxbx bll_lxbx = new BLL.Draft_lxbx();

    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();

    int PageSize = 5;
    static string strWhere =  "";

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
      
        Repeater1.DataSource = bll_lxbx.GetViewList(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex, strWhere);
        Repeater1.DataBind();

        LabelTotalInput.Text = bll_lxbx.GetAllList().Tables[0].Rows.Count.ToString();
        LabelTodayInput.Text = bll_lxbx.GetList(" cast(SendingTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ").Tables[0].Rows.Count.ToString();
        strWhere = "";
    }

    private void init()
    {
        strWhere = " Operator_id='" + Session["UserID"].ToString() + "'";
        DataSet dataSet = null;

        //地区
        dataSet = new BLL.TB_District().GetAllList();
        ddlDistrict.DataSource = dataSet;
        ddlDistrict.DataTextField = "Name";
        ddlDistrict.DataValueField = "ID";
        ddlDistrict.DataBind();

        ddlDistrict.Items.Insert(0,new ListItem("地区", "0"));

        //日期
      
        ddlDate.Items.Insert(0,new ListItem("日期类型","0"));
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

        //接触史
        dataSet = new BLL.TB_ContactHistory().GetAllList();
        ddlContactHistory.DataSource = dataSet;
        ddlContactHistory.DataTextField = "Name";
        ddlContactHistory.DataValueField = "ID";
        ddlContactHistory.DataBind();

        ddlContactHistory.Items.Insert(0, new ListItem("接触史", "0"));
    


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
        AspNetPager1.RecordCount = bll_lxbx.GetViewAllList().Tables[0].Rows.Count;
   
       
         }
   
    
 
    //删除
    protected void lbtnDelete_Click(object sender, EventArgs e)
    {

        int id = int.Parse(((LinkButton)sender).CommandArgument);
        Model.Draft_lxbx lxbx = bll_lxbx.GetModel(id);
        bll_lxbx.Delete(id);
        

        BinData();

        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理";
        log.Operation = "删除信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
    }

    //分页
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        //RememberOldValues();
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BinData();
      
        e.Cancel = true;
       // BinData();
    }
        


    //跳转到高级查询
    protected void BtnAdvancedSearch_Click(object sender, EventArgs e)
    {
      
        Response.Write("<script>window.location='SearchLxbx.aspx'</script>");
    }


    

    //查询
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        bool DistrictSelected = (ddlDistrict.SelectedIndex != 0);
        bool DateTypeSelected = (ddlDate.SelectedIndex != 0);
        bool InfoStateSelected = (ddlState.SelectedIndex != 0);

        string whereDistrictSelected = " FK_District='" + ddlDistrict.SelectedItem.Text + "'";
        string whereDateTypeSelected = " cast(" + ddlDate.SelectedValue + " as datetime) between '" + txtDateStart.Text + " 0:0:0' And '" + txtDateEnd.Text + " 23:59:59' ";
        string whereInfoStateSelected = " FK_Flag='" + ddlState.SelectedValue + "'";
        string whereInfectionWaysSelected = " FK_InfectionWay='" + ddlInfectionWay.SelectedValue + "'";
        string whereContactHistorySelected = " FK_ContactHistory='" + ddlContactHistory.SelectedValue + "'";
        string where = " ID != -100";
      
        if (DistrictSelected)
        {
            where += (" AND " + whereDistrictSelected+" ");
        }else
        if (DateTypeSelected)
        {
            where += (" AND " + whereDateTypeSelected + " ");
        }else
        if (InfoStateSelected)
        {
            where += (" AND " + whereInfoStateSelected + " ");
        }else 
            if (ddlInfectionWay.SelectedIndex != 0)
        {
            where += (" AND " + whereInfectionWaysSelected + " ");
        }else 
            if (ddlContactHistory.SelectedIndex != 0)
        {
            where += (" AND " + whereContactHistorySelected + " ");
        }
          strWhere = " Operator_id='" + Session["UserID"].ToString() + "' AND " + where;

         
          BinData();
    }

    protected void BtnVerify_Click(object sender, EventArgs e)
    {
        List<string> IDs = new List<string>();
       
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
     

     
        if (IDs.Count == 0)
        {
            JScript.Alert("没有选中项", this.Page);
        }
        else
        {
            for (int i = 0; i < IDs.Count; i++)
            {
                Model.Draft_lxbx lxbx = bll_lxbx.GetModel(int.Parse(IDs[i]));
                lxbx.FK_Flag = Global.InfoState.Verified;
                bll_lxbx.Update(lxbx);
            }
            JScript.Alert("审核成功",this.Page);
        }
        BinData();
    }
    protected void BtnShowToday_Click(object sender, EventArgs e)
    {
        strWhere = " cast(SendingTime as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' " + " AND " + " Operator_id='" + Session["UserID"].ToString() + "'";
        BinData();
         
    }
    protected void BtnShowTotal_Click(object sender, EventArgs e)
    {
        strWhere = "";
        BinData();
        
        
    }

     
    private void Export(string FileType, string FileName)
    {
        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.UTF7;
        //输出标题
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8).ToString());
        Response.ContentType = FileType;  //文件的类型
        this.EnableViewState = false;
        StringWriter tw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(tw);
        //this.GVCheapMaterialLib.RenderControl(hw);
        this.Repeater1.RenderControl(hw);
        Response.Write(tw.ToString());
        Response.End();
       
    }
    //加一个空方法使
    public override void VerifyRenderingInServerForm(Control control)
    {
        //base.VerifyRenderingInServerForm(control);
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
        Export("application/ms-excel", "导出数据.xls");
    }
   

}
