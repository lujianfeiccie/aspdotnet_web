<%@ Page Language="C#" AutoEventWireup="true" CodeFile="top.aspx.cs" Inherits="top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>深圳市疾病预防控制中心</title>
    <base target="main"></base>
<link href="images/skin.css" rel="stylesheet" type="text/css"  />

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /><style type="text/css">
<!--
body,td,th {
	color: #000000;
}
a:link {
	color: #FFFFFF;
}
a:visited {
	color: #FFFFFF;
}
a:hover {
	color: #FF6600;
}
-->
</style></head>

<script language="JavaScript" type="text/jscript">

function logout(str){
	if (confirm("您确定要退出吗？"))
	top.location = str;
	return false;
}

</script>
<script language="JavaScript1.2" type="text/jscript">

function showsubmenu(sid) {
	var whichEl = eval("submenu" + sid);
	var menuTitle = eval("menuTitle" + sid);
	if (whichEl.style.display == "none"){
		eval("submenu" + sid + ".style.display=\"\";");
	}else{
		eval("submenu" + sid + ".style.display=\"none\";");
	}
}

</script>

<script language="JavaScript1.2" type="text/jscript">

function showsubmenu(sid) {
	var whichEl = eval("submenu" + sid);
	var menuTitle = eval("menuTitle" + sid);
	if (whichEl.style.display == "none"){
		eval("submenu" + sid + ".style.display=\"\";");
	}else{
		eval("submenu" + sid + ".style.display=\"none\";");
	}
}

</script>

<body leftmargin="0" topmargin="0">

<table width="100%" height="64" border="0" cellpadding="0" cellspacing="0" class="admin_topbg">

  <tr>
  
    <td width="48%" height="64">
        <asp:Image ID="Image1" runat="server" Height="64px" ImageUrl="~/images/logo_2.gif"
            Width="333px" /></td>
    <td width="52%" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td height="38" class="admin_txt" style="width: 68%"><b></b> &nbsp;<asp:Label ID="Label1" runat="server" Width="118px"></asp:Label>您好,感谢登陆使用！</td>
        <td width="41%" align="right" valign="middle" >
            <a href="pageUser/UpdatePwd.aspx" target="main"  ><asp:Label ID="Label3" runat="server" Text="[修改密码]"></asp:Label></a>
            <a href="#" target="_self" onclick="logout('<%=ConfigurationManager.AppSettings["HomePage"].ToString() %>');" ><asp:Label ID="Label2" runat="server" Text="[退出后台]"></asp:Label></a></td>
        <td width="4%">&nbsp;</td>
      </tr>
      <tr>
        <td colspan="3" style="height: 19px">&nbsp;</td>
        </tr>
    </table></td>
  </tr>
</table>
</body>
</html>
