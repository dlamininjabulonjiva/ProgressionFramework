using System;

namespace PolymorphismExample
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var elderDragon = new ElderDragon();
      elderDragon.Attack();

      Console.ReadKey();
    }

    public class Enemy
    {
      protected string Name;
      protected int Damage;

      public virtual void Attack()
      {
        Console.WriteLine($"{ Name } attacks, dealing { Damage }% damage!");
      }
    }

    public class ElderDragon : Enemy
    {
      public ElderDragon()
      {
        Name = "Draco";
        Damage = 95;
      }

      public override void Attack()
      {
        base.Attack();
        Console.WriteLine("Draco attacks and kills you.");
      }
    }
  }
}
