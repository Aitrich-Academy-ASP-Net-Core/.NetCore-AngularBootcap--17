const ul1=document.getElementById('ull');
ul1.addEventListener("click",function(){
    const newli=document.createElement('li');
    
    newli.textContent='new li created';
    ul1.appendChild(newli);
});