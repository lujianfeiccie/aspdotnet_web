using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// 业务逻辑类tb_zdms 的摘要说明。
	/// </summary>
	public class tb_zdms
	{
		private readonly DAL.tb_zdms dal=new DAL.tb_zdms();
		public tb_zdms()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string zdm)
		{
			return dal.Exists(zdm);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Model.tb_zdms model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Model.tb_zdms model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string zdm)
		{
			
			dal.Delete(zdm);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_zdms GetModel(string zdm)
		{
			
			return dal.GetModel(zdm);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

