using System.Globalization;
namespace EstruturaDeRepeticao {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digita um número para eu dize qual é a raiz dele! ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.Write("Digita outra parada ai ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Você acabou de digitar um número negativo!");
        }
    }
}