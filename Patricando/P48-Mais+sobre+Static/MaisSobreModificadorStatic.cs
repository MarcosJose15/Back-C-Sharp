namespace Back_C_Sharp.POO.48_Mais+sobre+Static
{
    //Classe Pessoa
    public class Pessoa
    {
        //Atributos da classe Pessoa
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        //Método Imprimi Nome
        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }
        public Pessoa(string pNome)
        {
            nome = pNome
        }

    }
}