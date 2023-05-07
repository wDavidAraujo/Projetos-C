namespace Ex04FOR {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("quantos pares fazer fazer as divisões?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("digite um par de números para dividirmos:");
                float n1 = int.Parse(Console.ReadLine());
                float n2 = int.Parse(Console.ReadLine());

                if (n2 == 0) {
                    Console.WriteLine("divisão impossível");
                }
                else {
                    float resultado = n1 / n2;
                    Console.WriteLine($"sua divisão teve resultado igual á:{resultado}");
                }
            }
        }
    }
}