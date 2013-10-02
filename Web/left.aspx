<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市疾病预防控制中心</title>
	<script src="js/prototype.lite.js" type="text/javascript"></script>
<script src="js/moo.fx.js" type="text/javascript"></script>
<script src="js/moo.fx.pack.js" type="text/javascript"></script>

<style>
body {
	font:12px Arial, Helvetica, sans-serif;
	color: #000;
	background-color: #EEF2FB;
	margin: 0px;
}
#container {
	width: 182px;
}
H1 {
	font-size: 12px;
	margin: 0px;
	width: 182px;
	cursor: pointer;
	height: 30px;
	line-height: 20px;	
}
H1 a {
	display: block;
	width: 182px;
	color: #000;
	height: 30px;
	text-decoration: none;
	moz-outline-style: none;
	background-image: url(images/menu_bgS.gif);
	background-repeat: no-repeat;
	line-height: 30px;
	text-align: center;
	margin: 0px;
	padding: 0px;
}
.content{
	width: 182px;
	height: 26px;
	
}
.MM ul {
	list-style-type: none;
	margin: 0px;
	padding: 0px;
	display: block;
}
.MM li {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	line-height: 26px;
	color: #333333;
	list-style-type: none;
	display: block;
	text-decoration: none;
	height: 26px;
	width: 182px;
	padding-left: 0px;
}
.MM {
	width: 182px;
	margin: 0px;
	padding: 0px;
	left: 0px;
	top: 0px;
	right: 0px;
	bottom: 0px;
	clip: rect(0px,0px,0px,0px);
}
.MM a:link {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	line-height: 26px;
	color: #333333;
	background-image: url(images/menu_bg1.gif);
	background-repeat: no-repeat;
	height: 26px;
	width: 182px;
	display: block;
	text-align: center;
	margin: 0px;
	padding: 0px;
	overflow: hidden;
	text-decoration: none;
}
.MM a:visited {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	line-height: 26px;
	color: #333333;
	background-image: url(images/menu_bg1.gif);
	background-repeat: no-repeat;
	display: block;
	text-align: center;
	margin: 0px;
	padding: 0px;
	height: 26px;
	width: 182px;
	text-decoration: none;
}
.MM a:active {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	line-height: 26px;
	color: #333333;
	background-image: url(images/menu_bg1.gif);
	background-repeat: no-repeat;
	height: 26px;
	width: 182px;
	display: block;
	text-align: center;
	margin: 0px;
	padding: 0px;
	overflow: hidden;
	text-decoration: none;
}
.MM a:hover {
	font-family: Arial, Helvetica, sans-serif;
	font-size: 12px;
	line-height: 26px;
	font-weight: bold;
	color: #006600;
	background-image: url(images/menu_bg.gif);
	background-repeat: no-repeat;
	text-align: center;
	display: block;
	margin: 0px;
	padding: 0px;
	height: 26px;
	width: 182px;
	text-decoration: none;
}
</style>
</head>
<body>
  
    <form id="form1" runat="server">
    <table width="100%" height="280" border="0" cellpadding="0" cellspacing="0" bgcolor="#EEF2FB">
  <tr>
    <td valign="top" style="width: 181px">
    <div id="container">
      <h1 class="type"><a href="javascript:void(0)">HIV/AIDS病例报告管理</a></h1>
      <div class="content">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td><img src="images/menu_topline.gif" width="182" height="5" /></td>
          </tr>
        </table>
        <ul class="MM">
          <li  id="add1"><a href="pageLxbx/AddLxbx.aspx" target="main">添加信息</a></li>
          <li id="browser1"><a href="pageLxbx/Lxbx.aspx?page=0" target="main">浏览信息</a></li>
          <li id="advancedSearch1"><a href="pageLxbx/draft_Lxbx.aspx" target="main">草稿箱</a></li>
          <li id="verify1"><a href="pageLxbx/t_Lxbx.aspx?page=0" target="main">回收站</a></li>
          
        </ul>
      </div>
      <h1 class="type"><a href="javascript:void(0)">HIV/AIDS阳性样本管理</a></h1>
      <div class="content">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td><img src="images/menu_topline.gif" width="182" height="5" /></td>
          </tr>
        </table>
        <ul class="MM">
          <li  id="add2"><a href="pageYxyb/AddYxyb.aspx" target="main">添加样本</a></li>
          <li id="browser2"><a href="pageYxyb/Yxyb.aspx?page=0" target="main">浏览样本</a></li>
          <li id="advancedSearch2"><a href="pageYxyb/Draft_Yxyb.aspx" target="main">草稿箱</a></li>
          <li id="verify2"><a href="pageYxyb/t_Yxyb.aspx?page=0" target="main">回收站</a></li>
        </ul>
      </div>
      <h1 class="type"><a href="javascript:void(0)">HIV/AIDS随访信息管理</a></h1>
      <div class="content">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td><img src="images/menu_topline.gif" width="182" height="5" /></td>
          </tr>
        </table>
        <ul class="MM">
		  <li id="add3"><a href="pageSfjc/AddSfjc.aspx" target="main" >添加随访</a></li>
          <li id="browser3"><a href="pageSfjc/Sfjc.aspx?page=0" target="main">浏览信息</a></li>
          <li id="advancedSearch3"><a href="pageSfjc/Draft_Sfjc.aspx" target="main">草稿箱</a></li>
          <li id="verify3"><a href="pageSfjc/t_Sfjc.aspx?page=0" target="main">回收站</a></li>
        </ul>
      </div>
      <h1 class="type"><a href="javascript:void(0)">报表与统计管理</a></h1>
      <div class="content">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td><img src="images/menu_topline.gif" width="182" height="5" /></td>
          </tr>
        </table>
        <ul class="MM">
          <li><a href="Reports/Rpt_InfectionWayDistrict.aspx" target="main">按传播途径分地区统计</a></li>
          <li><a href="Reports/Rpt_InfectionWay.aspx" target="main">按传播途径统计</a></li>
          <li><a href="Reports/Rpt_SampleSource.aspx" target="main">按样本来源统计</a></li>
          <li><a href="Reports/Rpt_DeadByDistrict.aspx" target="main">分地区统计</a></li>
        </ul>
      </div>

    <div runat=server id="div5">
      <h1 class="type"><a href="javascript:void(0)">注册用户管理</a></h1>
      <div class="content">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          
          <tr>
            
            <td><img src="images/menu_topline.gif" width="182" height="5" />
            </td>
            
          </tr>
        </table>
        <ul class="MM">
          <li><a href="pageUser/User.aspx" target="main">用户管理</a></li>
          <li><a href="pageUser/AddUser.aspx" target="main">添加用户</a></li>
        </ul>
      </div>
      </div>
     <div id="div6" runat=server>
    <h1 class="type"><a href="javascript:void(0)">参数与日志管理</a></h1>
      <div class="content">
          <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td><img src="images/menu_topline.gif" width="182" height="5" /></td>
            </tr>
          </table>
        <ul class="MM">
            <li><a href="pageDesc/SetDesc.aspx?type=" target="main">参数设置</a></li>
            <li><a href="pageDesc/Log.aspx" target="main">查看日志</a></li>
            <li><a href="pageDesc/ServerInfo.aspx" target="main">服务器配置信息</a></li>
             <!--<li><a target="left" onclick="return confirm('开发中...')" style=" text-align:center">备份与还原</a></li>-->
        </ul>
      </div>
      </div>
       <div id="div7" runat=server>
    <h1 class="type"><a href="User/CommentList.aspx?type=" target="main">留言板</a></h1>
      
      </div>
        <script type="text/javascript">
		var contents = document.getElementsByClassName('content');
		var toggles = document.getElementsByClassName('type');
	
		var myAccordion = new fx.Accordion(
			toggles, contents, {opacity: true, duration: 400}
		);
		myAccordion.showThisHideOpen(contents[0]);
	</script>
        </td>
  </tr>
</table>
    </form>
</body>
</html>
