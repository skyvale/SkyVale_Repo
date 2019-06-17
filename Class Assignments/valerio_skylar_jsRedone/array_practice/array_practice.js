

/* Skylar Valerio
* 05.19.19
* C# to JS - Array Practice
*/

alert("Since this assignment doesn't require any prompts, it is all done in console logs.");

// declare the two arrays
let firstArray = [34, 20, 91, 49];
let secondArray = [42, 120.30, 210.20, 32.50];

// add together the sum of the first array
let firstSum = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];

// add together the sum of the second array
let secondSum = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];

// print out the sums of both arrays
console.log("The sum of the first array is " + firstSum + "!");
console.log("The sum of the second array is " + secondSum + "!");

// find the average of the first array
let firstAvr = firstSum / 4;

// find the average of the second array
let secondAvr = secondSum / 4;

// print out the averages of both arrays
console.log("The average of the first array is " + firstAvr + "!");
console.log("The average of the second array is " + secondAvr + "!");

// create a third array that is created from the combined values of the first and second arrays
let thirdArray = [firstArray[0] + secondArray[0],
    firstArray[1] + secondArray[1],
    firstArray[2] + secondArray[2],
    firstArray[3] + secondArray[3],];

// print out each element value of the third array
console.log("The first element in the third array is " + thirdArray[0] + "!")
console.log("The second element in the third array is " + thirdArray[1] + "!")
console.log("The third element in the third array is " + thirdArray[2] + "!")
console.log("The fourth element in the third array is " + thirdArray[3] + "!")


