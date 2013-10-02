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
using DBUtility;
using System.Data.OleDb;

public partial class pageSfjc_AddBatchSfjc : System.Web.UI.Page
{
    static DataSet ds=null;

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

        ds = ExecleDs(url, "随访批量录入");



        BinData();

    }

    protected void btnWrite_Click(object sender, EventArgs e)
    {
        
        //DBUtility.JScript.Alert("需求不确定，暂时未实现", Page);
        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
            Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
       

        int count = ds.Tables[0].Rows.Count;

        DataSet ds_invalid = ds.Clone();
        
        DataSet ds_valid = ds.Clone();

        //清空dataset
        ds_invalid.Clear();
        ds_valid.Clear();
    

        BLL.tb_sfjc bll_sfjc = new BLL.tb_sfjc();

     
        BLL.tb_yxyb bll_yxyb = new BLL.tb_yxyb();
       
        BLL.tb_lxbx bll_lxbx = new BLL.tb_lxbx();

        for (int i = 0; i < count; i++)
        {
           

            //判断随访记录表是否全部重复，如果全部重复的话，弹出一个提示
            string sfjcsql = "Name = '" + ds.Tables[0].Rows[i][0] + "' and DirectReportNumber = '" + ds.Tables[0].Rows[i][1] + "' and ConfirmationNumber ='sz"
                + ds.Tables[0].Rows[i][2] + "' and ConfirmationDate = '" + ds.Tables[0].Rows[i][3] + "' and FK_Sex = '" + ds.Tables[0].Rows[i][4] + "' and BirthDate = '" +
                ds.Tables[0].Rows[i][5] + "' and FK_InfectionWay = '" + ds.Tables[0].Rows[i][6] + "' and FK_CurrentSituation ='" + ds.Tables[0].Rows[i][7]
                + "' and FK_TypeOfTreatment = '" + ds.Tables[0].Rows[i][8] + "' and FK_District = '" + ds.Tables[0].Rows[i][9]
                + "' and CD4 = '" + ds.Tables[0].Rows[i][10] + "' and ViralLoad='" + ds.Tables[0].Rows[i][11] + "' and FK_Spouse_AntibodyDetection ='" + ds.Tables[0].Rows[i][12]
                + "' and FK_Children_AntibodyDetection ='" + ds.Tables[0].Rows[i][13] + "' and Remark ='" + ds.Tables[0].Rows[i][14] + "'";

            List<Model.tb_sfjc> list_sfjc = bll_sfjc.GetModelList(sfjcsql);
            
            //随访记录表存在该条记录，加入无效ds
            if (list_sfjc.Count > 0)
            {
                ds_invalid.Tables[0].Rows.Add(ds.Tables[0].Rows[i].ItemArray);
            }
            else
            {
                //阳性样表

                //取出存在表中的数据
                string strsql = " ConfirmationNumber = 'sz" + ds.Tables[0].Rows[i][2].ToString() + "' and DirectReportNumber ='" + ds.Tables[0].Rows[i][1].ToString() + "'";
                List<Model.tb_yxyb> list_yxyb = bll_yxyb.GetModelList(strsql);
                Model.tb_yxyb temp_yxyb = null;
                
                //若list中的总数大于0表明阳性样表表中存在该直报号和确认号
                if (list_yxyb.Count > 0)
                {
                    temp_yxyb = list_yxyb.ToArray()[0];
                    //为模型赋值
                    Model.tb_yxyb yxyb = new Model.tb_yxyb();

                    yxyb.Name = ds.Tables[0].Rows[i][0].ToString();
                    yxyb.DirectReportNumber = ds.Tables[0].Rows[i][1].ToString();
                    yxyb.ConfirmationNumber = ds.Tables[0].Rows[i][2].ToString();
                    yxyb.ConfirmationDate = ds.Tables[0].Rows[i][3].ToString();

                    yxyb.FK_Sex = Convert.ToInt32(ds.Tables[0].Rows[i][4]);
                    yxyb.BirthDate = ds.Tables[0].Rows[i][5].ToString();
                    yxyb.FK_InfectionWay = Convert.ToInt32(ds.Tables[0].Rows[i][6]);
                    yxyb.CD4 = ds.Tables[0].Rows[i][10].ToString();
                    yxyb.ViralLoad = ds.Tables[0].Rows[i][11].ToString();

                    //yxyb.FK_User = temp_yxyb.FK_User;

                    //yxyb.ID = temp_yxyb.ID;
                    //yxyb.HBV = temp_yxyb.HBV;
                    //yxyb.HCV = temp_yxyb.HCV;
                    //yxyb.Others = temp_yxyb.Others;


                    //yxyb.FK_Flag = temp_yxyb.FK_Flag;
                    //yxyb.PreservePosition = temp_yxyb.PreservePosition;
                    //yxyb.FlowNumber = temp_yxyb.FlowNumber;
                    //yxyb.SamplingDate = temp_yxyb.SamplingDate;
                    //yxyb.TB = temp_yxyb.TB;
                    //yxyb.Syphilis = temp_yxyb.Syphilis;
                    //yxyb.SendingTime = temp_yxyb.SendingTime;
                    //yxyb.showToUser = temp_yxyb.showToUser;
                    //yxyb.VerifyDate = temp_yxyb.VerifyDate;
                    //yxyb.FK_SampleType = temp_yxyb.FK_SampleType;
                    //yxyb.FK_SampleSize = temp_yxyb.FK_SampleSize;
                    //更新阳性样表
                    bll_yxyb.Add(yxyb);

     
                }

                //病例样例
                List<Model.tb_lxbx> list_lxbx = bll_lxbx.GetModelList(strsql);
                Model.tb_lxbx temp_lxbx = null;

                //若list中的总数大于0表明病例样例表中存在该直报号和确认号
                if (list_lxbx.Count > 0)
                {
                    temp_lxbx = list_lxbx.ToArray()[0];
                    //为模型赋值
                    Model.tb_lxbx lxbx = new Model.tb_lxbx();

                    lxbx.Name = ds.Tables[0].Rows[i][0].ToString();
                    lxbx.DirectReportNumber = ds.Tables[0].Rows[i][1].ToString();
                    lxbx.ConfirmationNumber = ds.Tables[0].Rows[i][2].ToString();


                    lxbx.FK_Sex = Convert.ToInt32(ds.Tables[0].Rows[i][4]);
                    lxbx.BirthDate = ds.Tables[0].Rows[i][5].ToString();

                    lxbx.FK_InfectionWay = Convert.ToInt32(ds.Tables[0].Rows[i][6]);
                    lxbx.FK_CurrentSituation = Convert.ToInt32(ds.Tables[0].Rows[i][7]);

                    lxbx.FK_District = Convert.ToInt32(ds.Tables[0].Rows[i][9]);
                    lxbx.FK_Spouse = Convert.ToInt32(ds.Tables[0].Rows[i][12]);
                    lxbx.FK_Children = Convert.ToInt32(ds.Tables[0].Rows[i][13]);

                    lxbx.Remark = ds.Tables[0].Rows[i][14].ToString();

                    lxbx.SendingTime = temp_lxbx.SendingTime;
                    lxbx.FK_IsDead = temp_lxbx.FK_IsDead;
                    lxbx.FK_User = temp_lxbx.FK_User;

                    lxbx.ID = temp_lxbx.ID;
                    lxbx.FK_Nationality = temp_lxbx.FK_Nationality;
                    lxbx.FK_MarriageStatus = temp_lxbx.FK_MarriageStatus;
                    lxbx.FK_Education = temp_lxbx.FK_Education;
                    lxbx.FK_Citizenship = temp_lxbx.FK_Citizenship;
                    lxbx.Province = temp_lxbx.Province;
                    lxbx.County = temp_lxbx.County;
                    lxbx.FK_ContactHistory = temp_lxbx.FK_ContactHistory;
                    lxbx.FK_JobCharacter = temp_lxbx.FK_JobCharacter;
                    lxbx.FK_DetectionClass = temp_lxbx.FK_DetectionClass;
                    lxbx.FK_HouseholdRegister = temp_lxbx.FK_HouseholdRegister;
                    lxbx.PositiveDecisionDate = temp_lxbx.PositiveDecisionDate;
                    lxbx.ToAidsDate = temp_lxbx.ToAidsDate;
                    lxbx.DetailedAddress = temp_lxbx.DetailedAddress;
                    lxbx.CensorshipUnit = temp_lxbx.CensorshipUnit;
                    lxbx.FK_DetectionStatement = temp_lxbx.FK_DetectionStatement;
                    lxbx.FK_Flag = temp_lxbx.FK_Flag;
                    lxbx.FK_ShowToUser = temp_lxbx.FK_ShowToUser;
                    lxbx.VerifyDate = temp_lxbx.VerifyDate;
                    lxbx.Spouse = temp_lxbx.Spouse;
                    lxbx.Children = temp_lxbx.Children;

                    //更新病例样例
                    bll_lxbx.Update(lxbx);

                    bll_lxbx.Add(temp_lxbx);

                }
                ds_valid.Tables[0].Rows.Add(ds.Tables[0].Rows[i].ItemArray);

            }
        }

        Model.tb_log log = new Model.tb_log();
        BLL.tb_log bll_log = new BLL.tb_log();

        int num = bll_sfjc.AddBatchData(ds_valid);

        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS随访信息管理";
        log.Operation = "添加了" + num + "条信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        DBUtility.JScript.Alert("成功添加了" + num + "条信息", this.Page);
    }

    private void BinData()
    {
      GridView1.DataSource = ds;

        GridView1.DataBind();

        btnWrite.Enabled = (((DataSet)GridView1.DataSource) != null);
    }
}
