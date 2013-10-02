using System;
using System.Data;
using System.Collections.Generic;

using Model;
namespace BLL
{
    /// <summary>
    /// ҵ���߼���tb_sfjc ��ժҪ˵����
    /// </summary>
    public class tb_sfjc
    {
        private readonly DAL.tb_sfjc dal = new DAL.tb_sfjc();
        public tb_sfjc()
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
        public int Add(Model.tb_sfjc model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.tb_sfjc model)
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
        public Model.tb_sfjc GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ����С�
        /// </summary>
        public Model.tb_sfjc GetModelByCache(int ID)
        {

            string CacheKey = "tb_sfjcModel-" + ID;
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
            return (Model.tb_sfjc)objModel;
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
        public List<Model.tb_sfjc> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<Model.tb_sfjc> modelList = new List<Model.tb_sfjc>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                Model.tb_sfjc model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.tb_sfjc();
                    if (ds.Tables[0].Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
                    }
                    model.DirectReportNumber = ds.Tables[0].Rows[n]["DirectReportNumber"].ToString();
                    model.ConfirmationNumber = ds.Tables[0].Rows[n]["ConfirmationNumber"].ToString();
                    model.ConfirmationDate = ds.Tables[0].Rows[n]["ConfirmationDate"].ToString();
                    model.Name = ds.Tables[0].Rows[n]["Name"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_Sex"].ToString() != "")
                    {
                        model.FK_Sex = int.Parse(ds.Tables[0].Rows[n]["FK_Sex"].ToString());
                    }
                    model.BirthDate = ds.Tables[0].Rows[n]["BirthDate"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_InfectionWay"].ToString() != "")
                    {
                        model.FK_InfectionWay = int.Parse(ds.Tables[0].Rows[n]["FK_InfectionWay"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_CurrentSituation"].ToString() != "")
                    {
                        model.FK_CurrentSituation = int.Parse(ds.Tables[0].Rows[n]["FK_CurrentSituation"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_District"].ToString() != "")
                    {
                        model.FK_District = int.Parse(ds.Tables[0].Rows[n]["FK_District"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_TypeOfTreatment"].ToString() != "")
                    {
                        model.FK_TypeOfTreatment = int.Parse(ds.Tables[0].Rows[n]["FK_TypeOfTreatment"].ToString());
                    }
                    model.AddingTime = ds.Tables[0].Rows[n]["AddingTime"].ToString();
                    model.TreatmentNumber = ds.Tables[0].Rows[n]["TreatmentNumber"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_MaintainStatus"].ToString() != "")
                    {
                        model.FK_MaintainStatus = int.Parse(ds.Tables[0].Rows[n]["FK_MaintainStatus"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_FirstFollowUpVisit"].ToString() != "")
                    {
                        model.FK_FirstFollowUpVisit = int.Parse(ds.Tables[0].Rows[n]["FK_FirstFollowUpVisit"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_FollowUpIntervention"].ToString() != "")
                    {
                        model.FK_FollowUpIntervention = int.Parse(ds.Tables[0].Rows[n]["FK_FollowUpIntervention"].ToString());
                    }
                    model.CD4 = ds.Tables[0].Rows[n]["CD4"].ToString();
                    model.ViralLoad = ds.Tables[0].Rows[n]["ViralLoad"].ToString();
                    if (ds.Tables[0].Rows[n]["FK_Spouse_AntibodyDetection"].ToString() != "")
                    {
                        model.FK_Spouse_AntibodyDetection = int.Parse(ds.Tables[0].Rows[n]["FK_Spouse_AntibodyDetection"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_DetectBefore"].ToString() != "")
                    {
                        model.FK_DetectBefore = int.Parse(ds.Tables[0].Rows[n]["FK_DetectBefore"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_Children_AntibodyDetection"].ToString() != "")
                    {
                        model.FK_Children_AntibodyDetection = int.Parse(ds.Tables[0].Rows[n]["FK_Children_AntibodyDetection"].ToString());
                    }
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
                    if (ds.Tables[0].Rows[n]["showToUser"].ToString() != "")
                    {
                        model.showToUser = int.Parse(ds.Tables[0].Rows[n]["showToUser"].ToString());
                    }
                    model.VerifyDate = ds.Tables[0].Rows[n]["VerifyDate"].ToString();
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

