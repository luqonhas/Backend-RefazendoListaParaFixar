using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o ano de seu nascimento:");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o seu ano atual:");
            int atual = int.Parse(Console.ReadLine());

            int resultado = atual - nascimento;

            if(resultado <= 17){
                Console.WriteLine("não é obrigatório votar, mas já pode se quiser!");
            }
            if(resultado >= 18){
                Console.WriteLine("é obrigatório votar!");
            }
            if(resultado >= 70){
                Console.WriteLine("não é mais obrigatório votar, mas ainda pode!");
            }
        }
    }
}
