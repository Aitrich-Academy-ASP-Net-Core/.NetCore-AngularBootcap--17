
class Payment {
  makePayment(): void {
    console.log("Processing generic payment...");
  }
}


class CreditCardPayment extends Payment {
  makePayment(): void {
    console.log(" Payment made using Credit Card.");
  }
}


class PaypalPayment extends Payment {
  makePayment(): void {
    console.log(" Payment made using PayPal.");
  }
}


class UPIPayment extends Payment {
  makePayment(): void {
    console.log(" Payment made using UPI.");
  }
}


let payment: Payment;

payment = new CreditCardPayment();
payment.makePayment(); 

payment = new PaypalPayment();
payment.makePayment(); 

payment = new UPIPayment();
payment.makePayment(); 





// activity2

class Shape {
  area(): void {
    console.log("Calculating area...");
  }
}

class Circle extends Shape {
  radius: number;

  constructor(radius: number) {
    super();
    this.radius = radius;
  }

  area(): void {
    let result = 3.14 * this.radius * this.radius;
    console.log("Area of Circle =", result);
  }
}

class Rectangle extends Shape {
  length: number;
  width: number;

  constructor(length: number, width: number) {
    super();
    this.length = length;
    this.width = width;
  }

  area(): void {
    let result = this.length * this.width;
    console.log("Area of Rectangle =", result);
  }
}


let shapes: Shape[] = [
  new Circle(5),
  new Rectangle(10, 4)
];

for (let s of shapes) {
  s.area(); 
}


// ctivity3 vehicle
class Vehicles{

sound():void{
  console.log("vehicle make a sound....");
}
}

 class Car1 extends Vehicles{
sound():void{
  console.log("vroom vroom")
}
 }

 class Bike extends Vehicles{
sound():void{
  console.log("beep beep")
}
 }


 class Bus extends Vehicles{
sound():void{
  console.log("honk,honk")
}

 }

let Vehicle:Vehicles;
Vehicle=new Car1();
Vehicle.sound();

Vehicle=new Bike();
Vehicle.sound();

Vehicle=new Bus();
Vehicle.sound();


// activity4

class Course{

  getCourseDetails():void{

    console.log("general course details")
  }
}
class Freecourse extends Course{

  getCourseDetails(): void {
    console.log("Free Course: Access to limited lessons, no certificate")
  }
}
class Premiumcourse extends Course{

  getCourseDetails(): void {
    console.log("Premium Course: Access to all lessons, certificate included!")
  }
}

let course:Course[]=[
  new Freecourse(),
  new Premiumcourse()
]

for(let c of course){

  c.getCourseDetails();
}