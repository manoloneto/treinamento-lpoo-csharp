using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //variável
            string nomeDoUsuario;

            Console.WriteLine("Informe o seu nome: ");
            nomeDoUsuario = Console.ReadLine();

            //primeira forma
            Console.WriteLine("O nome do usuário é: ");
            Console.WriteLine(nomeDoUsuario);

            //segunda forma
            Console.WriteLine("O nome do usuário é: " + nomeDoUsuario);

            //terceira forma - forma mais performática
            Console.WriteLine($"O nome do usuário é: {nomeDoUsuario}");
        }
    }
}
