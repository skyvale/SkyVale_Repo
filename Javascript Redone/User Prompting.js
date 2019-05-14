
/* Skylar Valerio
* 05.14.19
* C# to Javascript - User Prompting
*/


// Part One: Ask the user for their name

var userName = window.prompt("Hello! Please tell me your name.");
alert("Welcome to the program " + userName + "!");



// Part Two: Calculate area of a rectangle

alert("\nWe are going to calculate the area of a rectangle based on your measurements.");
var widthString = window.prompt("\nWhat is the width of your rectangle?");

var widthInt = parseInt(widthString, 10);

var heightString = window.prompt("\nGot it!\nYou typed in a width of "+ widthString +".\nNow, please type in the height of your rectangle.");

var heightInt = parseInt(heightString, 10);

var area = widthInt * heightInt;

alert("\nThe area of the rectangle is "+ area +"!\n\nThank you for using the rectangle calculator!");
