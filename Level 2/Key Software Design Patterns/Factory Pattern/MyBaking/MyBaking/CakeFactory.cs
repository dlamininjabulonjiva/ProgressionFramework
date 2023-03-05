using MyBaking.Type_Of_Cakes;

namespace MyBaking
{
    public class CakeFactory
    {
        public ICake CreateCake(CakeType cakeType)
        {
            switch (cakeType)
            {
                case CakeType.Chocolate:
                    return new ChocolateCake();
                case CakeType.Vanilla:
                    return new VanillaCake();
                case CakeType.Butter:
                    return new ButterCake();
                default:
                    return new ChocolateCake();
            }
        }
    }
}
