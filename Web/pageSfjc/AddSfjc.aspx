<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSfjc.aspx.cs" Inherits="AddSfjc" %>

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
<script type="text/javascript" src="../js/calendar.js"></script>
<script type="text/javascript" src="../js/textBox.js" ></script>


<form id="Form1" name="form1" runat="server">

<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">
  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif">
    
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            添加随访</div></td>
      </tr>
    </table>
    
    </td>
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 14px"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
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
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS随访检测信息添加</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 53px">
                    直报号：</td>
              
                <td bgcolor="#f2f2f2" style="width: 1029px; height: 53px; color: red;" class="left_txt" >
                    <asp:TextBox ID="txtDirectReportNumber1" runat="server"  style="ime-mode:disabled"  MaxLength="4" Width="41px"></asp:TextBox>
                    <asp:TextBox ID="txtDirectReportNumber2" runat="server" MaxLength="5" 
                        Style="ime-mode: disabled" Width="42px"></asp:TextBox>
                   
                    <asp:TextBox ID="txtDirectReportNumber3" runat="server" MaxLength="4" 
                      Style="ime-mode: disabled" Width="49px"></asp:TextBox>
                   
                    <asp:TextBox ID="txtDirectReportNumber4" runat="server" MaxLength="5" 
                        Style="ime-mode: disabled" Width="48px"></asp:TextBox>
                    *<asp:Button ID="btnIfExist" runat="server" OnClick="btnIfExist_Click" Text="查询已随访的次数"  /><span
                        style="font-size: 10pt; font-family: 宋体"></span>
                        <asp:Label ID="lblTimes" runat="server" Text=""></asp:Label>
                        </td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 53px">
                    确认ID：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 53px;">
                  </td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="width: 404px; height: 53px; color: red;">
                      <asp:TextBox ID="txtConfirmationNumber1" runat="server" MaxLength="4" style="ime-mode:disabled"  Width="56px"></asp:TextBox>
                      <asp:TextBox ID="txtConfirmationNumber2" runat="server" MaxLength="4" 
                          Style="ime-mode: disabled" Width="56px"></asp:TextBox>*</td>
              </tr>
              <tr style="color: #000000">
                  <td align="right" class="left_txt2" colspan="2" style="height: 30px">
                    姓名：</td>
                <td style="width: 1029px; height: 30px;">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                  <td align="right" class="left_txt2" colspan="2" style="height: 30px">
                      身份证号：</td>
                  <td class="left_txt" style="height: 30px;">
                  </td>
                  <td class="left_txt" style="height: 30px; width: 404px;">
                      <asp:TextBox ID="txtIDCard" runat="server" MaxLength="18"></asp:TextBox></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                      确认日期：</td>
                <td bgcolor="#f2f2f2" style="width: 1029px; height: 30px; color: red;" class="left_txt2">
                    <asp:TextBox ID="txtConfirmationDate" runat="server" Width="100px"></asp:TextBox>
                    *&nbsp;
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="非日期格式"
                        Operator="DataTypeCheck" Type="Date" ControlToValidate="txtConfirmationDate"></asp:CompareValidator></td><td align="right" class="left_txt2" colspan="2" style="height: 30px">
                    性别：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px;">
                  </td>
                  <td  bgcolor="#f2f2f2" style="width: 1029px; height: 30px; color: red;" class="left_txt2">
                      <asp:DropDownList ID="ddlSex" runat="server" Width="70px">
                      </asp:DropDownList></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" colspan="2" height="30">
                    可能感染途径：&nbsp;</td>
                <td height="30" style="width: 1029px">
                    <asp:DropDownList ID="ddlInfectionWay" runat="server" Width="140px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    出生日期：</td>
                  <td class="left_txt" height="30">
                  </td>
                  <td class="left_txt" height="30" style="width: 404px">
                      <asp:TextBox ID="txtBirthDate" runat="server" Width="100px"></asp:TextBox>
                      &nbsp;&nbsp;*&nbsp;
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtBirthDate"
                          ErrorMessage="非日期格式" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    现住区域：</td>
                <td bgcolor="#f2f2f2" style="width: 1029px; height: 30px;">
                    <asp:DropDownList ID="ddlDistrict" runat="server" Width="120px">
                    </asp:DropDownList></td>
                  <td align="right" class="left_txt2" colspan="2" height="30">
                      现况：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px; width: 404px;">
                      <asp:DropDownList ID="ddlCurrentSituation" runat="server" Width="70px">
                      </asp:DropDownList></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f7f8f9" class="left_txt2" rowspan="4" style="width: 311px;
                      text-align: center">
                      <span style="font-size: 14pt; font-family: 黑体">抗<br />
                          病<br />
                          毒<br />
                          治<br />
                          疗</span></td>
                <td align="right" bgcolor="#F7F8F9" class="left_txt2" style="width: 242px; height: 30px;">
                    治疗类型：</td>
                <td bgcolor="#F7F8F9" style="width: 1029px; height: 30px;">
                    <asp:DropDownList ID="ddlTypeOfTreatment" runat="server" Width="140px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f7f8f9" class="left_txt2" rowspan="4" style="width: 313px; text-align: center;">
                  <span style="font-size: 14pt; font-family: 黑体">
                      随<br />
                      访<br />
                      情<br />
                      况</span></td>
                <td bgcolor="#F7F8F9" class="left_txt2" style="width: 247px; height: 30px;" align="right">
                    首次随访：</td>
                  <td bgcolor="#f7f8f9" class="left_txt" style="height: 30px;">
                  </td>
                  <td bgcolor="#f7f8f9" class="left_txt" style="height: 30px; width: 404px;">
                    <asp:DropDownList ID="ddlFirstFollowUpVisit" runat="server" Width="110px">
                    </asp:DropDownList></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#F2F2F2" class="left_txt2" style="width: 242px; height: 30px;">
                    加入时间：</td>
                <td bgcolor="#F2F2F2" style="width: 1029px; height: 30px; color: red;" class="left_txt2">
                    <asp:TextBox ID="txtAddingTime" runat="server" Width="100px"></asp:TextBox>
                    *&nbsp;
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="非日期格式"
                        Operator="DataTypeCheck" Type="Date" ControlToValidate="txtAddingTime"></asp:CompareValidator></td>
                <td bgcolor="#F2F2F2" style="width: 247px; height: 30px;" align="right"><span class="left_txt2">随访干预：</span></td>
                  <td bgcolor="#f2f2f2" style="height: 30px;">
                  </td>
                  <td bgcolor="#f2f2f2" style="height: 30px; width: 404px;">
                    <asp:DropDownList ID="ddlFollowUpIntervention" runat="server" Width="110px">
                    </asp:DropDownList></td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 242px; height: 31px;">
                    治疗号：</td>
                <td style="width: 1029px; height: 31px; color: red;">
                    <asp:TextBox ID="txtTreatmentNumber" runat="server" Width="110px" style="ime-mode:disabled"  MaxLength="13"></asp:TextBox>
                    *</td>
                <td style="width: 247px; height: 31px;" align="right"><span class="left_txt2">CD4：</span></td>
                  <td style="height: 31px;">
                  </td>
                  <td style="height: 31px; width: 404px;">
                    <asp:TextBox ID="txtCD4" runat="server" Width="110px"></asp:TextBox><span lang="EN-US"
                        style="font-size: 10.5pt; font-family: 'Times New Roman'; mso-bidi-font-size: 12.0pt;
                        mso-fareast-font-family: 宋体; mso-font-kerning: 1.0pt; mso-ansi-language: EN-US;
                        mso-fareast-language: ZH-CN; mso-bidi-language: AR-SA">Cell/ml</span></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 242px">
                    维持状况：&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1029px" class="left_txt2">
                    <asp:DropDownList ID="ddlMaintainStatus" runat="server" Width="140px">
                    </asp:DropDownList></td>
                <td height="30" bgcolor="#f2f2f2" style="width: 247px" align="right"><span class="left_txt2">病毒载量：</span></td>
                  <td bgcolor="#f2f2f2" height="30">
                  </td>
                  <td bgcolor="#f2f2f2" height="30" class="left_txt2" style="width: 404px">
                    <asp:TextBox ID="txtViralLoad" runat="server" Width="110px"></asp:TextBox><span lang="EN-US"
                        style="font-size: 10.5pt; font-family: 'Times New Roman'; mso-bidi-font-size: 12.0pt;
                        mso-fareast-font-family: 宋体; mso-font-kerning: 1.0pt; mso-ansi-language: EN-US;
                        mso-fareast-language: ZH-CN; mso-bidi-language: AR-SA">Copies/ml</span></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" height="30" colspan="2">
                      配偶检测情况：</td>
                <td height="30" style="width: 1029px">
                    <asp:DropDownList ID="ddlSpouse_AntibodyDetection" runat="server" Width="90px">
                    </asp:DropDownList></td>
                  <td align="right" class="left_txt2" height="30" colspan="2">
                    是否死亡：</td>
                  <td class="left_txt" height="30">
                  </td>
                  <td class="left_txt" height="30" style="width: 404px">
                    <asp:DropDownList ID="ddlIsDead" runat="server" Width="70px">
                    </asp:DropDownList></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" height="30" colspan="2">
                      配偶是否当年检测：</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1029px">
                    <asp:DropDownList ID="ddlDetectBefore" runat="server" Width="90px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" height="30" colspan="2">
                      子女检测情况：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30">
                  </td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" style="width: 404px">
                    <asp:DropDownList ID="ddlChildren_AntibodyDetection" runat="server" Width="90px">
                    </asp:DropDownList></td>
              </tr>
              
              <tr>
                  <td align="right"  class="left_txt2" colspan="2" rowspan="2">
                    备注：</td>
                <td  colspan="5" rowspan="2">
                    <asp:TextBox ID="txtRemark" runat="server" Height="43px" Width="337px"></asp:TextBox></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td style="width: 16px">&nbsp;</td>
              </tr>
            </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
            <td align="right">
                  <asp:Button ID="btnSave" runat="server" Text="保存" Width="65px" OnClick="btnSave_Click" />
                  <asp:Button ID="btnWrite" runat="server" Text="录入" Width="65px" OnClick="btnWrite_Click" />
                  <asp:Button ID="btnBatchWrite" runat="server" OnClick="btnBatchWrite_Click" Text="批量录入" />
                  <asp:Button ID="btnBack" runat="server" Text="返回浏览" Width="65px" OnClick="btnBack_Click" /></td>
            </tr>
          </table></td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif" style="width: 14px; height: 476px;">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif" style="width: 14px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</form>
</body>
</html>
