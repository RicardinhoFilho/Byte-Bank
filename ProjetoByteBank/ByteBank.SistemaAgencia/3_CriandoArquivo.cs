using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;
using System.IO;//para lermos o arquivo texto precisamos desta diretiva using de input e output 

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        public static void CriarArquivo()
        {
            var caminho = "contasExportadas.txt";

            using (var fluxoDeArquivo = new FileStream(caminho,FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        public static void CriarArquivoComWriter()
        {
            var caminho = "contasExportadas.txt";
            using (var fluxoDeArquivo = new FileStream(caminho,FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo,Encoding.UTF8))
                {
                    escritor.Write("456,65465,456,Pedro Navas");
                }
            }
        }

        public static void CriarArquivoComWriterEUtilizandoMetodoFlush()
        {
            var caminho = "testeplush.txt";
            using (var fluxoDeArquivo = new FileStream(caminho, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        escritor.WriteLine($"Adicionando linha {i}");
                        escritor.Flush();//Este método adiciona elementos ao arquivo em tempo de execução
                        Console.WriteLine($"Elemento {i} adicionado, tecle enter par acontinuar");
                        Console.ReadLine();
                    }
                }
            }
        }
    }

   
}
