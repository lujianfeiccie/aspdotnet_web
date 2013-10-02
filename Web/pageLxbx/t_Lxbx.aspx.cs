using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.OleDb;
using DBUtility;
public partial class t_Lxbx : System.Web.UI.Page
{

    static string strWhere = "";
    int PageSize = 5;
    BLL.temp_tb_lxbx bll_temp_lxbx = new BLL.temp_tb_lxbx();
    BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
              
                if (Session["UserID"] == null)
                {

                    Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
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
     
        Repeater1.DataSource = bll_temp_lxbx.GetViewList(AspNetPager1.StartRecordIndex,AspNetPager1.EndRecordIndex,strWhere);
        Repeater1.DataBind();
        strWhere = "";
    }

    private void init()
    {
         
 
        
         DataSet dataSet = null;

        //地区
        dataSet = new BLL.TB_District().GetAllList();
        ddlDistrict.DataSource = dataSet;
        ddlDistrict.DataTextField = "Name";
        ddlDistrict.DataValueField = "ID";
        ddlDistrict.DataBind();

        ddlDistrict.Items.Insert(0, new ListItem("地区", "0"));

        //日期

        ddlDate.Items.Insert(0, new ListItem("日期类型", "0"));
        ddlDate.Items.Insert(1, new ListItem("出生日期", "BirthDate"));
        ddlDate.Items.Insert(2, new ListItem("转AIDS日期", "ToAidsDate"));
        ddlDate.Items.Insert(3, new ListItem("录入日期", "SendingTime"));
        ddlDate.Items.Insert(4, new ListItem("审核日期", "VerifyDate"));





        //状态
        dataSet = new BLL.TB_Flag().GetAllList();
        ddlState.DataSource = dataSet;
        ddlState.DataTextField = "Name";
        ddlState.DataValueField = "ID";
        ddlState.DataBind();

        ddlState.Items.Insert(0, new ListItem("状态", "0"));

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

        //日期开始时间
        txtDateStart.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        //日期结束时间
        txtDateEnd.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        AspNetPager1.PageSize = PageSize;
        AspNetPager1.RecordCount = bll_temp_lxbx.GetAllList().Tables[0].Rows.Count;
    }

    
    //删除
    protected void lbtnDelete_Click(object sender, EventArgs e)
    {
        int id = Int32.Parse(((LinkButton)sender).CommandArgument);
       
        bll_temp_lxbx.Delete(id);    

        BinData();
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理回收站";
        log.Operation = "删除信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        
    }

    //还原
    protected void lbtnRecovery_Click(object sender, EventArgs e)
    {
        
        int id = Int32.Parse(((LinkButton)sender).CommandArgument);
        Model.tb_lxbx temp=bll_temp_lxbx.GetModel(id);
        bll_temp_lxbx.Delete(id);
        temp.FK_Flag = Global.InfoState.Verified;
        bll_lxbx.Add(temp);
        
        BinData();

        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS病例报告管理回收站";
        log.Operation = "还原信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
     }

    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
       AspNetPager1.CurrentPageIndex = e.NewPageIndex;
         
