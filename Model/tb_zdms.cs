using System;
namespace Model
{
	/// <summary>
	/// ʵ����tb_zdms ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class tb_zdms
	{
		public tb_zdms()
		{}
		#region Model
		private string _zdm;
		private string _zdms;
		/// <summary>
		/// 
		/// </summary>
		public string zdm
		{
			set{ _zdm=value;}
			get{return _zdm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zdms
		{
			set{ _zdms=value;}
			get{return _zdms;}
		}
		#endregion Model

	}
}

