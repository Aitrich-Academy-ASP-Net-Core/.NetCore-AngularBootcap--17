// File: product.ts
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
var Product = /** @class */ (function () {
    function Product(name, price) {
        this.name = name;
        this.price = price;
    }
    Product.prototype.showProduct = function () {
        console.log("Product: ".concat(this.name, ", Price: ").concat(this.price));
    };
    return Product;
}());
var ElectronicsProduct = /** @class */ (function (_super) {
    __extends(ElectronicsProduct, _super);
    function ElectronicsProduct(name, price, warrantyYears) {
        var _this = _super.call(this, name, price) || this;
        _this.warrantyYears = warrantyYears;
        return _this;
    }
    ElectronicsProduct.prototype.showWarranty = function () {
        console.log("Warranty: ".concat(this.warrantyYears, " years"));
    };
    return ElectronicsProduct;
}(Product));
var e1 = new ElectronicsProduct("Laptop", 75000, 2);
e1.showProduct();
e1.showWarranty();
// multilevel inheritance
var Person = /** @class */ (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }
    return Person;
}());
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(name, age, employeeId, designation) {
        var _this = _super.call(this, name, age) || this;
        _this.employeeId = employeeId;
        _this.designation = designation;
        return _this;
    }
    return Employee;
}(Person));
var Manager = /** @class */ (function (_super) {
    __extends(Manager, _super);
    function Manager(name, age, employeeId, designation, department) {
        var _this = _super.call(this, name, age, employeeId, designation) || this;
        _this.department = department;
        return _this;
    }
    Manager.prototype.showDetails = function () {
        console.log("Name: ".concat(this.name, ", Age: ").concat(this.age, ", ID: ").concat(this.employeeId, ", Designation: ").concat(this.designation, ", Department: ").concat(this.department));
    };
    return Manager;
}(Employee));
var m1 = new Manager("neha", 25, 1, "developer", "HR");
m1.showDetails();
// Activity 3: Using super() — Vehicle Information
var Vehicle = /** @class */ (function () {
    function Vehicle(brand, model) {
        this.brand = brand;
        this.model = model;
    }
    return Vehicle;
}());
var Car = /** @class */ (function (_super) {
    __extends(Car, _super);
    function Car(brand, model, fuelType) {
        var _this = _super.call(this, brand, model) || this;
        _this.fuelType = fuelType;
        return _this;
    }
    Car.prototype.showCarDetails = function () {
        console.log("Brand: ".concat(this.brand, ", Model: ").concat(this.model, ", Fuel: ").concat(this.fuelType));
    };
    return Car;
}(Vehicle));
var c1 = new Car("Toyota", "Innova", "Diesel");
c1.showCarDetails();
// Activity 4: Multilevel + super() — Education System
var Persons = /** @class */ (function () {
    function Persons(name) {
        this.name = name;
    }
    Persons.prototype.showDetails1 = function () {
        console.log("Name: ".concat(this.name));
    };
    return Persons;
}());
var Teacher = /** @class */ (function (_super) {
    __extends(Teacher, _super);
    function Teacher(name, subject) {
        var _this = _super.call(this, name) || this;
        _this.subject = subject;
        return _this;
    }
    return Teacher;
}(Persons));
var HeadTeacher = /** @class */ (function (_super) {
    __extends(HeadTeacher, _super);
    function HeadTeacher(name, subject, department) {
        var _this = _super.call(this, name, subject) || this;
        _this.department = department;
        return _this;
    }
    HeadTeacher.prototype.showDetails = function () {
        console.log("Name: ".concat(this.name, ", Subject: ").concat(this.subject, ", Department: ").concat(this.department));
    };
    return HeadTeacher;
}(Teacher));
var ht1 = new HeadTeacher("Meera", "Maths", "Science Department");
ht1.showDetails();
ht1.showDetails1();
