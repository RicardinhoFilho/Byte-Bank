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
        public static void LidandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))//Definindo que vamos abrir este arquivo)
            {

                var buffer = new byte[1024]; //o máximo que lemos por vez é 1kb por vez, melhor do que ler todo o arquivo de uma só vez, desta forma ficamos enchendo nosso buffer e reutilizando. Desta forma conseguimos ler qualquer arquivo

                var numeroDeBytesLidos = -1;//Quando o aqrquivo é terminado de ler, nos retorna o numero 0, para isso criamos essa variavel para nos ajudar a ler o arquivo por completo 


                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);//quando chegar ao final do arquivo o método Read nos retorna o valor zero, e o nosso looping termina quando numeroDeBytesLidos for igual a zero
                    Console.WriteLine($"Número de Bytes Lidos: {numeroDeBytesLidos}");
                    if (numeroDeBytesLidos != 0)
                    {
                        EscreverBuffer(buffer, numeroDeBytesLidos);

                    }

                }

                fluxoDoArquivo.Close();

            }





            Console.ReadLine();

        }

        static void EscreverBuffer(byte[] buffer, int numeroDeBytesLidos)
        {

            var utf8 = new UTF8Encoding();


            var texto = utf8.GetString(buffer, 0, numeroDeBytesLidos);


            Console.Write(texto);

            /* foreach (var byteAtual in buffer)
             {
                texto  = 
             }*/

        }

    }
}