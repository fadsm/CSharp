using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Carro criado, velocidade inicial:" + c.velocidade);
            c.Acelerar();
            c.Acelerar();
            Console.WriteLine("Carro, velocidade atual: " + c.velocidade);

            Console.ReadKey();

        }

        static void AcelerarBaste(MeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
