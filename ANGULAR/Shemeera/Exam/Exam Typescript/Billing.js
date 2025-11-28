"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var CartItem_1 = require("./CartItem");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var cart = [];
var running = true;
function mainMenu() {
    console.log("\n======== SUPERMARKET MENU =========");
    console.log("1. Add Item to Cart");
    console.log("2. View Cart");
    console.log("3. Remove Item");
    console.log("4. Checkout");
    console.log("5. Exit");
    rl.question("Enter your choice: ", function (choice) {
        switch (choice) {
            case "1":
                rl.question("Enter item name: ", function (name) {
                    rl.question("Enter price: ", function (p) {
                        rl.question("Enter quantity: ", function (q) {
                            var price = Number(p);
                            var quantity = Number(q);
                            if (price <= 0 || quantity <= 0) {
                                console.log(" Price and Quantity must be positive!");
                                return mainMenu();
                            }
                            var total = price * quantity;
                            var item = new CartItem_1.Cartitem(name, price, quantity, total);
                            cart.push(item);
                            console.log(" Item Added!");
                            mainMenu();
                        });
                    });
                });
                break;
            //                 case"2":
            //                 if (cart.length===0){
            //                     console.log("cart is empty")
            //                 }else
            //                 {
            //                     let bill=0;
            //                     console.log("==========CART ITEMS==========");
            //                 for(let i=0;i<cart.length;i++){
            //                     console.log(`${i+1}.${cart[i].name}| Price: ${cart[i].price}| Qty: ${cart[i].quantity} | Total: ${cart[i].total} `);
            //                 bill+=cart[i].total;
            //                 console.log(`Total bill: $ {bill}`);
            //                 }
            //             }
            // mainMenu();
            // break;
            case "2":
                if (cart.length === 0) {
                    console.log("Cart is empty");
                }
                else {
                    var bill = 0;
                    console.log("\n===== CART ITEMS =====");
                    for (var i = 0; i < cart.length; i++) {
                        console.log("".concat(i + 1, ". ").concat(cart[i].name, " | Price: ").concat(cart[i].price, " | Qty: ").concat(cart[i].quantity, " | Total: ").concat(cart[i].total));
                        bill += cart[i].total;
                    }
                    console.log("Total Bill: \u20B9".concat(bill));
                }
                mainMenu();
                break;
            // REMOVE ITEM
            case "3":
                rl.question("Enter item name to remove: ", function (name) {
                    var index = cart.findIndex(function (c) { return c.name.toLowerCase() === name.toLowerCase(); });
                    if (index === -1) {
                        console.log(" Item not found!");
                    }
                    else {
                        cart.splice(index, 1);
                        console.log("Item removed!");
                    }
                    mainMenu();
                });
                break;
            //  CHECKOUT 
            case "4":
                var total_1 = 0;
                cart.forEach(function (c) { return total_1 += c.total; });
                console.log("\n===== CHECKOUT =====");
                if (cart.length === 0) {
                    console.log("cart is empty");
                    break;
                }
                console.log("Total Amount:", total_1);
                if (total_1 > 500) {
                    var discount = total_1 * 0.10;
                    total_1 -= discount;
                    console.log("10% Discount Applied:", discount);
                }
                console.log("Final Payable Amount:", total_1);
                // running = false;
                // rl.close();
                mainMenu();
                break;
            //  EXIT 
            case "5":
                console.log("Exiting...");
                running = false;
                rl.close();
                break;
            default:
                console.log("Invalid Choice!");
                mainMenu();
        }
    });
}
while (running) {
    mainMenu();
    break;
}
