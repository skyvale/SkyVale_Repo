

/* Skylar Valerio
* 05.19.19
* C# to Javascript - MadLibs
*/

alert("Welcome to the MadLibs!\nPlease answer the following questions:");

let name = prompt("Type a NAME");
while (name === ""){
    name = prompt("Please don't leave this blank!\nType a NAME");
}

let adjective = prompt("Type an ADJECTIVE");
while (adjective === ""){
    adjective = prompt("Please don't leave this blank!\nType an ADJECTIVE");
}

let animal = prompt("Type an ANIMAL");
while (animal === ""){
    animal = prompt("Please don't leave this blank!\nType an ANIMAL");
}

let foodItem = prompt("Type a FOOD ITEM");
while (foodItem === ""){
    foodItem = prompt("Please don't leave this blank!\nType a FOOD ITEM");
}

let yearNumber = Number(prompt("Type a YEAR NUMBER"));
while (yearNumber === ""){
    yearNumber = Number(prompt("Please don't leave this blank!\n Type a YEAR NUMBER"));
}

let cost = Number(prompt("Type a COST"));
while (cost === ""){
    cost = Number(prompt("Please don't leave this blank!\nType a COST"));
}

let randomNum = Number(prompt("Type a RANDOM NUMBER"));
while (randomNum === ""){
    randomNum = Number(prompt("Please don't leave this blank!\n Type a RANDOM NUMBER"));
}


// put the user input into the madlibs story
alert("\nYou were walking through the woods one day when you saw them-- " + name +
    ".\nThey looked "+ adjective +
    " and when they turned around, you saw they were devouring " + foodItem +
    ".\nBehind them, they had a pile of " + randomNum +
    " more " + foodItem + ".\nIt probably cost them at least $" + cost +
    ", especially since it was " + yearNumber + ".\n");

console.log("\nYou were walking through the woods one day when you saw them-- " + name +
    ".\nThey looked "+ adjective +
    " and when they turned around, you saw they were devouring " + foodItem +
    ".\nBehind them, they had a pile of " + randomNum +
    " more " + foodItem + ".\nIt probably cost them at least $" + cost +
    ", especially since it was " + yearNumber + ".\n");





