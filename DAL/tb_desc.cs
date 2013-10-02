using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;/*<请先添加引用*/
namespace DAL
{
	/// <summary>
	/// 数据访问类tb_desc。
	/// </summary>
	public class tb_desc
	{
		public tb_desc()
		{}
		#region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string zID,string zdmc)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_desc");
            strSql.Append(" where zID=@zID and zdmc=@zdmc");
            SqlParameter[] parameters = {
					new SqlParameter("@zID", SqlDbType.NVarChar,50),
                    new SqlParameter("@zdmc", SqlDbType.NVarChar,50)};
            parameters[0].Value = zID;
            parameters[1].Value = zdmc;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Model.tb_desc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_desc(");
			strSql.Append("zdmc,zID,zdz)");
			strSql.Append(" values (");
			strSql.Append("@zdmc,@zID,@zdz)");
			SqlParameter[] parameters = {
					new SqlParameter("@zdmc", SqlDbType.NChar,10),
					new SqlParameter("@zID", SqlDbType.Int,4),
					new SqlParameter("@zdz", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.zdmc;
			parameters[1].Value = model.zID;
			parameters[2].Value = model.zdz;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Model.tb_desc model)
		{
            StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_desc set ");
			strSql.Append("zID=@zID,");
			strSql.Append("zdz=@zdz");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@zID", SqlDbType.Int,4),
					new SqlParameter("@zdz", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ID;
            parameters[1].Value = model.zID;
			parameters[2].Value = model.zdz;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(string deleteID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_desc ");
            strSql.Append(" where ID in (" + deleteID + ") ");

            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_desc GetModel(int id)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,zdmc,zID,zdz from tb_desc ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
                new SqlParameter("@ID", SqlDbType.Int,4)
            };
            parameters[0].Value=id;

			Model.tb_desc model=new Model.tb_desc();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.zID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.zdmc=ds.Tables[0].Rows[0]["zdmc"].ToString();
				if(ds.Tables[0].Rows[0]["zID"].ToString()!="")
				{
					model.zID=int.Parse(ds.Tables[0].Rows[0]["zID"].ToString());
				}
				model.zdz=ds.Tables[0].Rows[0]["zdz"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,zdmc,zID,zdz ");
			strSql.Append(" FROM tb_desc ");
            if (strWhere != "") 
            { 
                strSql.Append(" where zdmc='"+strWhere+"' order by zID");
            }            
			return DbHelperSQL.Query(strSql.ToString());
		}


        public DataSet getPagerCollectFileInfo(string type,int startIndex, int endIndex)
        {
            DataSet dt = new DataSet();
            string sqlStr = "With Temptbl AS(Select ROW_NUMBER() Over (Order By [ID] ) as Num,* from [tb_desc] ";
            if(type != "")
            {
                sqlStr +="where zdmc = '"+type +"'";
            }
            sqlStr +=" ) Select * From Temptbl where Num between  @StartIndex and @EndIndex"; 
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@StartIndex",startIndex),
                new SqlParameter("@endIndex",endIndex)
            };
            dt = DbHelperSQL.Query(sqlStr, paras);
            return dt;
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
			parameters[0].Value = "tb_desc";
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

