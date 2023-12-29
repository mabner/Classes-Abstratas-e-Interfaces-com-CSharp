using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas_e_Interfaces_com_CSharp.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        // abstract method must be implemented by the child class
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Saldo disponível: {saldo}");
        }
    }
}