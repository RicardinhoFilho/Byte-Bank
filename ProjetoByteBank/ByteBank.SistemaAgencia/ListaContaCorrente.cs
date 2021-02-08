using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proxPosicao;

        /// <summary>
        ///     Define uma lista de Contas Correntes adicionadas pelo usuário 
        /// </summary>
        /// <param name="capacidadeInicial">É um parâmetro opcional dado para facilitar na definição do tamanho da lista</param>
        public ListaContaCorrente(int capacidadeInicial = 10)//Definindo o construtor desta forma deixamos como opicional o usuário definir ou não
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proxPosicao = 0;
        }

        /// <summary>
        /// Adiciona uma nova Conta Corrente à lista 
        /// </summary>
        /// <param name="item">Define o item que deve ser adicionado à lista e deve ser do tipo  <see cref=" ContaCorrente"/></param>
        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proxPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição{_proxPosicao}");

            _itens[_proxPosicao] = item;

            _proxPosicao++;
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }



            int novoTamanho = _itens.Length * 2;//Tamanho da lista sempre é aumentado para o dobro, evitando qué muito espaço seja reservado e não ocupado.  

            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            //Console.WriteLine("Aumentando capacidade da lista!");

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                Console.WriteLine(".");
            }

            _itens = novoArray;

        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proxPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    itemAtual == null;
                }
            }
        }
    }
}
