"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var User_1 = require("./User");
var Job_1 = require("./Job");
var Application_1 = require("./Application");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var JobPortal = /** @class */ (function () {
    function JobPortal() {
        this.users = [];
        this.jobs = [
            new Job_1.Job(101, "Java Developer"),
            new Job_1.Job(102, "Angular Developer"),
            new Job_1.Job(103, "ASP.NET Developer"),
            new Job_1.Job(104, "Python Developer")
        ];
        this.applications = [];
        this.currentUser = null;
    }
    JobPortal.prototype.start = function () {
        this.mainMenu();
    };
    JobPortal.prototype.mainMenu = function () {
        var _this = this;
        console.log("\n===== MAIN MENU =====");
        console.log("1. Signup");
        console.log("2. Login");
        console.log("0. Exit");
        rl.question("Enter your choice: ", function (choice) {
            switch (choice) {
                case "1":
                    _this.signup();
                    break;
                case "2":
                    _this.login();
                    break;
                case "0":
                    console.log("Exiting...");
                    rl.close();
                    break;
                default:
                    console.log("Invalid Choice!");
                    _this.mainMenu();
            }
        });
    };
    JobPortal.prototype.signup = function () {
        var _this = this;
        console.log("\n===== SIGNUP =====");
        rl.question("Enter Username: ", function (username) {
            rl.question("Enter Password: ", function (password) {
                rl.question("Enter First Name: ", function (firstName) {
                    rl.question("Enter Last Name: ", function (lastName) {
                        rl.question("Enter Gender: ", function (gender) {
                            rl.question("Enter Phone Number: ", function (phone) {
                                var newUser = new User_1.User(username, password, firstName, lastName, gender, phone);
                                _this.users.push(newUser);
                                console.log("\nSignup Successful!");
                                _this.login();
                            });
                        });
                    });
                });
            });
        });
    };
    JobPortal.prototype.login = function () {
        var _this = this;
        console.log("\n===== LOGIN =====");
        rl.question("Username: ", function (username) {
            rl.question("Password: ", function (password) {
                var foundUser = _this.users.find(function (u) { return u.username === username && u.password === password; });
                if (foundUser) {
                    _this.currentUser = foundUser;
                    console.log("\nLogin Successful!");
                    _this.userMenu();
                }
                else {
                    console.log("Invalid username or password!");
                    _this.mainMenu();
                }
            });
        });
    };
    JobPortal.prototype.userMenu = function () {
        var _this = this;
        console.log("\n===== USER MENU =====");
        console.log("1. View Listed Jobs");
        console.log("2. Apply for Job");
        console.log("3. View Applied Jobs");
        console.log("4. Logout");
        rl.question("Enter your choice: ", function (choice) {
            switch (choice) {
                case "1":
                    _this.viewJobs();
                    break;
                case "2":
                    _this.applyForJob();
                    break;
                case "3":
                    _this.viewAppliedJobs();
                    break;
                case "4":
                    _this.currentUser = null;
                    console.log("Logged out!");
                    _this.mainMenu();
                    break;
                default:
                    console.log("Invalid Choice!");
                    _this.userMenu();
            }
        });
    };
    JobPortal.prototype.viewJobs = function () {
        console.log("\n===== JOB LIST =====");
        this.jobs.forEach(function (j) {
            console.log("Job ID: ".concat(j.jobId, " | Title: ").concat(j.title));
        });
        this.userMenu();
    };
    JobPortal.prototype.applyForJob = function () {
        var _this = this;
        console.log("\nEnter Job ID to Apply:");
        rl.question("Job ID: ", function (jid) {
            var job = _this.jobs.find(function (j) { return j.jobId === Number(jid); });
            if (!job) {
                console.log("Invalid Job ID!");
                _this.userMenu();
                return;
            }
            if (!_this.currentUser)
                return;
            _this.applications.push(new Application_1.Application(_this.currentUser.username, job.jobId));
            console.log("Applied Successfully!");
            _this.userMenu();
        });
    };
    JobPortal.prototype.viewAppliedJobs = function () {
        var _this = this;
        if (!this.currentUser)
            return;
        console.log("\n===== APPLIED JOBS =====");
        var applied = this.applications.filter(function (a) { return a.username === _this.currentUser.username; });
        if (applied.length === 0) {
            console.log("No Applied Jobs!");
        }
        else {
            applied.forEach(function (a) {
                var job = _this.jobs.find(function (j) { return j.jobId === a.jobId; });
                console.log("Applied Job: ".concat(job === null || job === void 0 ? void 0 : job.title));
            });
        }
        this.userMenu();
    };
    return JobPortal;
}());
var portal = new JobPortal();
portal.start();
