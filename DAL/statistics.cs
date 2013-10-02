using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//请先添加引用
namespace DAL
{
    public class statistics
    {
        /// <summary>
        /// 根据脚本获得数据列表
        /// </summary>
        public DataSet GetListBySql(string strsql)
        {
            return DbHelperSQL.Query(strsql);
        }
    
    }
}
