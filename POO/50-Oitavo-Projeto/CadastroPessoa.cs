using System;
using System.Collections Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oitavo_projeto
{
	internal class CadastroPessoa
	{
		//Atributos
		private string nome;
		private string numeroDoDocumento;
		private DateTime dataDeNascimento;
		private string nomeDaRua;
		private UInt32 numeroDaCasa;

		//Propriedades
		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public string NumeroDoDocumento
		{
			get { return numeroDoDocumento; }
			set { numeroDoDocumento = value;}
		}

		public DateTime DataDeNascimento
		{
			get { return dataDeNascimento}
			set { dataDeNascimento = value; }
		}

		public string NomeDaRua
		{
			get { return nomeDaRua; }
			set { nomeDaRua = value; }
		}

		public UInt32 NumeroDaCasa
		{
			get { return numeroDaCasa; }
			set { numeroDaCasa = value; }
		}
		
		//Construtor
		public CadastroPessoa(string pNome, string pNumeroDoDocumento, DateTime pDataDeNascimento, string pNomeDaRua, UInt32 pNumeroDaCasa)
		{
			pNome = nome;
			pNumeroDaCasa = numeroDaCasa;
			pDataDeNascimento = dataDeNascimento;
			pNomeDaRua = nomeDaRua;
			pNumeroDaCasa = numeroDaCasa;

		}
	}
}
