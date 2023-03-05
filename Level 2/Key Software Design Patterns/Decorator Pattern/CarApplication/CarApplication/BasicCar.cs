using System;

namespace CarApplication
{
    public class BasicCar : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }

        public double GetCost()
        {
            return 150000;
        }
    }
}
