// File: product.ts

class Product {
  name: string;
  price: number;

  constructor(name: string, price: number) {
    this.name = name;
    this.price = price;
  }

  showProduct() {
    console.log(`Product: ${this.name}, Price: ${this.price}`);
  }
}

class ElectronicsProduct extends Product {
  warrantyYears: number;

  constructor(name: string, price: number, warrantyYears: number) {
    super(name, price);
    this.warrantyYears = warrantyYears;
  }

  showWarranty() {
    console.log(`Warranty: ${this.warrantyYears} years`);
  }
}

const e1 = new ElectronicsProduct("Laptop", 75000, 2);
e1.showProduct();
e1.showWarranty();





// multilevel inheritance
class Person{

name:string;
age:number;

constructor(name:string,age:number)
{
this.name=name;
this.age=age;

}

}

class Employee extends Person{

    employeeId:number;
    designation:string;

    constructor(name:string,age:number,employeeId:number,designation:string)
    {
        super(name,age);
        this.employeeId=employeeId;
        this.designation=designation;
    }

}
class Manager extends Employee{

    department:string;

    constructor(name:string,age:number,employeeId:number,designation:string,department:string){

super(name,age,employeeId,designation);
this.department=department;

    }
 showDetails() {
    console.log(
      `Name: ${this.name}, Age: ${this.age}, ID: ${this.employeeId}, Designation: ${this.designation}, Department: ${this.department}`
    );
 }

}

let m1=new Manager("neha",25,1,"developer","HR");
m1.showDetails();



// Activity 3: Using super() — Vehicle Information


class Vehicle {
  brand: string;
  model: string;

  constructor(brand: string, model: string) {
    this.brand = brand;
    this.model = model;
  }
}

class Car extends Vehicle {
  fuelType: string;

  constructor(brand: string, model: string, fuelType: string) {
    super(brand, model); 
    this.fuelType = fuelType;
  }

  showCarDetails() {
    console.log(`Brand: ${this.brand}, Model: ${this.model}, Fuel: ${this.fuelType}`);
  }
}

const c1 = new Car("Toyota", "Innova", "Diesel");
c1.showCarDetails();




// Activity 4: Multilevel + super() — Education System


class Persons {
  name: string;
  constructor(name: string) {
    this.name = name;
  }

 showDetails1() {
    console.log(`Name: ${this.name}`);
  }

}

class Teacher extends Persons {
  subject: string;
  constructor(name: string, subject: string) {
    super(name);
    this.subject = subject;
  }
}

class HeadTeacher extends Teacher {
  department: string;
  constructor(name: string, subject: string, department: string) {
    super(name, subject);
    this.department = department;
  }

  showDetails() {
    console.log(`Name: ${this.name}, Subject: ${this.subject}, Department: ${this.department}`);
  }
}

const ht1 = new HeadTeacher("Meera", "Maths", "Science Department");
ht1.showDetails();
ht1.showDetails1();