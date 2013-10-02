<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateDesc.aspx.cs" Inherits="ModifyDesc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>深圳市疾病控制预防中心</title>
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
a:link {
	color: #000000;
}
a:visited {
	color: #000000;
}
a:hover {
	color: #FF6600;
}
-->
    </style>
</head>
<body>
    <form id="Form1" runat=server>
<table width="100%" border="0" cellpadding="0" cellspacing="0" >
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif">
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td style="height: 31px"><div class="titlebt">参数设置</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td valign="top">&nbsp;</td>
        </tr>
      <tr>
        <td valign="top"><table width="100%" height="130" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td colspan="2" background="../images/news-title-bg.gif" style="height: 27px"><span class="left_bt2">请选择您所需设置的字段</span></td>
            <td width="14%" background="../images/news-title-bg.gif" class="left_bt2" style="height: 27px">&nbsp;</td>
            <td width="14%" background="../images/news-title-bg.gif" class="left_bt2" style="height: 27px">&nbsp;</td>
            <td width="15%" background="../images/news-title-bg.gif" class="left_bt2" style="height: 27px">&nbsp;</td>
            <td width="15%" background="../images/news-title-bg.gif" class="left_bt2" style="height: 27px">&nbsp;</td>
            <td width="14%" background="../images/news-title-bg.gif" class="left_bt2" style="height: 27px"></td>
          </tr>
          <tr bgcolor="#f2f2f2">
            <td width="14%" height="25" align="center" valign="middle"><a href="SetDesc.aspx?type=xb" class="left_bt3">性别</a></td>
            <td width="14%" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=mz">民族</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=whcd">文化程度</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=gj">国籍</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=hy">婚姻</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=jcs">接触史</a></td>
            <td height="25" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=zytz">职业特征</a></td>
          </tr>
          <tr>
            <td height="28" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=grtj">可能感染途径</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=jcfl">检测分类</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=hjqk">户籍情况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=xz">现况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=xzqy">居住区域</a></td>
            <td align="center" valign="middle"><span class="left_bt3"><a href="SetDesc.aspx?type=yblx">样品类型与数量</a></span></td>
            <td height="28" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=kbd_zllx">治疗类型</a></td>
          </tr>
          <tr bgcolor="#f2f2f2">
            <td height="29" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=kbd_wczk">维持状况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=">首次随访</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=sf_sfgr">随访干预</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=po_ktjc">配偶抗体检测情况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=po_sfdljc">配偶是否当年检测</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=znjc">子女检测情况</a></td>
            <td height="29" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=isDead">是否死亡</a></td>
          </tr>
          <tr>
            <td height="5" colspan="7">&nbsp;</td>
          </tr>
        </table></td>
        </tr>
      <tr>
        <td>&nbsp;</td>
        </tr>
      <tr>
        <td valign="top"><table width="100%" height="144" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td height="27" background="../images/news-title-bg.gif"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
            <td background="../images/news-title-bg.gif" align="right" style="width: 97%" >&nbsp;
                </td>
          </tr>
          <tr >
            <td height="102" colspan="2" valign="top"><label></label>
                <label>
                    &nbsp;</label>
                <table width="428" border="0" align="center" cellpadding="0" cellspacing="0" style="height: 114px">
                  <tr>
                    <td style="height: 22px; width: 131px;">&nbsp;</td>
                    <td class="left_bt3" style="height: 22px; width: 252px;">
                        修改
                        <asp:Label CssClass="left_bt1" ID="Label1" runat="server" Width="144px"></asp:Label></td>
                  </tr>
                  <tr>
                    <td style="width: 131px" align="right">&nbsp;<asp:Label CssClass="left_bt3" ID="Label2" runat="server" Text="编号：" Width="53px"></asp:Label></td>
                    <td style="width: 252px">&nbsp;<asp:TextBox ID="tb_ID" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                  </tr>
                  <tr>
                    <td style="width: 131px" align="right">&nbsp;<asp:Label CssClass="left_bt3" ID="Label3" runat="server" Text="内容：" Width="53px"></asp:Label></td>
                    <td style="width: 252px">&nbsp;<asp:TextBox ID="tb_nr" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_nr"
                            ErrorMessage="*"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td style="width: 131px; height: 27px" align="right">&nbsp;</td>
                    <td style="width: 252px; height: 27px">&nbsp;<asp:Button ID="Button1" runat="server" Text="修改" Width="60px" OnClick="Button1_Click" />
                        </td>
                  </tr>
                </table></td>
            </tr>
          <tr>
            <td height="5" colspan="2">&nbsp;</td>
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
