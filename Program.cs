using System;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UBUNTU 003 - STARTS...");

            Console.WriteLine("Digite a quantidade de Alunos");
            int Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome do Aluno?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a nota do Aluno?");
            int Nota = int.Parse(Console.ReadLine());

            if (Nota >= 7)
            {
                Console.WriteLine($"Aluno com maior nota:");
                Console.WriteLine(nome);
            }
            else
            {
                Console.WriteLine("Aluno com maior nota é Pedro");
            }

        }
    }
}
