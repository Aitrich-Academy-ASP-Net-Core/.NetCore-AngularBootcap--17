import * as readline from "readline";
import { Cartitem } from "./CartItem";  
const rl= readline.createInterface ({

input:process.stdin,
output:process.stdout

});

let cart:Cartitem[]=[]
let running=true;



function mainMenu() {
    console.log(`\n======== SUPERMARKET MENU =========`);
    console.log("1. Add Item to Cart");
    console.log("2. View Cart");
    console.log("3. Remove Item");
    console.log("4. Checkout");
    console.log("5. Exit");

    rl.question("Enter your choice: ", (choice) => {
        switch (choice) {

           
            case "1":
                rl.question("Enter item name: ", (name) => {
                    rl.question("Enter price: ", (p) => {
                        rl.question("Enter quantity: ", (q) => {

                            let price = Number(p);
                            let quantity = Number(q);

                            if (price <= 0 || quantity <= 0) {
                                console.log(" Price and Quantity must be positive!");
                                return mainMenu();
                            }

                            let total = price * quantity;

                            let item = new Cartitem(name, price, quantity, total);
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
                } else {
                    let bill = 0;
                    console.log("\n===== CART ITEMS =====");
                    for (let i = 0; i < cart.length; i++) {
                        console.log(`${i + 1}. ${cart[i].name} | Price: ${cart[i].price} | Qty: ${cart[i].quantity} | Total: ${cart[i].total}`);
                        bill += cart[i].total;
                    }
                    console.log(`Total Bill: ₹${bill}`);
                }
                mainMenu();
                break;






            // REMOVE ITEM
            case "3":
                rl.question("Enter item name to remove: ", (name) => {
                    let index = cart.findIndex(c => c.name.toLowerCase() === name.toLowerCase());

                    if (index === -1) {
                        console.log(" Item not found!");
                    } else {
                        cart.splice(index, 1);
                        console.log("Item removed!");
                    }
                    mainMenu();
                });
                break;





            //  CHECKOUT 
            case "4":
                let total = 0;

                cart.forEach(c => total += c.total);

                console.log("\n===== CHECKOUT =====");
                if (cart.length===0){

                    console.log("cart is empty");
                    break;
                }
                console.log("Total Amount:", total);

                if (total > 500) {
                    let discount = total * 0.10;
                    total -= discount;
                    console.log("10% Discount Applied:", discount);
                }

                console.log("Final Payable Amount:", total);

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






