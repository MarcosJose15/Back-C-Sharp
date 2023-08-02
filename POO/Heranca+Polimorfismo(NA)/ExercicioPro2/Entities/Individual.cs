using System;

namespace ExercicioPro2.Entities
{
    class Individual : Person
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Calc()
        {
            if(AnualIncome < 20000.00) 
            {
                if (HealthExpenditures > 0.0)
                {
                    return AnualIncome * 0.15 - (HealthExpenditures/2);
                }

                else
                {
                    return AnualIncome * 0.15;
                }

            }

            else
            {
                if (HealthExpenditures > 0.0)
                {
                    return AnualIncome * 0.25 - (HealthExpenditures / 2);
                }

                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}
