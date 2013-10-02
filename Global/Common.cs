using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections;

namespace Global
{
      //首先要获取URL，如下所示：
    
     
    
    /// <summary>
    /// 角色状态 (系统管理员，数据维护员，普通用户)
    /// </summary>
    public class RedirectState
    {
        /// <summary>
        /// 浏览表
        /// </summary>
        public static readonly int Browser = 1;
        /// <summary>
        /// 临时表
        /// </summary>
        public static readonly int Temporary = 2;
       
    }
  
    /// <summary>
    /// 角色状态 (系统管理员，数据维护员，普通用户)
    /// </summary>
    public class Role { 
    /// <summary>
    /// 系统管理员
    /// </summary>
        public static readonly int Admin=1;
        /// <summary>
        /// 数据维护员
        /// </summary>
        public static readonly int DataMaintenance = 7;
        /// <summary>
        /// 阳性样本管理
        /// </summary>
        public static readonly int YxybAdmin = 3;
        /// <summary>
        /// 病例报告管理
        /// </summary>
        public static readonly int LxblAdmin = 2;
        /// <summary>
        /// 随访信息管理
        /// </summary>
        public static readonly int SfjlAdmin = 5;
        /// <summary>
        /// 普通用户
        /// </summary>
        public static readonly int NormalUser = 6;

        
    }
    /// <summary>
    /// 信息状态 (已审核、未审核、已删除)
    /// </summary>
   public class InfoState {
       /// <summary>
       /// 已审核
       /// </summary>
       public static readonly int Deleted=1;
       /// <summary>
       /// 未审核
       /// </summary>
       public static readonly int UnVerified=2;
       /// <summary>
       /// 已删除
       /// </summary>
       public static readonly int Verified = 3;
       /// <summary>
       /// 全部
       /// </summary>
       public static readonly int VerifiedAndUnverified = 4;

       public static string getState(string state)
       {
           string str = "";
           if (state == Global.InfoState.Deleted.ToString())
               str = "已删除";
           else if (state == Global.InfoState.UnVerified.ToString())
               str = "未审核";
           else if (state == Global.InfoState.Verified.ToString())
               str = "已审核";
           return str;
       }
       /// <summary>
       /// 判断是否属于审核类型
       /// </summary>
       /// <param name="state">flag状态</param>
       /// <returns></returns>
       public static bool beChecked(string state)
       {
           return state.Trim().Equals(Global.InfoState.UnVerified.ToString());
       }
      /// <summary>
       /// 判断维护员是否到了可删除数据的日期
      /// </summary>
      /// <param name="inTime">录入日期</param>
      /// <returns></returns>
       public static bool beDeleted(DateTime inTime)
       {
           //DateTime timea = Convert.ToDateTime(bll_model.GetModelNumByQrID(QrId).inTime);
           DateTime nowTime = Convert.ToDateTime(DateTime.Now.ToLocalTime().ToString());
           TimeSpan ts = (TimeSpan)Convert.ToDateTime(nowTime).Subtract(Convert.ToDateTime(inTime));
           return ts.Days < 180;
       }
       /// <summary>
       /// 判断维护员是否到了可删除数据的日期
       /// </summary>
       /// <param name="inTime">录入日期</param>
       /// <returns></returns>
       public static bool beDeleted(string sInTime)
       {
           DateTime inTime = Convert.ToDateTime(sInTime);
           DateTime nowTime = Convert.ToDateTime(DateTime.Now.ToLocalTime().ToString());
           TimeSpan ts = (TimeSpan)Convert.ToDateTime(nowTime).Subtract(Convert.ToDateTime(inTime));
           return ts.Days < 180;
       }
             
   };
    /// <summary>
    /// 搜索方式 (录入日期、阳性判定日期、转AIDS日期、删除日期、审核日期、加入日期、出生日期、采样日期)
    /// </summary>
    public class Search
    {
        /// <summary>
        /// 录入日期
        /// </summary>
        public static readonly int inTime=1;
        /// <summary>
        /// 阳性判定日期
        /// </summary>
        public static readonly int yxpdDate=2;
        /// <summary>
        /// 转AIDS日期
        /// </summary>
        public static readonly int toAidsDate=3;
         /// <summary>
        /// 删除日期
        /// </summary>
        public static readonly int DeletedDate=4;
        /// <summary>
        /// 审核日期
        /// </summary>
        public static readonly int VerfiedDate=5;
        /// <summary>
        /// 加入日期
        /// </summary>
        public static readonly int AddDate=6;
        /// <summary>
        /// 出生日期
        /// </summary>
        public static readonly int birthDate = 7;
        /// <summary>
        /// 采样日期
        /// </summary>
        public static readonly int cyDate = 8;
        /// <summary>
        /// 确认日期
        /// </summary>
        public static readonly int confirmDate = 9;
        /// <summary>
        /// 保存位置
        /// </summary>
        public static readonly int savePosition = 10;
        /// <summary>
        /// 直报号
        /// </summary>
        public static readonly int zbNumber = 11;
        /// <summary>
        /// 确认ID
        /// </summary>
        public static readonly int qrNumber = 12;
        /// <summary>
        /// 流水号
        /// </summary>
        public static readonly int lsNumber = 13;
        /// <summary>
        /// 根据条件返回where条件语句(不包含where),用于查找今日的信息
        /// </summary>
        /// <param name="whereStatement">where语句</param>
        /// <param name="dateType">日期类型</param>
        /// <returns></returns>
        public static string getSearchTodaySql(string dateType)
        {
            string whereStatement;
            whereStatement = " cast(" + dateType + " as datetime) between '" + DateTime.Now.ToString("yyyy-MM-dd") + " 0:0:0' And '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ";

            return whereStatement;
        }
        /// <summary>
        /// 根据条件返回where语句,用于下拉框
        /// </summary>
        /// <param name="whereStatement">where语句</param>
        /// <param name="dateType">日期类型</param>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <returns></returns>
        public static string getSearchDateSql(string whereStatement, string dateType, string startDate, string endDate)
        {

            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " And ";

            whereStatement += "cast(" + dateType + " as datetime) between '" + startDate + " 0:0:0' And '" + endDate + " 23:59:59' ";

            return whereStatement;
        }
        /// <summary>
        /// 根据条件返回where 语句，用于textbox
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="dataValue"></param>
        /// <returns></returns>
         public static string getSearchDateSql(string whereStatement, string dateType, string dataValue)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " And ";

