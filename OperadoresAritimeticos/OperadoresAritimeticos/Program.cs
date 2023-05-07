using System;

namespace Operadores {
    class program {
        static void Main(string[] args) {

            //ordem original, dando preferencia a multiplicação
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            //ordem modificada com parentese, assim a preferencia é da soma
            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            //usando o % (mod), nesse caso temos como resultado o restante de uma divisão:
            int n3 = 17 % 3;
            Console.WriteLine(n3);

            //para dividirmos e o resultado vir de forma double ou float precisamos converster um dos dividendos para double ou float (duas forma de fazer):
            double n4 = (double)10 / 8;
            Console.WriteLine(n4);

            double n5 = 10.0 / 8;
            Console.WriteLine(n5);

            //BORA FAZER BHASKARA SÓ PRA APRENDER PROCEDENCIA!

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine($"O resultado de delta é: {delta}");
            Console.WriteLine($"O resultado do x1 é: {x1}");
            Console.WriteLine($"O resultado do x2 é: {x2}");
        }
    }
}