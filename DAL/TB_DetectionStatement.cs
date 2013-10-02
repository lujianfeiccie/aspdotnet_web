using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//�����������
namespace DAL
{
	/// <summary>
	/// ���ݷ�����TB_DetectionStatement��
	/// </summary>
	public class TB_DetectionStatement
	{
		public TB_DetectionStatement()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "TB_DetectionStatement"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TB_DetectionStatement");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Model.TB_DetectionStatement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TB_DetectionStatement(");
			strSql.Append("ID,Name)");
			strSql.Append(" values (");
			strSql.Append("@ID,@Name)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,30)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Name;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Model.TB_DetectionStatement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TB_DetectionStatement set ");
			strSql.Append("Name=@Name");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,30)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Name;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete TB_DetectionStatement ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Model.TB_DetectionStatement GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Name from TB_DetectionStatement ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.TB_DetectionStatement model=new Model.TB_DetectionStatement();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Name ");
			strSql.Append(" FROM TB_DetectionStatement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "TB_DetectionStatement";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

