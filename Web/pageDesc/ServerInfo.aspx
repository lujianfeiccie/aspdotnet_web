<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServerInfo.aspx.cs" Inherits="ServerInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
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
</head>
<body>
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="images/mail_leftbg.gif"><img src="images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td style="height: 31px"><div class="titlebt">
            服务器配置</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="images/mail_rightbg.gif"><img src="images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="2%" valign="top">&nbsp;</td>
        <td width="7%">&nbsp;</td>
        <td width="40%" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3" valign="top"><span class="left_bt1">
            <br />
            <br />
            <span style="font-size: 12px; color: #666666">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;以下是该服务器</span></span><span class="left_txt">&nbsp;配置情况</span><span class="left_txt"></span></td>
        </tr>
      <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3" valign="top"><!--JavaScript部分-->
              <!--HTML部分-->
              <TABLE width=16% border=0 cellPadding=0 cellSpacing=0 id=secTable>
                <TBODY>
                  <TR align="center" height=20>
                    <TD align="center" class=sec2 >服务器信息统计</TD>
                  </TR>
                </TBODY>
              </TABLE>
          <TABLE class=main_tab id=mainTable cellSpacing=0
cellPadding=0 width=100% border=0>
                <!--关于TBODY标记-->
                <TBODY style="DISPLAY: block">
                  <TR>
                    <TD vAlign=top align="center"><TABLE width=98% height="210" border=0 align="center" cellPadding=0 cellSpacing=0>
                        <TBODY>
                          <TR>
                            <TD height="5" colspan="5"></TD>
                          </TR>
                          <TR>
                            <TD width="2%" height="26" background="images/news-title-bg.gif"></TD>
                            <TD height="26" colspan="4" background="images/news-title-bg.gif" class="left_txt" align="left"><font color="#FFFFFF" class="left_ts"><b></b></TD>
                          </TR>
                          <TR>
                            <TD bgcolor="#FAFBFC"></TD>
                            <TD width="16%" height="35" bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器名： </span></TD>
                            <TD width="33%" bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=System.Environment.MachineName%></span></TD>
                            <TD width="16%" bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器IP：</span></TD>
                            <TD width="33%" height="36" bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%= HttpContext.Current.Request.ServerVariables["Local_Addr"].ToString() %> </span></TD>
                          </TR>
                          <TR>
                            <TD bgcolor="#FAFBFC">&nbsp;</TD>
                            <TD height="35" bgcolor="#FAFBFC" align="right"><span class="left_txt">脚本解释引擎：</span></TD>
                            <TD bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=System.Environment.Version%> </span></TD>
                            <TD bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器端口：</span></TD>
                            <TD height="31" bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%= HttpContext.Current.Request.ServerVariables["Server_Port"].ToString() %> </span></TD>
                          </TR>
                          <TR>
                            <TD bgcolor="#FAFBFC">&nbsp;</TD>
                            <TD height="35" bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器CPU个数： </span></TD>
                            <TD bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=System.Environment.ProcessorCount %> </span></TD>
                            <TD bgcolor="#FAFBFC" align="right"><span class="left_txt">站点物理路径： </span> </TD>
                            <TD height="29" bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=HttpContext.Current.Request.PhysicalApplicationPath.ToString() %></span></TD>
                          </TR>
                          <TR>
                            <TD bgcolor="#FAFBFC">&nbsp;</TD>
                            <TD height="35" bgcolor="#FAFBFC" align="right"><span class="left_txt">开机运行时长：</span></TD>
                            <TD bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=(System.Environment.TickCount/3600000).ToString("N2")%></span></TD>
                            <TD bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器IIS版本：</span></TD>
                            <TD height="32" bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=Request.ServerVariables["SERVER_SOFTWARE"]%></span></TD>
                          </TR>
                          <TR>
                            <TD bgcolor="#FAFBFC">&nbsp;</TD>
                            <TD height="35" bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器操作系统： </span></TD>
                            <TD bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=System.Environment.OSVersion.ToString()%></span></TD>
                            <TD bgcolor="#FAFBFC" align="right"><span class="left_txt">服务器时间：</span></TD>
                            <TD height="33" bgcolor="#FAFBFC" align="left"><span class="left_txt2"><%=DateTime.Now.ToString() %> </span></TD>
                          </TR>
                          <TR>
                            <TD height="5" colspan="5"></TD>
                          </TR>
                        </TBODY>
                    </TABLE></TD>
                  </TR>
                </TBODY>
                <!--关于cells集合--><!--关于tBodies集合--><!--关于display属性-->
          </TABLE></td>
        </tr>
      <tr>
        <td height="40" colspan="3"><table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
          <tr>
            <td></td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td height="46" colspan="3" align="center"><span class="left_txt"> CopyRight &copy; 2010 深圳市疾病控制预防中心 版权所有</span>
        <br /><span class="left_txt"> 地址：深圳市罗湖区 邮编：518000</span>
        </td>
        </tr>
    </table></td>
    <td background="images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="images/mail_leftbg.gif"><img src="images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="images/buttom_bgs.gif"><img src="images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="images/mail_rightbg.gif"><img src="images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
</body>
</html>
