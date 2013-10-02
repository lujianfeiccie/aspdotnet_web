using System;
namespace Model
{
	/// <summary>
	/// 实体类tb_desc 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class tb_desc
	{
		public tb_desc()
		{}
		#region Model
        private int _id;
		private string _zdmc;
		private int _zid;
		private string _zdz;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string zdmc
		{
			set{ _zdmc=value;}
			get{return _zdmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int zID
		{
			set{ _zid=value;}
			get{return _zid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zdz
		{
			set{ _zdz=value;}
			get{return _zdz;}
		}
		#endregion Model

	}
}

