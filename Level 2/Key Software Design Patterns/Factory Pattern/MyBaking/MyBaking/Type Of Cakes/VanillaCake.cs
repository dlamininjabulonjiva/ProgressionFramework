using System;

namespace MyBaking.Type_Of_Cakes
{
    public class VanillaCake: ICake
    {
        public void Bake()
        {
            Console.WriteLine("Baking a vanilla cake...");
        }
    }
}
