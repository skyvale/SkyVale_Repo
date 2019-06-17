

/* Skylar Valerio
* 05.14.19
* C# to Javascript - User Prompting
*/


// Part One: Ask the user for their name
// ------------------------

let userName = prompt("Hello! What is your name?");

// validate the username
while (userName === ""){
    userName = prompt("Please don't leave this blank!\nWhat is your name?");

}

alert("\nWelcome to the program " + userName + "!");



// Part Two: Calculate area of a rectangle
// ------------------------

alert("\nWe are going to calculate the area of a rectangle based on your measurements.");

// prompt and validate the rectangle dimensions
let widthString = Number(prompt("\nWhat is the width of your rectangle?"));
let heightString = Number(prompt("\nGot it!\nYou typed in a width of " + widthString + "." +
                          "\nNow, please type in the height of your rectangle."));


console.log("Rectangle height = " + heightString + " and the width is " + widthString);

// parse the inputs
let widthInt = parseInt(widthString, 10);
let heightInt = parseInt(heightString, 10);

// calculate rectangle area
let area = widthInt * heightInt;

alert("\nThe area of the rectangle is "+ area +"!\n\nThank you for using the rectangle calculator!");

console.log("The area of the rectangle is " + area);
console.log("\nEnd of program.");