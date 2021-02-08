using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma conta corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente
    {
        private static int TaxaOperacao;

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }
        public int Agencia { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia"> Representa o valor da propriedade <see cref=" Agencia"/> e deve possuir um valor maior que zero. </param>
        /// <param name="numero"> Representa o valor da propriedade <see cref=" Numero"/> e deve possuir um valor maior que zero. </param>
        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade Saldo.
        /// </summary>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que o Saldo. </param>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>. </exception>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que o <see cref="Saldo"/>. </param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }
        /// <summary>
        /// Realiza deposito de na conta corrente
        /// </summary>
        /// <param name="valor">Define valor que será depositado</param>
        /// <exception cref="ArgumentException">Ocorre quando valor do depósito é menor ou igual a zero</exception>
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Impossível gerar deposito do valor R$" + valor, nameof(valor));
            }
            _saldo += valor;
        }
        /// <summary>
        /// Realiza Tranferencia de uma conta corrente para outra 
        /// </summary>
        /// <param name="valor">Define valor que será transferido</param>
        /// <param name="contaDestino">Define destino da transfêrencia</param>
        /// <exception cref="ArgumentException">Ocorre quando valor da transferência é menor ou igual a zero</exception>
        /// <exception cref="SaldoInsuficienteException">Ocorre quando não à saldo suficiente para ocorrer transferência</exception>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraContaCorrente = obj as ContaCorrente;

            //Numero e agência são os campos que definem se uma conta corrente é repetida ou não
            return (Numero == outraContaCorrente.Numero && Agencia == outraContaCorrente.Agencia);
        }
    }

}
