// JavaScript Document


/*****************************************************
 *  ��������DateCheck()
 *  ��  �ã�����ַ����Ƿ���ָ���Ĵ�С��Χ�ں��Ƿ��зǷ��ַ�
 *	��  ����date: Ҫ�����ַ���
 *          minum:  �ַ���С�ĳ���
 *  		maxnum: �ַ����ĳ���
 *  ����ֵ��True:   ���ݲ���ָ����Χ�ڻ��зǷ��ַ�
 *			False:  ������ָ����Χ���Ҳ����зǷ��ַ�
 ******************************************************
*/
function DateCheck(date,minnum,maxnum)
{
	if (date.length < minnum || date.length > maxnum ){
		window.alert("�������ݵĳ��Ȳ������� " + minnum + " λ���Ҳ��ܴ��� " + maxnum + " λ!");
		return true;
	}

	 a = date.indexOf("'");
	 b = date.indexOf("|");
	 c = date.indexOf("\"");

	 if (a != -1||b != -1 ||c != -1){
	   window.alert("�������뺬�������ַ������������룡");
	   return true;
	  	}
	return false;
}


/*****************************************************
 *  ��������	IsNum()
 *  ��  �ã�����ַ��Ƿ��Ǵ�����
 *	��  ����str: Ҫ�����ַ���
 *  ����ֵ��True:   ������
 *			False:  ���Ǵ�����
 ******************************************************
*/
function IsNum(str)
{
	return !/\D/.test(str)
}


/*****************************************************
 *  ��������	IsStr()
 *  ��  �ã�����ַ��Ƿ����ַ�
 *	��  ����str: Ҫ�����ַ�
 *  ����ֵ��True:   ���ַ�
 *			False:  ���Ǵ��ַ�
 ******************************************************
*/
function IsStr(str)
{
����if (/[^\x00-\xff]/g.test(str))
	{
		return false;
	}
����else
	{
		return true;
	}
}


/*****************************************************
 *  ��������IsEmail()
 *  ��  �ã����Email��ַ�Ƿ�Ϸ�
 *	��  ����date: Ҫ����Email��ַ
 *  ����ֵ��True: Email ��ַ�Ϸ�
 *          False:Email ��ַ���Ϸ�
 *****************************************************
*/
function IsEmail(vEMail)
{
	var regInvalid=/(@.*@)|(\.\.)|(@\.)|(\.@)|(^\.)/;
	var regValid=/^.+\@(\[?)[a-zA-Z0-9\-\.]+\.([a-zA-Z]{2,3}|[0-9]{1,3})(\]?)$/;
	return (!regInvalid.test(vEMail)&&regValid.test(vEMail));
}





