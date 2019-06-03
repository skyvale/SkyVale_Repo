
/* Skylar Valerio
* 05.19.19
* C# to JS - Zombie Apocalypse


* How many zombies will there be at the end of 8 days?
*  Givens:
*   - start with 1 zombie
*   - 1 zombie can bite 4 people a day
*  - 8 days total
*/

// how many zombies we currently have
let numZombies = 1;

// number of people a zombie can bite per day
let numBites = 4;

// how many days total
let days = 8;

// greet user and explain the program
alert("Oh, wow. There's a zombie attack at Full Sail..." +
    "\nLet's figure out how many zombies we'll be dealing with at the end of 8 days.");

console.log("The apocalypse starts.");

for (var i = 0; i <= days; i++){
    // zombies go bite people and create new zombies
    let newZombies = numZombies + numBites;
    // new zombies join the zombie horde
    numZombies += newZombies;
    //end of the day - report to the public
    console.log("There are " + numZombies + " by Day " + i + "!");
}

alert("After 8 days, there are " +numZombies);


alert("How many days will it take to get to one million zombies?");

// recreate variables so things are easier
let numDays = 1;
let zombieHorde = 1;

while (zombieHorde <= 1000000){
    // creating new zombies
    let bittenPeople = zombieHorde * numBites;
    // add bittenPeople to the zombieHorde
    zombieHorde =+ bittenPeople;
    // report to the public
    console.log("On day " + numDays + " there are " + zombieHorde + " zombies!");

    if (zombieHorde >= 1000000){
        // if there are a million zombies, dont go on to the next day
        break;
    }

    // if there aren't a million zombies yet, continue to next day
    numDays++;

}

alert("On day " + numDays + " there are " + zombieHorde + " zombies");

console.log("\nEnd of program.");
