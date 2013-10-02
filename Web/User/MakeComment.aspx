<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MakeComment.aspx.cs" Inherits="MakeComment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
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
-->
</style>
<script language="javascript" type="text/javascript">
// <!CDATA[

 

// ]]>
</script>
</head>
<body>
<form name="df" runat=server>
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td style="height: 31px"><div class="titlebt">欢迎界面</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td colspan="3" valign="top" align="center"><!--JavaScript部分-->
              <!--HTML部分-->
            <table border="0" style="width: 700px; height: 302px; border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid; background-color: #ccffff;">
                <tr>
                    <td style="width: 142px; height: 56px">
                        &nbsp;您的姓名：</td>
                    <td style="width: 431px; height: 56px" align="left">
                        &nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <font color="red">*（请您填写姓名）</font><asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*请您填写姓名"></asp:RequiredFieldValidator></td>
                </tr>
                <tr style="color: #000000">
                    <td style="width: 142px">
                        <span style="color: #ff0000">&nbsp;您的邮箱：</span></td>
                    <td style="width: 431px; color: #ff0000" align="left">
                        &nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><font color="red"><span
                            style="color: #000000">*（请您填写有效的电子信箱）</span></font><asp:RegularExpressionValidator
                                ID="revEmail" runat="server" ControlToValidate="txtEmail" Font-Size="9pt" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                Width="212px">输入的E-mail地址不正确，重新输入</asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td style="width: 142px; height: 28px">
                        &nbsp;您的QQ：</td>
                    <td style="width: 431px; height: 28px" align="left">
                        &nbsp;<asp:TextBox ID="txtqq" runat="server" MaxLength="15" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 142px; height: 42px">
                        &nbsp;留言内容：<br />
                        <font color="red"><span style="color: #000000">（200字以内）</span></font></td>
                    <td style="width: 431px; color: #000000; height: 42px" align="left">
                        &nbsp;<asp:TextBox ID="txtbig" runat="server" Height="130px" MaxLength="100" TextMode="MultiLine"
                            Width="395px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 24px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 142px; height: 31px">
                    </td>
                    <td align="left">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="发表" />
                        &nbsp;&nbsp; &nbsp;
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="重置" /></td>
                </tr>
            </table>
   
        </tr>
      <tr>
        <td height="40" colspan="3"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
          <tr>
            <td></td>
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
