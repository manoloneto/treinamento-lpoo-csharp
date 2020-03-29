using System;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int media;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                numero += Convert.ToInt32(Console.ReadLine());
            }

            media = numero / 10;

            Console.WriteLine($"A média dos números é {media}!");
        }
    }
}
