using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//�����������
namespace DAL
{
	/// <summary>
	/// ���ݷ�����Draft_yxyb��
	/// </summary>
	public class Draft_yxyb
	{
		public Draft_yxyb()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Draft_yxyb"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Draft_yxyb");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Model.Draft_yxyb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Draft_yxyb(");
            strSql.Append("PreservePosition,FlowNumber,ConfirmationNumber,ConfirmationDate,DirectReportNumber,SamplingDate,Name,FK_Sex,BirthDate,FK_InfectionWay,CD4,ViralLoad,HCV,HBV,TB,Syphilis,Others,FK_User,SendingTime,FK_Flag,showToUser,VerifyDate,FK_SampleType,FK_SampleSize,Id_Card,Operator_id)");
			strSql.Append(" values (");
            strSql.Append("@PreservePosition,@FlowNumber,@ConfirmationNumber,@ConfirmationDate,@DirectReportNumber,@SamplingDate,@Name,@FK_Sex,@BirthDate,@FK_InfectionWay,@CD4,@ViralLoad,@HCV,@HBV,@TB,@Syphilis,@Others,@FK_User,@SendingTime,@FK_Flag,@showToUser,@VerifyDate,@FK_SampleType,@FK_SampleSize,@Id_Card,@Operator_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PreservePosition", SqlDbType.NVarChar,50),
					new SqlParameter("@FlowNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@ConfirmationNumber", SqlDbType.NVarChar,10),
					new SqlParameter("@ConfirmationDate", SqlDbType.NVarChar,50),
					new SqlParameter("@DirectReportNumber", SqlDbType.NVarChar,21),
					new SqlParameter("@SamplingDate", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Sex", SqlDbType.Int,4),
					new SqlParameter("@BirthDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_InfectionWay", SqlDbType.Int,4),
					new SqlParameter("@CD4", SqlDbType.NVarChar,50),
					new SqlParameter("@ViralLoad", SqlDbType.NVarChar,50),
					new SqlParameter("@HCV", SqlDbType.NVarChar,50),
					new SqlParameter("@HBV", SqlDbType.NVarChar,50),
					new SqlParameter("@TB", SqlDbType.NVarChar,50),
					new SqlParameter("@Syphilis", SqlDbType.NVarChar,50),
					new SqlParameter("@Others", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@SendingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Flag", SqlDbType.Int,4),
					new SqlParameter("@showToUser", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_SampleType", SqlDbType.Int,4),
					new SqlParameter("@FK_SampleSize", SqlDbType.Int,4),
                    new SqlParameter("@ID_Card", SqlDbType.NVarChar,18),
                    new SqlParameter("@Operator_id", SqlDbType.Int,4),};
			parameters[0].Value = model.PreservePosition;
			parameters[1].Value = model.FlowNumber;
			parameters[2].Value = model.ConfirmationNumber;
			parameters[3].Value = model.ConfirmationDate;
			parameters[4].Value = model.DirectReportNumber;
			parameters[5].Value = model.SamplingDate;
			parameters[6].Value = model.Name;
			parameters[7].Value = model.FK_Sex;
			parameters[8].Value = model.BirthDate;
			parameters[9].Value = model.FK_InfectionWay;
			parameters[10].Value = model.CD4;
			parameters[11].Value = model.ViralLoad;
			parameters[12].Value = model.HCV;
			parameters[13].Value = model.HBV;
			parameters[14].Value = model.TB;
			parameters[15].Value = model.Syphilis;
			parameters[16].Value = model.Others;
			parameters[17].Value = model.FK_User;
			parameters[18].Value = model.SendingTime;
			parameters[19].Value = model.FK_Flag;
			parameters[20].Value = model.showToUser;
			parameters[21].Value = model.VerifyDate;
			parameters[22].Value = model.FK_SampleType;
			parameters[23].Value = model.FK_SampleSize;
            parameters[24].Value = model.Id_card;
            parameters[25].Value = model.Operator_id;
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public void Update(Model.Draft_yxyb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Draft_yxyb set ");
			strSql.Append("PreservePosition=@PreservePosition,");
			strSql.Append("FlowNumber=@FlowNumber,");
			strSql.Append("ConfirmationNumber=@ConfirmationNumber,");
			strSql.Append("ConfirmationDate=@ConfirmationDate,");
			strSql.Append("DirectReportNumber=@DirectReportNumber,");
			strSql.Append("SamplingDate=@SamplingDate,");
			strSql.Append("Name=@Name,");
			strSql.Append("FK_Sex=@FK_Sex,");
			strSql.Append("BirthDate=@BirthDate,");
			strSql.Append("FK_InfectionWay=@FK_InfectionWay,");
			strSql.Append("CD4=@CD4,");
			strSql.Append("ViralLoad=@ViralLoad,");
			strSql.Append("HCV=@HCV,");
			strSql.Append("HBV=@HBV,");
			strSql.Append("TB=@TB,");
			strSql.Append("Syphilis=@Syphilis,");
			strSql.Append("Others=@Others,");
			strSql.Append("FK_User=@FK_User,");
			strSql.Append("SendingTime=@SendingTime,");
			strSql.Append("FK_Flag=@FK_Flag,");
			strSql.Append("showToUser=@showToUser,");
			strSql.Append("VerifyDate=@VerifyDate,");
			strSql.Append("FK_SampleType=@FK_SampleType,");
			strSql.Append("FK_SampleSize=@FK_SampleSize,");
            strSql.Append("Id_Card=@Id_Card");

			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PreservePosition", SqlDbType.NVarChar,50),
					new SqlParameter("@FlowNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@ConfirmationNumber", SqlDbType.NVarChar,10),
					new SqlParameter("@ConfirmationDate", SqlDbType.NVarChar,50),
					new SqlParameter("@DirectReportNumber", SqlDbType.NVarChar,21),
					new SqlParameter("@SamplingDate", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Sex", SqlDbType.Int,4),
					new SqlParameter("@BirthDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_InfectionWay", SqlDbType.Int,4),
					new SqlParameter("@CD4", SqlDbType.NVarChar,50),
					new SqlParameter("@ViralLoad", SqlDbType.NVarChar,50),
					new SqlParameter("@HCV", SqlDbType.NVarChar,50),
					new SqlParameter("@HBV", SqlDbType.NVarChar,50),
					new SqlParameter("@TB", SqlDbType.NVarChar,50),
					new SqlParameter("@Syphilis", SqlDbType.NVarChar,50),
					new SqlParameter("@Others", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@SendingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Flag", SqlDbType.Int,4),
					new SqlParameter("@showToUser", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_SampleType", SqlDbType.Int,4),
					new SqlParameter("@FK_SampleSize", SqlDbType.Int,4),
                    new SqlParameter("@Id_Card", SqlDbType.NVarChar,18)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PreservePosition;
			parameters[2].Value = model.FlowNumber;
			parameters[3].Value = model.ConfirmationNumber;
			parameters[4].Value = model.ConfirmationDate;
			parameters[5].Value = model.DirectReportNumber;
			parameters[6].Value = model.SamplingDate;
			parameters[7].Value = model.Name;
			parameters[8].Value = model.FK_Sex;
			parameters[9].Value = model.BirthDate;
			parameters[10].Value = model.FK_InfectionWay;
			parameters[11].Value = model.CD4;
			parameters[12].Value = model.ViralLoad;
			parameters[13].Value = model.HCV;
			parameters[14].Value = model.HBV;
			parameters[15].Value = model.TB;
			parameters[16].Value = model.Syphilis;
			parameters[17].Value = model.Others;
			parameters[18].Value = model.FK_User;
			parameters[19].Value = model.SendingTime;
			parameters[20].Value = model.FK_Flag;
			parameters[21].Value = model.showToUser;
			parameters[22].Value = model.VerifyDate;
			parameters[23].Value = model.FK_SampleType;
			parameters[24].Value = model.FK_SampleSize;
            parameters[25].Value = model.Id_card;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete Draft_yxyb ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Model.Draft_yxyb GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,PreservePosition,FlowNumber,ConfirmationNumber,ConfirmationDate,DirectReportNumber,SamplingDate,Name,FK_Sex,BirthDate,FK_InfectionWay,CD4,ViralLoad,HCV,HBV,TB,Syphilis,Others,FK_User,SendingTime,FK_Flag,showToUser,VerifyDate,FK_SampleType,FK_SampleSize,Id_Card,Operator_id from Draft_yxyb ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.Draft_yxyb model=new Model.Draft_yxyb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.PreservePosition=ds.Tables[0].Rows[0]["PreservePosition"].ToString();
				model.FlowNumber=ds.Tables[0].Rows[0]["FlowNumber"].ToString();
				model.ConfirmationNumber=ds.Tables[0].Rows[0]["ConfirmationNumber"].ToString();
				model.ConfirmationDate=ds.Tables[0].Rows[0]["ConfirmationDate"].ToString();
				model.DirectReportNumber=ds.Tables[0].Rows[0]["DirectReportNumber"].ToString();
				model.SamplingDate=ds.Tables[0].Rows[0]["SamplingDate"].ToString();
				model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				if(ds.Tables[0].Rows[0]["FK_Sex"].ToString()!="")
				{
					model.FK_Sex=int.Parse(ds.Tables[0].Rows[0]["FK_Sex"].ToString());
				}
				model.BirthDate=ds.Tables[0].Rows[0]["BirthDate"].ToString();
				if(ds.Tables[0].Rows[0]["FK_InfectionWay"].ToString()!="")
				{
					model.FK_InfectionWay=int.Parse(ds.Tables[0].Rows[0]["FK_InfectionWay"].ToString());
				}
				model.CD4=ds.Tables[0].Rows[0]["CD4"].ToString();
				model.ViralLoad=ds.Tables[0].Rows[0]["ViralLoad"].ToString();
				model.HCV=int.Parse(ds.Tables[0].Rows[0]["HCV"].ToString());
				model.HBV=int.Parse(ds.Tables[0].Rows[0]["HBV"].ToString());
				model.TB=int.Parse(ds.Tables[0].Rows[0]["TB"].ToString());
                if (ds.Tables[0].Rows[0]["Syphilis"].ToString() != "")
                {
                    model.Syphilis = int.Parse(ds.Tables[0].Rows[0]["Syphilis"].ToString());
                }
				model.Others=ds.Tables[0].Rows[0]["Others"].ToString();
				if(ds.Tables[0].Rows[0]["FK_User"].ToString()!="")
				{
					model.FK_User=int.Parse(ds.Tables[0].Rows[0]["FK_User"].ToString());
				}
				model.SendingTime=ds.Tables[0].Rows[0]["SendingTime"].ToString();
				if(ds.Tables[0].Rows[0]["FK_Flag"].ToString()!="")
				{
					model.FK_Flag=int.Parse(ds.Tables[0].Rows[0]["FK_Flag"].ToString());
				}
				if(ds.Tables[0].Rows[0]["showToUser"].ToString()!="")
				{
					model.showToUser=int.Parse(ds.Tables[0].Rows[0]["showToUser"].ToString());
				}
				model.VerifyDate=ds.Tables[0].Rows[0]["VerifyDate"].ToString();
				if(ds.Tables[0].Rows[0]["FK_SampleType"].ToString()!="")
				{
					model.FK_SampleType=int.Parse(ds.Tables[0].Rows[0]["FK_SampleType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FK_SampleSize"].ToString()!="")
				{
					model.FK_SampleSize=int.Parse(ds.Tables[0].Rows[0]["FK_SampleSize"].ToString());
				}
                if (ds.Tables[0].Rows[0]["Id_Card"].ToString() != "")
                {
                    model.Id_card = ds.Tables[0].Rows[0]["Id_Card"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Operator_id"].ToString() != "")
                {
                    model.Id_card = ds.Tables[0].Rows[0]["Operator_id"].ToString();
                }
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
            strSql.Append("select ID,PreservePosition,FlowNumber,ConfirmationNumber,ConfirmationDate,DirectReportNumber,SamplingDate,Name,FK_Sex,BirthDate,FK_InfectionWay,CD4,ViralLoad,HCV,HBV,TB,Syphilis,Others,FK_User,SendingTime,FK_Flag,showToUser,VerifyDate,FK_SampleType,FK_SampleSize,Id_Card,Operator_id ");
			strSql.Append(" FROM Draft_yxyb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
            strSql.Append(" FROM Draft_yxyb ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetViewList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Draft_yxyb ");
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
            strSql.Append(" FROM Draft_yxyb ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�ͨ��ID
        /// </summary>
        public DataSet GetDetailedViewByID(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Draft_yxyb ");
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
            strSql.Append(" FROM (SELECT ROW_NUMBER() OVER(Order by SendingTime DESC) AS rownum,* FROM Draft_yxyb ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" Where " + strWhere);
            }
            strSql.Append(" ) AS D ");

            strSql.Append(" where rownum between " + StartIndex + " and " + EndIndex + " ");

            return DbHelperSQL.Query(strSql.ToString());
        }

      
		#endregion  ��Ա����
	}
}

