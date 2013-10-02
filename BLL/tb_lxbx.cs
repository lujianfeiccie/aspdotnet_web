using System;
using System.Data;
using System.Collections.Generic;
using Model;
namespace BLL
{
    /// <summary>
    /// ҵ���߼���tb_lxbx ��ժҪ˵����
    /// </summary>
    public class tb_lxbx
    {
        private readonly DAL.tb_lxbx dal = new DAL.tb_lxbx();
        public tb_lxbx()
        { }
        #region  ��Ա����

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.tb_lxbx model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.tb_lxbx model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int ID)
        {

            dal.Delete(ID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.tb_lxbx GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ����С�
        /// </summary>
        public Model.tb_lxbx GetModelByCache(int ID)
        {

            string CacheKey = "tb_lxbxModel-" + ID;
            object objModel = LTP.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ID);
                    if (objModel != null)
                    {
                        int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.tb_lxbx)objModel;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Model.tb_lxbx> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<Model.tb_lxbx> modelList = new List<Model.tb_lxbx>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                Model.tb_lxbx model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.tb_lxbx();
                    if (ds.Tables[0].Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
                    }
                    model.ConfirmationNumber = ds.Tables[0].Rows[n]["ConfirmationNumber"].ToString();
                    model.DirectReportNumber = ds.Tables[0].Rows[n]["DirectReportNumber"].ToString();
                    model.Name = ds.Tables[0].Rows[n]["Name"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_Sex"].ToString() != "")
                    {
                        model.FK_Sex = int.Parse(ds.Tables[0].Rows[n]["FK_Sex"].ToString());
                    }
                    model.BirthDate = ds.Tables[0].Rows[n]["BirthDate"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_Nationality"].ToString() != "")
                    {
                        model.FK_Nationality = int.Parse(ds.Tables[0].Rows[n]["FK_Nationality"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_MarriageStatus"].ToString() != "")
                    {
                        model.FK_MarriageStatus = int.Parse(ds.Tables[0].Rows[n]["FK_MarriageStatus"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_Education"].ToString() != "")
                    {
                        model.FK_Education = int.Parse(ds.Tables[0].Rows[n]["FK_Education"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_Citizenship"].ToString() != "")
                    {
                        model.FK_Citizenship = int.Parse(ds.Tables[0].Rows[n]["FK_Citizenship"].ToString());
                    }
                    model.Province = ds.Tables[0].Rows[n]["Province"].ToString();
                    model.County = ds.Tables[0].Rows[n]["County"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_InfectionWay"].ToString() != "")
                    {
                        model.FK_InfectionWay = int.Parse(ds.Tables[0].Rows[n]["FK_InfectionWay"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_ContactHistory"].ToString() != "")
                    {
                        model.FK_ContactHistory = int.Parse(ds.Tables[0].Rows[n]["FK_ContactHistory"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_JobCharacter"].ToString() != "")
                    {
                        model.FK_JobCharacter = int.Parse(ds.Tables[0].Rows[n]["FK_JobCharacter"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_DetectionClass"].ToString() != "")
                    {
                        model.FK_DetectionClass = int.Parse(ds.Tables[0].Rows[n]["FK_DetectionClass"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_HouseholdRegister"].ToString() != "")
                    {
                        model.FK_HouseholdRegister = int.Parse(ds.Tables[0].Rows[n]["FK_HouseholdRegister"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_CurrentSituation"].ToString() != "")
                    {
                        model.FK_CurrentSituation = int.Parse(ds.Tables[0].Rows[n]["FK_CurrentSituation"].ToString());
                    }
                    model.PositiveDecisionDate = ds.Tables[0].Rows[n]["PositiveDecisionDate"].ToString();
                    model.ToAidsDate = ds.Tables[0].Rows[n]["ToAidsDate"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_District"].ToString() != "")
                    {
                        model.FK_District = int.Parse(ds.Tables[0].Rows[n]["FK_District"].ToString());
                    }
                    model.DetailedAddress = ds.Tables[0].Rows[n]["DetailedAddress"].ToString();
                    model.CensorshipUnit = ds.Tables[0].Rows[n]["CensorshipUnit"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_DetectionStatement"].ToString() != "")
                    {
                        model.FK_DetectionStatement = int.Parse(ds.Tables[0].Rows[n]["FK_DetectionStatement"].ToString());
                    }
                    model.Spouse = ds.Tables[0].Rows[n]["Spouse"].ToString();
                    model.Children = ds.Tables[0].Rows[n]["Children"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_IsDead"].ToString() != "")
                    {
                        model.FK_IsDead = int.Parse(ds.Tables[0].Rows[n]["FK_IsDead"].ToString());
                    }
                    model.Remark = ds.Tables[0].Rows[n]["Remark"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_User"].ToString() != "")
                    {
                        model.FK_User = int.Parse(ds.Tables[0].Rows[n]["FK_User"].ToString());
                    }
                    model.SendingTime = ds.Tables[0].Rows[n]["SendingTime"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_Flag"].ToString() != "")
                    {
                        model.FK_Flag = int.Parse(ds.Tables[0].Rows[n]["FK_Flag"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_ShowToUser"].ToString() != "")
                    {
                        model.FK_ShowToUser = int.Parse(ds.Tables[0].Rows[n]["FK_ShowToUser"].ToString());
                    }
                    model.VerifyDate = ds.Tables[0].Rows[n]["VerifyDate"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_Children"].ToString() != "")
                    {
                        model.FK_Children = int.Parse(ds.Tables[0].Rows[n]["FK_Children"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_Spouse"].ToString() != "")
                    {
                        model.FK_Spouse = int.Parse(ds.Tables[0].Rows[n]["FK_Spouse"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
         /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetViewAllList()
        {
            return dal.GetViewAllList();
        }
        /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetViewList(string strWhere)
        {
            return dal.GetViewList(strWhere);
        }
        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetViewList(int StartIndex, int EndIndex, string strWhere)
        {
            return dal.GetViewList(StartIndex, EndIndex, strWhere);
        }
         /// <summary>
        /// �����ͼ�����б�
        /// </summary>
        public DataSet GetDetailedViewAllList()
        {
            return dal.GetDetailedViewAllList();
        }
         /// <summary>
        /// �����ͼ�����б�ͨ��ID
        /// </summary>
        public DataSet GetDetailedViewByID(int id)
        {
            return dal.GetDetailedViewByID(id);
        }
    
        /// <summary>
        /// �����ͼ�����б� 
        /// </summary>
        public DataSet GetDetailedViewList(string strWhere)
        {
            return dal.GetDetailedViewList(strWhere);
        }

        /// <summary>
        /// ����¼��
        /// 
        /// </summary>
        public int AddBatchData(DataSet ds)
        {
            return dal.AddBatchData(ds);
        }
        #endregion  ��Ա����
    }
}

