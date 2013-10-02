using System;
namespace Model
{
	/// <summary>
	/// 实体类tb_role 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class tb_role
	{
		public tb_role()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _bz;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bz
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		#endregion Model

	}
}

