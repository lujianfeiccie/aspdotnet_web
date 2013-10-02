<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailSfjc.aspx.cs" Inherits="DetailSfjc" %>

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
	background-color: #F8F9FA;
}
-->
</style>

<link href="../images/skin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Form1" name="form1" runat="server">
    
<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">

  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif">
    <img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif">
    
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            详细信息</div></td>
      </tr>
         </table>
    </td>
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 34px"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif" style="height: 476px">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9" style="height: 476px"><table width="100%" height="138" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td height="13" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td valign="top"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">

          <tr>
            <td><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS随访检测详细信息</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0" style="font-size:12px">
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" height="30">
                    直报号：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1037px">
                    <asp:Label ID="lblDirectReportNumber" runat="server" Width="120px"></asp:Label></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" height="30">
                    确认ID：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" style="width: 14px">
                  </td>
                  <td bgcolor="#f2f2f2"  height="30" width="45%">
                      <asp:Label ID="lblConfirmationNumber" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr style="color: #000000">
                  <td align="right" class="left_txt2" colspan="2" style="height: 30px">
                    姓名：</td>
                <td style="width: 1px; height: 30px;">&nbsp;</td>
                <td style="width: 1037px; height: 30px;">
                    <asp:Label ID="lblName" runat="server"  Width="120px"></asp:Label></td>
                  <td align="right" class="left_txt2" colspan="2" style="height: 30px">
                      身份证号：</td>
                  <td class="left_txt" style="width: 14px; height: 30px;">
                  </td>
                  <td  style="height: 30px">
                      <asp:Label ID="lblIDCard" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                      确认日期：</td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 1037px; height: 30px" >
                    <asp:Label ID="lblConfirmationDate" runat="server" Width="120px"></asp:Label></td><td align="right" class="left_txt2" colspan="2" style="height: 30px">
                    性别：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px; width: 14px;">
                  </td>
                  <td bgcolor="#f2f2f2"  style="height: 30px">
                      <asp:Label ID="lblSex" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" colspan="2" height="30">
                    可能感染途径：&nbsp;</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 1037px">
                    <asp:Label ID="lblInfectionWay" runat="server" Width="120px"></asp:Label></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    出生日期：</td>
                  <td class="left_txt" height="30" style="width: 14px">
                  </td>
                  <td  height="30">
                      <asp:Label ID="lblBirthDate" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    现住区域：</td>
                <td bgcolor="#f2f2f2" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 1037px; height: 30px;">
                    <asp:Label ID="lblDistrict" runat="server" Width="120px"></asp:Label></td>
                  <td align="right" class="left_txt2" colspan="2" height="30">
                      现况：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="width: 14px; height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                      <asp:Label ID="lblCurrentSituation" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f7f8f9" class="left_txt2" rowspan="4" style="width: 504px;
                      text-align: center">
                      <span style="font-size: 14pt; font-family: 黑体">抗<br />
                          病<br />
                          毒<br />
                          治<br />
                          疗</span></td>
                <td align="right" bgcolor="#F7F8F9" class="left_txt2" style="width: 759px; height: 30px;">
                    治疗类型：</td>
                <td bgcolor="#F7F8F9" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#F7F8F9" style="width: 1037px; height: 30px;">
                    <asp:Label ID="lblTypeOfTreatment" runat="server" Width="120px"></asp:Label></td>
                  <td align="right" bgcolor="#f7f8f9" class="left_txt2" rowspan="4" style="width: 506px; text-align: center;">
                  <span style="font-size: 14pt; font-family: 黑体">
                      随<br />
                      访<br />
                      情<br />
                      况</span></td>
                <td bgcolor="#F7F8F9" class="left_txt2" style="width: 498px; height: 30px;" align="right">
                    首次随访：</td>
                  <td bgcolor="#f7f8f9" class="left_txt" style="width: 14px; height: 30px;">
                  </td>
                  <td bgcolor="#f7f8f9" style="height: 30px">
                      <asp:Label ID="lblFirstFollowUpVisit" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#F2F2F2" class="left_txt2" style="width: 759px; height: 30px;">
                    加入时间：</td>
                <td bgcolor="#F2F2F2" style="width: 1px; height: 30px;">&nbsp;</td>
                <td bgcolor="#F2F2F2" style="width: 1037px; height: 30px;" >
                    <asp:Label ID="lblAddingTime" runat="server" Width="120px"></asp:Label></td>
                <td bgcolor="#F2F2F2" style="width: 498px; height: 30px;" align="right"><span class="left_txt2">随访干预：</span></td>
                  <td bgcolor="#f2f2f2" style="width: 14px; height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" style="height: 30px">
                      <asp:Label ID="lblFollowUpIntervention" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 759px; height: 31px;">
                    治疗号：</td>
                <td style="width: 1px; height: 31px;">&nbsp;</td>
                <td style="width: 1037px; height: 31px;">
                    <asp:Label ID="lblTreatmentNumber" runat="server" Width="120px"></asp:Label></td>
                <td style="width: 498px; height: 31px;" align="right"><span class="left_txt2">CD4：</span></td>
                  <td style="width: 14px; height: 31px;">
                  </td>
                  <td style="height: 31px">
                      <asp:Label ID="lblCD4" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 759px">
                    维持状况：&nbsp;</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1037px" >
                    <asp:Label ID="lblMaintainStatus" runat="server" Width="120px"></asp:Label></td>
                <td height="30" bgcolor="#f2f2f2" style="width: 498px" align="right"><span class="left_txt2">病毒载量：</span></td>
                  <td bgcolor="#f2f2f2" height="30" style="width: 14px">
                  </td>
                  <td bgcolor="#f2f2f2" height="30" >
                      <asp:Label ID="lblViralLoad" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" height="30" colspan="2">
                      配偶抗体检测情况：</td>
                <td style="width: 1px">&nbsp;</td>
                <td height="30" style="width: 1037px">
                    <asp:Label ID="lblSpouse_AntibodyDetection" runat="server" Width="120px"></asp:Label></td>
                  <td align="right" class="left_txt2" height="30" colspan="2">
                      配偶是否当年检测：</td>
                  <td class="left_txt" height="30" style="width: 14px">
                  </td>
                  <td  height="30">
                      <asp:Label ID="lblDetectBefore" runat="server" Width="120px"></asp:Label></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" height="30" colspan="2">
                      子女检测情况：</td>
                <td bgcolor="#f2f2f2" style="width: 1px">&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1037px">
                    <asp:Label ID="lblChildren_AntibodyDetection" runat="server" Width="120px"></asp:Label></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" height="30" colspan="2">
                    是否死亡：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" style="width: 14px">
                  </td>
                  <td bgcolor="#f2f2f2"  height="30">
                      <asp:Label ID="lblIsDead" runat="server" Width="120px"></asp:Label></td>
              </tr>
              
              <tr>
                  <td align="right"  class="left_txt2" height="30" style="width: 504px">
                  </td>
                <td height="30" align="right"  class="left_txt2" style="width: 759px">
                    备注：</td>
                <td  style="width: 1px">&nbsp;</td>
                <td  colspan="5" rowspan="2">
                    <asp:Label ID="lblRemark" runat="server" Height="54px" Width="371px"></asp:Label></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                  <td align="right" class="left_txt2" height="30" style="width: 504px">
                  </td>
                <td height="30" align="right" class="left_txt2" style="width: 759px"></td>
                <td style="width: 1px">&nbsp;</td>
              </tr>
            </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="right" style="width: 50%; height: 30px">
                 <% 
                       
                     if (Session["RoleID"].ToString().Equals(Global.Role.Admin.ToString()) || Session["RoleID"].ToString().Equals(Global.Role.SfjlAdmin.ToString())
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
    <td background="../images/mail_rightbg.gif" style="width: 34px; height: 476px;">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif" style="width: 34px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</form>
</body>
</html>
