namespace MyBaking
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cakeFactory = new CakeFactory();

            // Create a Chocolate Cake using the Factory
            var chocolateCake = cakeFactory.CreateCake(CakeType.Chocolate);
            chocolateCake.Bake();

            // Create a Vanilla Cake using the Factory
            var vanillaCake = cakeFactory.CreateCake(CakeType.Vanilla);
            vanillaCake.Bake();

            // Create a Butter Cake using the Factory
            var butterCake = cakeFactory.CreateCake(CakeType.Butter);
            butterCake.Bake();
        }
    }
}