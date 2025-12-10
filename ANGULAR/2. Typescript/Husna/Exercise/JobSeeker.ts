import * as readline from 'readline';
import { Job } from './Job';
import { Application } from './Application';

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});



const jobs: Job[] = [
  { id: 1, title: "Software Developer", company: "TechCorp" },
  { id: 2, title: "Web Designer", company: "DHub" },
  { id: 3, title: "Administrator", company: "DataSys" }
];

let appliedJobs: Application[] = [];
let isLoggedIn = false;
let exitProgram = false;


class JobPortal {
  start() {
    this.showLogin();
  }

  
  showLogin() {
    console.log("\n JOB PORTAL LOGIN ");
    rl.question("Enter username: ", (username:string) => {
      rl.question("Enter password: ", (password:string) => {
        if (username === "user" && password === "user123") {
          console.log("\nLogin successful!");
          isLoggedIn = true;
          this.showMainMenu();
        } else {
          console.log("\nInvalid username or password. Try again.");
          this.showLogin();
        }
      });
    });
  }

  
  showMainMenu() {
    console.log("MAIN MENU ");
    console.log("1. All Jobs");
    console.log("2. My Applications");
    console.log("3. Logout");
    console.log("0. Exit");

    rl.question("Enter your choice: ", (choice:string) => {
      switch (choice) {
        case "1":
          this.showAllJobs();
          break;
        case "2":
          this.showMyApplications();
          break;
        case "3":
          this.logout();
          break;
        case "0":
          exitProgram = true;
          rl.close();
          break;
        default:
          console.log("Invalid choice. Try again.");
          this.showMainMenu();
          break;
      }
    });
  }

  
  showAllJobs() {
    console.log("\n------------------ AVAILABLE JOBS ------------------");
    jobs.forEach(job => {
      console.log(`ID: ${job.id} | Title: ${job.title} | Company: ${job.company}`);
    });

    rl.question("\nEnter Job ID to apply or 'b' to go back: ", (input:string) => {
      if (input.toLowerCase() === 'b') {
        this.showMainMenu();
      } else {
        const jobId = parseInt(input);
        const selectedJob = jobs.find(j => j.id === jobId);
        if (selectedJob) {
        //check
          const alreadyApplied = appliedJobs.some(app => app.jobId === jobId);
          if (!alreadyApplied) {
            appliedJobs.push({ jobId: selectedJob.id, jobTitle: selectedJob.title });
            console.log(`You have applied for "${selectedJob.title}".`);
          } else {
            console.log(` You already applied for "${selectedJob.title}".`);
          }
        } else {
          console.log("Invalid Job ID.");
        }
        this.showMainMenu();
      }
    });
  }

  
  showMyApplications() {
    console.log("\n------------------ MY APPLICATIONS ------------------");
    if (appliedJobs.length === 0) {
      console.log("You have not applied for any jobs yet.");
    } else {
      appliedJobs.forEach(app => {
        console.log(`Job Title: ${app.jobTitle}`);
      });
    }
    this.showMainMenu();
  }

  
  logout() {
    console.log("\nYou have been logged out.");
    isLoggedIn = false;
    appliedJobs = [];
    this.showLogin();
  }
}


const portal = new JobPortal();
portal.start();