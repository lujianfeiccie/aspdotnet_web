using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//�����������
namespace DAL
{
    /// <summary>
    /// ���ݷ�����tb_log��
    /// </summary>
    public class tb_log
    {
        public tb_log()
        { }
        #region  ��Ա����

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "tb_log");
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_log");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.tb_log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_log(");
            strSql.Append("FK_User,OperationDate,OperatingPosition,Operation)");
            strSql.Append(" values (");
            strSql.Append("@FK_User,@OperationDate,@OperatingPosition,@Operation)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@OperationDate", SqlDbType.NVarChar,50),
					new SqlParameter("@OperatingPosition", SqlDbType.NVarChar,50),
					new SqlParameter("@Operation", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.FK_User;
            parameters[1].Value = model.OperationDate;
            parameters[2].Value = model.OperatingPosition;
            parameters[3].Value = model.Operation;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.tb_log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_log set ");
            strSql.Append("FK_User=@FK_User,");
            strSql.Append("OperationDate=@OperationDate,");
            strSql.Append("OperatingPosition=@OperatingPosition,");
            strSql.Append("Operation=@Operation");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@OperationDate", SqlDbType.NVarChar,50),
					new SqlParameter("@OperatingPosition", SqlDbType.NVarChar,50),
					new SqlParameter("@Operation", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.FK_User;
            parameters[2].Value = model.OperationDate;
            parameters[3].Value = model.OperatingPosition;
            parameters[4].Value = model.Operation;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_log ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.tb_log GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,FK_User,OperationDate,OperatingPosition,Operation from tb_log ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Model.tb_log model = new Model.tb_log();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_User"].ToString() != "")
                {
                    model.FK_User = int.Parse(ds.Tables[0].Rows[0]["FK_User"].ToString());
                }
                model.OperationDate = ds.Tables[0].Rows[0]["OperationDate"].ToString();
                model.OperatingPosition = ds.Tables[0].Rows[0]["OperatingPosition"].ToString();
                model.Operation = ds.Tables[0].Rows[0]["Operation"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,FK_User,OperationDate,OperatingPosition,Operation ");
            strSql.Append(" FROM tb_log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetViewAllList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_log ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetViewList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetDetailedViewAllList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_log ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�ͨ��ID
        /// </summary>
        public DataSet GetDetailedViewByID(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_log ");
            strSql.Append(" where ID=@id");
            SqlParameter[] parameters ={
                 new SqlParameter("@id",SqlDbType.Int)
             };
            parameters[0].Value = id;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetViewList(int StartIndex, int EndIndex, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select * ");
            strSql.Append(" FROM (SELECT ROW_NUMBER() OVER(Order by OperationDate DESC) AS rownum,* FROM v_log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" Where " + strWhere);
            }
            strSql.Append(" ) AS D ");

            strSql.Append(" where rownum between " + StartIndex + " and " + EndIndex + " ");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetDetailedViewList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  ��Ա����
    }
}

