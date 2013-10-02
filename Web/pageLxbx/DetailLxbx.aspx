<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailLxbx.aspx.cs" Inherits="DetailLxbx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市疾病控制预防中心</title>
	<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #F8F9FA;
}
-->
</style>

<link href="../images/skin.css" rel="stylesheet" type="text/css" />

</head>
<body>

<form name="form1" runat="server">

<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">
  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif">
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            详细信息</div></td>
      </tr>
    </table></td>
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 6px"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td height="71" valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="100%" height="138" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td height="13" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td valign="top"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td style="width: 908px"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS流行病学详细信息</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td style="width: 908px"><table width="100%" border="0" cellspacing="0" cellpadding="0" style="font-size:12px">
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px">
                    直报号：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 280px"><asp:Label ID="lblDirectReportNumber" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td height="30" bgcolor="#f2f2f2" class="left_txt2" style="width: 237px" align="right">
                    确认ID：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td bgcolor="#f2f2f2"  height="30" style="width: 409px" >
                      <asp:Label ID="lblConfirmationNumber" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr style="color: #000000">
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    姓名：</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 280px">
                    <asp:Label ID="lblName" runat="server" Width="100%" Height="20px"></asp:Label></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    身份证：</td>
                  <td class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30" style="width: 409px">
                      <asp:Label ID="lbID_Card" runat="server" Width="100%" Height="20px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px">
                    性别：</td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px">
                    &nbsp;<asp:Label ID="lblSex" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px" align="right">
                    民族：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px; width: 8px;">
                  </td>
                  <td bgcolor="#f2f2f2"  style="height: 30px; width: 409px;">
                    <asp:Label ID="lblNationality" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    文化程度：
                </td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 280px">
                    <asp:Label ID="lblEducation" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    出生日期：</td>
                  <td class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30" style="width: 409px">
                      <asp:Label ID="lblBirthDate" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    户籍情况：</td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px;">
                    <asp:Label ID="lblHouseholdRegister" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    国籍：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="width: 8px; height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" style="height: 30px; width: 409px;">
                      &nbsp;<asp:Label ID="lblCitizenship" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#F7F8F9" class="left_txt2" style="width: 224px">
                    可能感染途径：</td>
                <td bgcolor="#F7F8F9" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#F7F8F9" style="width: 280px">
                    <asp:Label ID="lblInfactionWay" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td height="30" bgcolor="#F7F8F9" class="left_txt2" style="width: 237px" align="right">
                    户籍地址：</td>
                  <td bgcolor="#f7f8f9" class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td bgcolor="#f7f8f9"  height="30" style="width: 409px">
                    <asp:Label ID="lblProvince" runat="server" Height="20px" Width="47%"></asp:Label>
                      <asp:Label ID="lblCounty" runat="server" Height="20px" Width="48%"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#F2F2F2" class="left_txt2" style="width: 224px; height: 30px;">
                    职业特征：</td>
                <td bgcolor="#F2F2F2" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#F2F2F2" style="width: 280px; height: 30px;">
                    <asp:Label ID="lblJobCharacter" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td bgcolor="#F2F2F2" style="width: 237px; height: 30px;" align="right"><span class="left_txt2">
                    现住区域：</span></td>
                  <td bgcolor="#f2f2f2" style="width: 8px; height: 30px; background-color: #f7f8f9;">
                  </td>
                  <td bgcolor="#f2f2f2" style="height: 30px; width: 409px;">
                      <asp:Label ID="lblDistrict" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    婚姻状况：</td>
                <td style="width: 1px; font-size: 12pt; font-family: Times New Roman;">&nbsp;</td>
                <td height="30" style="width: 280px; font-size: 12pt; font-family: Times New Roman;">
                    <asp:Label ID="lblMarriageStatus" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td height="30" style="width: 237px; font-size: 12pt; font-family: Times New Roman;" align="right"><span class="left_txt2">
                    现况：</span></td>
                  <td height="30" style="width: 8px; font-size: 12pt; font-family: Times New Roman;">
                  </td>
                  <td height="30" style="font-size: 12pt; width: 409px; font-family: Times New Roman">
                      <asp:Label ID="lblCurrentSituation" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr style="font-size: 12pt; font-family: Times New Roman">
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    阳性判定日期：
                </td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px;">
                    <asp:Label ID="lblPositiveDecisionDate" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td bgcolor="#f2f2f2" style="width: 237px; height: 30px;" align="right"><span class="left_txt2">
                    是否死亡：</span></td>
                  <td bgcolor="#f2f2f2" style="width: 8px; height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" style="width: 409px; height: 30px;">
                    <asp:Label ID="lblIsDead" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    转AIDS日期：</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 280px">
                      <asp:Label ID="lblToAidsDate" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    送检单位：</td>
                  <td class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30" style="width: 409px">
                      <asp:Label ID="lblCensorshipUnit" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px">
                    配偶：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 280px">
                    <asp:Label ID="lblSpouse" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td height="30" bgcolor="#f2f2f2" class="left_txt2" style="width: 237px" align="right">
                    接触史：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td bgcolor="#f2f2f2"  height="30" style="width: 409px">
                      <asp:Label ID="lblContactHistory" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 224px; height: 30px;">
                    小孩：</td>
                <td style="width: 1px; height: 30px;">&nbsp;</td>
                <td style="width: 280px; height: 30px;">
                      <asp:Label ID="lblChildren" runat="server" Height="20px" Width="100%"></asp:Label></td>
                <td class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    检测分类：</td>
                  <td class="left_txt" style="width: 8px; height: 30px;">
                  </td>
                  <td  style="height: 30px; width: 409px;">
                      <asp:Label ID="lblDetectionClass" runat="server" Height="20px" Width="100%"></asp:Label></td>
              </tr>
              
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px">
                    备注：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td bgcolor="#f2f2f2" colspan="4" rowspan="2">
                    <asp:Label ID="lblRemark" runat="server" Height="50px" Width="100%"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px"></td>
                <td style="width: 1px">&nbsp;</td>
              </tr>
            </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <% 
                       
                  if (Session["RoleID"].ToString().Equals(Global.Role.Admin.ToString()) || Session["RoleID"].ToString().Equals(Global.Role.LxblAdmin.ToString())
                      || Session["RoleID"].ToString().Equals(Global.Role.DataMaintenance.ToString()))
                  { %>
              <td align="right" style="width: 50%; height: 30px">
                  <asp:Button ID="btnUpdate" runat="server" Text="修改" Width="65px" OnClick="btnUpdate_Click" /></td>
                  <%} %>
              <td width="6%" align="right" style="height: 30px">&nbsp;</td>
              <td style="width: 46%; height: 30px;">
                  <asp:Button ID="btnBack" runat="server" Text="返回" Width="65px" OnClick="btnBack_Click" /></td>
            </tr>

          </table></td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif" style="width: 6px">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif" style="width: 6px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</form>
</body>
</html>
