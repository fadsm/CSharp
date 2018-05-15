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

            Console.WriteLine("Carro criado, velocidade inicial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();
            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);

            AcelerarBastante(c);
            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);

            Onibus o = new Onibus();

            Console.WriteLine("Onibus criado, velocidade inicial: " + o.Velocidade);
            o.Acelerar();
            o.Acelerar();
            Console.WriteLine("Onibus, velocidade atual: " + o.Velocidade);

            AcelerarBastante(o);
            Console.WriteLine("Onibus, velocidade atual: " + o.Velocidade);

            Console.ReadKey();

        }
        static void AcelerarBastante(MeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
