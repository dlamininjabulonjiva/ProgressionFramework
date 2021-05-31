using System;

namespace MyAnimal
{
  public class AnimalInheritance
  {
    public static void Main(string[] args)
    {
      //instantiate derived classes
      Console.WriteLine("Information on my Snake");
      var mySnake = MySnakeInformation();
      mySnake.PrintAnimalInfo();
      mySnake.Sound();

      Console.WriteLine();

      Console.WriteLine("Information on my Cat1");
      var myCat1 = MyCat1Information();
      myCat1.PrintAnimalInfo();
      myCat1.Sound();
      myCat1.Move();
      Console.WriteLine("My Cat 1 new color is: " + myCat1.Color);

      Console.WriteLine();

      Console.WriteLine("Information on my Cat2");
      var myCat2 = MyCat2Information();
      myCat2.PrintAnimalInfo();
      myCat2.Sound();
      myCat2.Move();
      Console.WriteLine("My Cat 2 new color is: " + myCat2.Color);

      Console.ReadKey();
    }

    private static Cat2 MyCat2Information()
    {
      var myCat2 = new Cat2
      {
        Name = "Tito",
        Danger = "Not dangerous at all",
        Color = "White grey",
        Cuteness = "Very Ugly"
      };
      return myCat2;
    }

    private static Cat MyCat1Information()
    {
      var myCat1 = new Cat
      {
        Name = "Roman",
        Danger = "Not dangerous at all",
        Color = "White grey",
        Cuteness = "Very Cute"
      };
      return myCat1;
    }

    private static Snake MySnakeInformation()
    {
      var mySnake = new Snake
      {
        Name = "Ana",
        Danger = "Extremely dangerous",
        Color = "Black",
        Type = "Anaconda"
      };
      return mySnake;
    }

    //base class
    public abstract class Animal
    {
      public string Name;
      public string Danger;
      public string Color;

      public void PrintAnimalInfo()
      {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Danger: " + Danger);
        Console.WriteLine("Color: " + Color);
      }

      public abstract void Sound();
    }

    //derived class
    public class Snake : Animal
    {
      public string Type;

      public override void Sound()
      {
        Console.WriteLine("Sound: Hissing and type of snake(" + Type + ")");
      }
    }

    //derived class
    public class Cat : Animal
    {
      public string Cuteness;

      public override void Sound()
      {
        Console.WriteLine("Sound: Meow and the cuteness(" + Cuteness + ")");
        //giving my cat a new color
        Color = "Black";
      } 
      
      public virtual void Move()
      {
        Console.WriteLine("Creep silently");
      }
    }
    
    //inheriting from derived class
    public class Cat2 : Cat
    {
      public override void Sound()
      {
        Console.WriteLine("Sound: Meow Meow and the cuteness(" + Cuteness + ")");
        //giving my cat a new color
        Color = "Blue";
      }

      public override void Move()
      {
        Console.WriteLine("Leaps into the air");
      }
    }
  }
}
