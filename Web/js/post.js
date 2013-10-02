// JavaScript Document


/*****************************************************
 *  函数名：DateCheck()
 *  作  用：检查字符中是否在指定的大小范围内和是否含有非法字符
 *	参  数：date: 要检查的字符；
 *          minum:  字符最小的长度
 *  		maxnum: 字符最大的长度
 *  返回值：True:   数据不在指定范围内或含有非法字符
 *			False:  数据在指定范围内且不含有非法字符
 ******************************************************
*/
function DateCheck(date,minnum,maxnum)
{
	if (date.length < minnum || date.length > maxnum ){
		window.alert("输入数据的长度不能少于 " + minnum + " 位并且不能大于 " + maxnum + " 位!");
		return true;
	}

	 a = date.indexOf("'");
	 b = date.indexOf("|");
	 c = date.indexOf("\"");

	 if (a != -1||b != -1 ||c != -1){
	   window.alert("您的输入含有特殊字符，请重新输入！");
	   return true;
	  	}
	return false;
}


/*****************************************************
 *  函数名：	IsNum()
 *  作  用：检查字符是否是纯数字
 *	参  数：str: 要检查的字符；
 *  返回值：True:   是数字
 *			False:  不是纯数字
 ******************************************************
*/
function IsNum(str)
{
	return !/\D/.test(str)
}


/*****************************************************
 *  函数名：	IsStr()
 *  作  用：检查字符是否是字符
 *	参  数：str: 要检查的字符
 *  返回值：True:   是字符
 *			False:  不是纯字符
 ******************************************************
*/
function IsStr(str)
{
　　if (/[^\x00-\xff]/g.test(str))
	{
		return false;
	}
　　else
	{
		return true;
	}
}


/*****************************************************
 *  函数名：IsEmail()
 *  作  用：检查Email地址是否合法
 *	参  数：date: 要检查的Email地址
 *  返回值：True: Email 地址合法
 *          False:Email 地址不合法
 *****************************************************
*/
function IsEmail(vEMail)
{
	var regInvalid=/(@.*@)|(\.\.)|(@\.)|(\.@)|(^\.)/;
	var regValid=/^.+\@(\[?)[a-zA-Z0-9\-\.]+\.([a-zA-Z]{2,3}|[0-9]{1,3})(\]?)$/;
	return (!regInvalid.test(vEMail)&&regValid.test(vEMail));
}





/*****************************************************
 *  函数名：CheckID()
 *  作  用：检查ID是否是数字
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 ******************************************************
*/
function CheckID(){
    var CheckID = false;

	var tb_ID = document.form1.tb_ID.value;

	if(!IsNum(tb_ID))
		{
			alert("请您输入纯数字!");
			document.form1.tb_ID.focus();
			document.form1.tb_ID.value = "";
			return false;
		}
		
	return true;
}



