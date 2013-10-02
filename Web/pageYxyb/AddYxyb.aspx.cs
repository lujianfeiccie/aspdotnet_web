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
using System.Text;
using DBUtility;
using System.Drawing;

public partial class AddYxyb : System.Web.UI.Page
{

    static Hashtable ht = new Hashtable();

    Model.tb_yxyb yxyb = new Model.tb_yxyb();
    BLL.tb_yxyb bll_yxyb = new BLL.tb_yxyb();
    Model.tb_log log = new Model.tb_log();
    BLL.tb_log bll_log = new BLL.tb_log();

    protected void Page_Load(object sender, EventArgs e)
    {
        int role = 0;
        if (!IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
               
            }

            role = Int32.Parse(Session["RoleID"].ToString());
            init(); //初始化控件数据
        }
    }



    protected void btnWrite_Click(object sender, EventArgs e)
    {
        UpContextData();

        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
          Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            yxyb.FK_Flag = Global.InfoState.Verified;
        else
            yxyb.FK_Flag = Global.InfoState.UnVerified;

        yxyb.FK_User = int.Parse(Session["UserID"].ToString());
        yxyb.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

        int directReportNumSize = txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + txtDirectReportNumber3.MaxLength + txtDirectReportNumber4.MaxLength;
        int confirmNumSize = txtConfirmationNumber1.MaxLength + txtConfirmationNumber2.MaxLength;

        bool A = (yxyb.DirectReportNumber.Length - 3 == directReportNumSize); //DirectReportNumber长度减3，前面加了3个字符‘-’
        bool B = (yxyb.ConfirmationNumber.Length - 2 == confirmNumSize);
        bool C = (txtName.Text.Trim().Length != 0);
        bool D = (txtConfirmationDate.Text.Trim().Length != 0);
        bool E = (txtSamplingDate.Text.Trim().Length != 0);
        bool F = (txtBirthDate.Text.Trim().Length != 0);
        bool G = (bll_yxyb.GetList(" DirectReportNumber='" + yxyb.DirectReportNumber + "' ").Tables[0].Rows.Count == 0);
        bool H = (bll_yxyb.GetList(" ConfirmationNumber='" + yxyb.ConfirmationNumber + "' ").Tables[0].Rows.Count == 0);
        bool I = (yxyb.Id_card.Length == 18);
        if (!A)
        {
            JScript.Alert("直报号的长度不够");
            return;
        }
        if (!B)
        {
            JScript.Alert("确认号的长度不够");
            return;
        }
        if (!C)
        {
            JScript.Alert("姓名为空");
            return;
        }
        if (!D)
        {
            JScript.Alert("确认日期为空");
            return;
        }
        if (!E)
        {
            JScript.Alert("采样日期为空");
            return;
        }
        if (!F)
        {
            JScript.Alert("出生日期为空");
            return;
        }
        if (!G)
        {
            JScript.Alert("直报号已存在");
            return;
        }
        if (!H)
        {
            JScript.Alert("确认号已存在");
            return;
        }
        if (!I)
        {
            JScript.Alert("身份证号长度不正确！");
            return;
        }
            bll_yxyb.Add(yxyb);
            log.FK_User = int.Parse(Session["UserID"].ToString());
            log.OperatingPosition = "HIV/AIDS阳性样本管理";
            log.Operation = "添加信息";
            log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            bll_log.Add(log);
            DBUtility.JScript.Alert("成功添加", this.Page);

       
    }
    
    protected void btnSave_Click(object sender, EventArgs e)
    {
        BLL.Draft_yxyb draft_yxyb = new BLL.Draft_yxyb();
        Model.Draft_yxyb model_yxyb = new Model.Draft_yxyb();
        model_yxyb.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        model_yxyb.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;

        StringBuilder tempstr = new StringBuilder();
        //保存位置=(冰箱号+盒类型+盒编号+盒内编号)
        //  tempstr.Append(DateTime.Now.ToString("yyyyMMdd"));
        tempstr.Append(txtIceBox.Text.Trim()); //冰箱号
        tempstr.Append(txtFloor.Text.Trim()); //冰箱内的格数
        tempstr.Append(txtBoxID.Text.Trim()); //盒编号
        tempstr.Append(txtInsideBoxID.Text.Trim()); //盒内编号

        model_yxyb.PreservePosition = tempstr.ToString();
        model_yxyb.BirthDate = txtBirthDate.Text;
        model_yxyb.ConfirmationDate = txtConfirmationDate.Text;
        model_yxyb.FlowNumber = txtFlowNumber.Text;
        model_yxyb.SamplingDate = txtSamplingDate.Text;
        model_yxyb.Name = txtName.Text;
        model_yxyb.FK_Sex = int.Parse(ddlSex.SelectedValue);
        model_yxyb.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        model_yxyb.FK_SampleType = int.Parse(ddlSampleType.SelectedValue);
        model_yxyb.FK_SampleSize = int.Parse(ddlSampleSize.SelectedValue);
        model_yxyb.CD4 = txtCD4.Text;
        model_yxyb.ViralLoad = txtViralLoad.Text;
        model_yxyb.HCV = int.Parse(ddlHCV.SelectedValue);
        model_yxyb.HBV = int.Parse(ddlHBV.SelectedValue);
        model_yxyb.TB = int.Parse(ddlTB.SelectedValue);
        model_yxyb.Syphilis = int.Parse(ddlSyphilis.SelectedValue);
        model_yxyb.Others = txtOthers.Text;
        model_yxyb.Id_card = txtIDCard.Text.Trim();
        model_yxyb.Operator_id = int.Parse(Session["UserID"].ToString());
        if (Session["RoleID"].ToString() == "" || Session["RoleID"] == null ||
          Session["UserID"].ToString() == "" || Session["UserID"] == null)
            return;

        int RoleID = int.Parse(Session["RoleID"].ToString());
        string Authority = new BLL.tb_role().GetModel(RoleID).name;
        if (Authority == "系统管理员")
            model_yxyb.FK_Flag = Global.InfoState.Verified;
        else
            model_yxyb.FK_Flag = Global.InfoState.UnVerified;

        model_yxyb.FK_User = int.Parse(Session["UserID"].ToString());
        model_yxyb.SendingTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

        int directReportNumSize = txtDirectReportNumber1.MaxLength + txtDirectReportNumber2.MaxLength + txtDirectReportNumber3.MaxLength + txtDirectReportNumber4.MaxLength;
        int confirmNumSize = txtConfirmationNumber1.MaxLength + txtConfirmationNumber2.MaxLength;


        draft_yxyb.Add(model_yxyb);
        log.FK_User = int.Parse(Session["UserID"].ToString());
        log.OperatingPosition = "HIV/AIDS阳性样本管理";
        log.Operation = "添加信息";
        log.OperationDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        bll_log.Add(log);
        DBUtility.JScript.Alert("保存成功", this.Page);


    }

    private void init()
    {
        //流水号
        txtFlowNumber.Text = "ls" + DateTime.Now.ToLocalTime().ToString("yyyyMMddhhmmss");
   
        DataSet dataSet = null;

        //性别
        dataSet = new BLL.TB_SEX().GetAllList();
        ddlSex.DataSource = dataSet;
        ddlSex.DataTextField = "Name";
        ddlSex.DataValueField = "ID";
        ddlSex.DataBind();

        //可能感染途径
        dataSet = new BLL.TB_InfectionWay().GetAllList();
        ddlInfectionWay.DataSource = dataSet;
        ddlInfectionWay.DataTextField = "Name";
        ddlInfectionWay.DataValueField = "ID";
        ddlInfectionWay.DataBind();

        //样本类型
        dataSet = new BLL.TB_SampleType().GetAllList();
        ddlSampleType.DataSource = dataSet;
        ddlSampleType.DataTextField = "Name";
        ddlSampleType.DataValueField = "ID";
        ddlSampleType.DataBind();

        //样本量
        dataSet = new BLL.TB_SampleSize().GetAllList();
        ddlSampleSize.DataSource = dataSet;
        ddlSampleSize.DataTextField = "Name";
        ddlSampleSize.DataValueField = "ID";
        ddlSampleSize.DataBind();

        

        #region 2011-3-11 修改时间
        //样本类型
        dataSet = new BLL.TB_SampleType().GetAllList();
        ddlSampleType.DataSource = dataSet;
        ddlSampleType.DataTextField = "Name";
        ddlSampleType.DataValueField = "ID";
        ddlSampleType.DataBind();

        //样本量
        dataSet = new BLL.TB_SampleSize().GetAllList();
        ddlSampleSize.DataSource = dataSet;
        ddlSampleSize.DataTextField = "Name";
        ddlSampleSize.DataValueField = "ID";
        ddlSampleSize.DataBind();
        #endregion
        //阳性 阴性 不确定 未检测
        dataSet = new BLL.TB_AntibodyDetection().GetAllList();
        ddlHBV.DataSource = dataSet;
        ddlHBV.DataTextField = "Name";
        ddlHBV.DataValueField = "ID";
        ddlHBV.DataBind();
        ddlHBV.SelectedIndex = 3;
 
        ddlSyphilis.DataSource = dataSet;
        ddlSyphilis.DataTextField = "Name";
        ddlSyphilis.DataValueField = "ID";
        ddlSyphilis.DataBind();
        ddlSyphilis.SelectedIndex = 3;


        ddlTB.DataSource = dataSet;
        ddlTB.DataTextField = "Name";
        ddlTB.DataValueField = "ID";
        ddlTB.DataBind();
        ddlTB.SelectedIndex = 3;

        ddlHCV.DataSource = dataSet;
        ddlHCV.DataTextField = "Name";
        ddlHCV.DataValueField = "ID";
        ddlHCV.DataBind();
        ddlHCV.SelectedIndex = 3;


        DataSet ds = new DataSet();//用于存放配置文件信息
        ds.ReadXml(Server.MapPath(@"..\XMLFile.xml"));

        //////////////////////////////////ToolTips////////////////////////////////

        txtDirectReportNumber1.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber1"].ToString();
        txtDirectReportNumber2.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber2"].ToString();
        txtDirectReportNumber3.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber3"].ToString();
        txtDirectReportNumber4.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfDirectReportNumber4"].ToString();

        txtConfirmationNumber1.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfConfirmationNumber1"].ToString();
        txtConfirmationNumber2.ToolTip = ds.Tables[0].Rows[0]["ToolTipOfConfirmationNumber2"].ToString();

        //////////////////////////////////MaxLength////////////////////////////////
        txtDirectReportNumber1.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber1"].ToString());
        txtDirectReportNumber2.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber2"].ToString());
        txtDirectReportNumber3.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber3"].ToString());
        txtDirectReportNumber4.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfDirectReportNumber4"].ToString());

        txtConfirmationNumber1.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfConfirmationNumber1"].ToString());
        txtConfirmationNumber2.MaxLength = int.Parse(ds.Tables[0].Rows[0]["MaxLengthOfConfirmationNumber2"].ToString());




        //////////////////////////////////Add JS////////////////////////////////
        txtDirectReportNumber1.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber2.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber3.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");
        txtDirectReportNumber4.Attributes.Add("onkeypress", "if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}");

        txtDirectReportNumber1.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber2')");
        txtDirectReportNumber2.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber3')");
        txtDirectReportNumber3.Attributes.Add("onkeyup", "checkLen(this,'txtDirectReportNumber4')");

        txtConfirmationNumber1.Attributes.Add("onkeyup", "checkLen(this,'txtConfirmationNumber2')");
       

        //阳性判定时间
        txtConfirmationDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //采样时间
        txtSamplingDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

        //出生日期
        txtBirthDate.Attributes.Add("onclick", "javascript:new Calendar().show(this);");

       
        txtInsideBoxID.Attributes.Add("onclick", "textBoxClick();");
        txtFloor.Attributes.Add("onclick", "textFloorClick()");
        txtBoxID.Attributes.Add("onclick", "textHeClick()");

        //保存盒类型
        //ddlBoxType.Items.Insert(0, new ListItem("10×10冻存盒", "1"));
        //ddlBoxType.Items.Insert(1, new ListItem("96孔板", "2"));

    }
    protected void btnBatchWrite_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddBatchYxyb.aspx");
    }
    protected void btnCz_Click(object sender, EventArgs e)
    {
        Response.Redirect("Yxyb.aspx");
    }
    protected void txtIceBox_TextChanged(object sender, EventArgs e)
    {
        //Response.Write("<script language='javascript'>alert('change')</script>");
        ht.Clear();
    }
    protected void txtBoxID_TextChanged(object sender, EventArgs e)
    {
        ht.Clear();
    }
  
    private void UpContextData()
    {



        yxyb.DirectReportNumber = txtDirectReportNumber1.Text + "-" + txtDirectReportNumber2.Text + "-" + txtDirectReportNumber3.Text + "-" + txtDirectReportNumber4.Text;
        yxyb.ConfirmationNumber = "sz" + txtConfirmationNumber1.Text + txtConfirmationNumber2.Text;
    
        StringBuilder tempstr = new StringBuilder();
        //保存位置=(冰箱号+盒类型+盒编号+盒内编号)
        //  tempstr.Append(DateTime.Now.ToString("yyyyMMdd"));
        tempstr.Append(txtIceBox.Text.Trim()); //冰箱号
        tempstr.Append(txtFloor.Text.Trim()); //冰箱内的格数
        tempstr.Append(txtBoxID.Text.Trim()); //盒编号
        tempstr.Append(txtInsideBoxID.Text.Trim()); //盒内编号

        yxyb.PreservePosition = tempstr.ToString();
        yxyb.BirthDate = txtBirthDate.Text;
        yxyb.ConfirmationDate = txtConfirmationDate.Text;
        yxyb.FlowNumber = txtFlowNumber.Text;
        yxyb.SamplingDate = txtSamplingDate.Text;
        yxyb.Name = txtName.Text;
        yxyb.FK_Sex = int.Parse(ddlSex.SelectedValue);
        yxyb.FK_InfectionWay = int.Parse(ddlInfectionWay.SelectedValue);
        yxyb.FK_SampleType = int.Parse(ddlSampleType.SelectedValue);
        yxyb.FK_SampleSize = int.Parse(ddlSampleSize.SelectedValue);
        yxyb.CD4 = txtCD4.Text;
        yxyb.ViralLoad = txtViralLoad.Text;
        yxyb.HCV = int.Parse(ddlHCV.SelectedValue);
        yxyb.HBV =int.Parse(ddlHBV.SelectedValue);
        yxyb.TB = int.Parse(ddlTB.SelectedValue);
        yxyb.Syphilis = int.Parse(ddlSyphilis.SelectedValue);
        yxyb.Others = txtOthers.Text;
        yxyb.Id_card = txtIDCard.Text.Trim();
       

      
    
    
    }

