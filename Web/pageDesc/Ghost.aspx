<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ghost.aspx.cs" Inherits="Ghost" %>

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
</head>
<body>
<script type="text/javascript" src="../js/calendar.js"></script>
<script language=javascript>
function selectAll(obj)
{
    var allInput = document.getElementsByTagName("input");
    //alert(allInput.length);
    var loopTime = allInput.length;
    for(i = 0;i < loopTime;i++)
    {
        //alert(allInput[i].type);
        if(allInput[i].type == "checkbox")
        {
            allInput[i].checked = obj.checked;
        }
    }
}

function delIt() 
{ 
    var cbxBool = 0; 
    alert(cbxArray.length);
    for(var i = 0;i < cbxArray.length;i++){ 
        var obj = document.getElementById(cbxArray[i]); 
        if(obj.checked == true){ 
            cbxBool = 1; 
            break; 
         } 
    } 
    if(cbxBool == 1){ 
        var result = confirm("您确定要删除吗？"); 
        if(result){ 
            return true; 
        } 
    }else{ 
        alert("请选中要删除的项"); 
        return false; 
    } 
    return false; 
} 
</script>
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
        <td colspan="5" valign="top" style="height: 33px" align="right"><table width="100%" height="54" border="0" cellpadding="0" cellspacing="0" class="line_table">
          <tr>
          <td style="width: 1022px; height: 33px" align="left" class="left_bt2">
              &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;
              &nbsp;</td>
          <td style="height: 33px; width: 410px;">
          
          </td>
          <td style="height: 33px" align="right">
              </td>
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