/*****************************************************
 *  函数名：CheckUser()
 *  作  用：检查用户表单信息
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 ******************************************************
*/
function CheckUser(){
    var CheckUser = false;
	var AdminName = document.User.AdminName.value;
	if (AdminName=="")
	{
	   alert("用户名不能为空!");
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
	   alert("请输入管理员密码!");
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
	   alert("请再输入一次新密码!");
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
		alert("你两次输入的密码不一致，请重输入！");
		document.User.AdminPwd.focus();
		document.User.AdminPwd.value = "";
		document.User.AdminPwd2.value = "";
		return false;
	}

	var UserName = document.User.UserName.value;
	if (UserName=="")
	{
	   alert("真实姓名不能为空!");
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
	   alert("请输入电子邮件!");
	   document.User.UserEmail.focus();
	   return false;
	 }


	if(!IsEmail(UserEmail ))
	{
		alert("请输入正确的电子邮箱！");
		document.User.UserEmail .focus();
		document.User.UserEmail .value = "";
		return false;
	}

	var UserQQ = document.User.UserQQ.value;
	if (UserQQ != "")
	{
		if(!IsNum(UserQQ))
		{
			alert("您输入的QQ不是纯数字,如果没有QQ请不要填写!");
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
 *  函数名：CheckEditUser()
 *  作  用：检查用户表单信息
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
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
		   alert("请再输入一次新密码!");
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
			alert("你两次输入的密码不一致，请重输入！");
			document.User.AdminPwd.focus();
			document.User.AdminPwd.value = "";
			document.User.AdminPwd2.value = "";
			return false;
		}

	}



	var UserName = document.User.UserName.value;
	if (UserName=="")
	{
	   alert("真实姓名不能为空!");
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
	   alert("请输入电子邮件!");
	   document.User.UserEmail.focus();
	   return false;
	 }


	if(!IsEmail(UserEmail ))
	{
		alert("请输入正确的电子邮箱！");
		document.User.UserEmail .focus();
		document.User.UserEmail .value = "";
		return false;
	}

	var UserQQ = document.User.UserQQ.value;
	if (UserQQ != "")
	{
		if(!IsNum(UserQQ))
		{
			alert("您输入的QQ不是纯数字,如果没有QQ请不要填写!");
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
 *  函数名：CheckPerson()
 *  作  用：检查用户表单信息
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 ******************************************************
*/
function CheckPerson(){
    var CheckPerson = false;
	var UserName = document.User.UserName.value;
	if (UserName=="")
	{
	   alert("真实姓名不能为空!");
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
	   alert("请输入电子邮件!");
	   document.User.UserEmail.focus();
	   return false;
	 }


	if(!IsEmail(UserEmail ))
	{
		alert("请输入正确的电子邮箱！");
		document.User.UserEmail .focus();
		document.User.UserEmail .value = "";
		return false;
	}

	var UserQQ = document.User.UserQQ.value;
	if (UserQQ != "")
	{
		if(!IsNum(UserQQ))
		{
			alert("您输入的QQ不是纯数字,如果没有QQ请不要填写!");
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
 *  函数名：CheckModPwd()
 *  作  用：修改密码表单数据验证
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 *****************************************************
*/
function CheckModPwd()
{
	var OldPwd = document.User.OldPwd.value;
	if (OldPwd == "") {
	alert("请输入你的旧密码!");
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
	alert("新密码不能为空！");
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
	alert("请确认新密码！");
	document.User.AdminPwd2.focus();
		return false;
      }

	if(DateCheck(AdminPwd2,4,16)){
		document.User.AdminPwd2.focus();
		document.User.AdminPwd2.value = "";
		return false;
	}

	if (AdminPwd != AdminPwd2) {
	alert("你两次输入的密码不一致，请重输入！");
	document.User.AdminPwd.focus();
	document.User.AdminPwd.value = "";
	document.User.AdminPwd2.value = "";
		return false;
	}

  return true;
  }


 /*****************************************************
 *  函数名：CheckConfig()
 *  作  用：系统参数设置表单数据验证
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 *****************************************************
*/
 function CheckConfig()
 {
	var LoginCheck = false;


 }

/*****************************************************
 *  函数名：CheckLink()
 *  作  用：检查用户表单信息
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 ******************************************************
*/
function CheckLink(){
    var CheckLink = false;
	var LinkName = document.Link.LinkName.value;
	if (LinkName=="")
	{
	   alert("链接名称不能为空!");
	   document.Link.LinkName.focus();
	   return false;
	 }

	var LinkAddress = document.Link.LinkAddress.value;
	if (LinkAddress=="")
	{
	   alert("链接地址不能为空!");
	   document.Link.LinkAddress.focus();
	   return false;
	 }
}

/*****************************************************
 *  函数名：CheckEditLink()
 *  作  用：检查链接修改表单信息
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 ******************************************************
*/
function CheckEditLink(){
    var CheckEditLink = false;

	var LinkName = document.Link.LinkName.value;
	if (LinkName=="")
	{
	   alert("链接名称不能为空!");
	   document.Link.LinkName.focus();
	   return false;
	 }

	var LinkAddress = document.Link.LinkAddress.value;
	if (LinkAddress=="")
	{
	   alert("链接地址不能为空!");
	   document.Link.LinkAddress.focus();
	   return false;
	 }
}

/*****************************************************
 *  函数名：CheckLink()
 *  作  用：检查用户表单信息
 *	参  数：无
 *  返回值：True: 验证通过
 *          False: 验证没有通过
 ******************************************************
*/
function CheckFile(){
    var CheckFile = false;
	var FileTitle = document.AddDownload.FileTitle.value;
	if (FileTitle=="")
	{
	   alert("下载文件标题不能为空!");
	   document.AddDownload.FileTitle.focus();
	   return false;
	 }

	var FileName = document.AddDownload.FileName.value;
	if (FileName=="")
	{
	   alert("文件名不能为空!");
	   document.AddDownload.FileName.focus();
	   return false;
	 }

	var FileAuthor = document.AddDownload.FileAuthor.value;
	if (FileAuthor=="")
	{
	   alert("文件发布人不能为空!");
	   document.AddDownload.FileAuthor.focus();
	   return false;
	 }
}

function search(){
	var name = document.form1.name.value;
	if (name=="")
	{
	   alert("搜索内容不能为空!");
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
		alert("请填写留言人");
		document.message.name.focus();
		return false;
	}else if(!mobilereg.test(tele)){
              alert("电话号码格式错误!")
		document.message.tele.focus();
              return false;
        }else if(!regm.test(strm)){
		alert("邮箱地址格式错误或含有非法字符!");
		document.message.strm.focus();
   		return false;
	}else if(document.message.title.value==""){
		alert("请填写留言主题");
		document.message.title.focus();
		return false;
	}else if(document.message.content.value==""){
		alert("请填写留言内容");
		document.message.content.focus();
		return false;
	}
}
