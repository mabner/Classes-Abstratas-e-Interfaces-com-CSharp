using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas_e_Interfaces_com_CSharp.Models
{
    public class Aluno : Pessoa
    {
        // makes it possible to instance the aluno class without passing a name.
        public Aluno()
        {

        }

        // receives the 'nome' parameter and passes it to the base class (Pessoa).
        public Aluno(string nome) : base(nome)
        {

        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou aluno nota {Nota}.");
        }
    }
}