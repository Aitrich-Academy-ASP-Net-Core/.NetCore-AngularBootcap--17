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
var Payment = /** @class */ (function () {
    function Payment() {
    }
    Payment.prototype.makePayment = function () {
        console.log("Processing generic payment...");
    };
    return Payment;
}());
var CreditCardPayment = /** @class */ (function (_super) {
    __extends(CreditCardPayment, _super);
    function CreditCardPayment() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    CreditCardPayment.prototype.makePayment = function () {
        console.log(" Payment made using Credit Card.");
    };
    return CreditCardPayment;
}(Payment));
var PaypalPayment = /** @class */ (function (_super) {
    __extends(PaypalPayment, _super);
    function PaypalPayment() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    PaypalPayment.prototype.makePayment = function () {
        console.log(" Payment made using PayPal.");
    };
    return PaypalPayment;
}(Payment));
var UPIPayment = /** @class */ (function (_super) {
    __extends(UPIPayment, _super);
    function UPIPayment() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    UPIPayment.prototype.makePayment = function () {
        console.log(" Payment made using UPI.");
    };
    return UPIPayment;
}(Payment));
var payment;
payment = new CreditCardPayment();
payment.makePayment();
payment = new PaypalPayment();
payment.makePayment();
payment = new UPIPayment();
payment.makePayment();
// activity2
var Shape = /** @class */ (function () {
    function Shape() {
    }
    Shape.prototype.area = function () {
        console.log("Calculating area...");
    };
    return Shape;
}());
var Circle = /** @class */ (function (_super) {
    __extends(Circle, _super);
    function Circle(radius) {
        var _this = _super.call(this) || this;
        _this.radius = radius;
        return _this;
    }
    Circle.prototype.area = function () {
        var result = 3.14 * this.radius * this.radius;
        console.log("Area of Circle =", result);
    };
    return Circle;
}(Shape));
var Rectangle = /** @class */ (function (_super) {
    __extends(Rectangle, _super);
    function Rectangle(length, width) {
        var _this = _super.call(this) || this;
        _this.length = length;
        _this.width = width;
        return _this;
    }
    Rectangle.prototype.area = function () {
        var result = this.length * this.width;
        console.log("Area of Rectangle =", result);
    };
    return Rectangle;
}(Shape));
var shapes = [
    new Circle(5),
    new Rectangle(10, 4)
];
for (var _i = 0, shapes_1 = shapes; _i < shapes_1.length; _i++) {
    var s = shapes_1[_i];
    s.area();
}
// ctivity3 vehicle
var Vehicles = /** @class */ (function () {
    function Vehicles() {
    }
    Vehicles.prototype.sound = function () {
        console.log("vehicle make a sound....");
    };
    return Vehicles;
}());
var Car1 = /** @class */ (function (_super) {
    __extends(Car1, _super);
    function Car1() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Car1.prototype.sound = function () {
        console.log("vroom vroom");
    };
    return Car1;
}(Vehicles));
var Bike = /** @class */ (function (_super) {
    __extends(Bike, _super);
    function Bike() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Bike.prototype.sound = function () {
        console.log("beep beep");
    };
    return Bike;
}(Vehicles));
var Bus = /** @class */ (function (_super) {
    __extends(Bus, _super);
    function Bus() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Bus.prototype.sound = function () {
        console.log("honk,honk");
    };
    return Bus;
}(Vehicles));
var Vehicle;
Vehicle = new Car1();
Vehicle.sound();
Vehicle = new Bike();
Vehicle.sound();
Vehicle = new Bus();
Vehicle.sound();
// activity4
var Course = /** @class */ (function () {
    function Course() {
    }
    Course.prototype.getCourseDetails = function () {
        console.log("general course details");
    };
    return Course;
}());
var Freecourse = /** @class */ (function (_super) {
    __extends(Freecourse, _super);
    function Freecourse() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Freecourse.prototype.getCourseDetails = function () {
        console.log("Free Course: Access to limited lessons, no certificate");
    };
    return Freecourse;
}(Course));
var Premiumcourse = /** @class */ (function (_super) {
    __extends(Premiumcourse, _super);
    function Premiumcourse() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Premiumcourse.prototype.getCourseDetails = function () {
        console.log("Premium Course: Access to all lessons, certificate included!");
    };
    return Premiumcourse;
}(Course));
var course = [
    new Freecourse(),
    new Premiumcourse()
];
for (var _a = 0, course_1 = course; _a < course_1.length; _a++) {
    var c = course_1[_a];
    c.getCourseDetails();
}
