using System;

namespace MyBaking.Type_Of_Cakes
{
    public class ChocolateCake: ICake
    {
        public void Bake()
        {
            Console.WriteLine("Baking a chocolate cake...");
        }
    }
}
