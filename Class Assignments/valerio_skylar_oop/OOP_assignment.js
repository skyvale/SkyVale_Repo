
// create parent class (Animal) with the properties 'specie' and 'sound'
class Animal {
    // constructor function of parent class
    constructor(species, sound){
        this.species = species;
        this.sound = sound;

    }
    // create a method inside the parent class
    makeNoise(){
        console.log(`The ${this.species} let out a ${this.sound}!`);
    }

}

// create a child class
class Cat extends Animal{
    // in the constructor, add customized properties based on the parent class properties
    constructor(){
        super("cat","meow")
    }
}

// instantiate an object from the parent class (a generic animal)
var genericAnimal = new Animal("generic animal", "noise");
genericAnimal.makeNoise();

// instantiate an object from the child class (a cat)
var newCat = new Cat();
newCat.makeNoise();