#region 关于弹出样本框切换功能的实现
    protected void ddlBoxType_SelectedIndexChanged(object sender, EventArgs e)
    {
    
        ht.Clear();
    }

    private int toLogicNum(int value)
    {
        return value - 1;
    }
    private void ShowGrid(string type)
    {
        int width = 25;
        int height = 20;
        int rows = 0;
        int cols = 0;
        string UnSelectedColor = "#73A6DE";
        string SelectedColor = "#BD0000";
        string FontColor = "#000000";
        char[] Letters ={ 'N', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

        if (type.Equals("10X10"))
        {
            cols = 11;
            rows = 11;
        }
        else if (type.Equals("12X8"))
        {
            cols = 13;
            rows = 9;

        }
        else if (type.Equals("4X4"))
        {
            cols = 5;
            rows = 5;
            Letters[1] = '1';
            Letters[2] = '2';
            Letters[3] = '3';
            Letters[4] = '4';
        }
        else if (type.Equals("4X3"))
        {
            cols = 4;
            rows = 5;

            Letters[1] = '1';
            Letters[2] = '2';
            Letters[3] = '3';
            Letters[4] = '4';
        }
       

        TableRow tr;

        TableCell td;

        LinkButton lb;

        //Table Table1=new Table();

        tr = new TableRow();
        td = new TableCell();
        td.Height = height;
        td.HorizontalAlign = HorizontalAlign.Center;
        td.VerticalAlign = VerticalAlign.Middle;
        td.BackColor = Color.White;

        td.Text = "请选择样本位置";
        td.ColumnSpan = cols;
        tr.Cells.Add(td);
        Table1.Rows.Add(tr);




        for (int j = 1; j <= rows; j++)
        {
            tr = new TableRow();
            for (int i = 1; i <= cols; i++)
            {

                td = new TableCell();

                //第一排的特殊情况用于标识 1 2 3 4 5 6 7 8 9 10
                if (j == 1)
                {

                    //td.ID
                    td.Height = height;
                    td.Width = width;

                    if (i == 1) td.Text = " ";
                    else
                        td.Text = " " + (i - 1).ToString(); //1 2 3 4 5 6 7 8 9 10

                    tr.Cells.Add(td);
                    continue;
                }

                //第一列的情况 用于标识 A B C D E F G H I J
                if (i == 1)
                {
                    td.Height = height;
                    td.Width = width;
                    td.Text = " " + Letters[j - 1];
                    tr.Cells.Add(td);



                    continue;
                }

                lb = new LinkButton(); //添加组件，提供事件
                lb.ID = Letters[toLogicNum(j)] + toLogicNum(i).ToString(); //赋予ID标识




                lb.Text = Letters[j - 1] + (i - 1).ToString();



                if (ht.ContainsKey(lb.ID))
                {
                    lb.ToolTip = "此项已选";
                    lb.ForeColor = ColorTranslator.FromHtml(FontColor);
                    lb.BackColor = ColorTranslator.FromHtml(SelectedColor);
                    td.BackColor = ColorTranslator.FromHtml(SelectedColor);
                    td.ForeColor = ColorTranslator.FromHtml(FontColor);
                    
                    

                }
                else
                { 
                    if(type.Equals("4X4"))
                    {
                        lb.Attributes.Add("OnClick", "gridFloorClick('" + lb.ID + "');");
                    }else if (type.Equals("4X3"))
                    {
                        lb.Attributes.Add("OnClick", "gridHeClick('" + lb.ID + "');");
                    }
                    else
                    {
                        lb.Attributes.Add("OnClick", "gridClick('" + lb.ID + "');");
                    }
                    lb.ForeColor = ColorTranslator.FromHtml(FontColor);
                    lb.BackColor = ColorTranslator.FromHtml(UnSelectedColor);
                    td.BackColor = ColorTranslator.FromHtml(UnSelectedColor);
                    td.ForeColor = ColorTranslator.FromHtml(FontColor);
                    

                }


                td.Height = height;
                td.Width = width;
                //td.Text = Letters[i] + i.ToString();


                td.Controls.Add(lb);
                tr.Cells.Add(td);

            }

            Table1.Rows.Add(tr);
        }
        tr = new TableRow();
        td = new TableCell();
        lb = new LinkButton(); //添加组件，提供事件
        lb.Text = "关闭";

        td.Height = height;
        td.HorizontalAlign = HorizontalAlign.Center;
        td.VerticalAlign = VerticalAlign.Middle;
        td.BackColor = Color.White;


        td.ColumnSpan = cols;
        td.Controls.Add(lb);

        lb = new LinkButton(); //添加组件，提供事件
        lb.Text = "清空";
        if (type.Equals("4X4"))
        {
            lb.Attributes.Add("OnClick", "textFloorClear();");
        }else if (type.Equals("4X3"))
        {
            lb.Attributes.Add("OnClick", "textHeClear();");
        }
        else
        {
            lb.Attributes.Add("OnClick", "textClear();");
        }
        
        td.Controls.Add(lb);

        tr.Cells.Add(td);
        Table1.Rows.Add(tr);

    }
    public void textFloorClick(object sender, EventArgs e)
    {
        JScript.Alert("确认号已存在");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtFloor.Text.Trim() != "")
        {
            string type = "";
            string str = txtFloor.Text.Trim().Substring(1, 1);
            if (!str.Equals("4"))
            {
                type = "10X10";
            }
            else
            {
                type = "12X8";
            }
            if (type != "")
            {
                ShowGrid(type);
            }
            
            
        }
        else
        {
            JScript.Alert("请先选择冰箱格数！");
            return;
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        ShowGrid("4X4");

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ShowGrid("4X3");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ht.Add(txtInsideBoxID.Text, txtInsideBoxID.Text);



    }
#endregion


    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Yxyb.aspx");
    }
    protected void btnIfExist_Click(object sender, EventArgs e)
    {
        string str = txtDirectReportNumber1.Text.Trim() + "-" + txtDirectReportNumber2.Text.Trim() + "-" + txtDirectReportNumber3.Text.Trim() + "-" + txtDirectReportNumber4.Text.Trim();
        if (str.Length == 21)
        {
            string where = "DirectReportNumber = '" + str + "'";
            lblTimes.Text = "有 " + bll_yxyb.GetModelList(where).Count.ToString() + " 条记录";
        }
        else
        {
            JScript.Alert("直报号的长度不够");
        }
    }
}
