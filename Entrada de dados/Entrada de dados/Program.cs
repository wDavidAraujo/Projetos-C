namespace Operadores {
    class program {
        static void Main(string[] args) {

            // entrada simples de dados, cada dado em um variável
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            // mais complexo pois guardamos dentro de um vetor, e depois dividimos para armazenar em diferentes variáveis.
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
        }
    }
}