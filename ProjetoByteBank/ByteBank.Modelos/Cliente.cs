using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Profissao { get; set; }
        public Cliente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente; //este método só irá funcionar quando o objeto em comparação também for um "Cliente"

            return (CPF == outroCliente.CPF); //para nós a unica coisa que vale é se o CPF for igual, pois ele é nosso campo identificador
        }

    }
}
