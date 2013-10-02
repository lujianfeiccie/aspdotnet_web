using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// 业务逻辑类tb_user 的摘要说明。
	/// </summary>
	public class tb_user
	{
		private readonly DAL.tb_user dal=new DAL.tb_user();
		public tb_user()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
            return dal.Exists(ID);
		}
       /// <summary>
        /// 是否存在该记录
       /// </summary>
       /// <param name="username">用户名</param>
       /// <param name="password">密码</param>
       /// <returns></returns>
        public bool Exists(string username, string password)
        {

            return (dal.GetList(" UserName='" + username + "'  AND PassWord='" + password + "' ").Tables[0].Rows.Count!=0);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.tb_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Model.tb_user model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.tb_user GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.tb_user GetModel(string username, string password)
        {
            Model.tb_user temp=new Model.tb_user();
            DataSet ds=dal.GetList(" UserName='" + username + "'  AND PassWord='" + password + "' ");
            temp.ID =Int32.Parse(ds.Tables[0].Rows[0]["ID"].ToString().Trim());
            temp.UserName = ds.Tables[0].Rows[0]["UserName"].ToString().Trim();
            temp.PassWord = ds.Tables[0].Rows[0]["PassWord"].ToString().Trim();
            temp.TrueName = ds.Tables[0].Rows[0]["TrueName"].ToString().Trim();
            temp.RoleID = Int32.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString().Trim());

            return temp;
        }

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public Model.tb_user GetModelByCache(int ID)
		{
			
			string CacheKey = "tb_userModel-" + ID;
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
				catch{}
			}
			return (Model.tb_user)objModel;
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
		public List<Model.tb_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<Model.tb_user> modelList = new List<Model.tb_user>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_user();
					if(ds.Tables[0].Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
					}
					model.UserName=ds.Tables[0].Rows[n]["UserName"].ToString();
					model.PassWord=ds.Tables[0].Rows[n]["PassWord"].ToString();
					if(ds.Tables[0].Rows[n]["RoleID"].ToString()!="")
					{
						model.RoleID=int.Parse(ds.Tables[0].Rows[n]["RoleID"].ToString());
					}
					model.TrueName=ds.Tables[0].Rows[n]["TrueName"].ToString();
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

