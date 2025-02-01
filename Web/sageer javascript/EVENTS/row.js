//const tab=document.getElementById('tabrow');
const button1=document.getElementById('butadd');
button1.addEventListener("click",function(){
    const newtab=document.getElementById('tabrow');
    const newtr=newtab.insertRow();
    newtr.insertCell(0).textContent="john";
    newtr.insertCell(1).textContent="20";
    newtr.insertCell(2).textContent="newyork";
});
const button3=document.getElementById('butdel');
button3.addEventListener("click",function(){
    const newtab=document.getElementById('tabrow');
    const newtr=newtab.deleteRow(1);
    //newtr.deleteCell(0).textContent="john";
    //newtr.deleteCell(1).textContent="20";
    //newtr.deleteCell(2).textContent="newyork";
});
const button2=document.getElementById('buthigh');
button2.addEventListener("click",function(){
    const newr= document.getElementById("tabrow").rows[4];
    newr.style.backgroundColor="yellow";
});
const button4=document.getElementById('edit');
button4.addEventListener("click",function(){
    const newtabble=document.getElementById('tabrow');
    const newroww=newtabble.rows[2];
    newroww.cells[0].textContent="abdulla";
    newroww.cells[1].textContent="30";
    newroww.cells[2].textContent="agra";
});
const button5=document.getElementById('count');
button5.addEventListener("click",function(){
    const n=alert(document.getElementById('tabrow').rows.length-1);
    
});