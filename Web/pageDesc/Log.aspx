<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Log.aspx.cs" Inherits="Log" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市疾病预防控制中心</title>
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
-->
</style>
<script type="text/javascript" src="../js/calendar.js"></script>
 <script type="text/javascript" src="../js/SelectAll.js"></script>
</head>
<body>


    <form id="form1" runat="server">
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
     <tr>
      <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">
            浏览日志</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr height="10">
        <td height="29" style="height: 10px">&nbsp;</td>
        <td style="height: 10px; width: 155px;" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
      </tr>
      <tr>
        <td colspan="5" align="center" valign="middle" class="left_bt3" style="height: 25px; font-weight: bold;"><span class="left_txt">
        </span>
          <table width="100%" height="82" border="0" cellpadding="0" cellspacing="0" class="line_table">
            <tr >
              <td height="28" class="left_bt2" background="../images/news-title-bg.gif" style="width: 101px">查找条件</td>
              <td background="../images/news-title-bg.gif" style="width: 50px">&nbsp;</td>
              <td background="../images/news-title-bg.gif" style="width: 40px">&nbsp;</td>
              <td background="../images/news-title-bg.gif" style="width: 110px">&nbsp;</td>
              <td background="../images/news-title-bg.gif" style="width: 40px">&nbsp;</td>
                <td background="../images/news-title-bg.gif" style="width: 110px">
                </td>
              <td width="479" background="../images/news-title-bg.gif">&nbsp;</td>
            </tr>
            <tr class="left_txt2">
              <td align="right" style="width: 101px; height: 28px;" ></td>
              <td style="width: 50px; height: 28px;" align="left" >
                  日期：</td>
              <td align="left" style="height: 28px; width: 40px;" >
                  起始</td>
              <td style="height: 28px; width: 110px;" align="left" >
                  <asp:TextBox ID="txtDateStart" runat="server" Width="90px"></asp:TextBox></td>
              <td style="height: 28px; width: 40px;" align="left" >
                  终止</td>
                <td align="left" style="width: 110px; height: 28px">
                    <asp:TextBox ID="txtDateEnd" runat="server" Width="90px"></asp:TextBox></td>
              <td style="height: 28px" align="left" >
                  <asp:Button ID="BtnSearch" runat="server" Text="查询" Width="50px" OnClick="BtnSearch_Click" /></td>
            </tr>
            <tr>
              <td height="25" style="width: 101px" >&nbsp;</td>
              <td style="width: 50px" ></td>
              <td style="width: 40px" ></td>
              <td style="width: 110px" ></td>
              <td style="width: 40px" ></td>
                <td style="width: 110px">
                </td>
              <td ></td>
            </tr>
          </table></td>
        </tr>
      
      <tr>
        <td colspan="5" valign="top" style="height: 33px" align="right"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td background="../images/news-title-bg.gif" style="width: 1022px; height: 23px" align="left" class="left_bt2">
                信息显示</td>
            <td background="../images/news-title-bg.gif" class="left_bt2" style="width: 410px; height: 23px;" align="left">
                </td>
            <td width="217" background="../images/news-title-bg.gif" class="left_bt2" style="height: 23px" align="right">&nbsp;&nbsp;&nbsp;
            </td>
          </tr>
          <tr>
            <td colspan="3" valign="top" align="left" style="height: 25px"><asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1"  class="nowtable">
                    <tr class="left_bt3">
                        <td width="5%" height="22" align="center" >
                            
                        </td>
                        <td width="10%" height="22" align="center" >
                            ID
                        </td>
                        <td width="15%" height="22" align="center" >
                            操作人
                        </td>
                        <td width="15%" height="22" align="center" >
                            操作位置
                        </td>
                        <td width="20%" height="22" align="center" >
                            操作
                        </td>
                        <td width="25%" height="22" align="center" >
                            时间
                        </td> 
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td height="25" align="center" bgcolor="#EFF6FE" >
                        <asp:CheckBox ID="cbx" runat="server" key= <%# Eval("ID") %> />
                    </td>
                    <td height="25" align="center" bgcolor="#EFF6FE" >
                        <asp:Label id="lbl" Text=<%# Eval("ID") %> runat="server" ></asp:Label>
                    </td>
                    <td height="25" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("FK_User")%>
                    </td>
                    <td height="25" align="center" bgcolor="#EFF6FE">
                        <%# Eval("OperatingPosition")%>
                    </td>
                    <td height="25" align="center" bgcolor="#EFF6FE" class="typename">
                        <%# Eval("Operation")%>
                    </td>
                    <td height="25" align="center" bgcolor="#EFF6FE" class="typename">
                      <%# Eval("OperationDate")%>
                    </td>
                </tr>
           </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>
        
            </td>
          </tr>
          <tr bgcolor=e1e5ee height=25>
          <td colspan=3 ><webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="true" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
            CustomInfoSectionWidth="20%" CustomInfoTextAlign="Center" FirstPageText="首页"
            LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
            UrlPaging="True" Width="100%" Wrap="False" BackColor="ActiveBorder" BorderColor="ActiveCaptionText" Font-Size="12px" Font-Strikeout="False" 
            Font-Underline="False" ForeColor="Black" PageIndexBoxType="TextBox" ShowPageIndexBox="Always" SubmitButtonText="提交" TextAfterPageIndexBox="页" 
            TextBeforePageIndexBox="转到" BorderWidth="1px" PageSize="20" OnPageChanging="AspNetPager1_PageChanging"  >
        </webdiyer:AspNetPager></td>
          </tr>
          <tr>
          <td style="width: 1022px; height: 33px" align="left" class="left_bt2">
              <asp:CheckBox ID="cbx" runat="server" onclick="selectAll(this)" Text="全选"/>
              &nbsp;&nbsp; &nbsp;<asp:Button ID="btnDelete" runat="server" Height="26px" Text="删除"
                  Width="55px"  OnClientClick="return delIt()"  OnClick="lbtnDelete_Click"/>&nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;
              &nbsp;</td>
          <td style="height: 33px; width: 410px;">
          
          </td>
          <td style="height: 33px" align="right">
              <asp:Button ID="btnExport" runat="server" Text="导出到Excel" OnClick="btnExport_Click" /></td>
          </tr>
        </table>
            </td>
    </tr>
      <tr>
        <td height="40" colspan="5"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
          <tr>
            <td style="height: 1px"></td>
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
