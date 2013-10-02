using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//请先添加引用
namespace DAL
{
    /// <summary>
    /// 数据访问类temp_tb_sfjc。
    /// </summary>
    public class temp_tb_sfjc
    {
        public temp_tb_sfjc()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "temp_tb_sfjc");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from temp_tb_sfjc");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.tb_sfjc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into temp_tb_sfjc(");
            strSql.Append("DirectReportNumber,ConfirmationNumber,ConfirmationDate,Name,FK_Sex,BirthDate,FK_InfectionWay,FK_CurrentSituation,FK_District,FK_TypeOfTreatment,AddingTime,TreatmentNumber,FK_MaintainStatus,FK_FirstFollowUpVisit,FK_FollowUpIntervention,CD4,ViralLoad,FK_Spouse_AntibodyDetection,FK_DetectBefore,FK_Children_AntibodyDetection,FK_IsDead,Remark,FK_User,SendingTime,FK_Flag,showToUser,VerifyDate)");
            strSql.Append(" values (");
            strSql.Append("@DirectReportNumber,@ConfirmationNumber,@ConfirmationDate,@Name,@FK_Sex,@BirthDate,@FK_InfectionWay,@FK_CurrentSituation,@FK_District,@FK_TypeOfTreatment,@AddingTime,@TreatmentNumber,@FK_MaintainStatus,@FK_FirstFollowUpVisit,@FK_FollowUpIntervention,@CD4,@ViralLoad,@FK_Spouse_AntibodyDetection,@FK_DetectBefore,@FK_Children_AntibodyDetection,@FK_IsDead,@Remark,@FK_User,@SendingTime,@FK_Flag,@showToUser,@VerifyDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DirectReportNumber", SqlDbType.NVarChar,21),
					new SqlParameter("@ConfirmationNumber", SqlDbType.NVarChar,10),
					new SqlParameter("@ConfirmationDate", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Sex", SqlDbType.Int,4),
					new SqlParameter("@BirthDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_InfectionWay", SqlDbType.Int,4),
					new SqlParameter("@FK_CurrentSituation", SqlDbType.Int,4),
					new SqlParameter("@FK_District", SqlDbType.Int,4),
					new SqlParameter("@FK_TypeOfTreatment", SqlDbType.Int,4),
					new SqlParameter("@AddingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@TreatmentNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_MaintainStatus", SqlDbType.Int,4),
					new SqlParameter("@FK_FirstFollowUpVisit", SqlDbType.Int,4),
					new SqlParameter("@FK_FollowUpIntervention", SqlDbType.Int,4),
					new SqlParameter("@CD4", SqlDbType.NVarChar,50),
					new SqlParameter("@ViralLoad", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Spouse_AntibodyDetection", SqlDbType.Int,4),
					new SqlParameter("@FK_DetectBefore", SqlDbType.Int,4),
					new SqlParameter("@FK_Children_AntibodyDetection", SqlDbType.Int,4),
					new SqlParameter("@FK_IsDead", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@SendingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Flag", SqlDbType.Int,4),
					new SqlParameter("@showToUser", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.DirectReportNumber;
            parameters[1].Value = model.ConfirmationNumber;
            parameters[2].Value = model.ConfirmationDate;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.FK_Sex;
            parameters[5].Value = model.BirthDate;
            parameters[6].Value = model.FK_InfectionWay;
            parameters[7].Value = model.FK_CurrentSituation;
            parameters[8].Value = model.FK_District;
            parameters[9].Value = model.FK_TypeOfTreatment;
            parameters[10].Value = model.AddingTime;
            parameters[11].Value = model.TreatmentNumber;
            parameters[12].Value = model.FK_MaintainStatus;
            parameters[13].Value = model.FK_FirstFollowUpVisit;
            parameters[14].Value = model.FK_FollowUpIntervention;
            parameters[15].Value = model.CD4;
            parameters[16].Value = model.ViralLoad;
            parameters[17].Value = model.FK_Spouse_AntibodyDetection;
            parameters[18].Value = model.FK_DetectBefore;
            parameters[19].Value = model.FK_Children_AntibodyDetection;
            parameters[20].Value = model.FK_IsDead;
            parameters[21].Value = model.Remark;
            parameters[22].Value = model.FK_User;
            parameters[23].Value = model.SendingTime;
            parameters[24].Value = model.FK_Flag;
            parameters[25].Value = model.showToUser;
            parameters[26].Value = model.VerifyDate;

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
        public void Update(Model.tb_sfjc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update temp_tb_sfjc set ");
            strSql.Append("DirectReportNumber=@DirectReportNumber,");
            strSql.Append("ConfirmationNumber=@ConfirmationNumber,");
            strSql.Append("ConfirmationDate=@ConfirmationDate,");
            strSql.Append("Name=@Name,");
            strSql.Append("FK_Sex=@FK_Sex,");
            strSql.Append("BirthDate=@BirthDate,");
            strSql.Append("FK_InfectionWay=@FK_InfectionWay,");
            strSql.Append("FK_CurrentSituation=@FK_CurrentSituation,");
            strSql.Append("FK_District=@FK_District,");
            strSql.Append("FK_TypeOfTreatment=@FK_TypeOfTreatment,");
            strSql.Append("AddingTime=@AddingTime,");
            strSql.Append("TreatmentNumber=@TreatmentNumber,");
            strSql.Append("FK_MaintainStatus=@FK_MaintainStatus,");
            strSql.Append("FK_FirstFollowUpVisit=@FK_FirstFollowUpVisit,");
            strSql.Append("FK_FollowUpIntervention=@FK_FollowUpIntervention,");
            strSql.Append("CD4=@CD4,");
            strSql.Append("ViralLoad=@ViralLoad,");
            strSql.Append("FK_Spouse_AntibodyDetection=@FK_Spouse_AntibodyDetection,");
            strSql.Append("FK_DetectBefore=@FK_DetectBefore,");
            strSql.Append("FK_Children_AntibodyDetection=@FK_Children_AntibodyDetection,");
            strSql.Append("FK_IsDead=@FK_IsDead,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("FK_User=@FK_User,");
            strSql.Append("SendingTime=@SendingTime,");
            strSql.Append("FK_Flag=@FK_Flag,");
            strSql.Append("showToUser=@showToUser,");
            strSql.Append("VerifyDate=@VerifyDate");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DirectReportNumber", SqlDbType.NVarChar,21),
					new SqlParameter("@ConfirmationNumber", SqlDbType.NVarChar,10),
					new SqlParameter("@ConfirmationDate", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Sex", SqlDbType.Int,4),
					new SqlParameter("@BirthDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_InfectionWay", SqlDbType.Int,4),
					new SqlParameter("@FK_CurrentSituation", SqlDbType.Int,4),
					new SqlParameter("@FK_District", SqlDbType.Int,4),
					new SqlParameter("@FK_TypeOfTreatment", SqlDbType.Int,4),
					new SqlParameter("@AddingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@TreatmentNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_MaintainStatus", SqlDbType.Int,4),
					new SqlParameter("@FK_FirstFollowUpVisit", SqlDbType.Int,4),
					new SqlParameter("@FK_FollowUpIntervention", SqlDbType.Int,4),
					new SqlParameter("@CD4", SqlDbType.NVarChar,50),
					new SqlParameter("@ViralLoad", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Spouse_AntibodyDetection", SqlDbType.Int,4),
					new SqlParameter("@FK_DetectBefore", SqlDbType.Int,4),
					new SqlParameter("@FK_Children_AntibodyDetection", SqlDbType.Int,4),
					new SqlParameter("@FK_IsDead", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@SendingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Flag", SqlDbType.Int,4),
					new SqlParameter("@showToUser", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DirectReportNumber;
            parameters[2].Value = model.ConfirmationNumber;
            parameters[3].Value = model.ConfirmationDate;
            parameters[4].Value = model.Name;
            parameters[5].Value = model.FK_Sex;
            parameters[6].Value = model.BirthDate;
            parameters[7].Value = model.FK_InfectionWay;
            parameters[8].Value = model.FK_CurrentSituation;
            parameters[9].Value = model.FK_District;
            parameters[10].Value = model.FK_TypeOfTreatment;
            parameters[11].Value = model.AddingTime;
            parameters[12].Value = model.TreatmentNumber;
            parameters[13].Value = model.FK_MaintainStatus;
            parameters[14].Value = model.FK_FirstFollowUpVisit;
            parameters[15].Value = model.FK_FollowUpIntervention;
            parameters[16].Value = model.CD4;
            parameters[17].Value = model.ViralLoad;
            parameters[18].Value = model.FK_Spouse_AntibodyDetection;
            parameters[19].Value = model.FK_DetectBefore;
            parameters[20].Value = model.FK_Children_AntibodyDetection;
            parameters[21].Value = model.FK_IsDead;
            parameters[22].Value = model.Remark;
            parameters[23].Value = model.FK_User;
            parameters[24].Value = model.SendingTime;
            parameters[25].Value = model.FK_Flag;
            parameters[26].Value = model.showToUser;
            parameters[27].Value = model.VerifyDate;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete temp_tb_sfjc ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.tb_sfjc GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DirectReportNumber,ConfirmationNumber,ConfirmationDate,Name,FK_Sex,BirthDate,FK_InfectionWay,FK_CurrentSituation,FK_District,FK_TypeOfTreatment,AddingTime,TreatmentNumber,FK_MaintainStatus,FK_FirstFollowUpVisit,FK_FollowUpIntervention,CD4,ViralLoad,FK_Spouse_AntibodyDetection,FK_DetectBefore,FK_Children_AntibodyDetection,FK_IsDead,Remark,FK_User,SendingTime,FK_Flag,showToUser,VerifyDate from temp_tb_sfjc ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Model.tb_sfjc model = new Model.tb_sfjc();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.DirectReportNumber = ds.Tables[0].Rows[0]["DirectReportNumber"].ToString();
                model.ConfirmationNumber = ds.Tables[0].Rows[0]["ConfirmationNumber"].ToString();
                model.ConfirmationDate = ds.Tables[0].Rows[0]["ConfirmationDate"].ToString();
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["FK_Sex"].ToString() != "")
                {
                    model.FK_Sex = int.Parse(ds.Tables[0].Rows[0]["FK_Sex"].ToString());
                }
                model.BirthDate = ds.Tables[0].Rows[0]["BirthDate"].ToString();
                if (ds.Tables[0].Rows[0]["FK_InfectionWay"].ToString() != "")
                {
                    model.FK_InfectionWay = int.Parse(ds.Tables[0].Rows[0]["FK_InfectionWay"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_CurrentSituation"].ToString() != "")
                {
                    model.FK_CurrentSituation = int.Parse(ds.Tables[0].Rows[0]["FK_CurrentSituation"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_District"].ToString() != "")
                {
                    model.FK_District = int.Parse(ds.Tables[0].Rows[0]["FK_District"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_TypeOfTreatment"].ToString() != "")
                {
                    model.FK_TypeOfTreatment = int.Parse(ds.Tables[0].Rows[0]["FK_TypeOfTreatment"].ToString());
                }
                model.AddingTime = ds.Tables[0].Rows[0]["AddingTime"].ToString();
                model.TreatmentNumber = ds.Tables[0].Rows[0]["TreatmentNumber"].ToString();
                if (ds.Tables[0].Rows[0]["FK_MaintainStatus"].ToString() != "")
                {
                    model.FK_MaintainStatus = int.Parse(ds.Tables[0].Rows[0]["FK_MaintainStatus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_FirstFollowUpVisit"].ToString() != "")
                {
                    model.FK_FirstFollowUpVisit = int.Parse(ds.Tables[0].Rows[0]["FK_FirstFollowUpVisit"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_FollowUpIntervention"].ToString() != "")
                {
                    model.FK_FollowUpIntervention = int.Parse(ds.Tables[0].Rows[0]["FK_FollowUpIntervention"].ToString());
                }
                model.CD4 = ds.Tables[0].Rows[0]["CD4"].ToString();
                model.ViralLoad = ds.Tables[0].Rows[0]["ViralLoad"].ToString();
                if (ds.Tables[0].Rows[0]["FK_Spouse_AntibodyDetection"].ToString() != "")
                {
                    model.FK_Spouse_AntibodyDetection = int.Parse(ds.Tables[0].Rows[0]["FK_Spouse_AntibodyDetection"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_DetectBefore"].ToString() != "")
                {
                    model.FK_DetectBefore = int.Parse(ds.Tables[0].Rows[0]["FK_DetectBefore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_Children_AntibodyDetection"].ToString() != "")
                {
                    model.FK_Children_AntibodyDetection = int.Parse(ds.Tables[0].Rows[0]["FK_Children_AntibodyDetection"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_IsDead"].ToString() != "")
                {
                    model.FK_IsDead = int.Parse(ds.Tables[0].Rows[0]["FK_IsDead"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["FK_User"].ToString() != "")
                {
                    model.FK_User = int.Parse(ds.Tables[0].Rows[0]["FK_User"].ToString());
                }
                model.SendingTime = ds.Tables[0].Rows[0]["SendingTime"].ToString();
                if (ds.Tables[0].Rows[0]["FK_Flag"].ToString() != "")
                {
                    model.FK_Flag = int.Parse(ds.Tables[0].Rows[0]["FK_Flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["showToUser"].ToString() != "")
                {
                    model.showToUser = int.Parse(ds.Tables[0].Rows[0]["showToUser"].ToString());
                }
                model.VerifyDate = ds.Tables[0].Rows[0]["VerifyDate"].ToString();
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
            strSql.Append("select ID,DirectReportNumber,ConfirmationNumber,ConfirmationDate,Name,FK_Sex,BirthDate,FK_InfectionWay,FK_CurrentSituation,FK_District,FK_TypeOfTreatment,AddingTime,TreatmentNumber,FK_MaintainStatus,FK_FirstFollowUpVisit,FK_FollowUpIntervention,CD4,ViralLoad,FK_Spouse_AntibodyDetection,FK_DetectBefore,FK_Children_AntibodyDetection,FK_IsDead,Remark,FK_User,SendingTime,FK_Flag,showToUser,VerifyDate ");
            strSql.Append(" FROM temp_tb_sfjc ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得视图数据列表
        /// </summary>
        public DataSet GetViewAllList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_Temp_Sfjc ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得视图数据列表
        /// </summary>
        public DataSet GetViewList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_Temp_Sfjc ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得视图数据列表
        /// </summary>
        public DataSet GetDetailedViewAllList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_DetailedTemp_Sfjc ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得视图数据列表通过ID
        /// </summary>
        public DataSet GetDetailedViewByID(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM v_DetailedTemp_Sfjc ");
            strSql.Append(" where ID=@id");
            SqlParameter[] parameters ={
                 new SqlParameter("@id",SqlDbType.Int)
             };
            parameters[0].Value = id;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetViewList(int StartIndex, int EndIndex, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select * ");
            strSql.Append(" FROM (SELECT ROW_NUMBER() OVER(Order by SendingTime DESC) AS rownum,* FROM v_Temp_Sfjc ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" Where " + strWhere);
            }
            strSql.Append(" ) AS D ");

            strSql.Append(" where rownum between " + StartIndex + " and " + EndIndex + " ");

            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

