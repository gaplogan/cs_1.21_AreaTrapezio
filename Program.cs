using System;

namespace cs_1._21_AreaTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpar a tela do console.
            Console.Clear();

            // Declaração das variáveis.
            double b1, b2, h, area;

            // Valida as bases.
            do
            {
                Console.Write("Digite o valor da base menor: ");
                b1 = double.Parse(Console.ReadLine());
                // Garante base menor positiva.
                b1 = Math.Abs(b1);

                Console.Write("Digite o valor da base maior: ");
                b2 = double.Parse(Console.ReadLine());
                // Garante base maior positiva.
                b2 = Math.Abs(b2);

            } while ((b1 == 0) || (b2 == 0) || (b2 < b1));

            // valida a altura.
            do
            {
                Console.Write("Digite o valor da altura: ");
                h = double.Parse(Console.ReadLine());
                // Garante altura positiva.
                h = Math.Abs(h);

            } while (h < 0);

            // Fórmula da área do trapézio.
            area = ((b1 + b2) * h) / 2;
            Console.WriteLine($"\nÁrea Trapézio {area}");
        }
    }
}
