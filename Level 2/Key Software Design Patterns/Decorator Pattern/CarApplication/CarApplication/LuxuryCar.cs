using System;

namespace CarApplication
{
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", Luxury Car";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 600000;
        }
    }
}
