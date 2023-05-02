using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_de_classes
{
    internal class ClasseFilha: ClasseMae
    {
        public string atributoDaFilha = "Atributo da filha";
        public string PropriedadeDaFilha
        {
            set;
            get;
        }
        public void MetodoDaClasseFilha()
        {
            Console.WriteLine("Método da classe filha");
        }
        public ClasseFilha():base("akljghdkjHAGSDKjhgdkhA")
        {
            PropriedadeDaFilha = "Propriedade da filha";
        }
    }
}
