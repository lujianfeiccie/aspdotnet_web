using System;
namespace Model
{
	/// <summary>
	/// 实体类TB_MarriageStatus 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class TB_MarriageStatus
	{
		public TB_MarriageStatus()
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

