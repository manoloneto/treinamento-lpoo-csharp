using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            //int - inteiro (20)
            //double - real (4.5)

            int idade;

            Console.WriteLine("Informe a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            //se idade for maior ou igual 18 anos ele é de maior
            //senão ele é de menor

            if(idade >= 18)
            {
                Console.WriteLine("Você é de maior!");
            }
            else
            {
                Console.WriteLine("Você ainda é de menor!");
            }
        }
    }
}
