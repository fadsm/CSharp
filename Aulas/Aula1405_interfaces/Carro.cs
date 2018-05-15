using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    class Carro : MeioTransporte
    {
        public int velocidade { get; set ;}

        public void Acelerar()
        {
            velocidade += 10;
        }

        public void Desacelerar()
        {
            velocidade = -6;
        }
    }
}
