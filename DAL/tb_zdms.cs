using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//请先添加引用
namespace DAL
{
	/// <summary>
	/// 数据访问类tb_zdms。
	/// </summary>
	public class tb_zdms
	{
		public tb_zdms()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string zdm)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_zdms");
			strSql.Append(" where zdm=@zdm ");
			SqlParameter[] parameters = {
					new SqlParameter("@zdm", SqlDbType.NVarChar,50)};
			parameters[0].Value = zdm;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Model.tb_zdms model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_zdms(");
			strSql.Append("zdm,zdms)");
			strSql.Append(" values (");
			strSql.Append("@zdm,@zdms)");
			SqlParameter[] parameters = {
					new SqlParameter("@zdm", SqlDbType.NVarChar,20),
					new SqlParameter("@zdms", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.zdm;
			parameters[1].Value = model.zdms;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Model.tb_zdms model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_zdms set ");
			strSql.Append("zdms=@zdms");
			strSql.Append(" where zdm=@zdm ");
			SqlParameter[] parameters = {
					new SqlParameter("@zdm", SqlDbType.NVarChar,20),
					new SqlParameter("@zdms", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.zdm;
			parameters[1].Value = model.zdms;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string zdm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete tb_zdms ");
			strSql.Append(" where zdm=@zdm ");
			SqlParameter[] parameters = {
					new SqlParameter("@zdm", SqlDbType.NVarChar,50)};
			parameters[0].Value = zdm;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_zdms GetModel(string zdm)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 zdms from tb_zdms ");
			strSql.Append(" where zdm=@zdm ");
			SqlParameter[] parameters = {
					new SqlParameter("@zdm", SqlDbType.NVarChar,50)};
			parameters[0].Value = zdm;

			Model.tb_zdms model=new Model.tb_zdms();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				//model.zdm=ds.Tables[0].Rows[0]["zdm"].ToString();
				model.zdms=ds.Tables[0].Rows[0]["zdms"].ToString();
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
			strSql.Append("select zdm,zdms ");
			strSql.Append(" FROM tb_zdms ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
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
			parameters[0].Value = "tb_zdms";
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

