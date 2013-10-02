using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Model;
namespace BLL
{
	/// <summary>
	/// ҵ���߼���temp_tb_yxyb ��ժҪ˵����
	/// </summary>
	public class temp_tb_yxyb
	{
		private readonly DAL.temp_tb_yxyb dal=new DAL.temp_tb_yxyb();
		public temp_tb_yxyb()
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
		/// ����һ������
		/// </summary>
		public int  Add(Model.tb_yxyb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Model.tb_yxyb model)
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
		public Model.tb_yxyb GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public Model.tb_yxyb GetModelByCache(int ID)
		{
			
			string CacheKey = "temp_tb_yxybModel-" + ID;
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
			return (Model.tb_yxyb)objModel;
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
		public List<Model.tb_yxyb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<Model.tb_yxyb> modelList = new List<Model.tb_yxyb>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				Model.tb_yxyb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.tb_yxyb();
					if(ds.Tables[0].Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
					}
					model.PreservePosition=ds.Tables[0].Rows[n]["PreservePosition"].ToString();
					model.FlowNumber=ds.Tables[0].Rows[n]["FlowNumber"].ToString();
					model.ConfirmationNumber=ds.Tables[0].Rows[n]["ConfirmationNumber"].ToString();
					model.ConfirmationDate=ds.Tables[0].Rows[n]["ConfirmationDate"].ToString();
					model.DirectReportNumber=ds.Tables[0].Rows[n]["DirectReportNumber"].ToString();
					model.SamplingDate=ds.Tables[0].Rows[n]["SamplingDate"].ToString();
					model.Name=ds.Tables[0].Rows[n]["Name"].ToString();
					if(ds.Tables[0].Rows[n]["FK_Sex"].ToString()!="")
					{
						model.FK_Sex=int.Parse(ds.Tables[0].Rows[n]["FK_Sex"].ToString());
					}
					model.BirthDate=ds.Tables[0].Rows[n]["BirthDate"].ToString();
					if(ds.Tables[0].Rows[n]["FK_InfectionWay"].ToString()!="")
					{
						model.FK_InfectionWay=int.Parse(ds.Tables[0].Rows[n]["FK_InfectionWay"].ToString());
					}
					model.CD4=ds.Tables[0].Rows[n]["CD4"].ToString();
					model.ViralLoad=ds.Tables[0].Rows[n]["ViralLoad"].ToString();
					model.HCV=int.Parse(ds.Tables[0].Rows[n]["HCV"].ToString());
					model.HBV=int.Parse(ds.Tables[0].Rows[n]["HBV"].ToString());
					model.TB=int.Parse(ds.Tables[0].Rows[n]["TB"].ToString());
					model.Syphilis=int.Parse(ds.Tables[0].Rows[n]["Syphilis"].ToString());
					model.Others=ds.Tables[0].Rows[n]["Others"].ToString();
					if(ds.Tables[0].Rows[n]["FK_User"].ToString()!="")
					{
						model.FK_User=int.Parse(ds.Tables[0].Rows[n]["FK_User"].ToString());
					}
					model.SendingTime=ds.Tables[0].Rows[n]["SendingTime"].ToString();
					if(ds.Tables[0].Rows[n]["FK_Flag"].ToString()!="")
					{
						model.FK_Flag=int.Parse(ds.Tables[0].Rows[n]["FK_Flag"].ToString());
					}
					if(ds.Tables[0].Rows[n]["showToUser"].ToString()!="")
					{
						model.showToUser=int.Parse(ds.Tables[0].Rows[n]["showToUser"].ToString());
					}
					model.VerifyDate=ds.Tables[0].Rows[n]["VerifyDate"].ToString();
					if(ds.Tables[0].Rows[n]["FK_SampleType"].ToString()!="")
					{
						model.FK_SampleType=int.Parse(ds.Tables[0].Rows[n]["FK_SampleType"].ToString());
					}
					if(ds.Tables[0].Rows[n]["FK_SampleSize"].ToString()!="")
					{
						model.FK_SampleSize=int.Parse(ds.Tables[0].Rows[n]["FK_SampleSize"].ToString());
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

		#endregion  ��Ա����
	}
}

