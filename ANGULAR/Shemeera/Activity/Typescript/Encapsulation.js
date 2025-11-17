var BankAccount = /** @class */ (function () {
    function BankAccount(Accountnumber, Balance) {
        if (Balance === void 0) { Balance = 0; }
        this.Accountnumber = Accountnumber;
        this.Balance = Balance;
    }
    BankAccount.prototype.deposit = function (amount) {
        if (amount > 0) {
            this.Balance += amount;
            console.log("deposited".concat(amount, ",current balance is ").concat(this.Balance));
        }
        else {
            console.log("ivalied");
        }
    };
    BankAccount.prototype.widraw = function (amount) {
        if (amount > 0 && amount <= this.Balance) {
            this.Balance -= amount;
            console.log("Widrawn".concat(amount, ",current balance is ").concat(this.Balance));
        }
        else {
            console.log("invalied");
        }
    };
    BankAccount.prototype.getBalance = function () {
        return this.Balance;
    };
    return BankAccount;
}());
var b1 = new BankAccount(1457855455, 7000);
b1.deposit(1000);
b1.widraw(2000);
console.log("Final Balance:", b1.getBalance());
// activity2 ;studentmark
var studentMark = /** @class */ (function () {
    function studentMark(name) {
        this.mark = 0;
        this.name = name;
    }
    studentMark.prototype.settermark = function (mark) {
        if (mark > 0 && mark <= 100) {
            this.mark = mark;
        }
        else {
            console.log("invalied mark");
        }
    };
    studentMark.prototype.getttermark = function () {
        if (this.mark >= 90) {
            console.log("Garade :A");
        }
        else if (this.mark >= 80) {
            console.log("Garade :B");
        }
        else if (this.mark >= 70) {
            console.log("Garade :c");
        }
        else if (this.mark >= 60) {
            console.log("Garade :D");
        }
        else {
            console.log("Failed");
        }
    };
    return studentMark;
}());
var stud = new studentMark("meera");
stud.settermark(85);
stud.getttermark();
// activity3 employeesalary
var Employees = /** @class */ (function () {
    function Employees(Empname, salary) {
        this.Empname = Empname;
        this.Salary = salary;
    }
    Employees.prototype.settersalary = function (perfomence) {
        if (perfomence == "good") {
            this.Salary += 5000;
            console.log("".concat(this.Empname, "'s performance is good! Salary increased to \u20B9").concat(this.Salary));
        }
        else {
            console.log("".concat(this.Empname, "'s performance is not good. Salary remains \u20B9").concat(this.Salary));
        }
    };
    Employees.prototype.gettersalary = function () {
        //    return this.Salary;
        console.log("current salary".concat(this.Salary));
    };
    return Employees;
}());
var E1 = new Employees("meera", 10000);
E1.settersalary("good");
E1.gettersalary();
// activity4 PRODUCT
var Products = /** @class */ (function () {
    function Products(Productname, Productprice) {
        this.Discount = 0;
        this.Productname = Productname;
        this.Productprice = Productprice;
    }
    Products.prototype.setterdiscount = function (Discount) {
        if (Discount > 0 && Discount < 50) {
            this.Discount = Discount;
        }
        else {
            console.log(" Discount cannot be more than 50%! Setting it to 50%.");
        }
    };
    Products.prototype.getterdiscount = function () {
        var getFinalPrice = this.Productprice - (this.Productprice * this.Discount) / 100;
        console.log(" Product: ".concat(this.Productname));
        console.log(" Price: \u20B9".concat(this.Productprice));
        console.log(" Discount: ".concat(this.Discount, "%"));
        console.log(" Final Price after discount: \u20B9".concat(getFinalPrice));
        console.log("-------------------------------------");
    };
    return Products;
}());
var p1 = new Products("rice", 400);
p1.setterdiscount(55);
p1.getterdiscount();
