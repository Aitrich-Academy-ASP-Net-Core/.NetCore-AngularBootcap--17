import * as readline from 'readline';
//import { Item } from './Item';
interface Item{
    name:string;
    price:number;
    quantity:number;
    
    total:number;

}

import { Console } from 'console';
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
let cartitem:Item[]=[];
let exitProgram = false;

function showMenu() {
    console.log("----- SUPERMARKET BILLING SYSTEM -----");

    console.log("1. Add Item to Cart");

    console.log("2. View Cart");
    console.log("3. Remove Item");
    console.log("4. Checkout");
    console.log("5. Exit");

    rl.question("Enter your choice: ", (choice:string) => {
        handle(choice);
    });
}
function handle(choice: string) {
    switch (choice) {
        case "1":
            addItem();
            break;

        case "2":
            viewCart();
            showMenu();
            break;

        case "3":
            removeItem();
            break;

        case "4":
            checkout();
            break;

        case "5":
            console.log("Exiting...");
            rl.close();
            exitProgram = true;
            break;

        default:
            console.log("Invalid choice!");
            showMenu();
    }
}
function addItem() {
    rl.question("Enter item name: ", (name) => {
        rl.question("Enter price: ", (inputprice) => {
            rl.question("Enter quantity: ", (inputquantity) => {

                const price = Number(inputprice);
                const quantity = Number(inputquantity);

           

                const total = price * quantity;

                cartitem.push({ name, price, quantity, total });
                console.log("Item added successfully!");

                showMenu();
            });
        });
    });
}
function viewCart() {
    if (cartitem.length === 0) {
        console.log("Cart is empty.");
        return;
    }

    console.log("----- CART ITEMS -----");

    cartitem.forEach((item) => {
        console.log(`ItemName:${item.name} - Price:${item.price}-Quantity:${item.quantity}  -  Rupees:${item.total}`);
    });
}





function removeItem() {
    rl.question("\nEnter item name to remove: ", (name) => {

        const itemToRemove = cartitem.find(
        (item) => item.name === name
        );

        if (itemToRemove) {
         const newList = [];
        for (let item of cartitem) {
            if (item !== itemToRemove) {
                    newList.push(item);
                }
            }
            cartitem = newList;
            console.log("Item removed successfully.");
        } else
         {
            console.log("Item not found.");
        }

        showMenu();
    });
}
function checkout(){
    if (cartitem.length === 0) {
        console.log("Cart is empty.");
        showMenu();
        return;
    }
    let total=0;
    for(let item of cartitem){
        console.log(`${item.name}-${item.total}`);
        total+=item.total;
    }
    console.log(`Total=${total}`);
      rl.close();
    exitProgram = true;
}



while (!exitProgram) {
    showMenu();
    break;  
}





/*Machine Test Question: Supermarket Billing System
Create a menu-driven Supermarket Billing System in TypeScript using loops and conditional statements.
Your program must repeatedly display the following menu until the user chooses Exit:
1. Add Item to Cart
2. View Cart
3. Remove Item
4. Checkout
5. Exit

Your program must do the following:
Use a while loop to keep the menu running.

Use a switch-case to handle the menu choices.

When the user selects Add Item to Cart:

Ask for item name, price, and quantity.

Validate that price and quantity are positive numbers (use if conditions).

Calculate total amount for the item.

Store each item as an object inside an array, e.g.:
{ name: "Apple", price: 20, quantity: 3, total: 60 }


When the user selects View Cart:

Use a for loop to display each item in the cart.

Show the total bill amount at the bottom.

If cart is empty, show “Cart is empty”.


When the user selects Remove Item:

Ask for the item name.

Use conditional statements to check if the item exists.

If found → remove it from the array.

If not → show “Item not found”.


When the user selects Checkout:

Display all cart items and the final total amount.

If total amount is more than ₹500, apply a 10% discount.

Show the final payable amount.

Clear the cart and stop the program.


When the user selects Exit:

End the program immediately.*/