using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 09, 26);
            DateTime dataHora = new DateTime(2020, 09, 26, 14, 12, 45);

            //Podemos acessar ano, mes, dia e hora, minuto, segundo individualmente
            Console.WriteLine("Ano: " + dataHora.Year);
            Console.WriteLine("Mês: " + dataHora.Month);
            Console.WriteLine("Dia: " + dataHora.Day);
            Console.WriteLine("Hora: " + dataHora.Hour);
            Console.WriteLine("Minutos: " + dataHora.Minute);
            Console.WriteLine("Segundos: " + dataHora.Second);
            Console.WriteLine("Dia da semana: " + dataHora.DayOfWeek);
            Console.WriteLine("-------------");
            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());

            //Pegando as data e a hora atual
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());
            Console.WriteLine("-------------");

            //Convertendo uma string em DateTime
            DateTime dataConvertida = Convert.ToDateTime("22/11/2030");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2030 14:10:23");
            Console.WriteLine(dataConvertida.ToString());
            Console.WriteLine(dataHoraConvertida.ToString());
            Console.WriteLine("-------------");

            //Formatando a data e a hora impressa
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/dd"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy-MM-dd"));

            Console.WriteLine(dataHoraConvertida.ToString("HH:mm:ss"));

            Console.WriteLine("-------------");

            //Operações com as variáveis DateTime
            DateTime dataHora2 = new DateTime(2020, 09, 27, 14, 5, 20);
            dataHora2 = dataHora2.AddDays(4);
            //Para o ano: dataHora2.AddYears();
            //Para o dia: dataHora2.AddMonths();
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));

            dataHora2 = dataHora2.Add(new TimeSpan(4, 1, 55, 30));
            Console.WriteLine(dataHora2.ToString("dd HH:mm:ss"));
            Console.WriteLine("-------------");

            //Subtraindo datas
            DateTime dataHora3 = new DateTime(2022, 3, 1, 14, 5, 20);
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3.ToString("HH:mm:ss"));

            dataHora3 = dataHora3.AddDays(-1);
            Console.WriteLine(dataHora3.ToString("dd/MM/yyyy"));

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
