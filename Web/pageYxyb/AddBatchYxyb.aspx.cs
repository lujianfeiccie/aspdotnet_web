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
using System.Data.OleDb;

public partial class pageYxyb_AddBatchYxyb : System.Web.UI.Page
{

    static DataSet ds = null;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
                return;
            }

            BinData();
        }


    }






    public DataSet ExecleDs(string filenameurl, string table)
    {

        string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + filenameurl + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";
        OleDbConnection conn = new OleDbConnection(strConn);
        conn.Open();
        DataSet ds = new DataSet();

        OleDbDataAdapter odda = new OleDbDataAdapter("select * from [" + table + "$]", conn);
        odda.Fill(ds, "db");

        return ds;
    }

    protected void btnPreview_Click(object sender, EventArgs e)
    {
        string url = FileUpload1.PostedFile.FileName;

        ds = ExecleDs(url, "阳性样本批量录入");



        BinData();

    }

    protected void btnWrite_Click(object sender, EventArgs e)
    {
        //DBUtility.JScript.Alert("需求不确定，暂时未实现", Page);
        BLL.tb_yxyb bll_yxyb = new BLL.tb_yxyb();
  
        if (ds != null)
        {
            int count = bll_yxyb.AddBatchData(ds);
            DBUtility.JScript.Alert("增加了" + count + "条记录", Page);
        }
        
    }

    private void BinData()
    {
        GridView1.DataSource = ds;

        GridView1.DataBind();

        btnWrite.Enabled = (((DataSet)GridView1.DataSource) != null);
    }
}
