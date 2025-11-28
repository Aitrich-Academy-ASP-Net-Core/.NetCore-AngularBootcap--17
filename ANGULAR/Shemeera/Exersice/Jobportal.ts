import * as readline from "readline";

import { User } from "./User";
import { Job } from "./Job";
import { Application } from "./Application";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

 class JobPortal {
    users: User[] = [];
    jobs: Job[] = [
        new Job(101, "Java Developer"),
        new Job(102, "Angular Developer"),
        new Job(103, "ASP.NET Developer"),
        new Job(104, "Python Developer")
    ];
    applications: Application[] = [];
    currentUser: User | null = null;

    start() {
        this.mainMenu();
    }

    mainMenu() {
        console.log("\n===== MAIN MENU =====");
        console.log("1. Signup");
        console.log("2. Login");
        console.log("0. Exit");

        rl.question("Enter your choice: ", (choice) => {
            switch (choice) {
                case "1":
                    this.signup();
                    break;
                case "2":
                    this.login();
                    break;
                case "0":
                    console.log("Exiting...");
                    rl.close();
                    break;
                default:
                    console.log("Invalid Choice!");
                    this.mainMenu();
            }
        });
    }

    signup() {
        console.log("\n===== SIGNUP =====");

        rl.question("Enter Username: ", (username) => {
            rl.question("Enter Password: ", (password) => {
                rl.question("Enter First Name: ", (firstName) => {
                    rl.question("Enter Last Name: ", (lastName) => {
                        rl.question("Enter Gender: ", (gender) => {
                            rl.question("Enter Phone Number: ", (phone) => {

                                const newUser = new User(username, password, firstName, lastName, gender, phone);
                                this.users.push(newUser);

                                console.log("\nSignup Successful!");
                                this.login();
                            });
                        });
                    });
                });
            });
        });
    }

    login() {
        console.log("\n===== LOGIN =====");

        rl.question("Username: ", (username) => {
            rl.question("Password: ", (password) => {

                const foundUser = this.users.find(u => u.username === username && u.password === password);

                if (foundUser) {
                    this.currentUser = foundUser;
                    console.log("\nLogin Successful!");
                    this.userMenu();
                } else {
                    console.log("Invalid username or password!");
                    this.mainMenu();
                }
            });
        });
    }

    userMenu() {
        console.log("\n===== USER MENU =====");
        console.log("1. View Listed Jobs");
        console.log("2. Apply for Job");
        console.log("3. View Applied Jobs");
        console.log("4. Logout");

        rl.question("Enter your choice: ", (choice) => {
            switch (choice) {
                case "1":
                    this.viewJobs();
                    break;
                case "2":
                    this.applyForJob();
                    break;
                case "3":
                    this.viewAppliedJobs();
                    break;
                case "4":
                    this.currentUser = null;
                    console.log("Logged out!");
                    this.mainMenu();
                    break;
                default:
                    console.log("Invalid Choice!");
                    this.userMenu();
            }
        });
    }

    viewJobs() {
        console.log("\n===== JOB LIST =====");
        this.jobs.forEach(j => {
            console.log(`Job ID: ${j.jobId} | Title: ${j.title}`);
        });
        this.userMenu();
    }

    applyForJob() {
        console.log("\nEnter Job ID to Apply:");

        rl.question("Job ID: ", (jid) => {
            const job = this.jobs.find(j => j.jobId === Number(jid));

            if (!job) {
                console.log("Invalid Job ID!");
                this.userMenu();
                return;
            }

            if (!this.currentUser) return;

            this.applications.push(new Application(this.currentUser.username, job.jobId));

            console.log("Applied Successfully!");
            this.userMenu();
        });
    }

    viewAppliedJobs() {
        if (!this.currentUser) return;

        console.log("\n===== APPLIED JOBS =====");
        const applied = this.applications.filter(a => a.username === this.currentUser!.username);

        if (applied.length === 0) {
            console.log("No Applied Jobs!");
        } else {
            applied.forEach(a => {
                const job = this.jobs.find(j => j.jobId === a.jobId);
                console.log(`Applied Job: ${job?.title}`);
            });
        }

        this.userMenu();
    }
}
const portal = new JobPortal();
portal.start();