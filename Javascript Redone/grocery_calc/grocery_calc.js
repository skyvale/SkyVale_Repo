

/* Skylar Valerio
* 05.19.19
* C# to JS - Grocery Calculator
*/

// this program calculates how much the user will spend on groceries, including tax
alert("This is your personal grocery calculator!");

// get the apple information
let applePrice = Number(prompt("What is the price of an apple?"));
while(isNaN(applePrice) || applePrice === ""){
    applePrice = prompt("Please don't leave this blank!\nWhat is the price of an apple?");
}

let appleAmt = Number(prompt("How many apples did you buy?"));
while (isNaN(appleAmt) || appleAmt === ""){
    appleAmt = prompt("Please don't leave this blank!\nHow many apples did you buy?");
}

let appleTotal = applePrice * appleAmt;

// get the steak information
let steakPrice = Number(prompt("What is the price of a steak?"));
while (isNaN(steakPrice) || steakPrice === ""){
    steakPrice = Number(prompt("Please don't leave this blank!\nWhat is the price of a steak?"));
}

let steakAmt = Number(prompt("How many steaks did you buy?"));
while (isNaN(steakAmt) || steakAmt === ""){
    steakAmt = Number(prompt("Please don't leave this blank!\nHow many steaks did you buy?"));
}

let steakTotal = steakPrice * steakAmt;

// get the ice cream info
let icecreamPrice = Number(prompt("What is the price of an ice cream?"));
while (isNaN(icecreamPrice) || icecreamPrice === ""){
    icecreamPrice = Number(prompt("Please don't leave this blank!\nWhat is the price of an ice cream?"));
}

let icecreamAmt = Number(prompt("How many ice creams did you buy?"));
while (isNaN(icecreamAmt) || icecreamAmt === ""){
    icecreamAmt = Number(prompt("Please don't leave this blank!\nHow many ice creams did you buy?"));
}

let icecreamTotal = icecreamPrice * icecreamAmt;

// ask the user for the sales tax in their area
let salesTax = Number.parseFloat(prompt("What is the sales tax in your area?"));

// convert tax to the actual tax
let actualTax = salesTax * 0.01;

// do the maths
let totalPrice = applePrice + steakPrice + icecreamPrice;
let taxAmt = totalPrice * actualTax;
let finalAmount = totalPrice + taxAmt;

// alert the user to each price and the final total price with/without tax
alert("The price for " + appleAmt + " apples is $" + appleTotal +
    ".\nThe price for " + steakAmt + " steaks is $" + steakTotal +
    ".\nThe price for " + icecreamAmt + " icecreams is $" + icecreamTotal +
    ".\nThe total price without tax is $" + totalPrice +
    "!\nThe total price with tax included is $" + finalAmount + "!");

console.log("The price for " + appleAmt + " apples is $" + appleTotal +
    ".\nThe price for " + steakAmt + " steaks is $" + steakTotal +
    ".\nThe price for " + icecreamAmt + " icecreams is $" + icecreamTotal +
    ".\nThe total price without tax is $" + totalPrice +
    "!\nThe total price with tax included is $" + finalAmount + "!");