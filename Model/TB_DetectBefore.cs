using System;
namespace Model
{
	/// <summary>
	/// ʵ����TB_DetectBefore ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class TB_DetectBefore
	{
		public TB_DetectBefore()
		{}
		#region Model
		private int _id;
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

