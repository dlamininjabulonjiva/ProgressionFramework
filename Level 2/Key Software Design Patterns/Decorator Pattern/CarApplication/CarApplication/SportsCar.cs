using System;

namespace CarApplication
{
    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", Sports Car";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 1000000;
        }
    }
}