            whereStatement += " " + dateType + " like '%" + dataValue + "%' ";

            return whereStatement;
        }
       /// <summary>
       /// 用于判断or条件的筛选
       /// </summary>
       /// <param name="whereStatement"></param>
       /// <param name="dateType"></param>
       /// <param name="logicOper"></param>
       /// <param name="dataValue1"></param>
       /// <param name="dataValue2"></param>
       /// <returns></returns>
        public static string getSearchDateSql(string whereStatement, string dateType,int dataValue1, int dataValue2)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " And ";

            whereStatement += " " + dateType + " = " + dataValue1 + " or " + dateType + " = " + dataValue2 + " ";

            return whereStatement;
        }
        /// <summary>
        /// 用于判断or条件的筛选
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="logicOper"></param>
        /// <param name="dataValue1"></param>
        /// <param name="dataValue2"></param>
        /// <returns></returns>
        public static string getSearchDateSqlAccuracyAdvance(string whereStatement, string dateType, int dataValue1, int dataValue2,string logicOper)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " "+logicOper+" ";

            whereStatement += " " + dateType + " = " + dataValue1 + " or " + dateType + " = " + dataValue2 + " ";

            return whereStatement;
        }
        /// <summary>
        /// 根据条件返回where 语句，用于textbox
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="dataValue"></param>
        /// <returns></returns>
        public static string getSearchDateSql(string whereStatement, string dateType, int dataValue)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " And ";

            whereStatement += " " + dateType + "=" + dataValue.ToString() + " ";

            return whereStatement;
        }
        /// <summary>
        /// 根据条件返回where 语句，用于textbox
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="dataValue"></param>
        /// <returns></returns>
        public static string getSearchDateSqlAdvance(string whereStatement, string dateType, string dataValue,string logicalOper)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " "+logicalOper+" ";

            whereStatement += " " + dateType + " like '%" + dataValue + "%' ";

            return whereStatement;
        }
        /// <summary>
        /// 根据条件返回where 语句，用于textbox
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="dataValue"></param>
        /// <returns></returns>
        public static string getSearchDateSqlAccuracyAdvance(string whereStatement, string dateType, string dataValue, string logicalOper)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " " + logicalOper + " ";

            whereStatement += " " + dateType + " = '" + dataValue + "' ";

            return whereStatement;
        }
        /// 根据条件返回where 语句，用于textbox
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="dataValue"></param>
        /// <returns></returns>
        public static string getSearchDateSqlAccuracyAdvance(string whereStatement, string dateType, int dataValue, string logicalOper)
        {
            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " " + logicalOper + " ";

            whereStatement += " " + dateType + " = " + dataValue + " ";

            return whereStatement;
        }
       
        /// <summary>
        /// 加入逻辑运算
        /// </summary>
        /// <param name="whereStatement"></param>
        /// <param name="dateType"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="logicalOper"></param>
        /// <returns></returns>
        public static string getSearchDateSqlAdvance(string whereStatement, string dateType, string startDate, string endDate, string logicalOper)
        {

            if (whereStatement.Equals(""))
                whereStatement += " Where ";
            else
                whereStatement += " "+logicalOper+" ";

            whereStatement += "cast(" + dateType + " as datetime) between '" + startDate + " 0:0:0' And '" + endDate + " 23:59:59' ";

            return whereStatement;
        }
    };


    public class DataSaveToExcel
    {
        public static void ExportExcelFromDataGrid(string filename, System.Web.UI.WebControls.GridView ToExcelGrid)
        {

            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.Charset = "GB2312";
            System.Web.HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename + "");
            // 如果设置为 GetEncoding("GB2312");导出的文件将会出现乱码！！！
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF7;
            System.Web.HttpContext.Current.Response.ContentType = "application/ms-excel";//设置输出文件类型为excel文件。 
            System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
            ToExcelGrid.RenderControl(oHtmlTextWriter);
            System.Web.HttpContext.Current.Response.Output.Write(oStringWriter.ToString());
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End();
        }
        public static void ExportExcelFromDataGrid(string filename, System.Web.UI.WebControls.Repeater ToExcelGrid)
        {

            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.Charset = "GB2312";
            System.Web.HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename + "");
            // 如果设置为 GetEncoding("GB2312");导出的文件将会出现乱码！！！
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF7;
            System.Web.HttpContext.Current.Response.ContentType = "application/ms-excel";//设置输出文件类型为excel文件。 
            System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
            ToExcelGrid.RenderControl(oHtmlTextWriter);
            System.Web.HttpContext.Current.Response.Output.Write(oStringWriter.ToString());
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End();
        }
        public static string ExportExcelFromDataGrid(string filename)
        {

            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.Charset = "GB2312";
            System.Web.HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename + "");
            // 如果设置为 GetEncoding("GB2312");导出的文件将会出现乱码！！！
            //System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF7;
            //System.Web.HttpContext.Current.Response.ContentType = "application/ms-excel";//设置输出文件类型为excel文件。 
            //System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
            //System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
            //ToExcelGrid.RenderControl(oHtmlTextWriter);
           // System.Web.HttpContext.Current.Response.Output.Write(oStringWriter.ToString());
            
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End();
            return filename;
        }
  
    } 
        public class ZhiBaoHao
        {
            public class TooltipOf
            {
                public static string textbox1 = "城市(4位)";
                public static string textbox2 = "区号(5位)";
                public static string textbox3 = "年份(4位)";
                public static string textbox4 = "个人编码(5)";
            }

            public class MaxLengOf
            {
                public static int textbox1 = 4; //城市 4位
                public static int textbox2 = 5; //区号 5位
                public static int textbox3 = 4; //年份 4位
                public static int textbox4 = 5; //个人编码 5位
            
            }
        }

    public class QueRenHao
    {
        public class TooltipOf //提示信息
        {
            public static string textbox1 = "年份(4位,SZ2011)";
            public static string textbox2 = "序号(4位，如'0001')";
           
        }

        public class MaxLengOf //长度
        {
            public static int textbox1 = 4; //年份 4位
            public static int textbox2 = 4; //月日 5位
           
        }
        public class ValueOf //文本框值
        {
            public static string textbox1InsertLeft = "SZ"; //文本框1往左插入
            public static string textbox2InsertLeft = ""; //文本框2往左插入

        }
    }


 
    //专门处理页面返回的栈
    public class StateStack
    {
        private static Stack<string> urlsStack=new Stack<string>();
        private static Hashtable ht=new Hashtable();

        public static void Push(string str)
        {
            if (!ht.ContainsValue(str))
            {
                urlsStack.Push(str);
                ht.Add(str, str);
            }
        }
        public static string getTop()
        {
            return urlsStack.Pop();
        }
        public static void ClearState()
        {
            urlsStack.Clear();
            ht.Clear();
        }
    }

   

}
