<%@ Page Language="C#" AutoEventWireup="true" CodeFile="right.aspx.cs" Inherits="right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="images/skin.css" rel="stylesheet" type="text/css" />
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

<script language="javascript"> 


function ShowTab1(){ 
 document.getElementById("content1").style.display="block" 
 document.getElementById("content2").style.display="none" 

} 
function ShowTab2(){ 
 document.getElementById("content1").style.display="none" 
 document.getElementById("content2").style.display="block" 

} 
</script> 
</head>
<body onload="ShowTab1()">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
        <td style="height: 31px; width: 87px;"><div  onMouseOver="this.bgColor='blue';ShowTab1();"  class="titlebt">欢迎界面</div></td>
        <td style="height: 31px"><div  onMouseOver="this.bgColor='blue';ShowTab2();"   class="titlebt">留言板</div></td>
      </tr>
  </table>
  <div id="content1">
   <iframe name="ServerInfo" width="100%" height="100%" src="pageDesc/ServerInfo.aspx" ></iframe>
</div>
<div id="content2">
<iframe name="CommentBoard" width="100%" height="100%" src="User/CommentList.aspx" ></iframe> </div>
</body>
</html>
