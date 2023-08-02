using System;

namespace ExercicioPro2.Entities
{
    class Company : Person
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Calc()
        {
            if (NumberEmployees > 10) 
            {
                return AnualIncome * 0.14;
            }

            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
