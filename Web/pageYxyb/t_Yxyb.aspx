<%@ Page Language="C#" AutoEventWireup="true" CodeFile="t_Yxyb.aspx.cs" Inherits="t_Yxyb" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>深圳市疾病预防控制中心</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" src="../js/calendar.js"></script>
         <script type="text/javascript" src="../js/SelectAll.js"></script>
       
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
</head>

<body>
<form id="form1" runat="server">

<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
     
      <tr>
        <td height="31"><div class="titlebt">浏览信息</div></td>
      </tr>
      
    </table>
    </td>
    
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr height="10">
        <td height="29" style="height: 10px">&nbsp;</td>
          <td style="width: 155px; height: 10px">
          </td>
        <td style="height: 10px; width: 155px;" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
        <td style="height: 10px" >&nbsp;</td>
      </tr>
      <tr>
        
        
          <td colspan="5" align="center" valign="middle" class="left_bt3" style="height: 28px"><span class="left_txt">
        </span>
          <table width="100%" height="82" border="0"  style="table-layout:fixed; text-align:left;" cellpadding="0" cellspacing="0" class="line_table">
            <tr >
              <td height="28" class="left_bt2" background="../images/news-title-bg.gif" style="width: 168px"></td>
              <td background="../images/news-title-bg.gif" style="width: 179px" >&nbsp;</td>
              <td background="../images/news-title-bg.gif">&nbsp;</td>
            </tr>
            <tr>
              <td  align="center" colspan="3" class="left_txt" style="height: 21px">
                  &nbsp; &nbsp;
                  &nbsp;
                  &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</td>
            </tr>
            <tr>
              <td style="width: 168px; height: 3px; position: static;" >
                  </td>
              <td style="width: 179px; height: 3px;" ></td>
              <td style="height: 3px; width: 210px;" ></td>
            </tr>
              <tr>
                  <td style="width: 168px; height: 6px">
                     日期<asp:DropDownList ID="ddlDate" runat="server" Width="117px">
                      </asp:DropDownList></td>
                  <td style="width: 179px; height: 6px">
                      起始：<asp:TextBox ID="txtDateStart" runat="server" Width="108px"></asp:TextBox></td>
                  <td style="width: 210px; height: 6px">终止：<asp:TextBox ID="txtDateEnd" runat="server" Width="120px"></asp:TextBox></td>
              </tr>
              <tr>
                  <td style="width: 168px; height: 6px">
                      状态<asp:DropDownList ID="ddlState" runat="server" Width="127px">
                      </asp:DropDownList></td>
                  <td style="height: 3px; width: 180px;" > 感染路径<asp:DropDownList ID="ddlInfectionWay" runat="server" Width="127px"></asp:DropDownList>
              <td style="width: 179px; height: 3px;"  >
                  </td>
              </td>   
              <td style="height: 3px; width: 210px;" ></td>
                  <td style="width: 210px; height: 6px">
                  </td>
              </tr>
          </table></td>
        </tr>
      
      <tr>
        <td colspan="6" valign="top" align="right"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
            <td width="18" background="../images/news-title-bg.gif" style="width: 12px; height: 23px"><img src="../images/news-title-bg.gif" width="2" height="27" /></td>
            <td background="../images/news-title-bg.gif" class="left_bt2" style="width: 79%; height: 23px;" align="left">
                信息显示</td>
            <td width="217" background="../images/news-title-bg.gif" class="left_bt2" style="height: 23px" align="right">&nbsp;&nbsp;
              <asp:Button ID="BtnSearch" runat="server" Text="查询" Width="50px" OnClick="BtnSearch_Click" />
                </td>
          </tr>
          <tr>
            <td height="25" colspan="3" valign="top">
            <asp:Repeater ID="Repeater1" runat="server" >
            <HeaderTemplate>
                <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1"  class="nowtable" style="font-size:12px">
                    <tr class="left_bt3">
                     <td width="8%" height="22" align="center" >
                            状态
                        </td>
                        <td width="10%" height="22" align="center" >
                            保存位置
                        </td>
                        <td width="7%" height="22" align="center" >
                            确认ID
                        </td>
                        <td width="10%" height="22" align="center" >
                            确认日期
                        </td>
                        <td width="10%" height="22" align="center" >
                            流水号
                        </td>
                        <td width="15%" height="22" align="center" >
                            采样日期
                        </td>
                        <td width="10%" height="22" align="center" >
                            姓名
                        </td>
                        <td width="5%" height="22" align="center" >
                            性别
                        </td>
                        <td width="5%" height="22" align="center" >
                            操作人
                        </td>
                        
                        <td width="20%" height="22" align="center" >
                            操作
                        </td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                  <%if (Session["RoleID"].ToString().Equals(Global.Role.Admin.ToString()) || Session["RoleID"].ToString().Equals(Global.Role.YxybAdmin.ToString())
                         || Session["RoleID"].ToString().Equals(Global.Role.DataMaintenance.ToString()))
                     { %>
                    <td height="20" align="center" bgcolor="#EFF6FE" class="left_txt2" width="70">
                        <asp:CheckBox ID="cbx" runat="server" Visible='<%# Global.InfoState.beChecked(Eval("FK_Flag").ToString()) %>' key='<%# Eval("ID") %> ' />
                        <%# Eval("FK_Flag") %>
                    </td>
                          
                   <%
                     }
                     else
                     { 
                      %>
                     <td height="20" align="center" bgcolor="#EFF6FE"  class="left_txt2">
                        <%# Eval("FK_Flag")%>
                    </td>
                                  
                   <% }%>
                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("PreservePosition")%>
                    </td>

                    <td height="20" align="center" bgcolor="#EFF6FE" >
                        <%# Eval("ConfirmationNumber")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE">
                        <%# Eval("ConfirmationDate")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" class="typename">
                        <%# Eval("FlowNumber")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" class="typename">
                        <%# Eval("SamplingDate")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" class="typename">
                        <%# Eval("Name")%>
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" class="typename">
                          <%# Eval("FK_Sex") %>
                  
                    </td>
                    <td height="20" align="center" bgcolor="#EFF6FE" class="typename">
                        <%# Eval("FK_User")%>
                    </td>
                   
                    <td height="20" align="center" bgcolor="#EFF6FE">
                    <a href=DetailYxyb.aspx?ID=<%# Eval("ID") %> >详细</a>
                       <% 
                       
                           if (Session["RoleID"].ToString().Equals(Global.Role.Admin.ToString()) || Session["RoleID"].ToString().Equals(Global.Role.YxybAdmin.ToString())
                         || Session["RoleID"].ToString().Equals(Global.Role.DataMaintenance.ToString()))
                           { %>
                   
                        <asp:LinkButton ID="lbtnDelete" runat="server"  CommandArgument='<%# Eval("ID") %>'
                            OnClientClick="return confirm('确认删除本条信息吗？')" onclick="lbtnDelete_Click">删除</asp:LinkButton>
                              <asp:LinkButton ID="lbtnRecovery" runat="server"  CommandArgument='<%# Eval("ID") %>'
                            OnClientClick="return confirm('确认还原本条信息吗？')" onclick="lbtnRecovery_Click" Visible='<%# Eval("FK_Flag").ToString()==Global.Role.Admin.ToString()?false:true %>'>还原</asp:LinkButton>
                            <% } %>
                            
                    </td>
                </tr>
           </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>                </td>
            </tr>
            <tr>
          <td colspan=3 align="right">
          <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
            CustomInfoSectionWidth="20%" CustomInfoTextAlign="Center" FirstPageText="首页"
            LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
            UrlPaging="True" Width="100%" Wrap="False" BackColor="ActiveBorder" BorderColor="ActiveCaptionText" Font-Size="12px" Font-Strikeout="False" 
            Font-Underline="False" ForeColor="Black" PageIndexBoxType="TextBox" ShowPageIndexBox="Always" SubmitButtonText="提交" TextAfterPageIndexBox="页" 
            TextBeforePageIndexBox="转到" BorderWidth="1px" PageSize="20" OnPageChanging="AspNetPager1_PageChanging" >
        </webdiyer:AspNetPager>
          </td>
          </tr>
        </table>
          
        </td>
    </tr>
    <tr >
    <td style="height: 25px">
        &nbsp;</td>
        <td align="left" colspan="1" style="height: 25px">
            <asp:CheckBox ID="checkbox" runat="server"  Text="全选" /><asp:Button
                ID="BtnVerify" runat="server" Height="22px" OnClick="BtnVerify_Click" OnClientClick="return delIt()"
                Text="审核" Width="53px" /></td>
    <td colspan=4 style="height: 25px" align="right">
        &nbsp; &nbsp;&nbsp;
    </td>
    </tr>
      <tr>
        <td colspan="6" style="height: 40px">
        <table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
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