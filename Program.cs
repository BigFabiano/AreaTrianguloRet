using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Calcule a área de um triângulo retângulo, dados base (b) e altura (h). A área é dada pela metade do produto da base pela altura.
            double doubleBase;
            double doubleAltura;
            double doubleArea;
            Console.WriteLine("««« Calculando a área de um triangulo retangulo »»»");
            Console.Write("Informe a base do triangulo: ");
            doubleBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura do triangulo: ");
            doubleAltura = Convert.ToDouble(Console.ReadLine());
            doubleArea = (doubleBase * doubleAltura)/2;

            Console.WriteLine($" Base = {doubleBase}\n Altura = {doubleAltura} \n Área é: {doubleArea}");
        }
    }
}
