<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>深圳市疾病预防控制中心</title>
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #1D3647;
}
-->

 .hiddenttextbox
{   
     display: none;
}
</style>

<link href="images/skin.css" rel="stylesheet" type="text/css" />


<script language="javascript" type="text/javascript">
        function changeCode() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "CheckCode.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }  
     if (top.location !== self.location) { 
            top.location=self.location; } 
 
</script>
</head>

<script language="JavaScript" type="text/javascript">
function correctPNG()
{
    var arVersion = navigator.appVersion.split("MSIE")
    var version = parseFloat(arVersion[1])
    if ((version >= 5.5) && (document.body.filters)) 
    {
       for(var j=0; j<document.images.length; j++)
       {
          var img = document.images[j]
          var imgName = img.src.toUpperCase()
          if (imgName.substring(imgName.length-3, imgName.length) == "PNG")
          {
             var imgID = (img.id) ? "id='" + img.id + "' " : ""
             var imgClass = (img.className) ? "class='" + img.className + "' " : ""
             var imgTitle = (img.title) ? "title='" + img.title + "' " : "title='" + img.alt + "' "
             var imgStyle = "display:inline-block;" + img.style.cssText 
             if (img.align == "left") imgStyle = "float:left;" + imgStyle
             if (img.align == "right") imgStyle = "float:right;" + imgStyle
             if (img.parentElement.href) imgStyle = "cursor:hand;" + imgStyle
             var strNewHTML = "<span " + imgID + imgClass + imgTitle
             + " style=\"" + "width:" + img.width + "px; height:" + img.height + "px;" + imgStyle + ";"
             + "filter:progid:DXImageTransform.Microsoft.AlphaImageLoader"
             + "(src=\'" + img.src + "\', sizingMethod='scale');\"></span>" 
             img.outerHTML = strNewHTML
             j = j-1
          }
       }
    }    
}
window.attachEvent("onload", correctPNG);


function Reset_onclick() {
   getElementById()
}

</script>

<body>
    <table width="100%" height="166" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td height="42" valign="top"><table width="100%" height="42" border="0" cellpadding="0" cellspacing="0" class="login_top_bg">
      <tr>
        <td width="1%" height="21">&nbsp;</td>
        <td height="42">&nbsp;</td>
        <td width="17%">&nbsp;</td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td valign="top"><table width="100%" height="532" border="0" cellpadding="0" cellspacing="0" class="login_bg">
      <tr>
        <td width="49%" align="right"><table width="91%" height="532" border="0" cellpadding="0" cellspacing="0" class="login_bg2">
            <tr>
              <td height="138" valign="top"><table width="89%" height="427" border="0" cellpadding="0" cellspacing="0">
                <tr>
                  <td height="149">&nbsp;</td>
                </tr>
                <tr>
                  <td align="center" valign="top" style="height: 80px"><img src="images/logo.png" align="middle" style="width: 387px; height: 106px"></td>
                </tr>
                <tr>
                  <td height="198" align="left" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                      <td style="width: 121px">&nbsp;</td>
                      <td height="25" colspan="2" class="left_txt"><p>
                          &nbsp;</p></td>
                    </tr>
                    <tr class="left_txt">
                      <td style="width: 121px; height: 25px;" align="right">&nbsp;</td>
                      <td colspan="2" style="height: 25px" >
                          &nbsp;版权所有： 深圳市疾病预防控制中心</td>
                    </tr>
                    <tr class="left_txt">
                      <td style="width: 121px" align="right"></td>
                      <td height="25" colspan="2" ><p>
                          &nbsp;地址： 深圳市南山区龙苑路8号</p></td>
                    </tr>
                    <tr>
                      <td style="width: 121px">&nbsp;</td>
                      <td width="30%" height="40"> </td>
                      <td width="35%"></td>
                    </tr>
                  </table></td>
                </tr>
              </table></td>
            </tr>
            
        </table></td>
        <td width="1%" >&nbsp;</td>
        <td valign="bottom" style="width: 50%"><table width="100%" height="59" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
              <td width="4%">&nbsp;</td>
              <td width="96%" height="38"><span class="login_txt_bt">艾滋病防治数据信息管理系统</span></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td height="21"><table cellSpacing="0" cellPadding="0" width="100%" border="0" id="table211" height="328">
                  <tr>
                    <td height="164" colspan="2" align="center">    <form id="form2" runat="server">
                        <table cellSpacing="0" cellPadding="0" width="100%" border="0" height="143" id="table212">
                          <tr>
                            <td width="13%" height="38" class="top_hui_text" align="left"><span class="login_txt">帐 号：&nbsp;&nbsp; </span></td>
                            <td height="38" colspan="2" class="top_hui_text" align="left"><asp:TextBox ID="txtUser" runat="server" Height="22px" Width="150px"></asp:TextBox>                            </td>
                          </tr>
                          <tr>
                            <td width="13%" class="top_hui_text" align="left" style="height: 35px"><span class="login_txt"> 密 码： &nbsp;&nbsp; </span></td>
                            <td colspan="2" class="top_hui_text" align="left" style="height: 35px"><asp:TextBox ID="txtPassWord" CssClass="editbox4" runat="server" Height="22px" Width="150px" TextMode="Password" >admin</asp:TextBox>
                              <img src="images/luck.gif" width="19" height="18"> </td>
                          </tr>
                          <tr>
                            <td width="13%" height="35" align="left" ><span class="login_txt">验证码：</span></td>
                            <td height="35" colspan="2" class="top_hui_text" align="left"><asp:TextBox ID="txtValid" runat="server" Height="22px" Width="77px" MaxLength="6" ></asp:TextBox>
                                <img  align="middle" height="25"  src="CheckCode.ashx" id="vimg" alt="" onclick="changeCode()"/></td>
                          </tr>
                          <tr>
                            <td height="35" align="left" >&nbsp;</td>
                            <td width="20%" height="35" align="left" >
                                <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" /> </td>
                            <td width="67%" class="top_hui_text" align="left"><input id="Reset" type="reset" value="重置" language="javascript" onclick="return Reset_onclick()" />
                                       </tr>
                        </table>
                        <br>
                    </form></td>
                  </tr>
                  <tr>
                    <td width="433" height="164" align="right" valign="bottom"><img src="images/login-wel.gif" width="242" height="138" /></td>
                    <td width="57" align="right" valign="bottom">&nbsp;</td>
                  </tr>
              </table></td>
            </tr>
          </table>
          </td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="20"><table width="100%" border="0" cellspacing="0" cellpadding="0" class="login-buttom-bg">
      <tr>
        <td align="center" style="height: 20px"><span class="login-buttom-txt">Copyright &copy; 2009-2010 </span></td>
      </tr>
    </table></td>
  </tr>
</table>
</body>
</html>
