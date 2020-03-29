using System;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            while(idade < 18)
            {
                Console.WriteLine("Informe a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
