<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市疾病预防控制中心</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
	<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #EEF2FB;
}
a:hover {
	color: #FF6600;
}
.STYLE2 {font-size: 12px; color: #000000;}
-->
    </style>
</head>
<body>

    <form id="form1" runat="server">
    
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
    
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif">
    <img src="../images/left-top-right.gif" width="17" height="29" />
    </td>
    
    <td valign="top" background="../images/content-bg.gif">
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">浏览信息</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr height="10">
        <td height="29" style="height: 10px">&nbsp;</td>
        <td style="height: 10px; width: 155px;" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
      </tr>
      <tr>
        <td colspan="5" align="center" valign="middle" class="left_bt3" style="height: 25px"><span class="left_txt">
        </span>
          <table width="100%" height="62" border="0" cellpadding="0" cellspacing="0" class="line_table">
            <tr >
              <td height="25" background="../images/news-title-bg.gif" class="left_bt2" style="width: 229px; height: 4px;">查找条件</td>
              <td background="../images/news-title-bg.gif" style="width: 275px; height: 4px;">&nbsp;</td>
              <td background="../images/news-title-bg.gif" style="width: 144px; height: 4px;">&nbsp;</td>
              <td background="../images/news-title-bg.gif" style="width: 118px; height: 4px;">&nbsp;</td>
              <td background="../images/news-title-bg.gif" style="width: 182px; height: 4px;">&nbsp;</td>
              <td width="479" background="../images/news-title-bg.gif" style="height: 4px">&nbsp;</td>
            </tr>
            <tr>
              <td class="left_bt2" align="right" style="width: 229px; height: 28px;" >
                  </td>
              <td style="width: 275px; height: 28px;" class="left_bt2" align="right">
                  用户类型：</td>
              <td align="left" style="width: 144px; height: 28px;" class="left_bt2">
                  <asp:DropDownList ID="ddlUserRoleType" runat="server" Width="102px">
            </asp:DropDownList></td>
              <td style="width: 118px; height: 28px;" align="right" class="left_bt2">
                  用户名：</td>
              <td style="width: 182px; height: 28px;" align="left" >
                  <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox></td>
              <td style="height: 28px" align="left" >
              <asp:Button ID="btnSearch" runat="server" Text="查询" Width="50px" OnClick="btnSearch_Click" /></td>
            </tr>
          </table></td>
        </tr>
      
      <tr>
        <td colspan="5" valign="top"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td width="18" background="../images/news-title-bg.gif" style="width: 12px; height: 23px"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
            <td background="../images/news-title-bg.gif" class="left_bt2" style="width: 79%; height: 23px;">
                信息显示</td>
            <td width="217" background="../images/news-title-bg.gif" class="left_bt2" style="height: 23px" align="right">&nbsp;&nbsp;&nbsp;
                </td>
          </tr>
          <tr>
            <td height="25" colspan="3" valign="top"><asp:Repeater ID="Repeater1" runat="server" >
            <HeaderTemplate>
                <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1"  class="nowtable">
                    <tr class="left_bt3">
                        <td width="20%" height="22" align="center" >
                            ID
                        </td>
                        <td width="20%" height="22" align="center" >
                            用户名
                        </td>
                        <td width="20%" height="22" align="center" >
                            用户类型
                        </td>
                        <td width="20%" height="22" align="center" >
                            真实姓名
                        </td>
                        <td width="20%" height="22" align="center" >
                            操作
                        </td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("ID") %>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("UserName") %>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("RoleID")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE">
                        <%# Eval("TrueName")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE">
                    <a href=UpdateUser.aspx?ID=<%# Eval("ID") %>>修改</a>
                        <asp:LinkButton ID="lbtnDelete" runat="server"  CommandArgument='<%# Eval("ID") %>'
                            OnClientClick="return confirm('确认删除本条信息吗？')" onclick="lbtnDelete_Click">删除</asp:LinkButton>
                    </td>
                </tr>
           </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>                </td>
            </tr>
        </table></td>
        </tr>
      <tr>
        <td height="40" colspan="5"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
          <tr>
            <td></td>
          </tr>
        </table></td>
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
