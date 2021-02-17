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
       public static void LendoArquivoTextoEColetandoContaCorrenteECliente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDeArquivo, Encoding.UTF8))
                {

                    //var linha = leitor.ReadLine();//ReadLine nos retorna a primeira linha
                    //var linha = leitor.ReadToEnd();//Este método 'Read to end'lê todas as linhas e retorna em uma string gigante 

                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        //Console.WriteLine(linha);
                        var contaCorrente = ConverterStringParaContaCorrente(linha);
                        var cliente = ConverteStringParaCliente(linha);

                        Console.WriteLine($"Conta Corrente:titular[{contaCorrente.Titular.Nome}],numero[{contaCorrente.Numero}],ag[{contaCorrente.Agencia}], saldo[{contaCorrente.Saldo}]");
                    }

                }
            }

            Console.ReadLine();
        }

        static Cliente ConverteStringParaCliente(string linha)
        {
            var campos = linha.Split(',');
            var titular = campos[3];

            var cliente = new Cliente("11122233396", titular);

            return cliente;
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');//Quebra uma string pelo caractere passado como parâmetor, neste caso estamos quebrando nossa string pelo espaço

            //Como split nos retorna um vetor de strings, iremos armazenar estes dados dentro de variaveis
            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2]);
            //var titular = campos[3];
            //Acima estamos transformando nossas strings em inteiros, saldo em double
            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = ConverteStringParaCliente(linha);

            return resultado;
        }
    }
}