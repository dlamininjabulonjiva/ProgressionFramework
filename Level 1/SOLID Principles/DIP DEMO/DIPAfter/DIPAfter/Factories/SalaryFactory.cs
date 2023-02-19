using System;
using DIPAfter.Salaries;

namespace DIPAfter.Factories
{
    public class SalaryFactory
    {
        public SalaryFactory(){}

        public static ISalary Create(SalaryType type)
        {
            switch (type)
            {
                case SalaryType.Nett:
                    return new NetSalary();
                case SalaryType.Bonuses:
                    return new BonusSalary();
                case SalaryType.Gross:
                    return new GrossSalary();
                default:
                    return new GrossSalary();
            }
        }
    }
}
