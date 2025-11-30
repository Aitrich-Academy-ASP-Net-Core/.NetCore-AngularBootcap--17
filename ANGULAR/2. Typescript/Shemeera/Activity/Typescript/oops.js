// class car{
//     brand:string;
//     model:string;
//     price:number;
//     displaydetails(){
//         console.log(`BRAND ${this.brand} ,MODEL  ${this.model},PRICE  ${this.price}`)
//     }
// }
// let car1=new car();
// car1.brand="Toyota";
// car1.model="Innova"
// car1.price=1200000;
// car1.displaydetails();
// activity2
// class Person{
// Name:string;
// Age:number;
// City:string;
// constructor(Name:string,Age:Number,City:String){
// this.Name=Name;
// this.Age=Age;
// this.City=City;
// }
// showInfo(){
//     console.log(`Name: ${this.Name}, Age: ${this.Age}, City: ${this.City}`)
// }
// }
// let p1 = new Person("Anu", 25, "Kochi");
// let p2 = new Person("Ravi", 30, "Trivandrum");
// p1.showInfo();
// p2.showInfo()
// Activity 3: Default Constructor
var Laptop = /** @class */ (function () {
    function Laptop() {
        this.brand = "HP";
        this.price = 50000;
    }
    Laptop.prototype.showLaptop = function () {
        console.log("Brand: ".concat(this.brand, ", Price: ").concat(this.price));
    };
    return Laptop;
}());
var l1 = new Laptop();
l1.showLaptop();
// Activity 4: Parameterized Constructor
var Student = /** @class */ (function () {
    function Student(rollNo, name, marks) {
        this.rollNo = rollNo;
        this.name = name;
        this.marks = marks;
    }
    Student.prototype.display = function () {
        console.log("Roll No: ".concat(this.rollNo, ", Name: ").concat(this.name, ", Marks: ").concat(this.marks));
    };
    return Student;
}());
var s1 = new Student(1, "John", 85);
var s2 = new Student(2, "Asha", 92);
s1.display();
s2.display();
