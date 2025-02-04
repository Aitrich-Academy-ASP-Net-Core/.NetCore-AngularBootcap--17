const button=document.getElementById("newdiv");
console.log(button);
newdiv.addEventListener("mouseover",function(){
    newdiv.innerText="stop hovering";
    newdiv.style.backgroundColor=("cyan");
});
newdiv.addEventListener("mouseout",function(){
    newdiv.innerText="click here!";
    newdiv.style.backgroundColor="yellow";
});
newdiv.addEventListener("click",function(){
    newdiv.style.backgroundColor="red";
    alert("button clicked!");
});