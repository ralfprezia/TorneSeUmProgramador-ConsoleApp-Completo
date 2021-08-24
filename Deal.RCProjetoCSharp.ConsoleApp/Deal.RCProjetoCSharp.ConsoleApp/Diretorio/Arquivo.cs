using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    public class Arquivo
    {
        private static  string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoCaminho2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
