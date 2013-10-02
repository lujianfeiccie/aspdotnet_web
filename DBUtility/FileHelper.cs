using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBUtility
{
    public class FileHelper
    {
        /// <summary> 
        /// 将DataTable数据导出到EXCEL，调用该方法后自动返回可下载的文件流 
        /// </summary> 
        /// <param name="dtData">要导出的数据源</param> 
        public static void DataTableToExcel(System.Data.DataTable dtData, string filename)
        {
            System.Web.UI.WebControls.GridView gvExport = null;
            // 当前对话 
            System.Web.HttpContext curContext = System.Web.HttpContext.Current;
            // IO用于导出并返回excel文件 
            System.IO.StringWriter strWriter = null;
            System.Web.UI.HtmlTextWriter htmlWriter = null;
            if (dtData != null)
            {
                // 设置编码和附件格式 
                curContext.Response.AddHeader("content-disposition", "attachment;filename=" + System.Web.HttpUtility.UrlEncode(filename, System.Text.Encoding.UTF8) + ".xls");
                curContext.Response.ContentType = "application/vnd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
                curContext.Response.Charset = "utf-8";
                // 导出excel文件 
                strWriter = new System.IO.StringWriter();
                htmlWriter = new System.Web.UI.HtmlTextWriter(strWriter);
                // 为了解决gvData中可能进行了分页的情况，需要重新定义一个无分页的GridView 
                gvExport = new System.Web.UI.WebControls.GridView();
                gvExport.DataSource = dtData.DefaultView;
                gvExport.AllowPaging = false;
                gvExport.DataBind();
                // 返回客户端 
                gvExport.RenderControl(htmlWriter);
                curContext.Response.Write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />" + strWriter.ToString());
                curContext.Response.End();
            }
        }

    }
    
}
