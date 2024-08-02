using System;
using System.Formats.Asn1;
using System.Globalization;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Comprimento do terreno!");
            double comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Largura do terreno!");
            double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do metro");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double area = (comprimento * largura);
            Console.WriteLine("O terrenho tem:" +" "+ area.ToString("F2",CultureInfo.InvariantCulture) + " " + "m²");

            double valormetro = (area * valor);
            Console.WriteLine("O valor total do terreno é:"+ " " + valormetro.ToString("F2", CultureInfo.InvariantCulture) + "R$");

        }
    }
}