using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //inteiro - números sem vírgula 1 - 2 - 3
            //double - números com vírgula 1.1 - 2.4 - 2.1
            //string - palavras ou letras
            //booleano - verdadeiro ou falso

            int numero;
            double numeroComVirgula;
            string palavra;
            bool verdadeiro;

            numero = 10;
            numeroComVirgula = 2.5;
            palavra = "ragatanga";
            verdadeiro = true;

            Console.WriteLine("Os valores das variáveis são: ");
            Console.WriteLine("Variável palavra: " + palavra);
            Console.WriteLine("Variável numero: " + numero);
            Console.WriteLine("Variável numeroComVirgula: " + numeroComVirgula);
            Console.WriteLine("Variável verdadeiro: " + verdadeiro);

            string nomeDoUsuario;

            Console.WriteLine("Informe o seu nome: ");
            nomeDoUsuario = Console.ReadLine();

            Console.WriteLine("O nome do usuário é: " + nomeDoUsuario);

        }
    }
}
