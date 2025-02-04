function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;
     if(name==null  || name=="")
    {
        alert("Please Enter Name");
        return false;
    }
  
    if(email==null || email=="")
    {
        alert("Please Enter Email");
        return false;
    }
    if(phone==null  || phone=="")
    {
        alert("Please Enter Phone Number");
        return false;
    }
    if(role=="" || role==null)
    {
        alert("Please Enter Role");
        return false;
    }
    if(location==null || location=="")
    {
        alert("Please Enter Location");
        return false;
    }
    if(website==null || website=="")
    {
        alert("Please Enter Website");
        return false;
   
    }
    return true;
} 

function validateMail()
{
    const pattern= /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
   if(!pattern.test(email))
   {
        alert("Please enter valid mail");
        return false;
   }
   return true;
}
function fname(){
    const pattern=/A-Za-z/;
    if(!pattern.test(name)){
        alert("please enter a valid name");
        return false;
        }
        return true;
   }           
function phonenumber(){
    const pattern=/\d/;
    if(!pattern.test(phno)){
        alert("please enter a valid name");
        return false;
        }
        return true;
   }
   function myrole(){
    const pattern=/A-Za-z/;
    if(!pattern){
        alert("please enter a valid role");
        return false;
        }
        return true;
   }
   function myloc(){
    const pattern=/A-Za-z/;
    if(!pattern.test(location)){
        alert("please enter a valid location");
        return false;
        }
        return true;
   }
   function web(){
    const pattern=/a-z/;
    if(!pattern.test(location)){
        alert("enter a valid website");
        return false;
    }
        return true;
    }
