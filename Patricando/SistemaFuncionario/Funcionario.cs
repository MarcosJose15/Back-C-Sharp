using System;
using System.Globalization;

namespace SistemaFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double SalarioLiquido = 0;
        public double Imposto;
        public double porcentagem;



        public void CalcularSalarioLiquido()
        {
            SalarioLiquido = SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            //SalarioLiquido = SalarioLiquido + (SalarioBruto * porcentagem);

            double aumento = SalarioBruto * (porcentagem / 100.0);
            SalarioBruto += aumento;

            CalcularSalarioLiquido();
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}