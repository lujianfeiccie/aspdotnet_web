<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateUser.aspx.cs" Inherits="UpdateUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市疾病预防控制中心</title>
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
<link href="../images/skin.css" rel="stylesheet" type="text/css" />
</head>
<body>

    <form id="form1" runat="server">
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
    
  <tr>
  
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            修改用户</div></td>
      </tr>
    </table></td>
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 17px"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="53%" valign="top">&nbsp;</td>
        <td width="7%">&nbsp;</td>
        <td width="40%" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3" valign="top"><span class="left_txt">
</span>
          <table width="100%" height="111" border="0" cellpadding="0" cellspacing="0" class="line_table">
            <tr>
              <td width="255" height="27" background="../images/news-title-bg.gif"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
              <td colspan="2"  background="../images/news-title-bg.gif" class="left_bt2"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 修改用户信息</td>
              <td width="242" background="../images/news-title-bg.gif" class="left_bt2">&nbsp;</td>
            </tr>
            <tr>
              <td height="30" >&nbsp;</td>
              <td width="125"  align="right" style="width: 125px">
                  用户名：</td>
              <td width="348" >
                  <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                      ErrorMessage="*"></asp:RequiredFieldValidator></td>
              <td height="28" ></td>
            </tr>
              <tr>
                  <td style="height: 30px">
                  </td>
                  <td align="right" style="width: 125px; height: 26px">
                      用户类型：</td>
                  <td style="height: 26px">
                      <asp:DropDownList ID="ddlUserRoleType" runat="server" Width="128px">

                      </asp:DropDownList></td>
                  <td style="height: 26px">
                  </td>
              </tr>
              <tr>
                  <td style="height: 30px">
                  </td>
                  <td align="right" style="width: 125px; height: 26px">
                      真实姓名：</td>
                  <td style="height: 26px">
                      <asp:TextBox ID="txtTrueName" runat="server"></asp:TextBox></td>
                  <td style="height: 26px">
                  </td>
              </tr>
			            <tr>
              <td style="height: 30px" >&nbsp;</td>
              <td style="width: 125px; height: 30px" align="right" >&nbsp;
                  </td>
              <td style="height: 30px" >
                  <asp:Button ID="btnConfirm" runat="server" Text="修改" Width="50px" OnClick="btnConfirm_Click" /></td>
              <td style="height: 30px" ></td>
            </tr>
          </table></td>
        </tr>

    </table></td>
    <td background="../images/mail_rightbg.gif" style="width: 17px">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif" style="width: 17px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </form>
</body>
</html>
