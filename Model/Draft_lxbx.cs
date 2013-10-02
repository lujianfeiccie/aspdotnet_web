using System;
namespace Model
{
    /// <summary>
    /// 实体类tb_lxbx 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Draft_lxbx
    {
        public Draft_lxbx()
        { }
        #region Model
        private int _id;
        private string _confirmationnumber;
        private string _directreportnumber;
        private string _name;
        private string _id_card;
        private int? _fk_sex;
        private string _birthdate;
        private int? _fk_nationality;
        private int? _fk_marriagestatus;
        private int? _fk_education;
        private int? _fk_citizenship;
        private string _province;
        private string _county;
        private int? _fk_infectionway;
        private int? _fk_contacthistory;
        private int? _fk_jobcharacter;
        private int? _fk_detectionclass;
        private int? _fk_householdregister;
        private int? _fk_currentsituation;
        private string _positivedecisiondate;
        private string _toaidsdate;
        private int? _fk_district;
        private string _detailedaddress;
        private string _censorshipunit;
        private int? _fk_detectionstatement;
        private string _spouse;
        private string _children;
        private int? _fk_isdead;
        private string _remark;
        private int? _fk_user;
        private string _sendingtime;
        private int? _fk_flag;
        private int? _fk_showtouser;
        private string _verifydate;
        private int? _fk_children;
        private int? _fk_spouse;
        private int? _operator_id;
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
        public int? Operator_id
        {
            set { _operator_id = value; }
            get { return _operator_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ConfirmationNumber
        {
            set { _confirmationnumber = value; }
            get { return _confirmationnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DirectReportNumber
        {
            set { _directreportnumber = value; }
            get { return _directreportnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Id_card
        {
            set { _id_card = value; }
            get {return _id_card;}
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Sex
        {
            set { _fk_sex = value; }
            get { return _fk_sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BirthDate
        {
            set { _birthdate = value; }
            get { return _birthdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Nationality
        {
            set { _fk_nationality = value; }
            get { return _fk_nationality; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_MarriageStatus
        {
            set { _fk_marriagestatus = value; }
            get { return _fk_marriagestatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Education
        {
            set { _fk_education = value; }
            get { return _fk_education; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Citizenship
        {
            set { _fk_citizenship = value; }
            get { return _fk_citizenship; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string County
        {
            set { _county = value; }
            get { return _county; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? FK_InfectionWay
        {
            set { _fk_infectionway = value; }
            get { return _fk_infectionway; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_ContactHistory
        {
            set { _fk_contacthistory = value; }
            get { return _fk_contacthistory; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_JobCharacter
        {
            set { _fk_jobcharacter = value; }
            get { return _fk_jobcharacter; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_DetectionClass
        {
            set { _fk_detectionclass = value; }
            get { return _fk_detectionclass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_HouseholdRegister
        {
            set { _fk_householdregister = value; }
            get { return _fk_householdregister; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_CurrentSituation
        {
            set { _fk_currentsituation = value; }
            get { return _fk_currentsituation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PositiveDecisionDate
        {
            set { _positivedecisiondate = value; }
            get { return _positivedecisiondate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToAidsDate
        {
            set { _toaidsdate = value; }
            get { return _toaidsdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_District
        {
            set { _fk_district = value; }
            get { return _fk_district; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DetailedAddress
        {
            set { _detailedaddress = value; }
            get { return _detailedaddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CensorshipUnit
        {
            set { _censorshipunit = value; }
            get { return _censorshipunit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_DetectionStatement
        {
            set { _fk_detectionstatement = value; }
            get { return _fk_detectionstatement; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Spouse
        {
            set { _spouse = value; }
            get { return _spouse; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Children
        {
            set { _children = value; }
            get { return _children; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_IsDead
        {
            set { _fk_isdead = value; }
            get { return _fk_isdead; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
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
        public string SendingTime
        {
            set { _sendingtime = value; }
            get { return _sendingtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Flag
        {
            set { _fk_flag = value; }
            get { return _fk_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_ShowToUser
        {
            set { _fk_showtouser = value; }
            get { return _fk_showtouser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VerifyDate
        {
            set { _verifydate = value; }
            get { return _verifydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Children
        {
            set { _fk_children = value; }
            get { return _fk_children; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Spouse
        {
            set { _fk_spouse = value; }
            get { return _fk_spouse; }
        }
        #endregion Model

    }
}

