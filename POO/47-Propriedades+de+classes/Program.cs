using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_de_classes
{
    public class Carro
    {
        //Atributos
        private string marca;
        private double velocidade = 0;
        private bool carroLigado = false;

        //Propriedades
        //MODIFICADOR_DE_ACESSO TIPO NOME
        //{
        //    get { return ATRIBUTO; } - É utilizado para retornar o conteúdo do nosso atributo
        //    set { ATRIBUTO = value; } - É utilizado para alterar o conteúdo do nosso atributo
        //}

        public bool CarroLigado
        {
            get { return carroLigado; }
            set 
            {
                if (velocidade == 0)
                    carroLigado = value;
                else
                    return;
            }
        }

        public double Velocidade
        {
            get { return velocidade; }
            set
            {
                if (carroLigado)
                    velocidade = value;
                else
                    return;
            }
        }

        public uint NumeroDePortas
        {
            set;
            get;
        }

        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade = VelocidadeFinal;
            marca = "Fiat";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.CarroLigado = true;
            meuCarro.Velocidade = 100;
            meuCarro.CarroLigado = false;
            meuCarro.Velocidade = 0;
            meuCarro.CarroLigado = false;
            meuCarro.NumeroDePortas = 4;
        }
    }
}
