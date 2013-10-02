<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateDraftYxyb.aspx.cs" Inherits="UpdateYxyb" %>

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
    <script type="text/javascript" src="../js/calendar.js">
    </script>
    <script type="text/javascript" src="../js/textBox.js" ></script>
    <form name="form1" runat="server" id="Form1">
    
<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">

  <tr>
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif">
    <img src="../images/left-top-right.gif" width="17" height="29" />
    </td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif">
    
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            修改信息</div>
            </td>
      </tr>
    </table>
    </td>
    
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
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS阳性样本信息修改</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    保存位置：</td>
               
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px;">
                    <asp:TextBox ID="txtPreservePosition" runat="server"></asp:TextBox>
                    </td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    直报号：</td>
             
                  <td bgcolor="#f2f2f2" width="45%" style="height: 30px">
                      <asp:TextBox ID="txtDirectReportNumber1" runat="server" MaxLength="18" Width="50px"></asp:TextBox><asp:TextBox
                          ID="txtDirectReportNumber2" runat="server" MaxLength="5" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                          Style="ime-mode: disabled" Width="53px"></asp:TextBox><asp:TextBox ID="txtDirectReportNumber3" runat="server"
                              MaxLength="4" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                              Style="ime-mode: disabled" Width="53px"></asp:TextBox><asp:TextBox ID="txtDirectReportNumber4" runat="server"
                                  MaxLength="5" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                                  Style="ime-mode: disabled" Width="52px"></asp:TextBox></td>
              </tr>
              <tr style="color: #000000">
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    确认ID：</td>
               
                <td height="30" style="width: 280px">
                      <asp:TextBox ID="txtConfirmationNumber1" runat="server" MaxLength="10" Width="68px"></asp:TextBox>
                    <asp:TextBox ID="txtConfirmationNumber2" runat="server" MaxLength="4" onkeypress="if(((event.keyCode>=48)&&(event.keyCode <=57))||(event.keyCode==46)) {event.returnValue=true;} else{event.returnValue=false;}"
                        Style="ime-mode: disabled" Width="73px"></asp:TextBox></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    确认日期：</td>
                
                  <td class="left_txt" height="30">
                    <asp:TextBox ID="txtConfirmationDate" runat="server" Width="100px"></asp:TextBox></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px">
                    流水号：</td>
              
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px">
                    <asp:TextBox ID="txtFlowNumber" runat="server" Enabled="False"></asp:TextBox></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px" align="right">
                    采样日期：</td>
                
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                      <asp:TextBox ID="txtSamplingDate" runat="server" Width="100px"></asp:TextBox></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 224px">
                    姓名：
                </td>
              
                <td height="30" style="width: 280px">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    性别：</td>
                
                  <td class="left_txt" height="30">
                      <asp:DropDownList ID="ddlSex" runat="server" Width="70px">
                      </asp:DropDownList></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    身份证号：</td>
              
                <td bgcolor="#f2f2f2" style="width: 280px; height: 30px;">
                    <asp:TextBox ID="txtIDCard" runat="server" MaxLength="18"></asp:TextBox></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    可能感染途径：</td>
                 
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                    <asp:DropDownList ID="ddlInfectionWay" runat="server" Width="150px">
                    </asp:DropDownList></td>
              </tr>
                <tr><td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px;">
                    出生日期：</td>
                    <td bgcolor="#f2f2f2" style="width: 280px; height: 30px">
                    <asp:TextBox ID="txtBirthDate" runat="server" Width="100px"></asp:TextBox></td>
                    <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 237px; height: 30px">
                        样本量：</td>
                    <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px">
                        <asp:DropDownList ID="ddlSampleSize" runat="server" Width="138px">
                        </asp:DropDownList></td>
                </tr>
              <tr bgcolor="#F2F2F2">
                    <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 224px; height: 30px">
                        样本类型：</td>
              
                <td style="width: 280px; height: 30px;">
                        <asp:DropDownList ID="ddlSampleType" runat="server" Width="128px">
                        </asp:DropDownList></td>
                <td style="width: 237px; height: 30px;" align="right"><span class="left_txt2" style="background-color: #f2f2f2">
                    CD4：</span></td>
               
                  <td style="height: 30px">
                    <asp:TextBox ID="txtCD4" runat="server" Width="90px"></asp:TextBox>cell / ml</td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td align="right" class="left_txt2" style="width: 224px; height: 30px;">
                    HCV：</td>
              
                <td style="width: 280px; height: 30px;">
                    &nbsp;<asp:DropDownList ID="ddlHCV" runat="server" Width="140px">
                    </asp:DropDownList></td>
                <td class="left_txt2" style="width: 237px; height: 30px;" align="right">
                    病毒载量：</td>
                 
                  <td  style="height: 30px">
                      <asp:TextBox ID="txtViralLoad" runat="server" Width="100px"></asp:TextBox>
                      
                          Copies / ml</td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 224px; height: 30px;">
                    TB：</td>
               
                <td height="30"  style="width: 280px">
                    &nbsp;<asp:DropDownList ID="ddlTB" runat="server" Width="137px" >
                    </asp:DropDownList></td>
                <td height="30"  class="left_txt2" style="width: 237px" align="right">
                    HBV：</td>
               
                  <td  class="left_txt" height="30">
                      &nbsp;<asp:DropDownList ID="ddlHBV" runat="server" Width="160px">
                      </asp:DropDownList></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td height="30" align="right"  class="left_txt2" style="width: 224px">
                    梅毒：</td>
             
                <td height="30" style="width: 280px">
                    &nbsp;<asp:DropDownList ID="ddlSyphilis" runat="server" Width="159px">
                      </asp:DropDownList></td>
                <td height="30" class="left_txt2" style="width: 237px" align="right">
                    其他：</td>
                
                  <td class="left_txt" height="30">
                      &nbsp;<asp:TextBox ID="txtOthers" runat="server" Width="150px"></asp:TextBox>(合并感染)</td>
              </tr>
            </table></td>
          </tr>
        </table>
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="right" >
                  <asp:Button ID="btnUpdate" runat="server" Text="提交" Width="65px" OnClick="btnUpdate_Click" />
                  <asp:Button ID="Button1" runat="server" Text="保存" Width="65px" OnClick="btnSave_Click" />
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
