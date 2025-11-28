function greet(): void {
  console.log("Welcome to TypeScript!");
}

function main() {
  greet();
}

main();




// 2

function addNumbers(a: number, b: number): number {
  return a + b;
}

let sum = addNumbers(10, 20);
console.log("Sum:", sum);



// 3

let multiply = function (a: number, b: number): number {
  return a * b;
};

console.log("Multiplication:", multiply(5, 4));


// 4

let divide = (a: number, b: number): number => {
  if (b === 0) return 0;
  return a / b;
};

console.log("Division:", divide(10, 2));
console.log("Division (by zero):", divide(10, 0));



// 5
let message = function () {
  console.log("Hello, this is anonymous!");
};

message();




// Activity 6: Function Overloading

function showInfo(name: string): void;
function showInfo(age: number): void;

function showInfo(value: any): void {
  if (typeof value === "string") {
    console.log(`Name: ${value}`);
  } else if (typeof value === "number") {
    console.log(`Age: ${value}`);
  }
}

showInfo("John");
showInfo(25);





// Activity 7: Required Parameters

function displayStudent(id: number, name: string): void {
  console.log(`ID: ${id}, Name: ${name}`);
}

displayStudent(101, "Alice");



//  Activity 8: Optional Parameters
function registerUser(name: string, email?: string): void {
  if (email) {
    console.log(`Name: ${name}, Email: ${email}`);
  } else {
    console.log(`Name: ${name}, Email not provided`);
  }
}

registerUser("Bob", "bob@gmail.com");
registerUser("Charlie");





//  Activity 9: Default Parameters

function calculateBill(amount: number, tax: number = 5): number {
  return amount + (amount * tax) / 100;
}

console.log("Bill (default tax):", calculateBill(1000));
console.log("Bill (custom tax):", calculateBill(1000, 10));

//  Activity 10: Rest Parameters

function sumAll(...numbers: number[]): number {
  let total = 0;
  for (let n of numbers) {
    total += n;
  }
  return total;
}

console.log("Sum of all:", sumAll(3, 4, 5, 6));



//  Activity 11: Named Parameters (Object Destructuring)

function createUser({ name, age }: { name: string; age: number }): void {
  console.log(`Name: ${name}, Age: ${age}`);
}

createUser({ name: "Diana", age: 22 });




//  Activity 12: Function as Parameter

function performOperation(
  a: number,
  b: number,
  operation: (x: number, y: number) => number
): number {
  return operation(a, b);
}

let add = (x: number, y: number) => x + y;
let multiplyOp = (x: number, y: number) => x * y;

console.log("Addition:", performOperation(5, 10, add));
console.log("Multiplication:", performOperation(5, 10, multiplyOp));