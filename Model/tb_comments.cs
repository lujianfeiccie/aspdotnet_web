using System;
namespace Model
{
    /// <summary>
    /// 实体类tb_comments 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class tb_comments
    {
        public tb_comments()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _email;
        private string _qq;
        private string _content;
        private string _addtime;
        private string _reply;
        private bool _isreply;
        private bool _unread;
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
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qq
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reply
        {
            set { _reply = value; }
            get { return _reply; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool isreply
        {
            set { _isreply = value; }
            get { return _isreply; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool unread
        {
            set { _unread = value; }
            get { return _unread; }
        }
        #endregion Model

    }
}

