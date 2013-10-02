using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
    /// <summary>
    /// ҵ���߼���tb_log ��ժҪ˵����
    /// </summary>
    public class tb_log
    {
        private readonly DAL.tb_log dal = new DAL.tb_log();
        public tb_log()
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
        public int Add(Model.tb_log model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.tb_log model)
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
        public Model.tb_log GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ����С�
        /// </summary>
        public Model.tb_log GetModelByCache(int ID)
        {

            string CacheKey = "tb_logModel-" + ID;
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
            return (Model.tb_log)objModel;
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
        public List<Model.tb_log> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<Model.tb_log> modelList = new List<Model.tb_log>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                Model.tb_log model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.tb_log();
                    if (ds.Tables[0].Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["FK_User"].ToString() != "")
                    {
                        model.FK_User = int.Parse(ds.Tables[0].Rows[n]["FK_User"].ToString());
                    }
                    model.OperationDate = ds.Tables[0].Rows[n]["OperationDate"].ToString();
                    model.OperatingPosition = ds.Tables[0].Rows[n]["OperatingPosition"].ToString();
                    model.Operation = ds.Tables[0].Rows[n]["Operation"].ToString();
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
        #endregion  ��Ա����
    }
}

