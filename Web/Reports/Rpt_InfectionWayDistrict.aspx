<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rpt_InfectionWayDistrict.aspx.cs" Inherits="Rpt_InfectionWayDistrict" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>深圳市疾病预防控制中心</title>
	<link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="../css/GridView.css" rel="stylesheet" type="text/css" />
	<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #EEF2FB;
}
a:hover {
	color: #FF6600;
}
.STYLE2 {font-size: 12px; color: #000000;}
-->
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /></head>
<body>


    <form id="form1" runat="server">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">数据统计</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr height="10">
        <td height="29" style="height: 10px; width: 13px;">&nbsp;</td>
        <td style="height: 10px; width: 155px;" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
      </tr>
      <tr>
        <td colspan="5" align="center" valign="middle" class="left_bt3" style="height: 25px"><span class="left_txt">
        </span>
          </td>
        </tr>
      
      <tr>
        <td colspan="5" valign="top" style="height: 32px" align="left"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td width="18" background="../images/news-title-bg.gif" style="width: 12px; height: 23px"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
            <td background="../images/news-title-bg.gif" class="left_bt2" style="width: 95%; height: 23px;" align="center">
                按传播途径分区统计</td>
            <td width="217" background="../images/news-title-bg.gif" class="left_bt2" style="height: 23px" align="right">&nbsp;&nbsp;&nbsp;
            </td>
          </tr>
          <tr>
            <td height="25" colspan="3" valign="top" align="center">
                <asp:GridView ID="GridView1" CssClass="GridViewStyle" runat="server" AutoGenerateColumns="False">
                      <FooterStyle CssClass="GridViewFooterStyle" />
            <RowStyle CssClass="GridViewRowStyle" />   
            <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
            <PagerStyle CssClass="GridViewPagerStyle" />
            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
            <HeaderStyle CssClass="GridViewHeaderStyle" />
                    <Columns>
                        <asp:BoundField DataField="地区" HeaderText="地区" />
                        <asp:BoundField DataField="异性传播" HeaderText="异性传播例数" />
                        <asp:BoundField DataField="异性传播%" HeaderText="异性传播(%)" DataFormatString="{0}%"/>
                        <asp:BoundField DataField="同性/双性传播" HeaderText="同性/双性传播例数" />
                        <asp:BoundField DataField="同性/双性传播%" HeaderText="同性/双性传播(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="注射毒品" HeaderText="注射毒品例数" />
                        <asp:BoundField DataField="注射毒品%" HeaderText="注射毒品(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="采血(浆)" HeaderText="采血(浆)例数" />
                        <asp:BoundField DataField="采血(浆)%" HeaderText="采血(浆)(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="输血/血制品" HeaderText="输血/血制品例数" />
                        <asp:BoundField DataField="输血/血制品%" HeaderText="输血/血制品(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="母婴传播" HeaderText="母婴传播例数" />
                        <asp:BoundField DataField="母婴传播%" HeaderText="母婴传播(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="性接触+注射毒品" HeaderText="性接触+注射毒品例数" />
                        <asp:BoundField DataField="性接触+注射毒品%" HeaderText="性接触+注射毒品(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="职业暴露" HeaderText="职业暴露例数" />
                        <asp:BoundField DataField="职业暴露%" HeaderText="职业暴露(%)"  DataFormatString="{0}%" />
                        <asp:BoundField DataField="其他" HeaderText="其他例数" />
                        <asp:BoundField DataField="其他%" HeaderText="其他(%)"   DataFormatString="{0}%"/>
                        <asp:BoundField DataField="不详" HeaderText="不详例数" />
                        <asp:BoundField DataField="不详%" HeaderText="不详(%)"  DataFormatString="{0}%"/>
                        <asp:BoundField DataField="合计" HeaderText="合计" />
                    </Columns>
                </asp:GridView>
            </td>
          </tr>
          <tr>
          <td colspan=3 align="right">
          </td>
          </tr>
        </table>
            <asp:CheckBox ID="cbSettings" runat="server" Text="高级设置" AutoPostBack="True" OnCheckedChanged="cbSettings_CheckedChanged" />
            <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="导出到Excel" /></td>
    </tr>
        <tr>
            <td style="height: 25px; width: 13px;">
            </td>
            <td align="left" colspan="4">
               <asp:Panel ID="Panel1" runat="server" Height="100%" Width="100%" Visible="False">
                   &nbsp;<asp:CheckBox ID="cbDistrict" runat="server" Text="地区"/>
        <asp:CheckBox ID="cbOppositeSex" runat="server" Text="异性传播" />
        <asp:CheckBox ID="cbOppositeSexPer" runat="server" Text="异性传播%"/>
        <asp:CheckBox ID="cbSameSexOrBigender" runat="server" Text="同性/双性传播"/>
        <asp:CheckBox ID="cbSameSexOrBigenderPer" runat="server"  Text="同性/双性传播%" />&nbsp;
        <asp:CheckBox ID="cbInjection" runat="server" Text="注射" />
        <asp:CheckBox ID="cbInjectionPer" runat="server" Text="注射%"/>
        <asp:CheckBox ID="cbBloodCollection" runat="server"  Text="采血(浆)" />&nbsp;
        <asp:CheckBox ID="cbBloodCollectionPer" runat="server" Text="采血(浆)%" />
        <asp:CheckBox ID="cbBloodTransfusion" runat="server" Text="输血/血制品"/>
                <asp:CheckBox ID="cbBloodTransfusionPer" runat="server" Text="输血/血制品%"/>
        <asp:CheckBox ID="cbMotherToBaby" runat="server" Text="母婴传播" />
        <asp:CheckBox ID="cbMotherToBabyPer" runat="server" Text="母婴传播%" />
        <asp:CheckBox ID="cbSexualContactAndInjection" runat="server" Text="性接触+注射毒品" />
        <asp:CheckBox ID="cbSexualContactAndInjectionPer" runat="server" Text="性接触+注射毒品%" />
        <asp:CheckBox ID="cbOccupationalExposure" runat="server" Text="职业暴露" />
        <asp:CheckBox ID="cbOccupationalExposurePer" runat="server" Text="职业暴露%" />
        <asp:CheckBox ID="cbOthers" runat="server" Text="其他" />
        <asp:CheckBox ID="cbOthersPer" runat="server" Text="其他%" />
        <asp:CheckBox ID="cbUnknown" runat="server"  Text="不详" />
        <asp:CheckBox ID="cbUnknownPer" runat="server"  Text="不详%" />
        <asp:CheckBox ID="cbAmount" runat="server" Text="合计"/>
        <asp:CheckBox ID="cbSelectAll" runat="server" AutoPostBack="True" OnCheckedChanged="cbSelectAll_CheckedChanged"
                       Text="全选/全不选" /></asp:Panel>
            </td>
        </tr>
   
    </form>
     
</body>
</html>
