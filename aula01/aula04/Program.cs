using System;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            //enquanto a idade for menor do que 18 anos
            while(idade < 18)
            {
                Console.WriteLine("Informe a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
