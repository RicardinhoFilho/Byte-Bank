using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaContaCorrente lista = new ListaContaCorrente(20);

            lista.Adicionar(new ContaCorrente(886, 886125));
            lista.Adicionar(new ContaCorrente(886, 886126));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));
            lista.Adicionar(new ContaCorrente(886, 886127));




            Console.ReadLine();

        }    
    }
}









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
