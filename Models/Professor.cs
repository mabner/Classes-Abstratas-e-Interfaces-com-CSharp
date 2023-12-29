using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas_e_Interfaces_com_CSharp.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e meu salário é {Salario}");
        }
    }
}