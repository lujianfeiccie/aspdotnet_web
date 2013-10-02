using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// ҵ���߼���tb_user ��ժҪ˵����
	/// </summary>
	public class tb_user
	{
		private readonly DAL.tb_user dal=new DAL.tb_user();
		public tb_user()
		{}
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
        /// �Ƿ���ڸü�¼
       /// </summary>
       /// <param name="username">�û���</param>
       /// <param name="password">����</param>
       /// <returns></returns>
        public bool Exists(string username, string password)
        {

            return (dal.GetList(" UserName='" + username + "'  AND PassWord='" + password + "' ").Tables[0].Rows.Count!=0);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Model.tb_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Model.tb_user model)
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
		public Model.tb_user GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}
        /// <summary>
        /// �õ�һ������ʵ��
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
		/// �õ�һ������ʵ�壬�ӻ����С�
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ��������б�
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

