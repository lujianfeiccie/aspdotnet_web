using System;
namespace Model
{
	/// <summary>
	/// 实体类tb_user 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class tb_user
	{
		public tb_user()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _password;
		private int _roleid;
		private string _truename;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TrueName
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		#endregion Model

	}
}

