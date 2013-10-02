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
using System.Collections.Generic;
using System.IO;

public partial class Log : System.Web.UI.Page
{
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
             


                init();
                BinData();
            

        }

    }

    private void BinData()
    {

        Repeater1.DataSource = bll_log.GetViewList(AspNetPager1.StartRecordIndex, AspNetPager1.EndRecordIndex, strWhere);
        Repeater1.DataBind();

       
    }

    private void init()
    {
        
        //日期开始时间
        txtDateStart.Attributes.Add("onclick", "javascript:new Calendar().show(this);");
        //日期结束时间
        txtDateEnd.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        AspNetPager1.PageSize = PageSize;
        AspNetPager1.RecordCount = bll_log.GetViewAllList().Tables[0].Rows.Count;


    }



    
    //分页
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BinData();

    }



  



    //查询
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        bool A = (txtDateStart.Text.Length != 0);
        bool B = (txtDateEnd.Text.Length != 0);

        if (A && B)
        {
            strWhere = " cast(OperationDate as datetime) between '" + txtDateStart.Text + " 0:0:0' And '" + txtDateEnd.Text + " 23:59:59' ";
        }
        else
        {
            strWhere = "";
        }
        BinData();
    }

    //删除
    protected void lbtnDelete_Click(object sender, EventArgs e)
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
                bll_log.Delete(int.Parse(IDs[i]));
             }
            JScript.Alert("日志成功删除!", this.Page);
        }
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
