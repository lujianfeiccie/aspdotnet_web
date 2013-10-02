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

public partial class left : System.Web.UI.Page
{
    //权限枚举
    enum Permission
    {
      Administrator,  //系统管理员
      DataMaintenance, //数据维护员
      LxlbAdmin,        //流行性表管理员
      YxybAdmin,        //阳性表管理员
      SfjcAdmin,        //随访表管理员
      User             //普通用户
    }
        //权限设置
    private void SetPermission(Permission p, Page page)
        {
            string str=string.Empty;
            str = "<script>";
            switch (p)
            { 
                case Permission.Administrator:

                    for (int i = 1; i <= 3; i++)
                    {
                        str += "document.getElementById('add" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('verify" + i.ToString() + "').style.display=''; ";
                    }
                    this.div6.Visible = true;
                    this.div5.Visible = true;

                    break;
                case Permission.DataMaintenance:

                    for (int i = 1; i <= 3; i++)
                    {
                        str += "document.getElementById('add" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('verify" + i.ToString() + "').style.display=''; ";
                    }
                     this.div6.Visible = false;
                     this.div5.Visible = false;
                    
                    break;
                case Permission.LxlbAdmin:

                    for (int i = 1; i <= 3; i++)
                    {
                        if (i == 1)
                        {
                            str += "document.getElementById('add" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('verify" + i.ToString() + "').style.display=''; ";
                        }
                        else
                        {
                            str += "document.getElementById('add" + i.ToString() + "').style.display='none'; ";
                            str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display='none'; ";
                            str += "document.getElementById('verify" + i.ToString() + "').style.display='none'; ";
                        }

                    }
                    this.div6.Visible = false;
                    this.div5.Visible = false;

                    break;
                case Permission.YxybAdmin:

                    for (int i = 1; i <= 3; i++)
                    {
                        if (i == 2)
                        {
                            str += "document.getElementById('add" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('verify" + i.ToString() + "').style.display=''; ";
                        }
                        else
                        {
                            str += "document.getElementById('add" + i.ToString() + "').style.display='none'; ";
                            str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display='none'; ";
                            str += "document.getElementById('verify" + i.ToString() + "').style.display='none'; ";
                        }

                    }
                    this.div6.Visible = false;
                    this.div5.Visible = false;

                    break;
                case Permission.SfjcAdmin:

                    for (int i = 1; i <= 3; i++)
                    {
                        if (i == 3)
                        {
                            str += "document.getElementById('add" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('verify" + i.ToString() + "').style.display=''; ";
                        }
                        else
                        {
                            str += "document.getElementById('add" + i.ToString() + "').style.display='none'; ";
                            str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                            str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display='none'; ";
                            str += "document.getElementById('verify" + i.ToString() + "').style.display='none'; ";
                        }

                    }
                    this.div6.Visible = false;
                    this.div5.Visible = false;

                    break;
                case Permission.User:

                    for (int i = 1; i <= 3; i++)
                    {
                        str += "document.getElementById('add"+i.ToString()+"').style.display='none'; ";
                        str += "document.getElementById('browser" + i.ToString() + "').style.display=''; ";
                        str += "document.getElementById('advancedSearch" + i.ToString() + "').style.display='none'; ";
                        str += "document.getElementById('verify" + i.ToString() + "').style.display='none'; ";
                        
                    }
                    this.div6.Visible = false;
                    this.div5.Visible = false;
                    break;

            }
            str += "</script>";
        
            page.RegisterStartupScript("k", str);
         
        }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/" + ConfigurationManager.AppSettings["HomePage"].ToString());
        }
        else
        {
            int roleID = Int32.Parse(Session["RoleID"].ToString());

            switch (roleID)
            {
                case 1:
                    SetPermission(Permission.Administrator, this);
                    break;
                case 2:
                    SetPermission(Permission.LxlbAdmin, this);
                    break;
                case 3:
                    SetPermission(Permission.YxybAdmin, this);
                    break;
                case 5:
                    SetPermission(Permission.SfjcAdmin, this);
                    break;
                case 7:
                    SetPermission(Permission.DataMaintenance, this);
                    break;
                default:
                    SetPermission(Permission.User, this);
                    break;
            }
        } 
    }
}