/*****************************************************
 *  ��������CheckID()
 *  ��  �ã����ID�Ƿ�������
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckID(){
    var CheckID = false;

	var tb_ID = document.form1.tb_ID.value;

	if(!IsNum(tb_ID))
		{
			alert("�������봿����!");
			document.form1.tb_ID.focus();
			document.form1.tb_ID.value = "";
			return false;
		}
		
	return true;
}



/*****************************************************
 *  ��������CheckUser()
 *  ��  �ã�����û�����Ϣ
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckUser(){
    var CheckUser = false;
	var AdminName = document.User.AdminName.value;
	if (AdminName=="")
	{
	   alert("�û�������Ϊ��!");
	   document.User.AdminName.focus();
	   return false;
	 }

	if(DateCheck(AdminName,3,16))
	{
		document.User.AdminName.focus();
		document.User.AdminName.value = "";
		return false;
	}

	var AdminPwd = document.User.AdminPwd.value;
	if (AdminPwd=="")
	{
	   alert("���������Ա����!");
	   document.User.AdminPwd.focus();
	   return false;
	 }

	if(DateCheck(AdminPwd,4,16))
	{
		document.User.AdminPwd.focus();
		document.User.AdminPwd.value = "";
		return false;
	}

	var AdminPwd2 = document.User.AdminPwd2.value;
	if (AdminPwd2=="")
	{
	   alert("��������һ��������!");
	   document.User.AdminPwd2.focus();
	   return false;
	 }

	if(DateCheck(AdminPwd2,4,16))
	{
		document.User.AdminPwd.focus();
		document.User.AdminPwd.value = "";
		return false;
	}

	if (AdminPwd != AdminPwd2)
	{
		alert("��������������벻һ�£��������룡");
		document.User.AdminPwd.focus();
		document.User.AdminPwd.value = "";
		document.User.AdminPwd2.value = "";
		return false;
	}

	var UserName = document.User.UserName.value;
	if (UserName=="")
	{
	   alert("��ʵ��������Ϊ��!");
	   document.User.UserName.focus();
	   return false;
	 }

	if(DateCheck(UserName,2,16))
	{
		document.User.UserName.focus();
		document.User.UserName.value = "";
		return false;
	}

	var UserEmail = document.User.UserEmail.value;
	if (UserEmail=="")
	{
	   alert("����������ʼ�!");
	   document.User.UserEmail.focus();
	   return false;
	 }


	if(!IsEmail(UserEmail ))
	{
		alert("��������ȷ�ĵ������䣡");
		document.User.UserEmail .focus();
		document.User.UserEmail .value = "";
		return false;
	}

	var UserQQ = document.User.UserQQ.value;
	if (UserQQ != "")
	{
		if(!IsNum(UserQQ))
		{
			alert("�������QQ���Ǵ�����,���û��QQ�벻Ҫ��д!");
			document.User.UserQQ.focus();
			document.User.UserQQ.value = "";
			return false;
		}
		if(DateCheck(UserQQ,4,10))
		{
			document.User.UserQQ.focus();
			document.User.UserQQ.value = "";
			return false;
		}
	}
}


/*****************************************************
 *  ��������CheckEditUser()
 *  ��  �ã�����û�����Ϣ
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckEditUser(){
    var CheckEditUser = false;
	var AdminPwd = document.User.AdminPwd.value;
	if (AdminPwd!="")
	{
		if(DateCheck(AdminPwd,4,16))
		{
			document.User.AdminPwd.focus();
			document.User.AdminPwd.value = "";
			return false;
		}

		var AdminPwd2 = document.User.AdminPwd2.value;
		if (AdminPwd2=="")
		{
		   alert("��������һ��������!");
		   document.User.AdminPwd2.focus();
		   return false;
		 }

		if(DateCheck(AdminPwd2,4,16))
		{
			document.User.AdminPwd.focus();
			document.User.AdminPwd.value = "";
			return false;
		}

		if (AdminPwd != AdminPwd2)
		{
			alert("��������������벻һ�£��������룡");
			document.User.AdminPwd.focus();
			document.User.AdminPwd.value = "";
			document.User.AdminPwd2.value = "";
			return false;
		}

	}



	var UserName = document.User.UserName.value;
	if (UserName=="")
	{
	   alert("��ʵ��������Ϊ��!");
	   document.User.UserName.focus();
	   return false;
	 }

	if(DateCheck(UserName,3,16))
	{
		document.User.UserName.focus();
		document.User.UserName.value = "";
		return false;
	}

	var UserEmail = document.User.UserEmail.value;
	if (UserEmail=="")
	{
	   alert("����������ʼ�!");
	   document.User.UserEmail.focus();
	   return false;
	 }


	if(!IsEmail(UserEmail ))
	{
		alert("��������ȷ�ĵ������䣡");
		document.User.UserEmail .focus();
		document.User.UserEmail .value = "";
		return false;
	}

	var UserQQ = document.User.UserQQ.value;
	if (UserQQ != "")
	{
		if(!IsNum(UserQQ))
		{
			alert("�������QQ���Ǵ�����,���û��QQ�벻Ҫ��д!");
			document.User.UserQQ.focus();
			document.User.UserQQ.value = "";
			return false;
		}
		if(DateCheck(UserQQ,4,10))
		{
			document.User.UserQQ.focus();
			document.User.UserQQ.value = "";
			return false;
		}
	}
}



/*****************************************************
 *  ��������CheckPerson()
 *  ��  �ã�����û�����Ϣ
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckPerson(){
    var CheckPerson = false;
	var UserName = document.User.UserName.value;
	if (UserName=="")
	{
	   alert("��ʵ��������Ϊ��!");
	   document.User.UserName.focus();
	   return false;
	 }

	if(DateCheck(UserName,3,16))
	{
		document.User.UserName.focus();
		document.User.UserName.value = "";
		return false;
	}

	var UserEmail = document.User.UserEmail.value;
	if (UserEmail=="")
	{
	   alert("����������ʼ�!");
	   document.User.UserEmail.focus();
	   return false;
	 }


	if(!IsEmail(UserEmail ))
	{
		alert("��������ȷ�ĵ������䣡");
		document.User.UserEmail .focus();
		document.User.UserEmail .value = "";
		return false;
	}

	var UserQQ = document.User.UserQQ.value;
	if (UserQQ != "")
	{
		if(!IsNum(UserQQ))
		{
			alert("�������QQ���Ǵ�����,���û��QQ�벻Ҫ��д!");
			document.User.UserQQ.focus();
			document.User.UserQQ.value = "";
			return false;
		}
		if(DateCheck(UserQQ,4,10))
		{
			document.User.UserQQ.focus();
			document.User.UserQQ.value = "";
			return false;
		}
	}
}



/*****************************************************
 *  ��������CheckModPwd()
 *  ��  �ã��޸������������֤
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 *****************************************************
*/
function CheckModPwd()
{
	var OldPwd = document.User.OldPwd.value;
	if (OldPwd == "") {
	alert("��������ľ�����!");
	document.User.OldPwd.focus();
		return false;
	}

	if(DateCheck(OldPwd,4,16)){
		document.User.OldPwd.focus();
		document.User.OldPwd.value = "";
		return false;
	}

	var AdminPwd = document.User.AdminPwd.value;
	if (AdminPwd == "") {
	alert("�����벻��Ϊ�գ�");
	document.User.AdminPwd.focus();
		return false;
	}

	if(DateCheck(AdminPwd,4,16)){
		document.User.AdminPwd.focus();
		document.User.AdminPwd.value = "";
		return false;
	}

	var AdminPwd2 = document.User.AdminPwd2.value;
	if (AdminPwd2 == "") {
	alert("��ȷ�������룡");
	document.User.AdminPwd2.focus();
		return false;
      }

	if(DateCheck(AdminPwd2,4,16)){
		document.User.AdminPwd2.focus();
		document.User.AdminPwd2.value = "";
		return false;
	}

	if (AdminPwd != AdminPwd2) {
	alert("��������������벻һ�£��������룡");
	document.User.AdminPwd.focus();
	document.User.AdminPwd.value = "";
	document.User.AdminPwd2.value = "";
		return false;
	}

  return true;
  }


 /*****************************************************
 *  ��������CheckConfig()
 *  ��  �ã�ϵͳ�������ñ�������֤
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 *****************************************************
*/
 function CheckConfig()
 {
	var LoginCheck = false;


 }

