using System;
using System.Collections.Generic;

using System.Text;
using System.Web;
using System.Web.UI;

namespace DBUtility
{
        /// <summary> 
        /// 一些常用的Js调用 
        /// 添加新版说明：由于旧版普遍采用Response.Write(string msg)的方式输出js脚本，这种 
        /// 方式输出的js脚本会在html元素的&lt;html&gt;&lt;/html&gt;标签之外，破坏了整个xhtml的结构, 
        /// 而新版本则采用ClientScript.RegisterStartupScript(string msg)的方式输出，不会改变xhtml的结构, 
        /// 不会影响执行效果。 
        /// 为了向下兼容，所以新版本采用了重载的方式，新版本中要求一个System.Web.UI.Page类的实例。 
        /// </summary> 
        public class JScript
        {
             #region 弹出JavaScript小窗口
            /// <summary>
            /// 弹出JavaScript小窗口
            /// </summary>
            /// <param name="message">窗口信息</param>
        
            public static void Alert(string message)
            {
                System.Web.HttpContext.Current.Response.Write("<Script Language=javascript>alert('"+message+"');</Script>");
               // new System.Web.UI.Page().RegisterClientScriptBlock("", "<script>alert('" + message + "')</script>");
          
            }
            #endregion
             
            #region 弹出JavaScript小窗口
            /// <summary>
            /// 弹出JavaScript小窗口
            /// </summary>
            /// <param name="message">窗口信息</param>
            /// <param name="page"></param>
            public static void Alert(string message, Page page)
            {
                string jsStr = @"<Script language='JavaScript'>alert('" + message + "');</Script>";
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "alert"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "alert", jsStr);
                }
            }
            #endregion

            #region 弹出消息框并且转向到新的URL
            /// <summary> 
            /// 弹出消息框并且转向到新的URL 
            /// </summary> 
            /// <param name="message">消息内容</param> 
            /// <param name="toURL">连接地址</param> 
            public static void AlertAndRedirect(string message, string toURL, Page page)
            {
                string jsStr = "<script language=javascript>alert('{0}');window.location.replace('{1}')</script>";
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "AlertAndRedirect"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "AlertAndRedirect", string.Format(jsStr, message, toURL));
                }
            }
            #endregion

            #region 回到历史页面
            /// <summary> 
            /// 回到历史页面 
            /// </summary> 
            /// <param name="value">-1/1</param> 
            public static void GoHistory(int value, Page page)
            {
                string jsStr = @"<Script language='JavaScript'>history.go({0});</Script>";
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "GoHistory"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "GoHistory", string.Format(jsStr, value));
                }
            }
            #endregion

            #region 刷新父窗口
            /// <summary>
            /// 刷新父窗口
            /// </summary>
            /// <param name="url"></param>
            /// <param name="page"></param>
            public static void RefreshParent(string url, Page page)
            {
                string jsStr = @"<Script language='JavaScript'>window.opener.location.href='" + url + "';window.close();</Script>";
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "RefreshParent"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "RefreshParent", jsStr);
                }
            }
            #endregion

            #region 刷新打开窗口
            /// <summary> 
            /// 刷新打开窗口 
            /// </summary> 
            public static void RefreshOpener(Page page)
            {
                string jsStr = @"<Script language='JavaScript'>opener.location.reload();</Script>";
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "RefreshOpener"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "RefreshOpener", jsStr);
                }
            }
            #endregion

            #region 打开指定大小的新窗体
            /// <summary> 
            /// 打开指定大小的新窗体 
            /// </summary> 
            /// <param name="url">地址</param> 
            /// <param name="width">宽</param> 
            /// <param name="heigth">高</param> 
            /// <param name="top">头位置</param> 
            /// <param name="left">左位置</param> 
            public static void OpenWebFormSize(string url, int width, int heigth, int top, int left, Page page)
            {
                string jsStr = @"<Script language='JavaScript'>window.open('" + url + @"','','height=" + heigth + ",width=" + width + ",top=" + top + ",left=" + left + ",location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no');</Script>";
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "OpenWebFormSize"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "OpenWebFormSize", jsStr);
                }
            }
            #endregion

            #region 转向Url制定的页面
            /// <summary> 
            /// 转向Url制定的页面 
            /// </summary> 
            /// <param name="url">连接地址</param> 
            public static void JavaScriptLocationHref(string url, Page page)
            {
                string jsStr = @"<Script language='JavaScript'>window.location.replace('{0}');</Script>";
                jsStr = string.Format(jsStr, url);
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "JavaScriptLocationHref"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "JavaScriptLocationHref", jsStr);
                }
            }
            #endregion

            #region 返回顶级页面
            /// <summary>
            /// 返回顶级页面
            /// </summary>
            /// <param name="url"></param>
            /// <param name="page"></param>
            public static void LocationTop(string url, Page page)
            {
                string jsStr = @"<Script language='JavaScript'>top.location.replace('{0}');</Script>";
                jsStr = string.Format(jsStr, url);
                if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "JavaScriptLocationHref"))
                {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "JavaScriptLocationHref", jsStr);
                }
            }
            #endregion
        }
}