using System;
using System.Collections.Generic;
using System.Text;

namespace projetofinal
{
    class Aluno : Pessoa
    {
        public float peso { get; set; }
        public float altura { get; set; }

        public Aluno(string nome, string cpf, string endereco, string celular, string email, int idade, float peso, float altura)
        : base(nome, cpf, endereco, celular, email, idade)
        {
            this.peso = peso;
            this.altura = altura;
        }
    }
}
