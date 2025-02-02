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

    applicantList.forEach(applicant => {
        var row = document.createElement('tr');

        var imageCell = document.createElement('td');
        var image = document.createElement('img');
        image.src = applicant.image;
        image.className = "profile-pic";
        imageCell.appendChild(image);

        var nameCell = document.createElement('td');
        nameCell.textContent = applicant.name;

        var experienceCell = document.createElement('td');
        experienceCell.textContent = applicant.experience;

        var qualificationCell = document.createElement('td');
        qualificationCell.textContent = applicant.qualification;

        var locationCell = document.createElement('td');
        locationCell.textContent = applicant.location;

        row.appendChild(imageCell);
        row.appendChild(nameCell);
        row.appendChild(experienceCell);
        row.appendChild(qualificationCell);
        row.appendChild(locationCell);

        tableBody.appendChild(row);
    });
}

