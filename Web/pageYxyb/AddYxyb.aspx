<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddYxyb.aspx.cs" Inherits="AddYxyb" %>

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

 <script type="text/javascript" src="../js/calendar.js"></script>

  <script type="text/jscript" src="../js/textBox.js"></script>
   <script type="text/javascript" language="javascript">
     function textBoxClick()
     {
        document.getElementById("Button1").click();
       
     }
     function textFloorClick()
     {
        document.getElementById("Button3").click();
       
     }
     function textHeClick()
     {
        document.getElementById("Button4").click();
       
     }
     function gridClick(text)
     {
        document.getElementById("txtInsideBoxID").value=text;
         document.getElementById("Button2").click();
     }
     function gridFloorClick(text)
     {
        document.getElementById("txtFloor").value=text;
         document.getElementById("Button2").click();
     }
     function gridHeClick(text)
     {
        document.getElementById("txtBoxID").value=text;
         document.getElementById("Button2").click();
     }
     function textClear()
     {
        document.getElementById("txtInsideBoxID").value='';  
     }
     function textFloorClear()
     {
        document.getElementById("txtFloor").value='';  
     }
     function textHeClear()
     {
        document.getElementById("txtBoxID").value='';  
     }
    </script>
</head>

<body>



<form name="form1" runat="server">

