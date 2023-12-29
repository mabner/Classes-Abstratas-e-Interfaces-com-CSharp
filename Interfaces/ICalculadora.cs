using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Abstratas_e_Interfaces_com_CSharp.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);

        // default interface methods
        int Dividir(int num1, int num2)
        {
            return 1 / 2;
        }
    }
}