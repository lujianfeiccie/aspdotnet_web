<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddLxbx.aspx.cs" Inherits="AddLxbx" %>

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
<script type="text/javascript" src="../js/calendar.js" ></script>
<script type="text/javascript" src="../js/textBox.js" ></script>
 
 


<form name="myForm" runat="server" id="Form1">

<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">
  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            添加信息</div></td>
      </tr>
    </table></td>
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 16px"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
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
            <td style="height: 50px"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS流行病学信息添加</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 35px;">
                    直报号：</td>
                
                <td bgcolor="#f2f2f2" style="width: 532px; height: 35px; color: red;" class="left_txt" >
                
                    <asp:TextBox ID="txtDirectReportNumber1"  runat="server"  style="ime-mode:disabled" Width="46px"></asp:TextBox>&nbsp;
                    <asp:TextBox ID="txtDirectReportNumber2"  runat="server" 
                        Style="ime-mode: disabled" Width="46px"></asp:TextBox>&nbsp;
                    <asp:TextBox ID="txtDirectReportNumber3"  runat="server" 
                        Style="ime-mode: disabled" Width="46px"></asp:TextBox>&nbsp;
                    <asp:TextBox ID="txtDirectReportNumber4"  runat="server" 
                        Style="ime-mode: disabled" Width="46px"></asp:TextBox>&nbsp;
                        *
                  
   <span style="font-size: 10.5pt; color: blue; font-family: 宋体; mso-bidi-font-size: 12.0pt;
                        mso-ascii-font-family: 'Times New Roman'; mso-hansi-font-family: 'Times New Roman';
                        mso-bidi-font-family: 'Times New Roman'; mso-font-kerning: 1.0pt; mso-ansi-language: EN-US;
                        mso-fareast-language: ZH-CN; mso-bidi-language: AR-SA"></span></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 262px; height: 35px;" align="right">
                    确认ID：</td>
                 
                  <td bgcolor="#f2f2f2" class="left_txt" width="45%" style="height: 35px; color: red;">
                      <asp:TextBox ID="txtConfirmationNumber1" runat="server" MaxLength="4" Style="ime-mode: disabled" Width="76px"></asp:TextBox><asp:TextBox ID="txtConfirmationNumber2" runat="server" MaxLength="4" style="ime-mode:disabled"  Width="73px"></asp:TextBox>* &nbsp;&nbsp;
                  </td>
              </tr>
              <tr style="color: #000000">
                <td align="right" class="left_txt2" style="width: 224px; height: 30px;">
                    姓名：</td>
                <td style="width: 532px; height: 30px; color: red;">
                    <asp:TextBox ID="txtName" runat="server" MaxLength="10"></asp:TextBox>*</td>
                <td class="left_txt2" style="width: 262px; height: 30px;" align="right">
                    身份证号：</td>
                  <td class="left_txt" style="height: 30px; color: red;">
                      <asp:TextBox ID="txtIDCard" runat="server" MaxLength="18"></asp:TextBox>*</td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" classW="left_txt2" style="font-size: 12px">
                    性别：</td>
                <td bgcolor="#f2f2f2" style="width: 532px; height: 30px">
                      <asp:DropDownList ID="ddlSex" runat="server" Width="70px"></asp:DropDownList></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 262px; height: 30px" align="right">
                    民族：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px; color: red;">
                      &nbsp;&nbsp;<asp:DropDownList ID="ddlNationality" runat="server" Width="120px" >
                    </asp:DropDownList>&nbsp;</td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    文化程度：
                </td>
                <td height="30" style="width: 532px">
                    <asp:DropDownList ID="ddlEducation" runat="server" Width="120px"></asp:DropDownList></td>
                <td height="30" class="left_txt2" style="width: 262px" align="right">
                    出生日期：</td>
                  <td class="left_txt" height="30" style="color: red">
                      <asp:TextBox ID="txtBirthDate" runat="server" Width="100px"></asp:TextBox>*
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtBirthDate"
                          ErrorMessage="非日期格式" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    户籍情况：</td>
                <td bgcolor="#f2f2f2" style="width: 532px; height: 30px;">
                    <asp:DropDownList ID="ddlHouseholdRegister" runat="server" Width="120px"></asp:DropDownList></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 262px; height: 30px;" align="right">
                    国籍：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                      <asp:DropDownList ID="ddlCitizenship" runat="server" Width="93px"></asp:DropDownList></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#F7F8F9" class="left_txt2" style="width: 224px">
                    可能感染途径：</td>
                <td height="30" bgcolor="#F7F8F9" style="width: 532px">
                    <asp:DropDownList ID="ddlInfectionWay" runat="server" Width="150px"></asp:DropDownList></td><td bgcolor="#f2f2f2" class="left_txt2" style="width: 262px; height: 30px;" align="right">
                    现住区域：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                      <asp:DropDownList ID="ddlDistrict" runat="server" Width="120px">
                    </asp:DropDownList>
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtDetailedAddress" runat="server" Width="130px"></asp:TextBox></td>
                     <td bgcolor="#f7f8f9" class="left_txt" height="30">
                      </td>
                 
              </tr>
              <tr>
                <td align="right" bgcolor="#F2F2F2" class="left_txt2" style="width: 224px; height: 30px;">
                    职业特征：</td>
                <td bgcolor="#F2F2F2" style="width: 532px; height: 30px;">
                    <asp:DropDownList ID="ddlJobCharacter" runat="server" Width="150px"></asp:DropDownList></td>
                <td height="30" bgcolor="#F7F8F9" class="left_txt2" style="width: 262px" align="right">
                    户籍地址：</td>
                    <td bgcolor="#f2f2f2" style="height: 30px">
                    <asp:DropDownList ID="ddlProvince" runat="server" Width="150px"></asp:DropDownList>  </asp:TextBox><asp:TextBox ID="txtCounty" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    阳性判定日期：&nbsp;</td>
                <td height="30" style="width: 532px">
                    &nbsp;<asp:TextBox ID="txtPositiveDecisionDate" runat="server" Width="100px"></asp:TextBox><asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="非日期格式" ControlToValidate="txtPositiveDecisionDate" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
                <td height="30" style="width: 262px" align="right"><span class="left_txt2">
                    是否死亡：</span></td>
                  <td height="30">
                    <asp:DropDownList ID="ddlIsDead" runat="server" Width="70px"></asp:DropDownList></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px">
                    转AIDS日期：</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 532px; color: red;" class="left_txt2">
                    &nbsp;<asp:TextBox ID="txtToAidsDate" runat="server" Width="100px"></asp:TextBox>*<asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtToAidsDate"
                          ErrorMessage="非日期格式" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
                <td height="30" bgcolor="#f2f2f2" style="width: 262px" align="right"><span class="left_txt2">现况：</span></td>
                  <td bgcolor="#f2f2f2" height="30" class="left_txt2">
                      <asp:DropDownList ID="ddlCurrentSituation" runat="server" Width="70px"></asp:DropDownList></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    婚姻状况：</td>
                <td height="30" style="width: 532px; color: red;" class="left_txt2">
                    <asp:DropDownList ID="ddlMarriageStatus" runat="server" Width="170px"></asp:DropDownList>*</td>
                <td height="30" class="left_txt2" style="width: 262px" align="right">
                    送检单位：</td>
                  <td class="left_txt" height="30" style="color: red">
                      <asp:TextBox ID="txtCensorshipUnit" runat="server" Width="200px"></asp:TextBox></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px">
                     配偶检测情况：</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 532px">
                    <asp:DropDownList ID="ddlSpouse_AntibodyDetection" runat="server"></asp:DropDownList>
                    <asp:TextBox ID="txtSpouse" runat="server" Width="84px"></asp:TextBox></td>
                <td height="30" bgcolor="#f2f2f2" class="left_txt2" style="width: 262px" align="right">
                    接触史：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" height="30">
                      <asp:DropDownList ID="ddlContactHistory" runat="server" Width="170px"></asp:DropDownList></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    子女检测情况：</td>
                <td height="30" style="width: 532px">
                    &nbsp;<asp:DropDownList ID="ddlChildren_AntibodyDetection" runat="server">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtChildren" runat="server" Width="78px"></asp:TextBox></td>
                <td height="30" class="left_txt2" style="width: 262px" align="right">
                    检测分类：</td>
                  <td class="left_txt" height="30">
                      <asp:DropDownList ID="ddlDetectionClass" runat="server" Width="170px"></asp:DropDownList></td>
              </tr>
              
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px" rowspan="2">
                    备注：</td>
                <td bgcolor="#f2f2f2" colspan="4" rowspan="2">
                    <asp:TextBox ID="txtRemark" runat="server" Height="43px" Width="337px"></asp:TextBox></td>
              </tr>
              <tr>
                <td style="width: 3px">&nbsp;</td>
              </tr>
            </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
            <td align="right" >
                  <asp:Button ID="btnSave" runat="server" Text="保存" Width="65px" OnClick="btnSave_Click"  />
                  <asp:Button ID="btnWrite" runat="server" Text="录入" Width="65px" OnClick="btnWrite_Click"  />
                  <asp:Button ID="btnBatchWrite" runat="server"  Text="批量录入" OnClick="btnBatchWrite_Click" />
                  <asp:Button ID="btnBack" runat="server" Text="返回浏览" Width="65px" OnClick="btnBack_Click"  /></td>
            </tr>
          </table></td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif" style="width: 16px; height: 476px;">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif" style="width: 16px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</form>
</body>
</html>
