

/* Skylar Valerio
* 05.19.19
* C# to Javascript - Coffee Run
*/

// This program will keep track of the user's coffee orders by using arrays

alert("Hello! This program will help you keep track of your coffee orders.");

// create the array that holds the different coffees
let coffeeArray = ['coffee','cappuccino','latte','decaf','decaf','cappuccino','cappuccino','coffee','decaf'];

// declare variables to use for counting
let numberCoffee = 0;
let numberLatte = 0;
let numberCappu = 0;
let numberDecaf = 0;

// loop through each array to determine how many of each drink there is

for (var i = 0; i < coffeeArray.length; i++){
    if (coffeeArray[i] === "coffee"){
        // if element is present, +1 to the count
        numberCoffee++;
    }
    else if (coffeeArray[i] === "cappuccino"){
        numberCappu++;
    }
    else if (coffeeArray[i] === "latte"){
        numberLatte++;
    }
    else if (coffeeArray[i] === "decaf"){
        numberDecaf++;
    }
}

// alert the user the number of each element
alert("Order " + numberCoffee + " number of Coffees!" +
    "\nOrder " + numberCappu + " number of Cappucinos!" +
    "\nOrder " + numberLatte + " number of Lattes!" +
    "\nOrder " + numberDecaf + " number of Decafs!");

console.log("Order " + numberCoffee + " number of Coffees!" +
    "\nOrder " + numberCappu + " number of Cappuccinos!" +
    "\nOrder " + numberLatte + " number of Lattes!" +
    "\nOrder " + numberDecaf + " number of Decafs!");


// thank user for using program
alert("Thank you for using this coffee program! Good-bye!");

console.log("\nEnd of program.");