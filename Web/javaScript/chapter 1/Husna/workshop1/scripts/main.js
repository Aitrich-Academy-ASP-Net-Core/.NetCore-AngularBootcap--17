function validateForm()
{
    
    var jobTitle=document.myForm.jobTitle.value;  
    var description=document.myForm.jobDescription.value;  
    var salary=document.myForm.salary.value; 
    var location=document.myForm.location.value; 

    if(jobTitle==null || jobTitle=="")
    {
        alert("Please enter your job title");
        return false;
    }
     if(description==null || description=="")
    {
        alert("Please enter your job description");
        return false;

    }
    if(salary==null || salary=="")
    {
        alert("Please enter your salary");
        return false;

    }
    if(location==null ||location=="")
    {
        alert("Please enter your location");
        return false;

    }
    

}

function validateCharacter(inputChar)
{
   
    const regex = /^[a-zA-Z\s]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputChar))
    {
        alert("Allowed alphabets")
        return false;
    }

}
function validateNumber(inputNum)
{
   
    const regex = /^\d+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputNum))
    {
        alert("Allowed numbers")
        return false;
    }
}

