using System.Globalization; // para conseguir fazer funfar a parada de trocar o ponto pela virgula na variável de saldo

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            char gereno = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "ana";

            Console.Write("Hello World só com o write, assim ele n quebra linha.");
            Console.WriteLine("Hello World!");

            Console.WriteLine(gereno); // forma de imprimir na tela uma variável
            Console.WriteLine(saldo); // imprimindo puro e seco
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // somento com duas casas de cimais depois da virgula+ com pontos envez de virgula
            // imprimindo variáveis com acréssimos de tunação nos textos
            // (placeholders)
            Console.WriteLine("{0} tem {1} anos e tem o saldo de R${2}", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            // (interpolação) 
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo de R${saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            // (concatenação)
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo de R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}