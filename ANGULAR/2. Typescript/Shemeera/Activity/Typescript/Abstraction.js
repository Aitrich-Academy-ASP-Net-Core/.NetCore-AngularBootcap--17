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
    return Payment;
}());
var CreditCardPayment = /** @class */ (function (_super) {
    __extends(CreditCardPayment, _super);
    function CreditCardPayment() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    CreditCardPayment.prototype.makePayment = function (amount) {
        if (amount > 50000) {
            console.log("Limit exceeded!");
        }
        else {
            console.log("Payment of \u20B9".concat(amount, " made successfully via Credit Card."));
        }
    };
    return CreditCardPayment;
}(Payment));
var UPIPayment = /** @class */ (function (_super) {
    __extends(UPIPayment, _super);
    function UPIPayment() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    UPIPayment.prototype.makePayment = function (amount) {
        if (amount > 50000) {
            console.log("Limit exceeded!");
        }
        else {
            console.log("Payment of \u20B9".concat(amount, " made successfully via UPI."));
        }
    };
    return UPIPayment;
}(Payment));
var method = "upi";
var amount = 45000;
var payment;
switch (method.toLowerCase()) {
    case "credit":
        payment = new CreditCardPayment();
        break;
    case "upi":
        payment = new UPIPayment();
        break;
    default:
        console.log("Invalid payment method!");
        payment = null;
        break;
}
if (payment) {
    payment.makePayment(amount);
}
// activity2 vehicle
var Vehicle = /** @class */ (function () {
    function Vehicle() {
    }
    return Vehicle;
}());
var Car = /** @class */ (function (_super) {
    __extends(Car, _super);
    function Car() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Car.prototype.accelerate = function (speed) {
        for (var i = 0; i <= speed; i += 10) {
            console.log("Speed:", i);
            if (i >= 60) {
                console.log("Speed limit reached!");
                break;
            }
        }
    };
    return Car;
}(Vehicle));
var mycar = new Car();
mycar.accelerate(100);
// activity3 Calculator
var marks = [85, 90, -1, 75, 60];
var total = 0;
var count = 0;
for (var i = 0; i < marks.length; i++) {
    if (marks[i] === -1) {
        console.log("Subject", i + 1, ": Absent");
        continue;
    }
    total += marks[i];
    count++;
}
var avg = total / count;
console.log("Average:", avg);
if (avg >= 90)
    console.log("Grade: A");
else if (avg >= 75)
    console.log("Grade: B");
else if (avg >= 50)
    console.log("Grade: C");
else
    console.log("Fail");
// activity4
var Cart = /** @class */ (function () {
    function Cart() {
    }
    return Cart;
}());
var OnlineCart = /** @class */ (function (_super) {
    __extends(OnlineCart, _super);
    function OnlineCart() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    OnlineCart.prototype.calculateTotal = function () {
        var prices = [2000, 1500, 2500, 0];
        var total = 0;
        for (var i = 0; i < prices.length; i++) {
            if (prices[i] === 0) {
                console.log("Item adding stopped!");
                break;
            }
            total += prices[i];
        }
        console.log("Total before discount:", total);
        if (total > 5000) {
            var discount = 0;
            switch (true) {
                case total < 10000:
                    discount = total * 0.1;
                    console.log("Discount Type: 10%");
                    break;
                case total >= 10000:
                    discount = total * 0.2;
                    console.log("Discount Type: 20%");
                    break;
            }
            total -= discount;
        }
        console.log("Final Total after discount:", total);
    };
    return OnlineCart;
}(Cart));
var cart = new OnlineCart();
cart.calculateTotal();
// ATM Machine Simulation
var ATM = /** @class */ (function () {
    function ATM() {
    }
    return ATM;
}());
var UserATM = /** @class */ (function (_super) {
    __extends(UserATM, _super);
    function UserATM() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.balance = 0;
        return _this;
    }
    UserATM.prototype.withdraw = function (amount) {
        if (amount > this.balance) {
            console.log("Insufficient balance!");
        }
        else {
            this.balance -= amount;
            console.log("Withdrawn \u20B9".concat(amount, ". New balance: \u20B9").concat(this.balance));
        }
    };
    UserATM.prototype.deposit = function (amount) {
        this.balance += amount;
        console.log("Deposited \u20B9".concat(amount, ". New balance: \u20B9").concat(this.balance));
    };
    UserATM.prototype.checkBalance = function () {
        console.log("Current balance: \u20B9".concat(this.balance));
    };
    return UserATM;
}(ATM));
// Simulate ATM Menu
var atm = new UserATM();
var choice = 1;
while (true) {
    console.log("\n1. Deposit  2. Withdraw  3. Check Balance  4. Exit");
    switch (choice) {
        case 1:
            atm.deposit(5000);
            choice = 2;
            break;
        case 2:
            atm.withdraw(2000);
            choice = 3;
            break;
        case 3:
            atm.checkBalance();
            choice = 4;
            break;
        case 4:
            console.log("Exiting ATM...");
            break;
    }
    if (choice === 4)
        break;
}
