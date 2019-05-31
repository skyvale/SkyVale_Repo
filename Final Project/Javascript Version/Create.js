

// Name
let name = prompt("What is your character's name?");

while (name === ""){
    name = prompt("Please don't leave this blank.\nWhat is your character's name?");
}


// Gender
let gender = prompt("What is your character's gender?");

let genderList = ["Male", "Female", "Genderless", "Other"];

for (var i in genderList){
    console.log(i)
}

while (gender.toLowerCase() !== "male" || gender.toLowerCase() !== "female" || gender.toLowerCase() !== "other"){
    gender = prompt("Please choose from the option.\nWhat gender is your character?");
}


// Age
let age = prompt("How old is your character?");
while(isNaN(age) || age === ""){
    age = prompt("Please don't leave this blank.\nHow old is your character?");
}


// Eyes
let eyeColour = prompt("What colour is your character's eyes?");

let colourList = ["Brown", "Blue", "Green", "Other"];

for (var i in colourList){
    console.log(i);
}

while (eyeColour.toLowerCase() !== "brown" || eyeColour.toLowerCase() !== "blue" || eyeColour.toLowerCase() !== "green", eyeColour.toLowerCase() !== "other"){
    gender = prompt("Please choose from the option.\nWhat eye colour does your character have?");
}



// confirmation
console.log("Here is your new character!\n-----------\n");
console.log("\nName: " + name + "\nGender: " + gender + "\nAge: " + age + "\nEye Colour: " + eyeColour);


// create character object
let fileSave = require("fileSave");
let newCharacter = {
    name: name,
    gender: gender,
    age: age,
    eyeCol: eyeColour
};

// save character to json file





