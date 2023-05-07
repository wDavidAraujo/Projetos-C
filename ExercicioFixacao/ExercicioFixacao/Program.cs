using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Fala ai seu nome!");
            string nome = (Console.ReadLine());
            Console.WriteLine($"Olá! {nome}");

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Diz um preço de qual quer produto ai:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Aqui vai ser teu último nome, idade e a tua altura (tudo na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string unome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);


            Console.WriteLine($"Pronto, {nome} vamos ao resumão!");
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(unome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));

        }
    }
}