using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();

            clscomputadora.Memoria_ram = 16;
            clscomputadora.Procesador = 17;

            Console.WriteLine(nclscomputadora.EncenderComputadora(clscomputadora));
            Console.ReadLine();
        }
    }
}