/*****************************************************
 *  ��������CheckLink()
 *  ��  �ã�����û�����Ϣ
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckLink(){
    var CheckLink = false;
	var LinkName = document.Link.LinkName.value;
	if (LinkName=="")
	{
	   alert("�������Ʋ���Ϊ��!");
	   document.Link.LinkName.focus();
	   return false;
	 }

	var LinkAddress = document.Link.LinkAddress.value;
	if (LinkAddress=="")
	{
	   alert("���ӵ�ַ����Ϊ��!");
	   document.Link.LinkAddress.focus();
	   return false;
	 }
}

/*****************************************************
 *  ��������CheckEditLink()
 *  ��  �ã���������޸ı���Ϣ
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckEditLink(){
    var CheckEditLink = false;

	var LinkName = document.Link.LinkName.value;
	if (LinkName=="")
	{
	   alert("�������Ʋ���Ϊ��!");
	   document.Link.LinkName.focus();
	   return false;
	 }

	var LinkAddress = document.Link.LinkAddress.value;
	if (LinkAddress=="")
	{
	   alert("���ӵ�ַ����Ϊ��!");
	   document.Link.LinkAddress.focus();
	   return false;
	 }
}

/*****************************************************
 *  ��������CheckLink()
 *  ��  �ã�����û�����Ϣ
 *	��  ������
 *  ����ֵ��True: ��֤ͨ��
 *          False: ��֤û��ͨ��
 ******************************************************
*/
function CheckFile(){
    var CheckFile = false;
	var FileTitle = document.AddDownload.FileTitle.value;
	if (FileTitle=="")
	{
	   alert("�����ļ����ⲻ��Ϊ��!");
	   document.AddDownload.FileTitle.focus();
	   return false;
	 }

	var FileName = document.AddDownload.FileName.value;
	if (FileName=="")
	{
	   alert("�ļ�������Ϊ��!");
	   document.AddDownload.FileName.focus();
	   return false;
	 }

	var FileAuthor = document.AddDownload.FileAuthor.value;
	if (FileAuthor=="")
	{
	   alert("�ļ������˲���Ϊ��!");
	   document.AddDownload.FileAuthor.focus();
	   return false;
	 }
}

function search(){
	var name = document.form1.name.value;
	if (name=="")
	{
	   alert("�������ݲ���Ϊ��!");
	   document.form1.name.focus();
	   return false;
	 }
}

function message(){
	var strm = document.message.email.value
	var tele = document.message.telephone.value
	var regm = /^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$/;
	var mobilereg = /^(((13[0-9]{1})+\d{8}))|(((15[0-9]{1})+\d{8}))|(((18[0-9]{1})+\d{8}))$/;
	if(document.message.name.value==""){
		alert("����д������");
		document.message.name.focus();
		return false;
	}else if(!mobilereg.test(tele)){
              alert("�绰�����ʽ����!")
		document.message.tele.focus();
              return false;
        }else if(!regm.test(strm)){
		alert("�����ַ��ʽ������зǷ��ַ�!");
		document.message.strm.focus();
   		return false;
	}else if(document.message.title.value==""){
		alert("����д��������");
		document.message.title.focus();
		return false;
	}else if(document.message.content.value==""){
		alert("����д��������");
		document.message.content.focus();
		return false;
	}
}
