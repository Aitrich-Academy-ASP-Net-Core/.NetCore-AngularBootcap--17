// traffic Light Controller
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
while (true) {
    var light_1 = "green";
    switch (light_1.toLowerCase()) {
        case "red":
            console.log("Stop ");
            break;
        case "yellow":
            console.log("Get Ready ");
            break;
        case "green":
            console.log("Go ");
            break;
        case "exit":
            console.log("System stopped!");
            break;
        default:
            console.log("Invalid color!");
            continue;
    }
    if (light_1 === "exit") {
        break;
    }
    break;
}
// calculator
var Employee = /** @class */ (function () {
    function Employee() {
    }
    return Employee;
}());
var FullTimeEmployee = /** @class */ (function (_super) {
    __extends(FullTimeEmployee, _super);
    function FullTimeEmployee(name, baseSalary, experience) {
        var _this = _super.call(this) || this;
        _this.name = name;
        _this.baseSalary = baseSalary;
        _this.experience = experience;
        return _this;
    }
    FullTimeEmployee.prototype.calculateSalary = function () {
        var bonus = 0;
        if (this.experience > 5) {
            bonus = 5000;
        }
        else if (this.experience >= 2) {
            bonus = 2000;
        }
        else {
            bonus = 0;
        }
        console.log("".concat(this.name, " (Full-time) Salary = \u20B9").concat(this.baseSalary + bonus));
    };
    return FullTimeEmployee;
}(Employee));
var PartTimeEmployee = /** @class */ (function (_super) {
    __extends(PartTimeEmployee, _super);
    function PartTimeEmployee(name, hoursWorked, hourlyRate) {
        var _this = _super.call(this) || this;
        _this.name = name;
        _this.hoursWorked = hoursWorked;
        _this.hourlyRate = hourlyRate;
        return _this;
    }
    PartTimeEmployee.prototype.calculateSalary = function () {
        var total = this.hoursWorked * this.hourlyRate;
        console.log("".concat(this.name, " (Part-time) Salary = \u20B9").concat(total));
    };
    return PartTimeEmployee;
}(Employee));
var employees = [
    new FullTimeEmployee("Asha", 30000, 6),
    new FullTimeEmployee("Rahul", 25000, 3),
    new PartTimeEmployee("Meera", 40, 300)
];
for (var i = 0; i < employees.length; i++) {
    employees[i].calculateSalary();
}
// game
var randomNumber = Math.floor(Math.random() * 10) + 1;
var guess;
var attempts = 0;
do {
    guess = 4;
    attempts++;
    if (guess < 1 || guess > 10) {
        console.log("Invalid guess! Enter number between 1–10.");
        continue; // skip rest and start again
    }
    if (guess === randomNumber) {
        console.log(" Correct! The number was ".concat(randomNumber, ". Attempts: ").concat(attempts));
        break;
    }
    else {
        console.log(" Wrong guess, try again!");
        break;
    }
} while (true);
// appliancecontol
var Appliance = /** @class */ (function () {
    function Appliance() {
    }
    return Appliance;
}());
var Fan = /** @class */ (function (_super) {
    __extends(Fan, _super);
    function Fan() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Fan.prototype.turnOn = function () {
        console.log(" Fan is ON");
    };
    Fan.prototype.turnOff = function () {
        console.log(" Fan is OFF");
    };
    return Fan;
}(Appliance));
var Light = /** @class */ (function (_super) {
    __extends(Light, _super);
    function Light() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Light.prototype.turnOn = function () {
        console.log("💡 Light is ON");
    };
    Light.prototype.turnOff = function () {
        console.log("💡 Light is OFF");
    };
    return Light;
}(Appliance));
var fan = new Fan();
var light = new Light();
var option = "fanon";
while (true) {
    switch (option.toLowerCase()) {
        case "fanon":
            fan.turnOn();
            break;
        case "fanoff":
            fan.turnOff();
            break;
        case "lighton":
            light.turnOn();
            break;
        case "lightoff":
            light.turnOff();
            break;
        case "exit":
            console.log("System shutting down...");
            break;
        default:
            console.log("Invalid option!");
            break;
    }
    if (option === "exit") {
        break;
    }
    break;
}
// VOTING
var Citizen = /** @class */ (function () {
    function Citizen() {
    }
    return Citizen;
}());
var Voter = /** @class */ (function (_super) {
    __extends(Voter, _super);
    function Voter() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Voter.prototype.checkEligibility = function (age) {
        if (age < 18) {
            console.log("Age ".concat(age, ":  Not eligible to vote"));
        }
        else {
            console.log("Age ".concat(age, ":  Eligible to vote"));
        }
    };
    return Voter;
}(Citizen));
var voter = new Voter();
var age;
do {
    age = 25;
    if (age === 0) {
        console.log("Program ended!");
        break;
    }
    voter.checkEligibility(age);
    break;
} while (true);
