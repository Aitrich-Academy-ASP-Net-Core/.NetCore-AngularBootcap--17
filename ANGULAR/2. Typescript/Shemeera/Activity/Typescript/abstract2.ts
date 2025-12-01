// traffic Light Controller

while (true) {
  let light: string = "green"; 
  

  switch (light.toLowerCase()) {
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

  if (light === "exit") {
    break;
  }

  break; 
}




// calculator

abstract class Employee {
  abstract calculateSalary(): void;
}


class FullTimeEmployee extends Employee {
  constructor(private name: string, private baseSalary: number, private experience: number) {
    super();
  }

  calculateSalary(): void {
    let bonus = 0;
    if (this.experience > 5) {
      bonus = 5000;
    } else if (this.experience >= 2) {
      bonus = 2000;
    } else {
      bonus = 0;
    }
    console.log(`${this.name} (Full-time) Salary = ₹${this.baseSalary + bonus}`);
  }
}


class PartTimeEmployee extends Employee {
  constructor(private name: string, private hoursWorked: number, private hourlyRate: number) {
    super();
  }

  calculateSalary(): void {
    let total = this.hoursWorked * this.hourlyRate;
    console.log(`${this.name} (Part-time) Salary = ₹${total}`);
  }
}



let employees: Employee[] = [
  new FullTimeEmployee("Asha", 30000, 6),
  new FullTimeEmployee("Rahul", 25000, 3),
  new PartTimeEmployee("Meera", 40, 300)
];

for (let i = 0; i < employees.length; i++) {
  employees[i].calculateSalary();
}




// game

let randomNumber: number = Math.floor(Math.random() * 10) + 1; 
let guess: number;
let attempts: number = 0;

do {
  guess = 4; 
  attempts++;

  if (guess < 1 || guess > 10) {
    console.log("Invalid guess! Enter number between 1–10.");
    continue; // skip rest and start again
  }

  if (guess === randomNumber) {
    console.log(` Correct! The number was ${randomNumber}. Attempts: ${attempts}`);
    break; 
  } else {
    console.log(" Wrong guess, try again!");
break;

  }

} while (true);



// appliancecontol


abstract class Appliance {
  abstract turnOn(): void;
  abstract turnOff(): void;
}


class Fan extends Appliance {
  turnOn(): void {
    console.log(" Fan is ON");
  }
  turnOff(): void {
    console.log(" Fan is OFF");
  }
}


class Light extends Appliance {
  turnOn(): void {
    console.log("💡 Light is ON");
  }
  turnOff(): void {
    console.log("💡 Light is OFF");
  }
}


let fan = new Fan();
let light = new Light();

let option: string = "fanon"; 

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


abstract class Citizen {
  abstract checkEligibility(age: number): void;
}


class Voter extends Citizen {
  checkEligibility(age: number): void {
    if (age < 18) {
      console.log(`Age ${age}:  Not eligible to vote`);
    } else {
      console.log(`Age ${age}:  Eligible to vote`);
    }
  }
}


let voter = new Voter();
let age: number;

do {
  age = 25; 

  if (age === 0) {
    console.log("Program ended!");
    break; 
  }

  voter.checkEligibility(age);

  
  break;

} while (true);

