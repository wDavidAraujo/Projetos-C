using System;

namespace Converter {
    class Program {
        static void Main(string[] args) {
            //CONVERSÃO
            float a;
            double b;

            //nesse caso a baixo funfa, pois o float tem menos espaço do que o double
            a = 5.1f;
            b = a;

            //já aqui não irá funcionar, pois faltará espaço e depois pode haver perca de dados
            double c;
            float d;

            c = 5.1;
            //d = c; (comentado para n bugar o cod)
     
            //preciso especificar para o programa que ele pode proceguir e fazer a conversão, mesmo perdendo dados o programdor irá ficar responsável por qual quer dano (chamamos isso de casting).
            //fazemos isso da seguinte forma:
            c = 5.1;
            d = (float)c;

            //DIVISÃO
            int e = 5;
            int f = 2;
            //forma "errada" de fazer divisão, pois como estamos dividindo dois resultados int o c# acha que o resultado precisa ser int poir mais que a variável destino seja "double".
            //double resultado = e / f;
            //Console.WriteLine(resultado);

            //forma "correta" de fazer divisão, já estamos convertendo um dos valores em double assim o c# consegue fornecer a variável destido um valor float.
            double resultado = (double) e / f;
            Console.WriteLine(resultado);

        }
    }

}