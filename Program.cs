using System;
using Polimorfismo_Sobrecarga.Classes;

namespace Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Funcionarios fun = new Funcionarios();
            fun.Mostrar();
            fun.Mostrar("Caio");
            fun.Mostrar(2);

            Console.WriteLine();
        }
    }
}
