using System;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu Silva";
            int idade1 = 33;
            double peso1 = 88.50;
            double altura1 = 1.65;
            bool ehDev1 = true;
            //var imc1 = 32.50;
            
            string nome2 = "Ubuntu Bruno";
            int idade2 = 26;
            double peso2 = 84.50;
            double altura2 = 2.10;
            bool ehDev2 = true;
            //var imc2 = 19.16;
            
            string nome3 = "Ubuntu Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            double altura3 = 1.40;
            bool ehDev3 = false;
            //var imc3 = 33.92;

            //T1 - Soma das idades dos Ubuntus
            Console.WriteLine(idade1 + idade2+ idade3);
            
            //T2 - Agrupar o nome dos Ubuntus
            Console.WriteLine("{0} {1} {2}", nome1, nome2, nome3);

            //T3 - Média IMC dos Ubuntus
            double imc = peso1 / (altura1 * altura1);
            var imc2 = peso2 / (altura2 * altura2);
            var imc3 = peso3 / (altura3 * altura3);
            var Média = imc + imc2 + imc3;

            Console.WriteLine($"IMC nome1 é {imc}.");
            Console.WriteLine($"IMC nome2 é {imc2}.");
            Console.WriteLine($"IMC nome3 é {imc3}.");
            Console.WriteLine($"A média é: {Média.ToString("F")}");

            //T4 - Quantos são Devs
            if (ehDev1 == true)
            {
                Console.WriteLine("Sou Dev");
            }
            else
            {
                Console.WriteLine("Não sou Dev");
            }
            if (ehDev2 == true)
            {
                Console.WriteLine("Sou Dev");
            }
            else
            {
                Console.WriteLine("Não soe Dev");
            }
            if (ehDev3 == true)
            {
                Console.WriteLine("Sou Dev");
            }
            else
            {
                Console.WriteLine("Não sou Dev");
            }

            //T5 - Somente Umbuntus com Silva
            if (string.Equals(nome1, nome3))
            {
                Console.WriteLine($"{nome1} e {nome3} ");
            }
            else
            {
                Console.WriteLine($"{nome2}");
            }

        }
    }
}
