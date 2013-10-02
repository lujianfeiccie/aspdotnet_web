using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// ҵ���߼���tb_zdms ��ժҪ˵����
	/// </summary>
	public class tb_zdms
	{
		private readonly DAL.tb_zdms dal=new DAL.tb_zdms();
		public tb_zdms()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string zdm)
		{
			return dal.Exists(zdm);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(Model.tb_zdms model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Model.tb_zdms model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string zdm)
		{
			
			dal.Delete(zdm);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Model.tb_zdms GetModel(string zdm)
		{
			
			return dal.GetModel(zdm);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public Model.tb_zdms GetModelByCache(string zdm)
		{
			
			string CacheKey = "tb_zdmsModel-" + zdm;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(zdm);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.tb_zdms)objModel;
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
		public List<Model.tb_zdms> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<Model.tb_zdms> modelList = new List<Model.tb_zdms>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_zdms model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_zdms();
					model.zdm=ds.Tables[0].Rows[n]["zdm"].ToString();
					model.zdms=ds.Tables[0].Rows[n]["zdms"].ToString();
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

