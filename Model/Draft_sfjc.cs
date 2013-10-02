using System;
namespace Model
{
    /// <summary>
    /// 实体类tb_sfjc 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class Draft_sfjc
    {
        public Draft_sfjc()
        { }
        #region Model
        private int _id;
        private string _directreportnumber;
        private string _confirmationnumber;
        private string _confirmationdate;
        private string _name;
        private string _id_card;
        private int _fk_sex;
        private string _birthdate;
        private int? _fk_infectionway;
        private int? _fk_currentsituation;
        private int? _fk_district;
        private int? _fk_typeoftreatment;
        private string _addingtime;
        private string _treatmentnumber;
        private int? _fk_maintainstatus;
        private int? _fk_firstfollowupvisit;
        private int? _fk_followupintervention;
        private string _cd4;
        private string _viralload;
        private int? _fk_spouse_antibodydetection;
        private int? _fk_detectbefore;
        private int? _fk_children_antibodydetection;
        private int? _fk_isdead;
        private string _remark;
        private int _fk_user;
        private string _sendingtime;
        private int? _fk_flag;
        private int? _showtouser;
        private string _verifydate;
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
        public string DirectReportNumber
        {
            set { _directreportnumber = value; }
            get { return _directreportnumber; }
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
        public string ConfirmationDate
        {
            set { _confirmationdate = value; }
            get { return _confirmationdate; }
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
            get { return _id_card; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int FK_Sex
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
        public int? FK_InfectionWay
        {
            set { _fk_infectionway = value; }
            get { return _fk_infectionway; }
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
        public int? FK_District
        {
            set { _fk_district = value; }
            get { return _fk_district; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_TypeOfTreatment
        {
            set { _fk_typeoftreatment = value; }
            get { return _fk_typeoftreatment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AddingTime
        {
            set { _addingtime = value; }
            get { return _addingtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TreatmentNumber
        {
            set { _treatmentnumber = value; }
            get { return _treatmentnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_MaintainStatus
        {
            set { _fk_maintainstatus = value; }
            get { return _fk_maintainstatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_FirstFollowUpVisit
        {
            set { _fk_firstfollowupvisit = value; }
            get { return _fk_firstfollowupvisit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_FollowUpIntervention
        {
            set { _fk_followupintervention = value; }
            get { return _fk_followupintervention; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CD4
        {
            set { _cd4 = value; }
            get { return _cd4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ViralLoad
        {
            set { _viralload = value; }
            get { return _viralload; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Spouse_AntibodyDetection
        {
            set { _fk_spouse_antibodydetection = value; }
            get { return _fk_spouse_antibodydetection; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_DetectBefore
        {
            set { _fk_detectbefore = value; }
            get { return _fk_detectbefore; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FK_Children_AntibodyDetection
        {
            set { _fk_children_antibodydetection = value; }
            get { return _fk_children_antibodydetection; }
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
        public int FK_User
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
        public int? showToUser
        {
            set { _showtouser = value; }
            get { return _showtouser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VerifyDate
        {
            set { _verifydate = value; }
            get { return _verifydate; }
        }
        #endregion Model

    }
}

