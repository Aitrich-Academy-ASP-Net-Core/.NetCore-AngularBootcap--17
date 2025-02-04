const button=document.getElementById("mybutton");
button.addEventListener("click",function(f){
   let imageurl=prompt("Please enter the url of image:");
   let title=prompt("Please enter the title of image:");
   let description=prompt("Please enter the description of image:");
   if(imageurl===""||imageurl===null)
   {
    alert("Please provide all fields");
   }
     if(title===""||title===null)
      {
     alert("Please provide all fields");
     }
      if(description===""||description===null)
        {
         alert("Please provide all fields");
        }
        const maindiv=document.getElementById("container");
        const gallery=document.createElement('div');
        gallery.classList.add("box");

        gallery.innerHTML=`<h5>${title}</h5> <img src="${imageurl}">  <p>${description}</P>`; 
        
        
        maindiv.appendChild(gallery);
        const delbutton=document.createElement('button');
        delbutton.textContent="Delete"
        gallery.appendChild(delbutton);
        
        
        delbutton.addEventListener("click",function(){
         maindiv.removeChild(gallery);

        });

        
});