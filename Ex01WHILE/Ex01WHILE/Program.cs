namespace Ex01WHILE {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("digite sua senha (somente números) ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.Write("senha inválida, tente novamente! ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("acesso permitido!");
        }
    }
}