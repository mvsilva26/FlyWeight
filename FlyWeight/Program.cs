using System;

namespace FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCírculos Amarelos ");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo"); // chamando o metodo passando a chave
                circulo.SetCor("Amarelo");
                circulo.Desenhar();
            }

            Console.WriteLine("\nCírculos Verdes ");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Verde");
                circulo.Desenhar();
            }

            Console.WriteLine("\nCírculos Azul ");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Azul");
                circulo.Desenhar();
            }
        }
    }
}
