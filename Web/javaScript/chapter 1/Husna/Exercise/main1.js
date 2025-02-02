const form=document.getElementById("myform");
form.addEventListener("submit", function (event) {
    event.preventDefault(); 

const email=document.getElementById("myemail").value.trim();
const pass=document.getElementById("mypassword");
const feedback=document.getElementById("emailfeed");
const feedback1=document.getElementById("passfeed");
let isValid=true;




    if(pass.value===""){
        feedback1.textContent="******Password cannot be empty*******";
        feedback1.className="error";
        isValid=false;
    }else{
        feedback1.textContent="";
        
    }

    const emailPattern=/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/; 
    
    if(email===""){
        feedback.textContent="******Email cannot be empty*******";
        feedback.className="error";
        isValid=false;
    }
    else if(!emailPattern.test(email)){
        feedback.textContent="Not a valid email";
        isValid=false;
    }else{
        feedback.textContent="";

    }

    if(isValid){
     
        alert("form submitted successfully");
    
    }
    
});
