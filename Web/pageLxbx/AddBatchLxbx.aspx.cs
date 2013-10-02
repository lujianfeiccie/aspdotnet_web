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

public partial class AddBatchLxbx : System.Web.UI.Page
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
        //OleDbDataAdapter odda = new OleDbDataAdapter("select  ConfirmationNumber,DirectReportNumber,Name,FK_Sex,BirthDate,FK_Nationality,FK_MarriageStatus,FK_Education,FK_Citizenship,Province,County,FK_InfectionWay,FK_ContactHistory,FK_JobCharacter,FK_DetectionClass,FK_HouseholdRegister,FK_CurrentSituation,PositiveDecisionDate,ToAidsDate,FK_District,DetailedAddress,CensorshipUnit,Spouse,Children,FK_IsDead,Remark from [" + table + "$]", conn);
       
        odda.Fill(ds, "db");
        conn.Close();
        return ds;
    }

    protected void btnPreview_Click(object sender, EventArgs e)
    {
        string url = FileUpload1.PostedFile.FileName;

        ds = ExecleDs(url, "流行病学信息批量录入");



        BinData();

    }

    protected void btnWrite_Click(object sender, EventArgs e)
    {
        //DBUtility.JScript.Alert("需求不确定，暂时未实现", Page);
        BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();
        if (ds != null)
        {
            int count = bll_lxbx.AddBatchData(ds);
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
