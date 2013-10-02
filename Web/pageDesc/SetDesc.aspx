<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SetDesc.aspx.cs" Inherits="SetLxbx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
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
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /></head>
<body>
<form runat=server>
<table width="100%" border="0" cellpadding="0" cellspacing="0" >
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
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
            <td width="14%" height="25" align="center" valign="middle"><a href="SetDesc.aspx?type=TB_SEX" class="left_bt3">性别</a></td>
            <td width="14%" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_Nationality">民族</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_Education">文化程度</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_Citizenship">国籍</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_MarriageStatus">婚姻</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_ContactHistory">接触史</a></td>
            <td height="25" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_JobCharacter">职业特征</a></td>
          </tr>
          <tr>
            <td height="28" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_InfectionWay">可能感染途径</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_DetectionClass">检测分类</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_HouseholdRegister">户籍情况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_CurrentSituation">现况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_District">居住区域</a></td>
            <td align="center" valign="middle"><span class="left_bt3"><a href="SetDesc.aspx?type=TB_SampleType">样品类型</a></span></td>
            <td height="28" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_TypeOfTreatment">治疗类型</a></td>
          </tr>
          <tr bgcolor="#f2f2f2">
            <td height="29" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_MaintainStatus">维持状况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_FirstFollowUpVisit">首次随访</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_FollowUpIntervention">随访干预</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_DetectionStatement">检测情况</a></td>
            <td align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_DetectBefore">配偶是否当年检测</a></td>
            <td height="29" align="center" valign="middle" class="left_bt3"><a href="SetDesc.aspx?type=TB_IsDead">是否死亡</a></td>
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
        <td style="height: 52px" ><table width="100%" height="144" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td height="27" background="../images/news-title-bg.gif" style="width: 13px"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
              <td align="right" background="../images/news-title-bg.gif" style="width: 44%" >
                  </td>
              <td align="left" background="../images/news-title-bg.gif" style="width: 97%" class="left_bt1">
                  <asp:Label ID="Label1" runat="server" Width="150px" style="text-align : center;"></asp:Label></td>
            <td background="../images/news-title-bg.gif" align="right" style="width: 97%" >
                &nbsp;</td>
          </tr>
          <tr >
            <td colspan="4" style="height: 30px"><asp:Repeater ID="Repeater1" runat="server" >
            <HeaderTemplate>
                <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1"  class="nowtable">
                    <tr class="left_bt3">
                        <td width="10%" height="22" align="center" >
                            编号
                        </td>
                        <td width="15%" height="22" align="center" >
                            字段名
                        </td>
                      
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("ID") %>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("Name") %>
                   </td>
                </tr>
           </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>
                
            </td>
            </tr>
          <tr>
            <td colspan="4" style="height: 5px" align="right"><webdiyer:aspnetpager id="AspNetPager1" runat="server" alwaysshow="True" backcolor="ActiveBorder"
                    bordercolor="ActiveCaptionText" borderwidth="1px" custominfohtml="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
                    custominfosectionwidth="20%" custominfotextalign="Center" firstpagetext="首页"
                    font-size="12px" font-strikeout="False" font-underline="False" forecolor="Black"
                    lastpagetext="尾页" nextpagetext="下一页" onpagechanging="AspNetPager1_PageChanging"
                    pageindexboxtype="TextBox" pagesize="20" prevpagetext="上一页" showpageindexbox="Always"
                    submitbuttontext="提交" textafterpageindexbox="页" textbeforepageindexbox="转到" urlpaging="True"
                    width="100%" wrap="False"> </webdiyer:aspnetpager></td>
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