// let username:string="maya";
// console.log(username);

// ques .1
let studentnmae:string="priya";
let age:number=25;
let ispassed:boolean=true;

console.log(`studentname ${studentnmae} ,age${age} , has passed ${ispassed}`);

// ques .2
let productname:string="rice";
let price:number=50;
let quantity:number=2;
let totalcost:number=price*quantity;
 console.log(`productname :${productname} total cost=${totalcost}`);

// ques .3

let isLoggedIn: boolean = true;

if (isLoggedIn) {
  console.log("Welcome back!");
} else {
  console.log("Please log in");
}

// ques .4

let employeename:null=null;
let employeeage:undefined;

console.log(employeename);
console.log(employeeage);



let data: any;

data = "Hello";
console.log(data);

data = 123;
console.log(data);

data = true;
console.log(data);



let cities:string[]=["kochi","Ekm","Trissur"]

console.log("First city:", cities[0]);
console.log("Last city:", cities[cities.length - 1]);



let person: [string, number, boolean] = ["Shemeera", 23, true];

console.log(`Name: ${person[0]}`);
console.log(`Age: ${person[1]}`);
console.log(`Employed: ${person[2]}`);



enum Days {
  Sunday,
  Monday,
  Tuesday}

  console.log(`sanday is ${Days.Sunday}`);
