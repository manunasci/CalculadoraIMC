using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora IMC");

            Console.WriteLine("Digite sua Altura");
            string altura = Console.ReadLine();
            double medida = double.Parse(altura);

            Console.WriteLine("Digite seu Peso");
            string peso = Console.ReadLine();
            double massa = double.Parse(peso);

            double IMC = massa/(medida*medida);

            Console.WriteLine($"Seu IMC é {IMC:N2}");

            if (IMC < 17)
            {
              Console.WriteLine("Situação: Muito abaixo do peso");
            }

            else if (IMC < 18.49)
            {
               Console.WriteLine("Situação: Abaixo do peso");
            }
            
            else if (IMC < 24.99)
            {
               Console.WriteLine("Situação: Peso normal");
            }

            else if (IMC < 29.99)
            {
               Console.WriteLine("Situação: Acima do peso");
            }

            else if (IMC < 34.99)
            {
                Console.WriteLine("Situação: Obesidade I");
            }

            else if (IMC < 39.99)
            {
                Console.WriteLine("Situação: Obesidade II (severa)");
            }

            else if (IMC < 40)
            {
                Console.WriteLine("Situação: Obesidade III (mórbida");
            }
        }
    }
}
