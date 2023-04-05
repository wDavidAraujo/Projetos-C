using Microsoft.Win32.SafeHandles;
using System;
using System.Linq;

namespace DesafioSenha {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá, como você se chama?");
            string nome = Console.ReadLine();

            Console.WriteLine($"Certo {nome}, qual a sanha que você quer cadastrar?");
            string senha = Console.ReadLine();

            int contagemespecial = senha.Split(new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' }).Length - 1;

            if (senha.Length >= 9) {
                if (!senha.Any(char.IsDigit)) {
                    Console.WriteLine("ERRO! Sua senha não tem 1 ou mais números!");
                    System.Environment.Exit(0);
                }
                else if (contagemespecial == 0) {
                    Console.WriteLine("ERRO! Sua senha não tem 1 ou mais caracteris especiais!");
                    System.Environment.Exit(0);
                }
                else if (!senha.Any(char.IsUpper)) {
                    Console.WriteLine("ERRO! Sua senha não tem 1 ou mais letras maiusculas!");
                    System.Environment.Exit(0);
                }
                else if (!senha.Any(char.IsLower)) {
                    Console.WriteLine("ERRO! Sua senha não tem 1 ou mais letra minuscula!");
                    System.Environment.Exit(0);
                }
                else if (senha.ToCharArray().Distinct().ToArray().Length != senha.Length) {
                    Console.WriteLine("ERRO! Sua senha tem uma caractere repetido!");
                    System.Environment.Exit(0);
                }

                Console.WriteLine($"Sucesso {nome}! Sua senha foi cadastrada.");
            }
            else if (senha.Length < 9) {
                Console.WriteLine("ERRO! Sua senha não tem 9 ou mais caracteris!");
            }
        }
    }
}