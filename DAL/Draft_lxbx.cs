using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//�����������
namespace DAL
{
    /// <summary>
    /// ���ݷ�����Draft_lxbx��
    /// </summary>
    public class Draft_lxbx
    {
        public Draft_lxbx()
        { }
        #region  ��Ա����

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "Draft_lxbx");
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Draft_lxbx");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.Draft_lxbx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Draft_lxbx(");
            strSql.Append("ConfirmationNumber,DirectReportNumber,Name,FK_Sex,BirthDate,FK_Nationality,FK_MarriageStatus,FK_Education,FK_Citizenship,Province,County,FK_InfectionWay,FK_ContactHistory,FK_JobCharacter,FK_DetectionClass,FK_HouseholdRegister,FK_CurrentSituation,PositiveDecisionDate,ToAidsDate,FK_District,DetailedAddress,CensorshipUnit,FK_DetectionStatement,Spouse,Children,FK_IsDead,Remark,FK_User,SendingTime,FK_Flag,FK_ShowToUser,VerifyDate,FK_Children,FK_Spouse,Id_Card,Operator_id)");
            strSql.Append(" values (");
            strSql.Append("@ConfirmationNumber,@DirectReportNumber,@Name,@FK_Sex,@BirthDate,@FK_Nationality,@FK_MarriageStatus,@FK_Education,@FK_Citizenship,@Province,@County,@FK_InfectionWay,@FK_ContactHistory,@FK_JobCharacter,@FK_DetectionClass,@FK_HouseholdRegister,@FK_CurrentSituation,@PositiveDecisionDate,@ToAidsDate,@FK_District,@DetailedAddress,@CensorshipUnit,@FK_DetectionStatement,@Spouse,@Children,@FK_IsDead,@Remark,@FK_User,@SendingTime,@FK_Flag,@FK_ShowToUser,@VerifyDate,@FK_Children,@FK_Spouse,@Id_Card,@Operator_id)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ConfirmationNumber", SqlDbType.NVarChar,12),
					new SqlParameter("@DirectReportNumber", SqlDbType.NVarChar,21),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Sex", SqlDbType.Int,4),
					new SqlParameter("@BirthDate", SqlDbType.NVarChar,15),
					new SqlParameter("@FK_Nationality", SqlDbType.Int,4),
					new SqlParameter("@FK_MarriageStatus", SqlDbType.Int,4),
					new SqlParameter("@FK_Education", SqlDbType.Int,4),
					new SqlParameter("@FK_Citizenship", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.NVarChar,20),
					new SqlParameter("@County", SqlDbType.NVarChar,20),
					new SqlParameter("@FK_InfectionWay", SqlDbType.Int,4),
					new SqlParameter("@FK_ContactHistory", SqlDbType.Int,4),
					new SqlParameter("@FK_JobCharacter", SqlDbType.Int,4),
					new SqlParameter("@FK_DetectionClass", SqlDbType.Int,4),
					new SqlParameter("@FK_HouseholdRegister", SqlDbType.Int,4),
					new SqlParameter("@FK_CurrentSituation", SqlDbType.Int,4),
					new SqlParameter("@PositiveDecisionDate", SqlDbType.NVarChar,15),
					new SqlParameter("@ToAidsDate", SqlDbType.NVarChar,15),
					new SqlParameter("@FK_District", SqlDbType.Int,4),
					new SqlParameter("@DetailedAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@CensorshipUnit", SqlDbType.NVarChar,100),
					new SqlParameter("@FK_DetectionStatement", SqlDbType.Int,4),
					new SqlParameter("@Spouse", SqlDbType.NVarChar,50),
					new SqlParameter("@Children", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_IsDead", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@SendingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Flag", SqlDbType.Int,4),
					new SqlParameter("@FK_ShowToUser", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Children", SqlDbType.Int,4),
					new SqlParameter("@FK_Spouse", SqlDbType.Int,4),
                    new SqlParameter("@ID_Card", SqlDbType.NVarChar,18),
                    new SqlParameter("@Operator_id", SqlDbType.Int,4)
                    };
            parameters[0].Value = model.ConfirmationNumber;
            parameters[1].Value = model.DirectReportNumber;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.FK_Sex;
            parameters[4].Value = model.BirthDate;
            parameters[5].Value = model.FK_Nationality;
            parameters[6].Value = model.FK_MarriageStatus;
            parameters[7].Value = model.FK_Education;
            parameters[8].Value = model.FK_Citizenship;
            parameters[9].Value = model.Province;
            parameters[10].Value = model.County;
            parameters[11].Value = model.FK_InfectionWay;
            parameters[12].Value = model.FK_ContactHistory;
            parameters[13].Value = model.FK_JobCharacter;
            parameters[14].Value = model.FK_DetectionClass;
            parameters[15].Value = model.FK_HouseholdRegister;
            parameters[16].Value = model.FK_CurrentSituation;
            parameters[17].Value = model.PositiveDecisionDate;
            parameters[18].Value = model.ToAidsDate;
            parameters[19].Value = model.FK_District;
            parameters[20].Value = model.DetailedAddress;
            parameters[21].Value = model.CensorshipUnit;
            parameters[22].Value = model.FK_DetectionStatement;
            parameters[23].Value = model.Spouse;
            parameters[24].Value = model.Children;
            parameters[25].Value = model.FK_IsDead;
            parameters[26].Value = model.Remark;
            parameters[27].Value = model.FK_User;
            parameters[28].Value = model.SendingTime;
            parameters[29].Value = model.FK_Flag;
            parameters[30].Value = model.FK_ShowToUser;
            parameters[31].Value = model.VerifyDate;
            parameters[32].Value = model.FK_Children;
            parameters[33].Value = model.FK_Spouse;
            parameters[34].Value = model.Id_card;
            parameters[35].Value = model.Operator_id;

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
        public void Update(Model.Draft_lxbx model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Draft_lxbx set ");
            strSql.Append("ConfirmationNumber=@ConfirmationNumber,");
            strSql.Append("DirectReportNumber=@DirectReportNumber,");
            strSql.Append("Name=@Name,");
            strSql.Append("FK_Sex=@FK_Sex,");
            strSql.Append("BirthDate=@BirthDate,");
            strSql.Append("FK_Nationality=@FK_Nationality,");
            strSql.Append("FK_MarriageStatus=@FK_MarriageStatus,");
            strSql.Append("FK_Education=@FK_Education,");
            strSql.Append("FK_Citizenship=@FK_Citizenship,");
            strSql.Append("Province=@Province,");
            strSql.Append("County=@County,");
            strSql.Append("FK_InfectionWay=@FK_InfectionWay,");
            strSql.Append("FK_ContactHistory=@FK_ContactHistory,");
            strSql.Append("FK_JobCharacter=@FK_JobCharacter,");
            strSql.Append("FK_DetectionClass=@FK_DetectionClass,");
            strSql.Append("FK_HouseholdRegister=@FK_HouseholdRegister,");
            strSql.Append("FK_CurrentSituation=@FK_CurrentSituation,");
            strSql.Append("PositiveDecisionDate=@PositiveDecisionDate,");
            strSql.Append("ToAidsDate=@ToAidsDate,");
            strSql.Append("FK_District=@FK_District,");
            strSql.Append("DetailedAddress=@DetailedAddress,");
            strSql.Append("CensorshipUnit=@CensorshipUnit,");
            strSql.Append("FK_DetectionStatement=@FK_DetectionStatement,");
            strSql.Append("Spouse=@Spouse,");
            strSql.Append("Children=@Children,");
            strSql.Append("FK_IsDead=@FK_IsDead,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("FK_User=@FK_User,");
            strSql.Append("SendingTime=@SendingTime,");
            strSql.Append("FK_Flag=@FK_Flag,");
            strSql.Append("FK_ShowToUser=@FK_ShowToUser,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("FK_Children=@FK_Children,");
            strSql.Append("FK_Spouse=@FK_Spouse,");
            strSql.Append("Id_Card=@Id_Card");
     
            
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ConfirmationNumber", SqlDbType.NVarChar,12),
					new SqlParameter("@DirectReportNumber", SqlDbType.NVarChar,21),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Sex", SqlDbType.Int,4),
					new SqlParameter("@BirthDate", SqlDbType.NVarChar,15),
					new SqlParameter("@FK_Nationality", SqlDbType.Int,4),
					new SqlParameter("@FK_MarriageStatus", SqlDbType.Int,4),
					new SqlParameter("@FK_Education", SqlDbType.Int,4),
					new SqlParameter("@FK_Citizenship", SqlDbType.Int,4),
					new SqlParameter("@Province", SqlDbType.NVarChar,20),
					new SqlParameter("@County", SqlDbType.NVarChar,20),
					new SqlParameter("@FK_InfectionWay", SqlDbType.Int,4),
					new SqlParameter("@FK_ContactHistory", SqlDbType.Int,4),
					new SqlParameter("@FK_JobCharacter", SqlDbType.Int,4),
					new SqlParameter("@FK_DetectionClass", SqlDbType.Int,4),
					new SqlParameter("@FK_HouseholdRegister", SqlDbType.Int,4),
					new SqlParameter("@FK_CurrentSituation", SqlDbType.Int,4),
					new SqlParameter("@PositiveDecisionDate", SqlDbType.NVarChar,15),
					new SqlParameter("@ToAidsDate", SqlDbType.NVarChar,15),
					new SqlParameter("@FK_District", SqlDbType.Int,4),
					new SqlParameter("@DetailedAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@CensorshipUnit", SqlDbType.NVarChar,100),
					new SqlParameter("@FK_DetectionStatement", SqlDbType.Int,4),
					new SqlParameter("@Spouse", SqlDbType.NVarChar,50),
					new SqlParameter("@Children", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_IsDead", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar),
					new SqlParameter("@FK_User", SqlDbType.Int,4),
					new SqlParameter("@SendingTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Flag", SqlDbType.Int,4),
					new SqlParameter("@FK_ShowToUser", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.NVarChar,50),
					new SqlParameter("@FK_Children", SqlDbType.Int,4),
					new SqlParameter("@FK_Spouse", SqlDbType.Int,4),
                    new SqlParameter("@Id_Card", SqlDbType.NVarChar,18),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.ConfirmationNumber;
            parameters[2].Value = model.DirectReportNumber;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.FK_Sex;
            parameters[5].Value = model.BirthDate;
            parameters[6].Value = model.FK_Nationality;
            parameters[7].Value = model.FK_MarriageStatus;
            parameters[8].Value = model.FK_Education;
            parameters[9].Value = model.FK_Citizenship;
            parameters[10].Value = model.Province;
            parameters[11].Value = model.County;
            parameters[12].Value = model.FK_InfectionWay;
            parameters[13].Value = model.FK_ContactHistory;
            parameters[14].Value = model.FK_JobCharacter;
            parameters[15].Value = model.FK_DetectionClass;
            parameters[16].Value = model.FK_HouseholdRegister;
            parameters[17].Value = model.FK_CurrentSituation;
            parameters[18].Value = model.PositiveDecisionDate;
            parameters[19].Value = model.ToAidsDate;
            parameters[20].Value = model.FK_District;
            parameters[21].Value = model.DetailedAddress;
            parameters[22].Value = model.CensorshipUnit;
            parameters[23].Value = model.FK_DetectionStatement;
            parameters[24].Value = model.Spouse;
            parameters[25].Value = model.Children;
            parameters[26].Value = model.FK_IsDead;
            parameters[27].Value = model.Remark;
            parameters[28].Value = model.FK_User;
            parameters[29].Value = model.SendingTime;
            parameters[30].Value = model.FK_Flag;
            parameters[31].Value = model.FK_ShowToUser;
            parameters[32].Value = model.VerifyDate;
            parameters[33].Value = model.FK_Children;
            parameters[34].Value = model.FK_Spouse;
            parameters[35].Value = model.Id_card;
            
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete Draft_lxbx ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.Draft_lxbx GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ConfirmationNumber,DirectReportNumber,Name,FK_Sex,BirthDate,FK_Nationality,FK_MarriageStatus,FK_Education,FK_Citizenship,Province,County,FK_InfectionWay,FK_ContactHistory,FK_JobCharacter,FK_DetectionClass,FK_HouseholdRegister,FK_CurrentSituation,PositiveDecisionDate,ToAidsDate,FK_District,DetailedAddress,CensorshipUnit,FK_DetectionStatement,Spouse,Children,FK_IsDead,Remark,FK_User,SendingTime,FK_Flag,FK_ShowToUser,VerifyDate,FK_Children,FK_Spouse,Id_Card,Operator_id from Draft_lxbx ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Model.Draft_lxbx model = new Model.Draft_lxbx();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.ConfirmationNumber = ds.Tables[0].Rows[0]["ConfirmationNumber"].ToString();
                model.DirectReportNumber = ds.Tables[0].Rows[0]["DirectReportNumber"].ToString();
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["FK_Sex"].ToString() != "")
                {
                    model.FK_Sex = int.Parse(ds.Tables[0].Rows[0]["FK_Sex"].ToString());
                }
                model.BirthDate = ds.Tables[0].Rows[0]["BirthDate"].ToString();
                if (ds.Tables[0].Rows[0]["FK_Nationality"].ToString() != "")
                {
                    model.FK_Nationality = int.Parse(ds.Tables[0].Rows[0]["FK_Nationality"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_MarriageStatus"].ToString() != "")
                {
                    model.FK_MarriageStatus = int.Parse(ds.Tables[0].Rows[0]["FK_MarriageStatus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_Education"].ToString() != "")
                {
                    model.FK_Education = int.Parse(ds.Tables[0].Rows[0]["FK_Education"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_Citizenship"].ToString() != "")
                {
                    model.FK_Citizenship = int.Parse(ds.Tables[0].Rows[0]["FK_Citizenship"].ToString());
                }
                model.Province = ds.Tables[0].Rows[0]["Province"].ToString();
                model.County = ds.Tables[0].Rows[0]["County"].ToString();
                if (ds.Tables[0].Rows[0]["FK_InfectionWay"].ToString() != "")
                {
                    model.FK_InfectionWay = int.Parse(ds.Tables[0].Rows[0]["FK_InfectionWay"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_ContactHistory"].ToString() != "")
                {
                    model.FK_ContactHistory = int.Parse(ds.Tables[0].Rows[0]["FK_ContactHistory"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_JobCharacter"].ToString() != "")
                {
                    model.FK_JobCharacter = int.Parse(ds.Tables[0].Rows[0]["FK_JobCharacter"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_DetectionClass"].ToString() != "")
                {
                    model.FK_DetectionClass = int.Parse(ds.Tables[0].Rows[0]["FK_DetectionClass"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_HouseholdRegister"].ToString() != "")
                {
                    model.FK_HouseholdRegister = int.Parse(ds.Tables[0].Rows[0]["FK_HouseholdRegister"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_CurrentSituation"].ToString() != "")
                {
                    model.FK_CurrentSituation = int.Parse(ds.Tables[0].Rows[0]["FK_CurrentSituation"].ToString());
                }
                model.PositiveDecisionDate = ds.Tables[0].Rows[0]["PositiveDecisionDate"].ToString();
                model.ToAidsDate = ds.Tables[0].Rows[0]["ToAidsDate"].ToString();
                if (ds.Tables[0].Rows[0]["FK_District"].ToString() != "")
                {
                    model.FK_District = int.Parse(ds.Tables[0].Rows[0]["FK_District"].ToString());
                }
                model.DetailedAddress = ds.Tables[0].Rows[0]["DetailedAddress"].ToString();
                model.CensorshipUnit = ds.Tables[0].Rows[0]["CensorshipUnit"].ToString();
                if (ds.Tables[0].Rows[0]["FK_DetectionStatement"].ToString() != "")
                {
                    model.FK_DetectionStatement = int.Parse(ds.Tables[0].Rows[0]["FK_DetectionStatement"].ToString());
                }
                model.Spouse = ds.Tables[0].Rows[0]["Spouse"].ToString();
                model.Children = ds.Tables[0].Rows[0]["Children"].ToString();
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
                if (ds.Tables[0].Rows[0]["FK_ShowToUser"].ToString() != "")
                {
                    model.FK_ShowToUser = int.Parse(ds.Tables[0].Rows[0]["FK_ShowToUser"].ToString());
                }
                model.VerifyDate = ds.Tables[0].Rows[0]["VerifyDate"].ToString();
                if (ds.Tables[0].Rows[0]["FK_Children"].ToString() != "")
                {
                    model.FK_Children = int.Parse(ds.Tables[0].Rows[0]["FK_Children"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FK_Spouse"].ToString() != "")
                {
                    model.FK_Spouse = int.Parse(ds.Tables[0].Rows[0]["FK_Spouse"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Id_Card"].ToString() != "")
                {
                    model.Id_card = ds.Tables[0].Rows[0]["Id_Card"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Operator_id"].ToString() != "")
                {
                    model.Operator_id = int.Parse(ds.Tables[0].Rows[0]["Operator_id"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ConfirmationNumber,DirectReportNumber,Name,FK_Sex,BirthDate,FK_Nationality,FK_MarriageStatus,FK_Education,FK_Citizenship,Province,County,FK_InfectionWay,FK_ContactHistory,FK_JobCharacter,FK_DetectionClass,FK_HouseholdRegister,FK_CurrentSituation,PositiveDecisionDate,ToAidsDate,FK_District,DetailedAddress,CensorshipUnit,FK_DetectionStatement,Spouse,Children,FK_IsDead,Remark,FK_User,SendingTime,FK_Flag,FK_ShowToUser,VerifyDate,FK_Children,FK_Spouse,Id_Card,Operator_id  ");
            strSql.Append(" FROM Draft_lxbx ");
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
            strSql.Append(" FROM Draft_lxbx ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetViewList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Draft_lxbx ");
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
            strSql.Append(" FROM Draft_lxbx ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ͼ�����б�ͨ��ID
        /// </summary>
        public DataSet GetDetailedViewByID(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Draft_lxbx ");
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
            strSql.Append(" FROM (SELECT ROW_NUMBER() OVER(Order by SendingTime DESC) AS rownum,* FROM Draft_lxbx ");
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
            strSql.Append(" FROM Draft_lxbx ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion  ��Ա����
    }
}

