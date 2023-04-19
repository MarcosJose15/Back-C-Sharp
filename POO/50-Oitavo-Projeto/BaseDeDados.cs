using System;
using System.Collections Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oitavo_projeto
{
    internal class BaseDeDados
    {
        //Atributo
        private List<CadastroPessoa> listaDePessoas;

        //Metodos
        //Adicionar Pessoas
        public void AdicionarPessoa(CadastroPessoa pPessoa)
        {
            listaDePessoas.Add(pPessoa);
        }

        //Pesquisar pessoa pelo numero do documento
        public List<CadastroPessoa> PesquisaPessoaPorDoc(string pNumeroDeDocumento)
        {
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.where(x=> x.numeroDoDocumento == pNumeroDeDocumento).ToList();
            if(listaDePessoasTemp.Count > 0)
            {
                return listaDePessoasTemp;
            }
            else
            {
                return null;
            }

        //Remover Pessoa pelo numero do documento
        public List<CadastroPessoa> RemoverPessoaPorDoc (string pNumeroDoDocumento)
        {
            
            List<CadastroPessoa> listaDePessoasTemp = listaDePessoas.where(x => x.numeroDoDocumento == pNumeroDoDocumento).ToList();
            if(listaDePessoasTemp.Count > 0)
            {
                foreach(CadastroPessoa pessoa in listaDePessoasTemp)
                {
                    listaDePessoas.Remove(pessoa);
                }
                return listaDePessoasTemp;
            }
            else
            {
                return null;
            }   

        //Construtor
        public BaseDeDados()
        {
            listaDePessoas = new List<CadastroPessoa>();
        }      
    }
}