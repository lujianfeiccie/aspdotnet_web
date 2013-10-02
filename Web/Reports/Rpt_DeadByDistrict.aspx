<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rpt_DeadByDistrict.aspx.cs" Inherits="Rpt_DeadByDistrict" %>

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
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="images/left-top-right.gif" width="17" height="29" /></td>
    
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      
      <tr>
        <td height="31"><div class="titlebt">数据统计</div></td>
      </tr>
      
    </table>
    
    </td>
    
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr height="10">
        <td style="height: 10px; width: 155px;" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
      </tr>
      <tr>
        <td colspan="4" align="center" valign="middle" class="left_bt3" style="height: 25px"><span class="left_txt">
        </span>
          </td>
        </tr>
      
      <tr>
        <td colspan="4" valign="top" style="height: 32px" align="right"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td width="18" background="../images/news-title-bg.gif" style="width: 12px; height: 23px"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
            <td background="../images/news-title-bg.gif" class="left_bt2" style="width: 95%; height: 23px;" align="center">
                按分区统计</td>
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
                        <asp:BoundField DataField="HIV本年" HeaderText="今年感染HIV例数" />
                        <asp:BoundField DataField="AIDS本年" HeaderText="今年感染AIDS例数" />
                        <asp:BoundField DataField="本年死亡" HeaderText="今年死亡例数" />
                        <asp:BoundField DataField="HIV" HeaderText="累积感染HIV例数" />
                        <asp:BoundField DataField="AIDS" HeaderText="累积感染AIDS例数" />
                        <asp:BoundField DataField="死亡" HeaderText="累积死亡例数" />
                    </Columns>
                </asp:GridView>
            </td>
          </tr>
        </table>
          
        </td>
    </tr>
    <tr >
    <td colspan=4 style="height: 25px" align="left">
        <asp:CheckBox ID="cbSettings" runat="server" AutoPostBack="True" OnCheckedChanged="cbSettings_CheckedChanged"
            Text="高级设置" />&nbsp;
            <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="导出到Excel" /></td>
    </tr>
      <tr>
        <td colspan="4" >
            &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Panel ID="Panel1" runat="server" Height="100%" Visible="False" Width="100%">
                <asp:CheckBox ID="cbDistrict" runat="server" Text="地区" /><asp:CheckBox ID="cbHivThisYear" runat="server" Text="今年感染HIV例数" /><asp:CheckBox
                    ID="cbAidsThisYear" runat="server" Text="今年感染AIDS例数" /><asp:CheckBox ID="cbDiedThisYear" runat="server" Text="今年死亡例数" /><asp:CheckBox
                        ID="cbHiv" runat="server" Text="累积感染HIV例数" /><asp:CheckBox ID="cbAids" runat="server" Text="累积感染AIDS例数" /><asp:CheckBox
                            ID="cbDeath" runat="server" Text="累积死亡例数" />
                <asp:CheckBox ID="cbSelectAll" runat="server" AutoPostBack="True" OnCheckedChanged="cbSelectAll_CheckedChanged"
                    Text="全选/全不选" /></asp:Panel>
        </td>
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
