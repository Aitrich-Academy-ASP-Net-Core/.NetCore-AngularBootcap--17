function showForm(buttonVal)
{
    var id=document.getElementById('myTextBox');
    
    var skillButton=document.getElementById('myButton');


    if(buttonVal=="myButton1")
    {
    id.style.display='block';
    skillButton.style.display='block';
    }

    else if(buttonVal=="myButton2")
    {

        var id=document.getElementById('eduTextBox');
        var eduButton=document.getElementById('eduButton');
        id.style.display='block';
        eduButton.style.display='block';
    }
    else if(buttonVal=="myButton3")
        {
    
            var id=document.getElementById('abouTextBox');
            var eduButton=document.getElementById('abouButton');
            id.style.display='block';
            abouButton.style.display='block';
        }
        else if(buttonVal=="myButton4")
            {
        
                var id=document.getElementById('exTextBox');
                var exButton=document.getElementById('exButton');
                id.style.display='block';
                exButton.style.display='block';
            }


    
}

function add(text)
{
    if(text=="skill")
    {
    var data=document.getElementById('myTextBox').value;
    var textBox=document.getElementById('myTextBox');
    var listId=document.getElementById('skillList');
    var skills=[]
    skills.push(data);
    console.log(skills);
    for(i=0;i<skills.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = skills[i];

             // Append the list item to the list element
             listId.appendChild(li);
             textBox.value='';

    }
}
    else if(text=="edu")
        {
        var datas=document.getElementById('eduTextBox').value;
        var textBoxs=document.getElementById('eduTextBox');
        var listId2=document.getElementById('eduList');
        var educat=[]
        educat.push(datas);
        console.log(educat);
        for(i=0;i<educat.length;i++)
        {
            // Create a new list item
            var li = document.createElement('li');
    
             // Set the text content of the list item
                li.textContent = educat[i];
    
                 // Append the list item to the list element
                 listId2.appendChild(li);
                 textBoxs.value='';
    
        }
}
else if(text=="ex")
    {
    var datas2=document.getElementById('exTextBox').value;
    var textBoxs2=document.getElementById('exTextBox');
    var listId3=document.getElementById('exList');
    var excat=[]
    excat.push(datas2);
    console.log(excat);
    for(i=0;i<excat.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = excat[i];

             // Append the list item to the list element
             listId3.appendChild(li);
             textBoxs2.value='';

    }
}
else if(text=="abou")
    {
    var datas3=document.getElementById('abouTextBox').value;
    var textBoxs4=document.getElementById('abouTextBox');
    var listId4=document.getElementById('abouList');
    var aboucat=[]
    aboucat.push(datas3);
    console.log(aboucat);
    for(i=0;i<aboucat.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = aboucat[i];

             // Append the list item to the list element
             listId4.appendChild(li);
             textBoxs4.value='';

    }
}






// else if(text=="edu")
// {

//     var data=document.getElementById('eduTextBox').value;
//     var textBox=document.getElementById('eduTextBox');
//     var listId=document.getElementById('eduList');
//     var edu=[]
//     edu.push(data);
//     console.log(edu);
//     for(i=0;i<edu.length;i++)
//     {
//         // Create a new list item
//         var li = document.createElement('li');

//          // Set the text content of the list item
//             li.textContent = edu[i];

//              // Append the list item to the list element
//              listId.appendChild(li);
//              textBox.value='';

//     }
// }

}