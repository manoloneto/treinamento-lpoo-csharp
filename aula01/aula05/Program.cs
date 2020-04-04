using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("Escolha uma opção:\n 1 ou 4 - Bom dia;\n 2 ou 3 - Boa tarde;");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                case 4:
                    Console.WriteLine("Bom dia usuário!");
                    break;

                case 2:
                case 3:
                    Console.WriteLine("Boa tarde usuário!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
