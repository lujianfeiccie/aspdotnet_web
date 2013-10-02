<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CommentList.aspx.cs" Inherits="CommentList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="CommentList.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #EEF2FB;
}
-->
</style>
<script language="javascript" type="text/javascript">
// <!CDATA[

 

// ]]>
</script>
</head>
<body>
 <form id="form1" runat="server">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
     
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td colspan="3" valign="top" align="center"><!--JavaScript部分-->
            <asp:LinkButton ID="lbtnUnread" runat="server" OnClick="lbtnUnread_Click"></asp:LinkButton>
            <asp:LinkButton ID="lbtnAll" runat="server" OnClick="lbtnAll_Click">所有信息</asp:LinkButton><!--HTML部分--></tr>
      <tr>
        <td height="40" colspan="3"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
          <tr>
            <td>
 
                    <div align="center">
                        <!--
	
 
  
	-->
                        <table width="777" border="0" cellpadding="0" cellspacing="0">
                            <!--DWLayoutTable-->
                            <tr>
                                <td valign="middle" style="width: 775px" align="center" height="79">
                                    &nbsp;留 言 板</td>
                            </tr>
                        </table>
                    </div>
                    <div align="center" ><table border="0" cellpadding="0" cellspacing="0" width="777">
                        <!--DWLayoutTable-->
                        <tr>
                            <td rowspan="2" valign="top" width="310">
                                <table bgcolor="#E6EDF2" border="0" cellpadding="0" cellspacing="1" width="100%" Style="border-right: #E6EDF2 1px solid;
                                                border-top: #E6EDF2 1px solid; font: menu; border-left: #E6EDF2 1px solid; border-bottom: #E6EDF2 1px solid">
                                    <!--DWLayoutTable-->
                                    <tr>
                                        <td width="87" valign="middle" align="center" bgcolor="#ffffff" style="height: 20px">
                                                      你的姓名:</td>
                                        <td align="left" bgcolor="#ffffff" colspan="1" valign="top" style="height: 20px" >
                                            <asp:TextBox ID="txtName" runat="server" Style="border-right: #3771EF 1px solid;
                                                border-top: #3771EF 1px solid; font: menu; border-left: #3771EF 1px solid; border-bottom: #3771EF 1px solid"></asp:TextBox>&nbsp;</td>
                                        <td bgcolor="#ffffff" valign="top" width="57" style="height: 20px">
                                            </td>
                                    </tr>
                                    <tr>
                                        <td align="center" bgcolor="#ffffff" style="height: 20px" valign="middle">
                                                      电子邮箱:</td>
                                        <td align="left" bgcolor="#ffffff" colspan="1" style="height: 20px" valign="middle">
                                            <asp:TextBox ID="txtEmail" runat="server" Style="border-right: #3771EF 1px solid; border-top: #3771EF 1px solid;
                                                font: menu; border-left: #3771EF 1px solid; border-bottom: #3771EF 1px solid"></asp:TextBox>&nbsp;</td>
                                        <td bgcolor="#ffffff" style="height: 20px" valign="top">
                                            </td>
                                    </tr>
                                    <tr>
                                        <td align="center" bgcolor="#ffffff" height="20" valign="middle">
                                                      QQ号码:</td>
                                        <td align="left" bgcolor="#ffffff" style="width: 153px" valign="top">
                                            <asp:TextBox ID="txtqq" runat="server" Style="border-right: #3771EF 1px solid; border-top: #3771EF 1px solid;
                                                font: menu; border-left: #3771EF 1px solid; border-bottom: #3771EF 1px solid"
                                                Width="118px"></asp:TextBox></td>
                                        <td bgcolor="#ffffff" colspan="1" valign="top">
                                            </td>
                                    </tr>
                                    <tr style="font-size: 12pt; font-family: Times New Roman">
                                        <td bgcolor="#ffffff" height="27" valign="top">
                                            <!--DWLayoutEmptyCell-->
                                            &nbsp;</td>
                                        <td align="left" bgcolor="#ffffff" style="width: 153px" valign="middle">
                                            &nbsp;<asp:Button ID="addly" runat="server" OnClick="addly_Click" Style="border-right: #009900 2px solid;
                                                border-top: #009900 2px solid; font: menu; border-left: #009900 2px solid; border-bottom: #009900 2px solid;
                                                background-color: #E6EDF2" Text="添加留言" Width="77px" /></td>
                                        <td align="left" bgcolor="#ffffff" colspan="1" valign="middle">
                                            </td>
                                    </tr>
                                    <tr style="font-size: 12pt; font-family: Times New Roman">
                                        <td bgcolor="#ffffff" height="0">
                                        </td>
                                        <td bgcolor="#ffffff" style="width: 153px">
                                        </td>
                                        <td bgcolor="#ffffff">
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="font-size: 12pt; font-family: Times New Roman; height: 101px" valign="top"
                                width="464">
                                <table border="0" cellpadding="0" cellspacing="0" width="96%">
                                    <!--DWLayoutTable-->
                                    <tr>
                                        <td align="left" valign="top" width="100%">
                                            &nbsp;<asp:TextBox ID="txtContent" runat="server" Height="91px" MaxLength="500" Style="border-right: #3771EF 1px solid;
                                                border-top: #3771EF 1px solid; font: menu; border-left: #3771EF 1px solid; border-bottom: #3771EF 1px solid"
                                                TextMode="MultiLine" Width="430px"></asp:TextBox></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td height="27" valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <!--DWLayoutTable-->
                                    <tr>
                                        <td height="26" width="457">
                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; 留 言 内 容
                                            <asp:Label ID="Label1" runat="server"
                                                Width="131px"></asp:Label></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    </div>
                    <div align="center">
                        <table border="0" cellpadding="0" cellspacing="0" style="font-size: 12pt; font-family: Times New Roman"
                            width="770">
                            <!--DWLayoutTable-->
                            <tr>
                                <td align="center" height="18" style="width: 775px" valign="middle" width="775">
                                    留 言 列 表 &nbsp; &nbsp;
                                 <%--   <asp:HyperLink ID="admin_go" runat="server" NavigateUrl="~/default.aspx" ForeColor="Blue" Target="Main">管理登陆</asp:HyperLink>--%>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div align="center">
                         <asp:Repeater ID="rpt1" runat="server">
                          <ItemTemplate>
                              <table bgcolor="#F7FAFB" border="0" cellpadding="0" cellspacing="1" class="tb" width="777">
                                  <!--DWLayoutTable-->
                                  <tr>
                                      <td bgcolor="#F7FAFB" rowspan="3" valign="top" width="11">
                                          <!--DWLayoutEmptyCell-->
                                          &nbsp;</td>
                                      
                                      <td align="left" bgcolor="#F7FAFB" height="20" colspan="2" valign="middle" width="528">
                                            &nbsp; &nbsp;  <%#Eval("name")%>    留言于:<%#Eval("addTime")%>
                                      </td>
                                      <td align="center" bgcolor="#F7FAFB" valign="middle" width="136">
                                          &nbsp;
                                          <%# show_admin(Convert.ToInt32(Eval("ID"))) %>
                                      </td>
                                      <td bgcolor="#F7FAFB" rowspan="3" style="width: 10px" valign="top" width="12">
                                          <!--DWLayoutEmptyCell-->
                                          &nbsp;</td>
                                  </tr>
                                  <tr>
                                      <td align="left" bgcolor="#F7FAFB" colspan="3" height="78" valign="top">
                                          &nbsp;&nbsp; <%# showbody(Eval("content").ToString())%>
                                        <%# showrely((bool)Eval("isreply"), Eval("reply").ToString())%>
                                      </td>
                                  </tr>
                                  <tr>
                                     
                                      <td align="left" bgcolor="#F7FAFB" colspan="3" style="height: 25px" valign="middle">
                                          &nbsp; &nbsp; 邮 箱:<%#Eval("email")%>>&nbsp; &nbsp; QQ:<%#Eval("qq")%>&nbsp; &nbsp;
                                        
                                  </tr>
                              </table>
                              <br>
                          </ItemTemplate>
                      </asp:Repeater>
                        <table id="Table1" border="0" cellpadding="1" cellspacing="1" style="font-size: 12pt;
                            font-family: Times New Roman" width="775">
                            <tr>
                                <td align="center" style="width: 775px; height: 18px">
                                    <webdiyer:aspnetpager id="AspNetPager1" runat="server" onpagechanging="AspNetPager1_PageChanging"  ></webdiyer:aspnetpager>
                                </td>
                            </tr>
                        </table>
                    </div>
            </td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td height="46" colspan="3" align="center"><span class="left_txt"> CopyRight &copy; 2010 深圳市疾病控制预防中心 版权所有</span>
        <br /><span class="left_txt"> 地址：深圳市南山区 邮编：518000</span>
        </td>
        </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
	</form>
</body>
</html>
