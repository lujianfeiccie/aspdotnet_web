function selectAll(obj)
{
    var allInput = document.getElementsByTagName("input");
    //alert(allInput.length);
    var loopTime = allInput.length;
    for(i = 0;i < loopTime;i++)
    {
        //alert(allInput[i].type);
        if(allInput[i].type == "checkbox")
        {
            allInput[i].checked = obj.checked;
        }
    }
}

function delIt() 
{ 
    var cbxBool = 0; 
    for(var i = 0;i < cbxArray.length;i++){ 
    
        var obj = document.getElementById(cbxArray[i]); 
        if(obj.checked == true){ 
            cbxBool = 1; 
            break; 
         } 
    } 
    if(cbxBool == 1){ 
        var result = confirm("您确定要审核吗？"); 
        if(result){ 
            return true; 
        } 
    }else{ 
        alert("请选中需要审核的项"); 
        return false; 
    } 
    return false; 
} 