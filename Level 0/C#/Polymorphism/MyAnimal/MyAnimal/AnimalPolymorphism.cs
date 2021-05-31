using System;
using System.Collections.Generic;
using System.Text;

namespace MyAnimal
{
  public class AnimalPolymorphism
  {
    public static void Main(string[] args)
    {
      var myAnimal = new Animal();
      var myPig = new Pig();
      var myDog = new Dog();

      myAnimal.AnimalSound();
      myPig.AnimalSound();
      myDog.AnimalSound();

      Console.ReadKey();
    }

    // Base class (parent) 
    public class Animal  
    {
      public virtual void AnimalSound()
      {
        Console.WriteLine("The animal makes a sound");
      }
    }

    // Derived class (child)
    public class Pig : Animal   
    {
      public override void AnimalSound()
      {
        Console.WriteLine("The pig says: wee wee");
      }
    }

    // Derived class (child)
    public class Dog : Animal  
    {
      public override void AnimalSound()
      {
        Console.WriteLine("The dog says: bow wow");
      }
    }
  }
}
