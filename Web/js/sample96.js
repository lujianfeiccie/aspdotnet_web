// JavaScript Document
<!--
        var rows =9 ;//行数
        var colls =13;//列数
        var outObject;
        var Enchar=new Array('A','B','C','D','E','F','G','H','I','J','K','L','M','N');

function getImage2(tt,obj) //主调函数
{
  if (arguments.length >  2){alert("对不起！传入本控件的参数太多！");return;}

  if (arguments.length == 0){alert("对不起！您没有传回本控件任何参数！");return;}

  var dads  = document.all.meizzDateLayer.style;
  
  var th = tt;

  var ttop  = tt.offsetTop;     //TT控件的定位点高

  var thei  = tt.clientHeight;  //TT控件本身的高

  var tleft = tt.offsetLeft;    //TT控件的定位点宽

  var ttyp  = tt.type;          //TT控件的类型

  while (tt = tt.offsetParent){ttop+=tt.offsetTop; tleft+=tt.offsetLeft;}

  dads.top  = (ttyp=="image")? ttop+thei : ttop+thei+6;

  dads.left = tleft;

  outObject = (arguments.length == 1) ? th : obj;

  dads.display = '';

  event.returnValue=false;

}


document.writeln('<div id=meizzDateLayer style="position: absolute; width: 250; height: 166; z-index: 9999; display: none">');

document.writeln('<span id=tmpSelectYearLayer  style="z-index: 9999;position: absolute;top: 2; left: 18;display: none"></span>');

document.writeln('<span id=tmpSelectMonthLayer style="z-index: 9999;position: absolute;top: 2; left: 75;display: none"></span>');

document.writeln('<table border=0 cellspacing=1 cellpadding=0 width=250 height=160 bgcolor=#000000 onselectstart="return false">');

document.writeln('  <tr><td width=250 height=23 bgcolor=#FFFFFF><table border=0 cellspacing=1 cellpadding=0 width=140 height=23>');

document.writeln('      <tr align=center><td width=20 align=center  style="font-size:12px;cursor: hand;color: #FFD700" ');

document.writeln('        </td><td width=180 align=center style="font-size:12px;cursor:default" Author=meizz colspan="2">'); 

document.writeln('        <span Author=meizz id=meizzYearHead  style="cursor: hand;"></span>选择样本的位置<span>');

document.writeln('         </td>');

document.writeln('         </tr>');

document.writeln('    </table></td></tr>');

document.writeln('  <tr><td width=250 height=120>');

document.writeln('    <table border=0 cellspacing=1 cellpadding=0 width=250 height=120 bgcolor=#FFFFFF>');

var n=0; 

for (j=0;j<rows;j++)
{

 document.writeln (' <tr align=center>'); 

  for (i=0;i<colls;i++)
  {
   n++;
   
   if(j==0)
   {
      //第一行第一列的处理
      if(i==0)
      {
        
        document.writeln('<td width=20 height=20 id=meizzDay'+n+' style="font-size:12px" Author=meizz      bgcolor="WHITE"> </td>');
        continue;
      }
      
     //第一行的处理
    document.writeln('<td width=20 height=20 id=meizzDay'+n+' style="font-size:12px" Author=meizz      bgcolor="WHITE">'+i+'</td>');
    continue;
   }
   
    if(i==0)
    {
    document.writeln('<td width=20 height=20 id=meizzDay'+n+' style="font-size:12px" Author=meizz      bgcolor="WHITE">'+Enchar[Number(j-1)]+'</td>');
    continue;
    }
  
   document.writeln('<td width=20 height=20 id=meizzDay'+n+' style="font-size:12px" Author=meizz onclick=meizzDayClick(this.id)         onmouseover="style.backgroundColor=\'yellow\'" onmouseout="style.backgroundColor=\'#73a6de\'" bgcolor="#73a6de"></td>');
   
   
  }

document.writeln('</tr>');}

document.writeln('      <tr align=center><td width=20 height=20 style="font-size:12px" id=meizzDay35 Author=meizz ');

document.writeln('         onclick=meizzDayClick(this.innerText)></td>');

document.writeln('        <td width=20 height=20 style="font-size:12px" id=meizzDay36 Author=meizz onclick=meizzDayClick(this.innerText)></td>');

document.writeln('        <td colspan=5 align=center Author=meizz>');

document.writeln('        <span onclick=clearLayer() style="font-size:12px;cursor: hand" Author=meizz ><u>清空</u></span>&nbsp;');

document.writeln('        <span onclick=closeLayer() style="font-size:12px;cursor: hand" Author=meizz ><u>关闭</u></span>&nbsp;</td></tr>');

document.writeln('    </table></td></tr><tr><td>');

document.writeln('        <table border=0 cellspacing=1 cellpadding=0 width=100% bgcolor=#FFFFFF>');

document.writeln('          <tr><td>  ');


document.writeln('             </td>');


document.writeln('</tr></table></td></tr> </table>  ');

document.writeln('<iframe   src="" frameborder="0"  style="position:absolute;   visibility:inherit;   top:0px;   left:0px;  width:expression(this.parentNode.offsetWidth);   height:expression(this.parentNode.offsetHeight);   z-index:-1;"></iframe>     ');

document.writeln(' </div>');



function document.onclick() //任意点击时关闭该控件

{ 

  with(window.event.srcElement)

  { if (tagName != "INPUT" && getAttribute("Author")==null)

    document.all.meizzDateLayer.style.display="none";

  }

}
 

function closeLayer()               //这个层的关闭

  {

    document.all.meizzDateLayer.style.display="none";

  }

function clearLayer()               //这个层的关闭,清空文本框

  {
	outObject.value="";
    document.all.meizzDateLayer.style.display="none";

  }
 

function document.onkeydown()

  {

    if (window.event.keyCode==27)document.all.meizzDateLayer.style.display="none";

  }
 

function meizzDayClick(n)  //点击显示框选取日期，主输入函数*************
{
  
  if (outObject)

  {
    if (!n) {outObject.value=""; return;}

	n = n.replace("meizzDay","");

	var i=Math.floor(n/(colls));
	  
	var j=n%(colls);
	 	//alert(n);
	//if(i<10) i="0"+Number(i-1);
	//if(j<10) j="0"+Number(j-1);
        
         j=Number(j-1);
         
      if(j==-1) //修正处理
      { j=12; --i; }
      
            i=Enchar[Number(i-1)];
    outObject.value=  i+""+j ; //注：在这里你可以输出改成你想要的格式

    closeLayer(); 

  }

  else {closeLayer(); alert("您所要输出的控件对象并不存在！");}

}


// -->

