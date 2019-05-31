

// load the jSON data
function preload(){
    let characters = loadJSON("Characters.json");
}


// welcome user to the program
console.log("Welcome to the Character Creator!");
console.log("----------------\n")

// give options for the user to choose from
let menu = ["Create", "Display", "Delete"];

for (var i in menu){
    console.log(i);
}

// get user input
console.log("\nPlease make a selection...")
