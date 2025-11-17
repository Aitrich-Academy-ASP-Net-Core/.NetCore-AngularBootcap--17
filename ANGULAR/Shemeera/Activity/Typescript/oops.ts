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


class Laptop {
  brand: string;
  price: number;

  constructor() {
    this.brand = "HP";
    this.price = 50000;
  }

  showLaptop() {
    console.log(`Brand: ${this.brand}, Price: ${this.price}`);
  }
}

const l1 = new Laptop();
l1.showLaptop();







// Activity 4: Parameterized Constructor


class Student {
  rollNo: number;
  name: string;
  marks: number;

  constructor(rollNo: number, name: string, marks: number) {
    this.rollNo = rollNo;
    this.name = name;
    this.marks = marks;
  }

  display() {
    console.log(`Roll No: ${this.rollNo}, Name: ${this.name}, Marks: ${this.marks}`);
  }
}

const s1 = new Student(1, "John", 85);
const s2 = new Student(2, "Asha", 92);

s1.display();
s2.display();
