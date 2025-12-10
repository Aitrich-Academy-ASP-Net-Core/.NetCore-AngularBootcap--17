// let username:string="maya";
// console.log(username);
// ques .1
var studentnmae = "priya";
var age = 25;
var ispassed = true;
console.log("studentname ".concat(studentnmae, " ,age").concat(age, " , has passed ").concat(ispassed));
// ques .2
var productname = "rice";
var price = 50;
var quantity = 2;
var totalcost = price * quantity;
console.log("productname :".concat(productname, " total cost=").concat(totalcost));
// ques .3
var isLoggedIn = true;
if (isLoggedIn) {
    console.log("Welcome back!");
}
else {
    console.log("Please log in");
}
// ques .4
var employeename = null;
var employeeage;
console.log(employeename);
console.log(employeeage);


var data;
data = "Hello";
console.log(data);
data = 123;
console.log(data);
data = true;
console.log(data);



var cities = ["kochi", "Ekm", "Trissur"];
console.log("First city:", cities[0]);
console.log("Last city:", cities[cities.length - 1]);
var person = ["Shemeera", 23, true];
console.log("Name: ".concat(person[0]));
console.log("Age: ".concat(person[1]));
console.log("Employed: ".concat(person[2]));


var Days;
(function (Days) {
    Days[Days["Sunday"] = 0] = "Sunday";
    Days[Days["Monday"] = 1] = "Monday";
    Days[Days["Tuesday"] = 2] = "Tuesday";
})(Days || (Days = {}));
console.log("sanday is ".concat(Days.Sunday));
