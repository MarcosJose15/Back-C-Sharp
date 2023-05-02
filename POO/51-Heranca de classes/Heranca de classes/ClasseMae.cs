using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_de_classes
{
    //Modificadores de acesso
    //public - todo mundo tem acesso (classes filhas e externamente)
    //private - somente a própria classe tem acesso (nem as filhas nem externamente conseguiremos acessar)
    //protected - somente poderá ser acessado pela classe filha e pela própria classe (externamente não poderá ser acessado)
    internal class ClasseMae
    {
        public string atributoDaMae = "Atributo da mãe";
        public string PropriedadeDaMae
        {
            set;
            get;
        }
        public void MetodoDaClasseMae()
        {
            Console.WriteLine("Método da classe mae");
        }
        public ClasseMae(string pPropriedadeDaMae)
        {
            PropriedadeDaMae = pPropriedadeDaMae;
        }
    }
}
