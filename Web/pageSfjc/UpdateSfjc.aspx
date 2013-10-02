<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateSfjc.aspx.cs" Inherits="UpdateSfjc" %>

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
    <script type="text/javascript" src="../js/calendar.js">
 
    </script>
    <script type="text/javascript" src="../js/textBox.js" ></script>
    
<form id="Form1" name="form1" runat="server">

<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">

  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif">
    <img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif">
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            修改随访</div></td>
      </tr>
    </table>
    </td>
    
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 34px">
    <img src="../images/nav-right-bg.gif" width="16" height="29" />
    </td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif" style="height: 476px">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9" style="height: 476px">
    <table width="100%" height="138" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td height="13" valign="top" style="width: 925px">&nbsp;</td>
      </tr>
      <tr>
        <td valign="top" style="width: 925px"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">

          <tr>
            <td style="width: 890px"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="nowtable">
              <tr>
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS随访检测信息修改</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td style="height: 414px; width: 890px;"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" height="30">
                    直报号：</td>
                
                <td height="30" bgcolor="#f2f2f2" style="width: 1021px" class="left_txt" >
                    <asp:TextBox ID="txtDirectReportNumber1" runat="server"  style="ime-mode:disabled" OnKeyPress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}" MaxLength="18" Enabled="true" Width="46px"></asp:TextBox><asp:TextBox
                        ID="txtDirectReportNumber2" runat="server" MaxLength="5" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                        Style="ime-mode: disabled" Width="46px"></asp:TextBox><asp:TextBox ID="txtDirectReportNumber3" runat="server"
                            MaxLength="4" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                            Style="ime-mode: disabled" Width="46px"></asp:TextBox><asp:TextBox ID="txtDirectReportNumber4" runat="server"
                                MaxLength="5" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                                Style="ime-mode: disabled" Width="46px"></asp:TextBox></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" height="30">
                    确认ID：</td>
                
                  <td bgcolor="#f2f2f2" class="left_txt" height="30" width="45%">
                      <asp:TextBox ID="txtConfirmationNumber1" runat="server" MaxLength="10" style="ime-mode:disabled" OnKeyPress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}" Width="78px"></asp:TextBox>
                      <asp:TextBox ID="txtConfirmationNumber2" runat="server" MaxLength="4" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                          Style="ime-mode: disabled" Width="73px"></asp:TextBox></td>
              </tr>
              <tr style="color: #000000">
                  <td align="right" class="left_txt2" colspan="2" style="height: 30px">
                    姓名：</td>
                <td style="width: 1021px; height: 30px;">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                  <td align="right" class="left_txt2" colspan="2" style="height: 30px">
                      身份证号：</td>
                  <td class="left_txt" style="height: 30px">
                      <asp:TextBox ID="txtIDCard" runat="server" MaxLength="18"></asp:TextBox></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                      确认日期：</td>
                <td bgcolor="#f2f2f2" style="width: 1021px; height: 30px" class="left_txt2">
                    <asp:TextBox ID="txtConfirmationDate" runat="server" Width="100px"></asp:TextBox>
                    &nbsp;
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="非日期格式"
                        Operator="DataTypeCheck" Type="Date" ControlToValidate="txtConfirmationDate"></asp:CompareValidator></td><td align="right" class="left_txt2" colspan="2" style="height: 30px">
                    性别：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                      <asp:DropDownList ID="ddlSex" runat="server" Width="70px">
                      </asp:DropDownList></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" colspan="2" height="30">
                    可能感染途径：&nbsp;</td>
                <td height="30" style="width: 1021px">
                    <asp:DropDownList ID="ddlInfectionWay" runat="server" Width="140px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    出生日期：</td>
                  <td class="left_txt" height="30">
                      <asp:TextBox ID="txtBirthDate" runat="server" Width="100px"></asp:TextBox>
                      &nbsp;&nbsp;
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtBirthDate"
                          ErrorMessage="非日期格式" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    现住区域：</td>
                <td bgcolor="#f2f2f2" style="width: 1021px; height: 30px;">
                    <asp:DropDownList ID="ddlDistrict" runat="server" Width="120px">
                    </asp:DropDownList></td>
                  <td align="right" class="left_txt2" colspan="2" height="30">
                      现况：</td><td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                      <asp:DropDownList ID="ddlCurrentSituation" runat="server" Width="70px">
                      </asp:DropDownList></td>
              </tr>
              <tr>
                  <td align="right" bgcolor="#f7f8f9" class="left_txt2" rowspan="4" style="width: 243px;
                      text-align: center">
                      <span style="font-size: 14pt; font-family: 黑体">抗<br />
                          病<br />
                          毒<br />
                          治<br />
                          疗</span></td>
                <td align="right" bgcolor="#F7F8F9" class="left_txt2" style="width: 1334px; height: 30px;">
                    治疗类型：</td>
                <td bgcolor="#F7F8F9" style="width: 1021px; height: 30px;">
                    <asp:DropDownList ID="ddlTypeOfTreatment" runat="server" Width="140px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f7f8f9" class="left_txt2" rowspan="4" style="width: 506px; text-align: center;">
                  <span style="font-size: 14pt; font-family: 黑体">
                      随<br />
                      访<br />
                      情<br />
                      况</span></td>
                <td bgcolor="#F7F8F9" class="left_txt2" style="width: 675px; height: 30px;" align="right">
                    首次随访：</td>
                  <td bgcolor="#f7f8f9" class="left_txt" style="height: 30px">
                    <asp:DropDownList ID="ddlFirstFollowUpVisit" runat="server" Width="110px">
                    </asp:DropDownList></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#F2F2F2" class="left_txt2" style="width: 1334px; height: 30px;">
                    加入时间：</td>
                <td bgcolor="#F2F2F2" style="width: 1021px; height: 30px;" class="left_txt2">
                    <asp:TextBox ID="txtAddingTime" runat="server" Width="100px"></asp:TextBox>
                    &nbsp;
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="非日期格式"
                        Operator="DataTypeCheck" Type="Date" ControlToValidate="txtAddingTime"></asp:CompareValidator></td>
                <td bgcolor="#F2F2F2" style="width: 675px; height: 30px;" align="right"><span class="left_txt2">随访干预：</span></td>
                  <td bgcolor="#f2f2f2" style="height: 30px">
                    <asp:DropDownList ID="ddlFollowUpIntervention" runat="server" Width="110px">
                    </asp:DropDownList></td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 1334px; height: 31px;">
                    治疗号：</td>
                <td style="width: 1021px; height: 31px;">
                    <asp:TextBox ID="txtTreatmentNumber" runat="server" Width="110px" style="ime-mode:disabled" OnKeyPress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}" MaxLength="13"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTreatmentNumber"
                        ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td style="width: 675px; height: 31px;" align="right"><span class="left_txt2">CD4：</span></td>
                  <td style="height: 31px">
                    <asp:TextBox ID="txtCD4" runat="server" Width="110px"></asp:TextBox></td>
              </tr>
              <tr>
                <td height="30" align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 1334px">
                    维持状况：&nbsp;</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1021px" class="left_txt2">
                    <asp:DropDownList ID="ddlMaintainStatus" runat="server" Width="140px">
                    </asp:DropDownList></td>
                <td height="30" bgcolor="#f2f2f2" style="width: 675px" align="right"><span class="left_txt2">病毒载量：</span></td>
                  <td bgcolor="#f2f2f2" height="30" class="left_txt2">
                    <asp:TextBox ID="txtViralLoad" runat="server" Width="110px"></asp:TextBox></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" height="30" colspan="2">
                      配偶抗体检测情况：</td>
                <td height="30" style="width: 1021px">
                    <asp:DropDownList ID="ddlSpouse_AntibodyDetection" runat="server" Width="90px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" colspan="2" style="height: 30px">
                    是否死亡：</td>
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                    <asp:DropDownList ID="ddlIsDead" runat="server" Width="70px">
                    </asp:DropDownList></td>
              </tr>
              <tr>
                  <td align="right" class="left_txt2" height="30" colspan="2">
                      配偶是否当年检测：</td>
                  <td class="left_txt" height="30">
                    <asp:DropDownList ID="ddlDetectBefore" runat="server" Width="90px">
                    </asp:DropDownList></td>
                  <td align="right" bgcolor="#f2f2f2" class="left_txt2" height="30" colspan="2">
                      子女检测情况：</td>
                <td height="30" bgcolor="#f2f2f2" style="width: 1021px">
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
                <td style="width: 5px">&nbsp;</td>
              </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="right" style="width: 50%; height: 30px">
                  <asp:Button ID="btnUpdate" runat="server" Text="确定" Width="65px" OnClick="btnUpdate_Click" /></td>
              <td width="6%" align="right" style="height: 30px">&nbsp;</td>
              <td style="width: 46%; height: 30px;">
                  <asp:Button ID="btnBack" runat="server" Text="返回" Width="65px" OnClick="btnBack_Click" /></td>
            </tr>
             
           
          </table></td>
      </tr>
    </table></td>
  </tr>
</table>
</form>
</body>
</html>
