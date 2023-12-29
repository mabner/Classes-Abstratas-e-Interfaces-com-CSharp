using Classes_Abstratas_e_Interfaces_com_CSharp.Interfaces;
using Classes_Abstratas_e_Interfaces_com_CSharp.Models;

Calculadora c1 = new Calculadora();
ICalculadora c2 = new Calculadora();

c2.Dividir(4, 2);

// name is now a required parameter for instancing the class.
// Aluno a1 = new Aluno("Marcos");
// a1.Apresentar();

// Aluno a2 = new Aluno();

// Corrente c = new Corrente();
// c.Creditar(300);
// c.ExibirSaldo();


