var applicantList = [
    { name: "Alex", image: "images/m1.png", experience: "2 years", qualification: "MCA", location: "Bangalore" },
    { name: "Saara", image: "images/m2.png", experience: "2 years", qualification: "MSC", location: "Chennai" },
    { name: "Vivek", image: "images/Userpic (2).png", experience: "4 years", qualification: "Btech", location: "Thiruvananthapuram" },
    { name: "Deepak Roy", image: "images/Image.png", experience: "4 years", qualification: "Btech", location: "Calicut" }
];

listApplicants();

function listApplicants() {
    var tableBody = document.getElementById('applicantTableBody');
    tableBody.innerHTML = ""; // Clear previous content

    for (let i = 0; i < applicantList.length; i += 2) {
        var row = document.createElement('tr');
        
        for (let j = 0; j < 2; j++) {
            if (i + j < applicantList.length) {
                var applicant = applicantList[i + j];
                var detailsCell = document.createElement('td');
                detailsCell.style.width = "150px";
                detailsCell.style.textAlign = "center";
                detailsCell.style.padding = "5px";
                
                var image = document.createElement('img');
                image.src = applicant.image;
                image.className = "profile-pic";
                image.style.display = "block";
                image.style.margin = "0 auto";
                image.style.width = "50px";
                image.style.height = "50px";
                
                detailsCell.appendChild(image);
                detailsCell.innerHTML += `<br><strong>${applicant.name}</strong><br>Experience: ${applicant.experience}<br>Qualification: ${applicant.qualification}<br>Location: ${applicant.location}`;
                
                row.appendChild(detailsCell);
            }
        }
        
        tableBody.appendChild(row);
    }
}
