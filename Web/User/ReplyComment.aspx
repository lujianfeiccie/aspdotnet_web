<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReplyComment.aspx.cs" Inherits="ReplyComment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
     <link href="CommentList.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

 
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
            <table border="0" style="width: 592px; background-color:#E6EDF2" >
                <tr>
                    <td style="width: 93px; height: 32px;">
                        &nbsp;回复：</td>
                    <td style="width: 551px; height: 32px" align="left">
                        &nbsp;<asp:TextBox ID="txtName" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 93px; height: 42px">
                        &nbsp;留言内容：<br />
                        <font color="red"><span style="color: #000000">（200字以内）</span></font></td>
                    <td style="width: 551px; color: #000000; height: 42px" align="left">
                        &nbsp;<asp:TextBox ID="txtContent" runat="server" Height="130px" MaxLength="100" TextMode="MultiLine"
                            Width="395px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 93px; height: 31px">
                    </td>
                    <td align="left" style="width: 551px">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="发表" />
                        &nbsp;&nbsp; &nbsp;
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="重置" />
                          &nbsp;&nbsp; &nbsp;
                        <asp:Button ID="ButtonReturn" runat="server" Text="返回" OnClick="ButtonReturn_Click" /></td>
                </tr>
            </table>
   
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
