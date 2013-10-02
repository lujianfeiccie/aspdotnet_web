<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBatchLxbx.aspx.cs" Inherits="AddBatchLxbx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    
    <title>深圳市疾病预防控制中心</title>
		<link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="../css/GridView.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td background="../images/mail_leftbg.gif" valign="top" width="17">
                    <img height="29" src="../images/left-top-right.gif" width="17" /></td>
                <td background="../images/content-bg.gif" valign="top">
                    <table id="table2" border="0" cellpadding="0" cellspacing="0" class="left_topbg"
                        height="31" width="100%">
                        <tr>
                            <td height="31">
                                <div class="titlebt">
                                    流行病学</div>
                            </td>
                        </tr>
                    </table>
                </td>
                <td background="../images/mail_rightbg.gif" style="width: 5px" valign="top">
                    <img height="29" src="../images/nav-right-bg.gif" width="16" /></td>
            </tr>
            <tr>
                <td background="../images/mail_leftbg.gif" valign="middle">
                    &nbsp;</td>
                <td bgcolor="#f7f8f9" valign="top">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="98%">
                        <tr height="10">
                            <td style="width: 155px; height: 10px">
                                &nbsp;</td>
                            <td style="height: 10px">
                                &nbsp;</td>
                            <td style="height: 10px">
                                &nbsp;</td>
                            <td style="height: 10px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" class="left_bt3" colspan="4" style="height: 25px" valign="middle">
                                <span class="left_txt"></span>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" colspan="4" style="height: 32px" valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" class="line_table" height="54"
                                    width="100%">
                                    <tr>
                                        <td background="../images/news-title-bg.gif" style="width: 12px; height: 23px" width="18">
                                            <img height="27" src="../images/news-title-bg.gif" width="2" /></td>
                                        <td align="center" background="../images/news-title-bg.gif" class="left_bt2" style="width: 95%;
                                            height: 23px">
                                            批量录入</td>
                                        <td align="right" background="../images/news-title-bg.gif" class="left_bt2" style="height: 23px"
                                            width="217">
                                            &nbsp; &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3" height="25" valign="top">
                                            <asp:FileUpload ID="FileUpload1" runat="server" Width="448px" on />
                                            <asp:Button ID="btnPreview" runat="server" OnClick="btnPreview_Click" Text="预览" />
                                            <asp:Button ID="btnWrite" runat="server" Text="写入" OnClick="btnWrite_Click" /></td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3">
                                            <asp:GridView ID="GridView1" runat="server" CssClass="GridViewStyle" PageSize="5">
                                                <PagerSettings PreviousPageText="上一页" />
                                                <FooterStyle CssClass="GridViewFooterStyle" />
                                                <RowStyle CssClass="GridViewRowStyle" />
                                                <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
                                                <PagerStyle CssClass="GridViewPagerStyle" />
                                                <HeaderStyle CssClass="GridViewHeaderStyle" />
                                                <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" colspan="4">
                                <asp:Panel ID="Panel1" runat="server" Height="100%" Visible="False" Width="100%">
                                    &nbsp;</asp:Panel>
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
                <td background="../images/mail_rightbg.gif" style="width: 5px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td background="../images/mail_leftbg.gif" valign="bottom">
                    <img height="17" src="../images/buttom_left2.gif" width="17" /></td>
                <td background="../images/buttom_bgs.gif">
                    <img height="17" src="../images/buttom_bgs.gif" width="17" /></td>
                <td background="../images/mail_rightbg.gif" style="width: 5px" valign="bottom">
                    <img height="17" src="../images/buttom_right2.gif" width="16" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
