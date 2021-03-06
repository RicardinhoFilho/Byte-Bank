﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ListaDeObjects
    {
        private Object[] _itens;
        private int _proxPosicao;

        public int Tamanho
        {
            get
            {
                return _proxPosicao;
            }
        }
        public Object GetItemObjectNoIndice(int indice)
        {
            if (indice < 0 || indice > _proxPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }


        public Object this[int indice]
        {
            get
            {

                return _itens[indice];
            }
        }


        /// <summary>
        ///     Define uma lista de Contas Correntes adicionadas pelo usuário 
        /// </summary>
        /// <param name="capacidadeInicial">É um parâmetro opcional dado para facilitar na definição do tamanho da lista</param>
        public ListaDeObjects(int capacidadeInicial = 10)//Definindo o construtor desta forma deixamos como opicional o usuário definir ou não
        {
            _itens = new Object[capacidadeInicial];
            _proxPosicao = 0;
        }

        /// <summary>
        /// Adiciona uma nova Object Corrente à lista 
        /// </summary>
        /// <param name="item">Define o item que deve ser adicionado à lista e deve ser do tipo  <see cref=" ContaCorrente"/></param>
        public void Adicionar(Object item)
        {
            VerificarCapacidade(_proxPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição{_proxPosicao}");

            _itens[_proxPosicao] = item;

            _proxPosicao++;
        }

        public void AdicionarVarios(params Object[] itens)
        {
            foreach (Object item in itens)
            {
                Adicionar(item);
            }
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proxPosicao; i++)
            {
                Object item = _itens[i];
                Console.WriteLine($"Item no indíce [{i}]: {_itens[i]}");
            }
        }

        public void Remover(Object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proxPosicao; i++)
            {
                Object itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proxPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proxPosicao--;
            _itens[_proxPosicao] = null;
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

            Object[] novoArray = new Object[novoTamanho];

            //Console.WriteLine("Aumentando capacidade da lista!");

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //Console.WriteLine(".");
            }

            _itens = novoArray;

        }
    }
}
