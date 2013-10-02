using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
    /// <summary>
    /// ҵ���߼���tb_comments ��ժҪ˵����
    /// </summary>
    public class tb_comments
    {
        private readonly DAL.tb_comments dal = new DAL.tb_comments();
        public tb_comments()
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
        public int Add(Model.tb_comments model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.tb_comments model)
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
        public Model.tb_comments GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ����С�
        /// </summary>
        public Model.tb_comments GetModelByCache(int ID)
        {

            string CacheKey = "tb_commentsModel-" + ID;
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
            return (Model.tb_comments)objModel;
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
        public List<Model.tb_comments> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<Model.tb_comments> modelList = new List<Model.tb_comments>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                Model.tb_comments model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.tb_comments();
                    if (ds.Tables[0].Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
                    }
                    model.name = ds.Tables[0].Rows[n]["name"].ToString();
                    model.email = ds.Tables[0].Rows[n]["email"].ToString();
                    model.qq = ds.Tables[0].Rows[n]["qq"].ToString();
                    model.content = ds.Tables[0].Rows[n]["content"].ToString();
                    model.addTime = ds.Tables[0].Rows[n]["addTime"].ToString();
                    model.reply = ds.Tables[0].Rows[n]["reply"].ToString();
                    if (ds.Tables[0].Rows[n]["isreply"].ToString() != "")
                    {
                        if ((ds.Tables[0].Rows[n]["isreply"].ToString() == "1") || (ds.Tables[0].Rows[n]["isreply"].ToString().ToLower() == "true"))
                        {
                            model.isreply = true;
                        }
                        else
                        {
                            model.isreply = false;
                        }
                    }
                    if (ds.Tables[0].Rows[n]["unread"].ToString() != "")
                    {
                        if ((ds.Tables[0].Rows[n]["unread"].ToString() == "1") || (ds.Tables[0].Rows[n]["unread"].ToString().ToLower() == "true"))
                        {
                            model.unread = true;
                        }
                        else
                        {
                            model.unread = false;
                        }
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
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetList(int StartIndex, int EndIndex, string strWhere)
        {
            return dal.GetList(StartIndex, EndIndex, strWhere);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  ��Ա����
    }
}

