
// create list to display the main menu and also an empty list for the characters
var mainMenu = ["[1] Create Character", "[2] Delete Character", "[3] Display Characters"];
var characterList = [];

// CHARACTER CLASSES

class Character {
    constructor(name, health, attack, defense, speed, magic){
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.magic = magic;
    }

}

// + health, + defense, - magic, - speed
class Warrior extends Character{
    constructor(){
        super(name, 10, 10, 10, 10, 10);
        this.health = this.health + (Math.floor(Math.random() * 10));
        this.defense = this.defense + (Math.floor(Math.random() * 10));
        this.speed = this.speed - (Math.floor(Math.random() * 10));
        this.magic = this.magic - (Math.floor(Math.random() * 10));

    }
}


// + defense, + magic, - attack, - health
class Mage extends Character{
    constructor(){
        super(name, 10, 10, 10, 10, 10);
        this.defense = this.defense + (Math.floor(Math.random() * 10));
        this.magic = this.magic + (Math.floor(Math.random() * 10));
        this.attack = this.attack - (Math.floor(Math.random() * 10));
        this.health = this.health - (Math.floor(Math.random() * 10));
    }
}

// + magic, + speed, - attack, - defense
class Cleric extends Character{
    constructor(){
        super(name, 10, 10, 10, 10, 10);
        this.magic = this.magic + (Math.floor(Math.random() * 10));
        this.speed = this.speed + (Math.floor(Math.random() * 10));
        this.attack = this.attack - (Math.floor(Math.random() * 10));
        this.defense = this.defense - (Math.floor(Math.random() * 10));
    }
}

// + attack, + speed, - health, - defense
class Rogue extends Character{
    constructor(){
        super(name, 10, 10, 10, 10, 10);
        this.speed = this.speed + (Math.floor(Math.random() * 10));
        this.attack = this.attack + (Math.floor(Math.random() * 10));
        this.health = this.health - (Math.floor(Math.random() * 10));
        this.magic = this.magic - (Math.floor(Math.random() * 10));
    }
}

// THE CODE

// show the main menu
Selection();

// shows the main menu and allows user to make a selection
function Selection(){

    // display main menu options from list
    for (i= 0; i < mainMenu.length; i++){
        console.log(mainMenu[i]);
    }

    // get user input
    var menuSelection = prompt("\nPlease make a selection...");

    // validate user input
    while (menuSelection === ""){
        menuSelection = prompt("\nPlease make a selection...");
    }

    // determine which menu option the user chose and navigate to appropriate function
    switch (menuSelection.toLowerCase()){

        case "1":
        case "create character":
        case "create": {
            Create();

        }break;

        case "2":
        case "delete character":
        case "delete": {
            Delete();

        }break;

        case "3":
        case "display characters":
        case "display": {
            Display();

        }break;

        default:{
            console.log("\nPlease make a selection from the menu!");
            Selection();

        }break;

    }

}

// create a new character
function Create(){

    console.clear();

    // get user input for character name
    var inputName = prompt("What is your character's name?");

    // validate the user input
    while (inputName === ""){
        console.log("\nPlease don't leave this blank!\n")
        inputName = prompt("What is your character's name?");
    }

    console.clear();

    var charaTypeMenu = ["[1] Warrior", "[2] Mage", "[3] Cleric", "[4] Rogue"];
    for (i = 0; i < charaTypeMenu.length; i++){
        console.log(charaTypeMenu[i]);
    }

    var charaTypeInput = prompt("Please choose a class for your character!");

    while (charaTypeInput === ""){
        console.log("\nPlease don't leave this blank!\n")
        prompt("What is your character's name?");
    }

    switch(charaTypeInput.toLowerCase()){

        case "1":
        case "warrior": {

            var newWarrior = new Warrior();
            var warriorStorage = [inputName, newWarrior.health, newWarrior.attack, newWarrior.defense, newWarrior.speed, newWarrior.magic];

            if (localStorage.getItem(inputName) === null) {
                localStorage.setItem(inputName, warriorStorage);
            }
            else{
                console.log("That character already exists! Please choose a different name next time.")
                Selection();
            }

            console.log(`${inputName} has been created!\n`);
            Selection();


        }break;
        case "2":
        case "mage": {

            var newMage = new Mage();
            var mageStorage = [inputName, newMage.health, newMage.attack, newMage.defense, newMage.speed, newMage.magic];

            if (localStorage.getItem(inputName) === null) {
                localStorage.setItem(inputName, mageStorage);
            }
            else{
                console.log("That character already exists! Please choose a different name next time.")
                Selection();
            }

            console.log(`${inputName} has been created!\n`);
            Selection();

        }break;
        case "3":
        case "cleric": {

            var newCleric = new Cleric();
            var clericStorage = [inputName, newCleric.health, newCleric.attack, newCleric.defense, newCleric.speed, newCleric.magic];

            if (localStorage.getItem(inputName) === null) {
                localStorage.setItem(inputName, clericStorage);
            }
            else{
                console.log("That character already exists! Please choose a different name next time.")
                Selection();
            }

            console.log(`${inputName} has been created!\n`);
            Selection();

        }break;
        case "4":
        case "rogue": {

            var newRogue = new Rogue();
            var rogueStorage = [inputName, newRogue.health, newRogue.attack, newRogue.defense, newRogue.speed, newRogue.magic];

            if (localStorage.getItem(inputName) === null) {
                localStorage.setItem(inputName, rogueStorage);
            }
            else{
                console.log("That character already exists! Please choose a different name next time.")
                Selection();
            }

            console.log(`${inputName} has been created!\n`);
            Selection();

        }break;

    }

}

function Delete(){

    console.clear();

    // get user input
    var chooseDelete = prompt("\nPlease select a character to delete...");

    // validate user input
    while (chooseDelete === ""){
        chooseDelete = prompt("\nPlease select a character to delete...");
    }

    if (Object.keys(localStorage).length ===  0){
        console.log("There are no characters yet!\n");
        Selection();
    }
    else{
        for (var i = 0; i < localStorage.length; i++){
            return console.log(JSON.stringify(localStorage));
        }

        if (Object.keys(localStorage) === chooseDelete){
            localStorage.remove(chooseDelete);
            console.log(`${chooseDelete} has been deleted!`);
            Selection();
        }
        else{
            console.log("Invalid character. Please choose from the list!");
            Delete();
        }
    }


}

function Display(){

    console.clear();

    if (Object.keys(localStorage).length ===  0){
        console.log("There are no characters to display yet!\n");
        Selection();
    }
    else{
        for (var i = 0; i <localStorage.length; i++){
            var key = localStorage.key(i);
            var value = localStorage.getItem(key);
            console.log(`Name: ${key}\nStats:${value}`);
        }

        console.log();
        Selection();
    }


}



