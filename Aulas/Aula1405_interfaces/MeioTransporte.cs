using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    interface MeioTransporte
    {
        int velocidade { get; set; }
        void Acelerar();
        void Desacelerar();
    }
}
