using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Atividade01{
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de pc";

            byte idade = 30;
            int codigo = 5190;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.2345677;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1}");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2}");

            Console.Write("Registro");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e pertence ao gênero: {genero}");


            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado (três casas de cimais) e com o separador decimal invariant culture: {medida.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
   }