<table border="0" cellpadding="0" cellspacing="0" style="width: 99%">
  
  <tr>
  
    <td width="17" height="29" valign="top" background="../images/mail_leftbg.gif">
    <img src="../images/left-top-right.gif" width="17" height="29" />
    </td>
    <td width="935" height="29" valign="top" background="../images/content-bg.gif">
    <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            添加信息</div></td>
      </tr>
    </table>
    </td>
    
    <td valign="top" background="../images/mail_rightbg.gif" style="width: 28px">
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
                <td class="left_bt2" style="height: 30px">&nbsp;&nbsp;&nbsp;&nbsp;HIV/AIDS阳性样本信息添加</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td style="height: 379px"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              
              <tr bgcolor= #f2f2f2>
                <td align="right" class="left_txt2" style="width: 99px; height: 30px;">
                    直报号：</td>
                <td style="width: 358px; color: red; height: 30px;" class="left_txt">
                      <asp:TextBox ID="txtDirectReportNumber1" runat="server" style="ime-mode:disabled"  MaxLength="18" Width="51px"></asp:TextBox>
                      <asp:TextBox ID="txtDirectReportNumber2" runat="server" MaxLength="18" 
                          Style="ime-mode: disabled" Width="51px"></asp:TextBox>
                      <asp:TextBox ID="txtDirectReportNumber3" runat="server" MaxLength="18" 
                          Style="ime-mode: disabled" Width="51px"></asp:TextBox>
                      <asp:TextBox ID="txtDirectReportNumber4" runat="server" MaxLength="18" 
                          Style="ime-mode: disabled" Width="51px"></asp:TextBox>
                      &nbsp; &nbsp;*<asp:Button ID="btnIfExist" runat="server" OnClick="btnIfExist_Click"
                        Text="查询记录数" /><asp:Label ID="lblTimes" runat="server" Text=""></asp:Label></td>
                <td class="left_txt2" style="width: 101px; height: 30px;" align="right">
                    确认ID：</td>
                 
                  <td class="left_txt" style="color: red; height: 30px; width: 314px;" colspan="2">
                      <asp:TextBox ID="txtConfirmationNumber1" runat="server" style="ime-mode:disabled"  MaxLength="10" Width="72px"></asp:TextBox>
                    <asp:TextBox ID="txtConfirmationNumber2" runat="server" MaxLength="10" 
                        Style="ime-mode: disabled" Width="71px"></asp:TextBox>
                    &nbsp; &nbsp;*</td>
              </tr>
              <tr style="color: #000000">
                <td align="right"  class="left_txt2" style="height: 30px;" >
                    保存位置：</td>
                <td  class="left_txt2" style="width: 568px"  >
                    冰箱号：<asp:TextBox ID="txtIceBox" runat="server" style="ime-mode:disabled"  Width="32px" MaxLength="2" OnTextChanged="txtIceBox_TextChanged"></asp:TextBox>
                    冻存架位置：
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Width="1px" Height="1px"/>
                    <asp:TextBox ID="txtFloor" runat="server" Width="23px" ></asp:TextBox>
                    &nbsp;&nbsp;  冻存盒位置：<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Width="1px" Height="1px"/><asp:TextBox ID="txtBoxID" runat="server" Width="35px" style="ime-mode:disabled"  MaxLength="3" OnTextChanged="txtBoxID_TextChanged"></asp:TextBox> 
                  &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" TabIndex="1" Text="ButtonForGrid"
                          Width="1px" Height="1px" /><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ButtonForState"
                              Width="1px" Height="1px"  />盒内编号：<asp:TextBox ID="txtInsideBoxID" runat="server" Width="40px" ></asp:TextBox>&nbsp;
                      
                   </td>
                  <td class="left_txt2" >
                          <asp:Table ID="Table1" runat="server" Height="0px" Width="32px">
                          </asp:Table>
                  </td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 99px; height: 30px">
                    流水号：</td>
                <td bgcolor="#f2f2f2" style="width: 358px; height: 30px" class="left_txt">
                    <asp:TextBox ID="txtFlowNumber" runat="server"></asp:TextBox></td>
                <td bgcolor="#f2f2f2" class="left_txt2" style="width: 101px; height: 30px" align="right">
                    确认日期：</td>
                  
                  <td bgcolor="#f2f2f2" class="left_txt" style="height: 30px; color: red; width: 314px;" colspan="2">
                      &nbsp; &nbsp;
                    <asp:TextBox ID="txtConfirmationDate" runat="server" Width="100px"></asp:TextBox>
                      *&nbsp; &nbsp; &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="非日期格式" ControlToValidate="txtConfirmationDate" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
              </tr>
              <tr>
                <td height="30" align="right" class="left_txt2" style="width: 99px">
                    姓名：
                </td>
                <td height="30" style="width: 358px; color: red;">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    *</td>
                <td height="30" class="left_txt2" style="width: 101px" align="right" >
                    采样日期：</td>
                 
                  <td colspan="2" class="left_txt" height="30" style="color: red; width: 222px;">
                      <asp:TextBox ID="txtSamplingDate" runat="server" Width="100px"></asp:TextBox>
                      *&nbsp; &nbsp; &nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="非日期格式" ControlToValidate="txtSamplingDate" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
              </tr>
              <tr>
                <td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 99px; height: 30px;">
                    身份证号：</td>
                  <td bgcolor="#f2f2f2" style="width: 358px; height: 30px;" class="left_txt">
                      <asp:TextBox ID="txtIDCard" runat="server" MaxLength="18"></asp:TextBox></td>
                <td bgcolor="#f2f2f2"  class="left_txt2" style="width: 101px; height: 30px;" align="right">
                    出生日期：</td>
                  
                  <td colspan="2" bgcolor="#f2f2f2" class="left_txt" style="height: 30px; color: red; width: 222px;">
                    <asp:TextBox ID="txtBirthDate" runat="server" Width="100px"></asp:TextBox>
                      *
                    &nbsp;&nbsp; &nbsp;
                      <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="非日期格式" ControlToValidate="txtBirthDate" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
              </tr>
              <tr><td align="right" bgcolor="#f2f2f2" class="left_txt2" style="width: 99px; height: 30px;">
                    性别：</td>
                <td bgcolor="#f2f2f2" style="width: 358px; height: 30px;" class="left_txt">
                      <asp:DropDownList ID="ddlSex" runat="server" Width="70px">
                      </asp:DropDownList></td>
                <td  style="width: 101px; height: 30px;"  align="right"><span class="left_txt2">
                    可能感染途径：</span></td>
                  
                  <td colspan="2" style="height: 30px; width: 222px;">
                    <asp:DropDownList ID="ddlInfectionWay" runat="server" Width="150px">
                    </asp:DropDownList></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td align="right"  class="left_txt2" style="width: 99px; height: 30px;">
                    样本类型：</td>
                <td  style="width: 358px; height: 30px;">
                    <asp:DropDownList ID="ddlSampleType" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;
                </td>
                <td class="left_txt2" style="width: 101px; height: 30px;" align="right">
                    CD4：</td>
                  
                  <td  colspan="2" style="height: 30px; width: 222px;" class="left_bt2">
                    <asp:TextBox ID="txtCD4" runat="server" Width="90px"></asp:TextBox>cell / ml</td>
              </tr>
              <tr>
                <td align="right" class="left_txt2" style="width: 99px; height: 30px;">
                    样本量：</td>
                <td style="width: 358px; height: 30px;">
                    &nbsp;<asp:DropDownList ID="ddlSampleSize" runat="server">
                    </asp:DropDownList></td>
                <td height="30"  class="left_txt2" style="width: 101px" align="right">
                    HCV：</td>
                  
                  <td colspan="2" class="left_txt" height="30" style="width: 222px">
                      
                      <asp:DropDownList ID="ddlHCV" runat="server" Width="155px" >
                      </asp:DropDownList></td>
              </tr>
              <tr bgcolor="#f2f2f2">
                <td height="30" align="right"  class="left_txt2" style="width: 99px">
                    病毒载量：</td>
                <td height="30"  style="width: 358px">
                      <asp:TextBox ID="txtViralLoad" runat="server" Width="100px"></asp:TextBox>
                    Copies / ml</td>
                <td height="30" class="left_txt2" style="width: 101px" align="right">
                    HBV：</td>
                  
                  <td colspan="2" class="left_txt" height="30" style="width: 222px">
                     
                      <asp:DropDownList ID="ddlHBV" runat="server" Width="158px">
                      </asp:DropDownList></td>
              </tr>
              <tr >
                <td align="right" class="left_txt2" style="width: 99px; height: 30px;">
                    TB：</td>
                <td style="width: 358px; height: 30px;">
                    
                    <asp:DropDownList ID="ddlTB" runat="server" Width="146px">
                    </asp:DropDownList></td>
                      <td class="left_txt2" style="width: 101px; height: 30px;" align="right">
                          其他：</td>
                  
                  <td  colspan="2" style="height: 30px; width: 222px;" class="left_bt2">
                      <asp:TextBox ID="txtOthers" runat="server" Width="150px"></asp:TextBox>&nbsp; &nbsp;&nbsp; &nbsp; (合并感染)</td>
              </tr>
              <tr>
                <td align="right"  class="left_txt2" style="width: 99px; height: 30px;">
                    梅毒：</td>
                  <td align="left"   style="height: 30px; width: 358px;">
                    
                      <asp:DropDownList ID="ddlSyphilis" runat="server" Width="145px">
                      </asp:DropDownList></td>
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
    <td background="../images/mail_rightbg.gif" style="width: 28px; height: 10px;">&nbsp;</td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
      <td height="17" valign="top" background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17" /></td>
    <td background="../images/mail_rightbg.gif" style="width: 28px"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</form>
</body>
</html>
