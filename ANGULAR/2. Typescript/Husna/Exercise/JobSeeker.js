"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
// ---------------------- Data ----------------------
var jobs = [
    { id: 1, title: "Software Developer", company: "TechCorp" },
    { id: 2, title: "Web Designer", company: "DesignHub" },
    { id: 3, title: "Database Administrator", company: "DataSys" }
];
var appliedJobs = [];
var isLoggedIn = false;
var exitProgram = false;
// ---------------------- Class ----------------------
var JobPortal = /** @class */ (function () {
    function JobPortal() {
    }
    JobPortal.prototype.start = function () {
        this.showLogin();
    };
    // 1️⃣ LOGIN SCREEN
    JobPortal.prototype.showLogin = function () {
        var _this = this;
        console.log("\n=================== JOB PORTAL LOGIN ===================");
        rl.question("Enter username: ", function (username) {
            rl.question("Enter password: ", function (password) {
                if (username === "user" && password === "user123") {
                    console.log("\n✅ Login successful!");
                    isLoggedIn = true;
                    _this.showMainMenu();
                }
                else {
                    console.log("\n❌ Invalid username or password. Try again.");
                    _this.showLogin();
                }
            });
        });
    };
    // 2️⃣ MAIN MENU AFTER LOGIN
    JobPortal.prototype.showMainMenu = function () {
        var _this = this;
        console.log("\n=================== MAIN MENU ===================");
        console.log("1. All Jobs");
        console.log("2. My Applications");
        console.log("3. Logout");
        console.log("0. Exit");
        rl.question("Enter your choice: ", function (choice) {
            switch (choice) {
                case "1":
                    _this.showAllJobs();
                    break;
                case "2":
                    _this.showMyApplications();
                    break;
                case "3":
                    _this.logout();
                    break;
                case "0":
                    exitProgram = true;
                    rl.close();
                    break;
                default:
                    console.log("❌ Invalid choice. Try again.");
                    _this.showMainMenu();
                    break;
            }
        });
    };
    // 3️⃣ DISPLAY ALL JOBS
    JobPortal.prototype.showAllJobs = function () {
        var _this = this;
        console.log("\n------------------ AVAILABLE JOBS ------------------");
        jobs.forEach(function (job) {
            console.log("ID: ".concat(job.id, " | Title: ").concat(job.title, " | Company: ").concat(job.company));
        });
        rl.question("\nEnter Job ID to apply or 'b' to go back: ", function (input) {
            if (input.toLowerCase() === 'b') {
                _this.showMainMenu();
            }
            else {
                var jobId_1 = parseInt(input);
                var selectedJob = jobs.find(function (j) { return j.id === jobId_1; });
                if (selectedJob) {
                    // Check if already applied
                    var alreadyApplied = appliedJobs.some(function (app) { return app.jobId === jobId_1; });
                    if (!alreadyApplied) {
                        appliedJobs.push({ jobId: selectedJob.id, jobTitle: selectedJob.title });
                        console.log("\u2705 You have applied for \"".concat(selectedJob.title, "\"."));
                    }
                    else {
                        console.log("\u26A0\uFE0F You already applied for \"".concat(selectedJob.title, "\"."));
                    }
                }
                else {
                    console.log("❌ Invalid Job ID.");
                }
                _this.showMainMenu();
            }
        });
    };
    // 4️⃣ DISPLAY MY APPLICATIONS
    JobPortal.prototype.showMyApplications = function () {
        console.log("\n------------------ MY APPLICATIONS ------------------");
        if (appliedJobs.length === 0) {
            console.log("You have not applied for any jobs yet.");
        }
        else {
            appliedJobs.forEach(function (app) {
                console.log("Job Title: ".concat(app.jobTitle));
            });
        }
        this.showMainMenu();
    };
    // 5️⃣ LOGOUT
    JobPortal.prototype.logout = function () {
        console.log("\n👋 You have been logged out.");
        isLoggedIn = false;
        appliedJobs = [];
        this.showLogin();
    };
    return JobPortal;
}());
// ---------------------- PROGRAM START ----------------------
var portal = new JobPortal();
portal.start();
