<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailYxyb.aspx.cs" Inherits="DetailYxyb" %>

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

    <form name="form1" runat="server">
    
<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">

  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            详细信息</div></td>
      </tr>
    </table></td>
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 26px">
    <img src="../images/nav-right-bg.gif" width="16" height="29" />
    </td>
    
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif" style="height: 10px">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9" style="height: 10px"><table width="100%" height="138" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td height="13" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td valign="top" style="height: 408px"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">

          <tr>
            <td><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS阳性样本详细信息</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0" style="font-size:12px">
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px">
                    保存位置：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 280px">
                    <asp:Label ID="lblPreservePosition" runat="server" Height="20px" Width="150px"></asp:Label></td>
                <td height="30" bgcolor="#f2f2f2" class="left_txt2" style="width: 237px" align="right">
                    直报号：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td bgcolor="#f2f2f2"  height="30" width="45%">
                      <asp:Label ID="lblDirectReportNumber" runat="server" Height="20px" Width="150px"></asp:Label></td>
              </tr>
              <tr style="color: #000000">
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    确认ID：</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 280px">
                    <asp:Label ID="lblConfirmationNumber" runat="server" Height="20px" Width="150px"></asp:Label></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    确认日期：</td>
                  <td class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30">
                      <asp:Label ID="lblConfirmationDate" runat="server" Height="20px"  Width="150px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px">
                    流水号：</td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px">
                    <asp:Label ID="lblFlowNumber" runat="server" Height="20px"  Width="150px"></asp:Label></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px" align="right">
                    采样日期：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px; width: 8px;">
                  </td>
                  <td bgcolor="#f2f2f2"  style="height: 30px">
                      <asp:Label ID="lblSamplingDate" runat="server" Height="20px"  Width="150px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 224px; height: 30px;">
                    姓名：
                </td>
                <td style="width: 1px; height: 30px;">&nbsp;</td>
                <td style="width: 280px; height: 30px;">
                    <asp:Label ID="lblName" runat="server" Height="20px"  Width="150px"></asp:Label></td>
                <td class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    身份证号：</td>
                  <td class="left_txt" style="width: 8px; height: 30px;">
                  </td>
                  <td style="height: 30px">
                      <asp:Label ID="lblIDCard" runat="server" Height="20px" Width="150px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    出生日期：</td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px;">
                    <asp:Label ID="lblBirthDate" runat="server" Height="20px" Width="150px"></asp:Label></td><td height="30" class="left_txt2" style="width: 237px" align="right">
                    性别：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="width: 8px; height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" style="height: 30px">
                      <asp:Label ID="lblSex" runat="server" Height="20px" Width="150px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right"  class="left_txt2" style="width: 224px; height: 30px;">
                    样本类型：</td>
                <td  style="width: 1px; height: 30px;">&nbsp;</td>
                <td  style="width: 280px; height: 30px;">
                    <asp:Label ID="lblSampleType" runat="server" Text="Label"></asp:Label></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    可能感染途径：</td>
                  <td  style="width: 8px; height: 30px;">
                  </td>
                  <td  style="height: 30px">
                      <asp:Label ID="lblInfectionWay" runat="server" Height="20px" Width="150px"></asp:Label></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td align="right" class="left_txt2" style="width: 224px; height: 30px;">
                    CD4：</td>
                <td style="width: 1px; height: 30px;">&nbsp;</td>
                <td style="width: 280px; height: 30px;">
                    <asp:Label ID="lblCD4" runat="server" Height="20px"  Width="50px"></asp:Label>cell / ml</td>
                <td  style="width: 237px; height: 30px;" align="right"><span class="left_txt2">样本量：</span></td>
                  <td class="left_txt" style="width: 8px; height: 30px;">
                  </td>
                  <td  style="height: 30px">
                      <asp:Label ID="lblSampleSize" runat="server" Text="lblSampleSize"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right"  class="left_txt2" style="width: 224px">
                    HCV：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30"  style="width: 280px">
                    <asp:Label ID="lblHCV" runat="server" Height="20px" Width="150px"></asp:Label></td>
                <td class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    病毒载量：</td>
                  <td  class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30">
                      <asp:Label ID="lblViralLoad" runat="server" Height="20px" Width="50px"></asp:Label>Copies / ml</td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    TB：</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 280px">
                    <asp:Label ID="lblTB" runat="server" Height="20px" Width="150px"></asp:Label></td>
                <td height="30"  class="left_txt2" style="width: 237px" align="right">
                    HBV：</td>
                  <td class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30">
                      <asp:Label ID="lblHBV" runat="server" Height="20px" Width="150px"></asp:Label></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    其他：</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 280px">
                    &nbsp;<asp:Label ID="lblOthers" runat="server" Height="20px" Width="150px"></asp:Label></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    梅毒：</td>
                  <td class="left_txt" height="30" style="width: 8px">
                  </td>
                  <td  height="30">
                      <asp:Label ID="lblSyphilis" runat="server" Height="20px" Width="150px"></asp:Label></td>
              </tr>
             
              
            </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="right" style="width: 50%; height: 30px">
                 <% 
                       
                     if (Session["RoleID"].ToString().Equals(Global.Role.Admin.ToString()) || Session["RoleID"].ToString().Equals(Global.Role.YxybAdmin.ToString())
                         || Session["RoleID"].ToString().Equals(Global.Role.DataMaintenance.ToString()))
                      { %>
                  <asp:Button ID="btnUpdate" runat="server" Text="修改" Width="65px" OnClick="btnUpdate_Click" /></td>
                  <%} %>
              <td width="6%" align="right" style="height: 30px">&nbsp;</td>
              <td style="width: 46%; height: 30px;">
                  <asp:Button ID="btnBack" runat="server" Text="返回" Width="65px" OnClick="btnBack_Click" /></td>
            </tr>
          </table></td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif" style="width: 26px; height: 10px;">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif" style="width: 26px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</form>
</body>
</html>
