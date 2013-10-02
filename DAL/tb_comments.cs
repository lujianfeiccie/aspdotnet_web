using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//请先添加引用
namespace DAL
{
    /// <summary>
    /// 数据访问类tb_comments。
    /// </summary>
    public class tb_comments
    {
        public tb_comments()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "tb_comments");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_comments");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.tb_comments model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_comments(");
            strSql.Append("name,email,qq,content,addTime,reply,isreply,unread)");
            strSql.Append(" values (");
            strSql.Append("@name,@email,@qq,@content,@addTime,@reply,@isreply,@unread)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@email", SqlDbType.NVarChar,50),
					new SqlParameter("@qq", SqlDbType.NVarChar,15),
					new SqlParameter("@content", SqlDbType.NVarChar),
					new SqlParameter("@addTime", SqlDbType.NVarChar,50),
					new SqlParameter("@reply", SqlDbType.NVarChar),
					new SqlParameter("@isreply", SqlDbType.Bit,1),
					new SqlParameter("@unread", SqlDbType.Bit,1)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.email;
            parameters[2].Value = model.qq;
            parameters[3].Value = model.content;
            parameters[4].Value = model.addTime;
            parameters[5].Value = model.reply;
            parameters[6].Value = model.isreply;
            parameters[7].Value = model.unread;

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
        /// 更新一条数据
        /// </summary>
        public void Update(Model.tb_comments model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_comments set ");
            strSql.Append("name=@name,");
            strSql.Append("email=@email,");
            strSql.Append("qq=@qq,");
            strSql.Append("content=@content,");
            strSql.Append("addTime=@addTime,");
            strSql.Append("reply=@reply,");
            strSql.Append("isreply=@isreply,");
            strSql.Append("unread=@unread");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@email", SqlDbType.NVarChar,50),
					new SqlParameter("@qq", SqlDbType.NVarChar,15),
					new SqlParameter("@content", SqlDbType.NVarChar),
					new SqlParameter("@addTime", SqlDbType.NVarChar,50),
					new SqlParameter("@reply", SqlDbType.NVarChar),
					new SqlParameter("@isreply", SqlDbType.Bit,1),
					new SqlParameter("@unread", SqlDbType.Bit,1)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.name;
            parameters[2].Value = model.email;
            parameters[3].Value = model.qq;
            parameters[4].Value = model.content;
            parameters[5].Value = model.addTime;
            parameters[6].Value = model.reply;
            parameters[7].Value = model.isreply;
            parameters[8].Value = model.unread;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_comments ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.tb_comments GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,name,email,qq,content,addTime,reply,isreply,unread from tb_comments ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Model.tb_comments model = new Model.tb_comments();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.name = ds.Tables[0].Rows[0]["name"].ToString();
                model.email = ds.Tables[0].Rows[0]["email"].ToString();
                model.qq = ds.Tables[0].Rows[0]["qq"].ToString();
                model.content = ds.Tables[0].Rows[0]["content"].ToString();
                model.addTime = ds.Tables[0].Rows[0]["addTime"].ToString();
                model.reply = ds.Tables[0].Rows[0]["reply"].ToString();
                if (ds.Tables[0].Rows[0]["isreply"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["isreply"].ToString() == "1") || (ds.Tables[0].Rows[0]["isreply"].ToString().ToLower() == "true"))
                    {
                        model.isreply = true;
                    }
                    else
                    {
                        model.isreply = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["unread"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["unread"].ToString() == "1") || (ds.Tables[0].Rows[0]["unread"].ToString().ToLower() == "true"))
                    {
                        model.unread = true;
                    }
                    else
                    {
                        model.unread = false;
                    }
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,name,email,qq,content,addTime,reply,isreply,unread ");
            strSql.Append(" FROM tb_comments ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int StartIndex, int EndIndex, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select * ");
            strSql.Append(" FROM (SELECT ROW_NUMBER() OVER(Order by addTime DESC) AS rownum,* FROM tb_comments ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" Where " + strWhere);
            }
            strSql.Append(" ) AS D ");

            strSql.Append(" where rownum between " + StartIndex + " and " + EndIndex + " ");

            return DbHelperSQL.Query(strSql.ToString());
        }
        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "tb_comments";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  成员方法
    }
}

