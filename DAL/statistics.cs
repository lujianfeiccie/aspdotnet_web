using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//�����������
namespace DAL
{
    public class statistics
    {
        /// <summary>
        /// ���ݽű���������б�
        /// </summary>
        public DataSet GetListBySql(string strsql)
        {
            return DbHelperSQL.Query(strsql);
        }
    
    }
}
