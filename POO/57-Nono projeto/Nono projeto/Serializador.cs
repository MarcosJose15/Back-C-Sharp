﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace Nono_projeto
{
    internal static class Serializador
    {
        static private DataContractSerializer serializador = new DataContractSerializer(typeof(BaseDeDados));

        public static void Serializa(string pCaminhoArquivoXml, BaseDeDados pBaseDeDados)
        {
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeStrings = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeStrings, xmlConfig);
            serializador.WriteObject(escritorDeXml, pBaseDeDados);
            escritorDeXml.Flush();
            string objetoSerializadoStr = construtorDeStrings.ToString();

            FileStream meuArquivoXml = File.Create(pCaminhoArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(pCaminhoArquivoXml, objetoSerializadoStr);
            escritorDeXml.Close();
        }

        public static BaseDeDados Desserializa(string pCaminhoArquivoXml)
        {
            try
            {
                if (File.Exists(pCaminhoArquivoXml))
                {
                    string conteudoDoObjetoSerializado = File.ReadAllText(pCaminhoArquivoXml);
                    StringReader leitorDeString = new StringReader(conteudoDoObjetoSerializado);
                    XmlReader leitorDeXml = XmlReader.Create(leitorDeString);
                    BaseDeDados baseDeDadosTemp = (BaseDeDados)serializador.ReadObject(leitorDeXml);
                    return baseDeDadosTemp;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
    }
}


