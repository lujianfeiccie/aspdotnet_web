using System;
namespace Model
{
    /// <summary>
    /// ʵ����tb_log ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    public class tb_log
    {
        public tb_log()
        { }
        #region Model
        private int _id;
        private int? _fk_user;
        private string _operationdate;
        private string _operatingposition;
        private string _operation;
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
        public int? FK_User
        {
            set { _fk_user = value; }
            get { return _fk_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OperationDate
        {
            set { _operationdate = value; }
            get { return _operationdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OperatingPosition
        {
            set { _operatingposition = value; }
            get { return _operatingposition; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Operation
        {
            set { _operation = value; }
            get { return _operation; }
        }
        #endregion Model

    }
}

