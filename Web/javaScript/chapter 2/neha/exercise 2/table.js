const data=[
    {name:"Alen",qualification:"MCA",experience:"3 years",location:"Banglore",Image:"images/serious"},
    {name:"Sarah",qualification:"MSc",experience:"2 years",location:"Chenni",Image:"images/girl"},
    {name:"Vivek",qualification:"BTech",experience:"1 years",location:"Thiruvananthapuram",Image:"images/handsome"},
    {name:"Anu Roy",qualification:"BTech",experience:"1 years",location:"Delhi",Image:"images/young"},

];
function createtable(array) {
    const table=document.createElement("table");
    let index=0;
    for(let i=0;i<2;i++){
        const row=document.createElement("tr");
        for(let j=0;j<2;j++){
            const cell=document.createElement("td");
            if(array[index])
            {const person=array[index++];
                cell.innerHTML=`<img src="${person.Image}"><br>
                <strong>${person.name}</strong><br>
                Qualification:${person.qualification}<br>
                Experience:${person.experience}<br>
                Location:${person.location}`;
            }
            row.appendChild(cell);
        }

        table.appendChild(row);
    }
    document.getElementById("tablecontainer").appendChild(table);
}
createtable(data);