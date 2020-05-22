using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, você precisa calcular a área e o semiperímetro de um triângulo?");
            Console.WriteLine("Pressione enter para continuar...:");

            Console.ReadKey();



            Console.WriteLine("Digite o valor do primeiro lado:");

            double p = double.Parse (Console.ReadLine());



            Console.WriteLine("Digite o valor do segundo lado:");

            double s = double.Parse (Console.ReadLine());



            Console.WriteLine("Infome o valor do terceiro lado:");

            double t = double.Parse (Console.ReadLine());



            double r = (p + s + t) / 2;

            double resultado2 = r * ( r-p) * ( r-s )* ( r-t );

            double resultado3 = Convert.ToSingle (Math.Sqrt(resultado2));



            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Área: " + resultado3);

            Console.WriteLine("Semiperímetro: " + r);
        }
    }
}
