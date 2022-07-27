using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    class Professor : Pessoa
    {
        public string aula { get; set; }

        public Professor(string nome, string cpf, string endereco, string celular, string email, int idade, string aula)
        : base(nome, cpf, endereco, celular, email, idade)
        {
            this.aula = aula;
        }
    }
}
