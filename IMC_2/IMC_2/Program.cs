using System;

namespace IMC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            string idade = Console.ReadLine();

            Console.WriteLine("Qual sua altura? ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o seu peso?");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.Write("Abaixo do peso.");
            }
            else if (imc < 25) 
            {
                Console.Write("Peso normal.");
            }
            else if (imc < 30)
            {
                Console.Write("Sobrepeso.");
            }
            else if (imc >= 30)
            {
                Console.Write("Obesidade.");
            }
        }
    }
}
