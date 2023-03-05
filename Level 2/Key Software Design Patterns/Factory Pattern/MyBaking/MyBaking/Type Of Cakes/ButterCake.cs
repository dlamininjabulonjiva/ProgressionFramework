using System;

namespace MyBaking.Type_Of_Cakes
{
    public class ButterCake: ICake
    {
        public void Bake()
        {
            Console.WriteLine("Baking a butter cake...");
        }
    }
}
