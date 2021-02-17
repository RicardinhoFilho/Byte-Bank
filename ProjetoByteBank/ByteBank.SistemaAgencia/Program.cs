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
        static void Main(string[] args)
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");




            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine($"Arquivo possui {linhas.Length} linhas!");

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();







            Console.WriteLine("Digite o seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);


            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();

        }
    }
}










/* var listaContaCorrente = new List<ContaCorrente>()
            {
                new ContaCorrente(886,886173),
                new ContaCorrente(887,886173),
                new ContaCorrente(887,886173),
                new ContaCorrente(881,886173),
                null,
                new ContaCorrente(883,886173),
                new ContaCorrente(883,886173)
            };

            var listaContaCorrenteSemNulos = new List<ContaCorrente>();

            foreach (var conta in listaContaCorrente)
            {
                if (conta != null)
                {
                    listaContaCorrenteSemNulos.Add(conta);
                }
            }

            listaContaCorrenteSemNulos.Sort();

            foreach (var conta in listaContaCorrenteSemNulos)
            {
                Console.WriteLine($"Ag.{conta.Agencia}; Conta.{conta.Numero}");
            }

            Console.ReadLine();

            IOrderedEnumerable < ContaCorrente > ordenacaoPorAgencia = listaContaCorrenteSemNulos.OrderBy(ContaCorrente => ContaCorrente.Agencia);

            foreach (var conta in ordenacaoPorAgencia)
            {
                Console.WriteLine($"Ag.{conta.Agencia}; Conta.{conta.Numero}");
            }*/

/*var listaContaCorrente = new List<ContaCorrente>()
            {
                new ContaCorrente(886,886173),
                new ContaCorrente(887,886173),
                new ContaCorrente(887,886173),
                new ContaCorrente(881,886173),
                new ContaCorrente(883,886173),
                new ContaCorrente(883,886173)
            };

            Console.WriteLine("Antes da ordenação por agência: ");

            foreach (var conta in listaContaCorrente)
            {
                Console.WriteLine($"Ag.{conta.Agencia}, Num.{conta.Numero}");
            }

            Console.ReadLine();
            
            listaContaCorrente.Sort(new ComparerContaCorrentePorAgencia());

            Console.WriteLine("Após ordenação por agência: ");

            foreach (var conta in listaContaCorrente)
            {
                Console.WriteLine($"Ag.{conta.Agencia}, Num.{conta.Numero}");
            }*/

/*ListaGenerica<int> listaDeIdades = new ListaGenerica<int>();

            listaDeIdades.AdicionarVarios(30, 45, 60, 55, 48, 22);
            listaDeIdades.EscreverListaNaTela();
            int somaDeIdades = 0;
            double mediaDeIdades;
            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                somaDeIdades += listaDeIdades[i];
            }
            mediaDeIdades = somaDeIdades / listaDeIdades.Tamanho;
            Console.WriteLine($"Média de Idades: {mediaDeIdades}");
            Console.ReadKey();

            ContaCorrente conta1 = new ContaCorrente(885,886125);
            conta1.Saldo = 300;
            ContaCorrente conta2 = new ContaCorrente(885, 886128);
            conta2.Saldo = 600;
            ContaCorrente conta3 = new ContaCorrente(885, 886120);
            conta3.Saldo = 130;
            ContaCorrente conta4 = new ContaCorrente(885, 886124);
            conta4.Saldo = 200;
            ContaCorrente conta5 = new ContaCorrente(885, 886140);
            conta5.Saldo = 1300;

            ListaGenerica<ContaCorrente> listaContaCorrente = new ListaGenerica<ContaCorrente>();

            listaContaCorrente.AdicionarVarios(conta1, conta2, conta3, conta4, conta5);
            listaContaCorrente.EscreverListaNaTela();

            double somaSaldo = 0;
            double mediaSaldo;

            for (int i = 0; i < listaContaCorrente.Tamanho; i++)
            {
                somaSaldo += (listaContaCorrente[i].Saldo);
            }
            mediaSaldo = somaSaldo / listaContaCorrente.Tamanho;

            Console.WriteLine($"Média de saldo : {mediaSaldo}");

            Console.ReadKey();*/

/* ListaDeObjects listaIdades = new ListaDeObjects();

            
            listaIdades.Adicionar(25);
            listaIdades.Adicionar(22);
            listaIdades.Adicionar(23);
            listaIdades.Adicionar(13);

            listaIdades.EscreverListaNaTela();
            Console.ReadLine();


            ListaDeObjects lista = new ListaDeObjects();
            lista.Adicionar(new ContaCorrente(886, 886125));
            lista.Adicionar(new ContaCorrente(886, 886126));

            Console.ReadLine();*/

/* ContaCorrente contaGui = new ContaCorrente(111, 111);
            ListaContaCorrente lista = new ListaContaCorrente();
            /*lista.Adicionar(contaGui);
            lista.Adicionar(new ContaCorrente(886, 886125));
            lista.Adicionar(new ContaCorrente(886, 886126));///



lista.AdicionarVarios(contaGui, new ContaCorrente(886, 886125),
    new ContaCorrente(886, 886128));





Console.WriteLine($"Tamanho da lista = {lista.Tamanho}");
Console.WriteLine($"Buscando elemento 0 -> Agência: {lista[2].Agencia} Conta: {lista[2].Numero}");
Console.WriteLine(lista[1]);




Console.ReadLine();
*/

/*Console.WriteLine("Antes da remoção!");
            lista.EscreverListaNaTela();

            lista.Remover(contaGui);
            
            Console.WriteLine("Depois da remoção!");
            lista.EscreverListaNaTela();*/



/*   ContaCorrente[] conta = new ContaCorrente[]
            {
                new ContaCorrente(886,117886),
                new ContaCorrente(886,182886),
                new ContaCorrente(886,446886),
            };

            for (int i = 0; i < conta.Length; i++)
            {

                Console.WriteLine($"Agência Conta[{i}] = {conta[i].Agencia}");
                Console.WriteLine($"Número De Conta[{i}] = {conta[i].Numero} ");

            }
*/




/*
 Cliente cliente1 = new Cliente("11122233396", "Carlos");
            Cliente cliente2 = new Cliente("11122233396", "Rodrigo");

            if(cliente1.Equals(cliente2))
            {
                Console.WriteLine("Os objetos possuem o mesmo identificador");
            }

            ContaCorrente conta1 = new ContaCorrente(886, 117886);
            ContaCorrente conta2 = new ContaCorrente(886, 117886);

            if (conta1.Equals(conta2))
            {
                Console.WriteLine("Contas identicas");
            }
            
            Console.ReadLine();
        }
 */


/*string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDEstino=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            string valor = (extrator.GetValor("moeda"));
            Console.WriteLine("Valor da moeda Destino: " + valor);

            valor = (extrator.GetValor("moedaOrigem"));
            Console.WriteLine("Valor da moeda Origem : " + valor);*/



/*          DateTime dataLimite = new DateTime(2021, 5, 23);
            DateTime dataAtual = DateTime.Now;//CAPTAMOS A DATA ATUAL E O HORÁRIO
            TimeSpan diferenca =(dataLimite - dataAtual); //dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);*/
