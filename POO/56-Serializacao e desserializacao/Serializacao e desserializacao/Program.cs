﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace Serializacao_e_desserializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Bilu", "Boxer", "Marrom");
            Cachorro meuCachorroDesserializado;

            DataContractSerializer serializador = new DataContractSerializer(typeof(Cachorro));

            //Serialização
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter ecritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serializador.WriteObject(ecritorDeXml, meuCachorro);
            ecritorDeXml.Flush();
            string objetoSerializadoStr = construtorDeString.ToString();

            //Salvando o conteúdo do objeto num XML
            string caminhoDoMeuArquivoXml = "cachorro.xml";
            FileStream meuArquivoXml = File.Create(caminhoDoMeuArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(caminhoDoMeuArquivoXml, objetoSerializadoStr);

            //Desserialização
            string conteudoDoObjetoSerializado = File.ReadAllText(caminhoDoMeuArquivoXml);
            StringReader leitorDeStrings = new StringReader(conteudoDoObjetoSerializado);
            XmlReader leitorDeXml = XmlReader.Create(leitorDeStrings);
            meuCachorroDesserializado = (Cachorro)serializador.ReadObject(leitorDeXml);

            ecritorDeXml.Close();
            leitorDeXml.Close();

        }
    }
}
