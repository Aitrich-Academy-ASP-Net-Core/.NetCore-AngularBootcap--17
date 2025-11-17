abstract class Payment {
  abstract makePayment(amount: number): void; 
}

class CreditCardPayment extends Payment {
  makePayment(amount: number): void {
    if (amount > 50000) {
      console.log("Limit exceeded!");
    } else {
      console.log(`Payment of ₹${amount} made successfully via Credit Card.`);
    }
  }
}

class UPIPayment extends Payment {
  makePayment(amount: number): void {
    if (amount > 50000) {
      console.log("Limit exceeded!");
    } else {
      console.log(`Payment of ₹${amount} made successfully via UPI.`);
    }
  }
}


let method: string = "upi";  
let amount: number = 45000;

let payment: Payment; 

switch (method.toLowerCase()) {
  case "credit":
    payment = new CreditCardPayment();
    break;
  case "upi":
    payment = new UPIPayment();
    break;
  default:
    console.log("Invalid payment method!");
    payment = null!;
    break;
}


if (payment) {
  payment.makePayment(amount);
}




// activity2 vehicle

abstract class Vehicle {
  abstract accelerate(speed: number): void;
}

class Car extends Vehicle {
  accelerate(speed: number): void {
    for (let i = 0; i <= speed; i += 10) {
      console.log("Speed:", i);
      if (i >= 60) {
        console.log("Speed limit reached!");
        break;
      }
    }
  }
}

let mycar = new Car();
mycar.accelerate(100);





// activity3 Calculator

let marks: number[] = [85, 90, -1, 75, 60]; 
let total = 0;
let count = 0;

for (let i = 0; i < marks.length; i++) {
  if (marks[i] === -1) {
    console.log("Subject", i + 1, ": Absent");
    continue; 
  }
  total += marks[i];
  count++;
}

let avg = total / count;
console.log("Average:", avg);

if (avg >= 90) console.log("Grade: A");
else if (avg >= 75) console.log("Grade: B");
else if (avg >= 50) console.log("Grade: C");
else console.log("Fail");





// activity4


abstract class Cart {
  abstract calculateTotal(): void;
}

class OnlineCart extends Cart {
  calculateTotal(): void {
    let prices: number[] = [2000, 1500, 2500, 0]; 
    let total = 0;

    for (let i = 0; i < prices.length; i++) {
      if (prices[i] === 0) {
        console.log("Item adding stopped!");
        break; 
      }
      total += prices[i];
    }

    console.log("Total before discount:", total);

    if (total > 5000) {
      let discount = 0;

      
      switch (true) {
        case total < 10000:
          discount = total * 0.1; 
          console.log("Discount Type: 10%");
          break;
        case total >= 10000:
          discount = total * 0.2; 
          console.log("Discount Type: 20%");
          break;
      }

      total -= discount;
    }

    console.log("Final Total after discount:", total);
  }
}


let cart = new OnlineCart();
cart.calculateTotal();




// ATM Machine Simulation

abstract class ATM {
  abstract withdraw(amount: number): void;
  abstract deposit(amount: number): void;
  abstract checkBalance(): void;
}

class UserATM extends ATM {
  private balance: number = 0;

  withdraw(amount: number): void {
    if (amount > this.balance) {
      console.log("Insufficient balance!");
    } else {
      this.balance -= amount;
      console.log(`Withdrawn ₹${amount}. New balance: ₹${this.balance}`);
    }
  }

  deposit(amount: number): void {
    this.balance += amount;
    console.log(`Deposited ₹${amount}. New balance: ₹${this.balance}`);
  }

  checkBalance(): void {
    console.log(`Current balance: ₹${this.balance}`);
  }
}

// Simulate ATM Menu
let atm = new UserATM();
let choice: number = 1;

while (true) {
  console.log("\n1. Deposit  2. Withdraw  3. Check Balance  4. Exit");
 
  switch (choice) {
    case 1:
      atm.deposit(5000);
      choice = 2;
      break;
    case 2:
      atm.withdraw(2000);
      choice = 3;
      break;
    case 3:
      atm.checkBalance();
      choice = 4;
      break;
    case 4:
      console.log("Exiting ATM...");
      break;
  }
  if (choice === 4) break;
}