       BinData();
       this.RePopulateValue();
      
    }
 

  
    

    public static void prerepater(Repeater repeater, System.Web.UI.Page page)
    {
        //ClientScriptManager cs = page.ClientScript;
        //for (int i = 0; i < repeater.Items.Count; i++)
        //{
        //    CheckBox cbx = (CheckBox)repeater.Items[i].FindControl("cbx");
        //    cs.RegisterArrayDeclaration("cbxArray", String.Concat("'", cbx.ClientID, "'"));
        //}
    }
    protected void Repeater1_PreRender(object sender, EventArgs e)
    {
      //  prerepater(Repeater1, this);
    }

    #region 审核
    protected void BtnVerify_Click(object sender, EventArgs e)
    {
        List<string> IDs = new List<string>();
        string delId = "";
        //先遍历取得选中项 
        for (int i = 0; i < this.Repeater1.Items.Count; i++)
        {
            CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("cbx");
            Label lbl = (Label)Repeater1.Items[i].FindControl("lbl");

            if (cbx != null)
            {
                if (cbx.Checked)
                {
                    IDs.Add(lbl.Text.ToString());
                    delId += lbl.Text + ",";
                }
            }
        }  
        ////去掉最后一个, 
        delId = (delId + ")").Replace(",)", "");

      //  DesignPattern.t_Lxbx.DataRecovery dataRecovery = new DesignPattern.t_Lxbx.DataRecovery();
        if (IDs.Count == 0)
        {
            JScript.Alert("没有选中项");
        }
        else
        {
            for (int i = 0; i < IDs.Count; i++)
            {
               // dataRecovery.Request(Int32.Parse(IDs[i]));
            }
            JScript.Alert("审核成功");
        }
        DataBind();
      
    }
    #endregion
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
            where += (" AND " + whereDistrictSelected + " ");
        }
        else
            if (DateTypeSelected)
            {
                where += (" AND " + whereDateTypeSelected + " ");
            }
            else
                if (InfoStateSelected)
                {
                    where += (" AND " + whereInfoStateSelected + " ");
                }
        if (ddlInfectionWay.SelectedIndex != 0)
        {
            where += (" AND " + whereInfectionWaysSelected + " ");
        }
        if (ddlContactHistory.SelectedIndex != 0)
        {
            where += (" AND " + whereContactHistorySelected + " ");
        }
        strWhere = where;
    }

    
    protected void BtnDataExport_Click(object sender, EventArgs e)
    {
       
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

    protected void BtnFlag_Click(object sender, EventArgs e)
    {
        this.RememberOldValues();
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        Export("流行性病例表");
    }

    private void Export( string FileName)
    {
        ArrayList al = null;
        DataTable dt = new DataTable();
        dt.Columns.Add("状态");
        dt.Columns.Add("姓名");
        dt.Columns.Add("性别");
        dt.Columns.Add("出生日期");
        dt.Columns.Add("民族");
        dt.Columns.Add("国籍");
        dt.Columns.Add("现住区域");
        dt.Columns.Add("操作人");
        DataSet ds = bll_lxbx.GetList(strWhere);
        if (Session["checked_items"] != null)
        {
            al = (ArrayList)Session["checked_items"];
        }
        if (al == null || al.Count == 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                DataRow dr = dt.NewRow();
                dr[0] = ds.Tables[0].Rows[i]["FK_Flag"].ToString();
                dr[1] = ds.Tables[0].Rows[i]["Name"].ToString();
                dr[2] = ds.Tables[0].Rows[i]["FK_Sex"].ToString();
                dr[3] = ds.Tables[0].Rows[i]["BirthDate"].ToString();
                dr[4] = ds.Tables[0].Rows[i]["FK_Nationality"].ToString();
                dr[5] = ds.Tables[0].Rows[i]["FK_Citizenship"].ToString();
                dr[6] = ds.Tables[0].Rows[i]["FK_District"].ToString();
                dr[7] = ds.Tables[0].Rows[i]["FK_User"].ToString();
                dt.Rows.Add(dr);

            }

        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {


                string id = ds.Tables[0].Rows[i]["ID"].ToString();

                if (al.Contains(id))
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = ds.Tables[0].Rows[i]["FK_Flag"].ToString();
                    dr[1] = ds.Tables[0].Rows[i]["Name"].ToString();
                    dr[2] = ds.Tables[0].Rows[i]["FK_Sex"].ToString();
                    dr[3] = ds.Tables[0].Rows[i]["BirthDate"].ToString();
                    dr[4] = ds.Tables[0].Rows[i]["FK_Nationality"].ToString();
                    dr[5] = ds.Tables[0].Rows[i]["FK_Citizenship"].ToString();
                    dr[6] = ds.Tables[0].Rows[i]["FK_District"].ToString();
                    dr[7] = ds.Tables[0].Rows[i]["FK_User"].ToString();

                    dt.Rows.Add(dr);
                }
            }
        }
        DBUtility.FileHelper.DataTableToExcel(dt, FileName);

    }


    //标记选中的复选框
    private void RememberOldValues()
    {
        ArrayList al = null; //声明集合
        //创建一个Session并检查是否为空，这个Session用来保存集合
        //这里是判断是否是第一次进行分页
        if (Session["checked_items"] != null)
        {
            al = (ArrayList)Session["checked_items"];
        }
        else
        {
            al = new ArrayList();
        }

        for (int i = 0; i < this.Repeater1.Items.Count; i++)
        {
            CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("CheckBox1");
            string id = cbx.Attributes["key"];
            bool result = cbx.Checked;
            if (result)
            {
                if (!al.Contains(id))
                {
                    al.Add(id);
                }
            }
            else
            {
                if (al.Contains(id))
                {
                    al.Remove(id);
                }
            }
        }
        if (al != null && al.Count > 0)
        {
            Session["checked_items"] = al;
        }

    }
    //恢复选中的复选框
    private void RePopulateValue()
    {
        ArrayList al = (ArrayList)Session["checked_items"];
        if (al != null && al.Count > 0)
        {
            for (int i = 0; i < this.Repeater1.Items.Count; i++)
            {
                CheckBox cbx = (CheckBox)Repeater1.Items[i].FindControl("CheckBox1");
                string id = cbx.Attributes["key"];

                if (al.Contains(id))
                {
                    cbx.Checked = true;
                }
            }
        }
    }
}
