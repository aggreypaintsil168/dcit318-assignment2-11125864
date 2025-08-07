using System;
// Parent class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Child class
class Dog : Animal 
{
    public override void MakeSound() {
        Console.WriteLine("Bark");
    }
}

// Another child class
class Cat : Animal 
{
    public override void MakeSound() {
        Console.WriteLine("Meow");
    }
}

// Testing
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.MakeSound(); // Output: Some generic sound
        myDog.MakeSound();    // Output: Bark
        myCat.MakeSound();    // Output: Meow
    }
}