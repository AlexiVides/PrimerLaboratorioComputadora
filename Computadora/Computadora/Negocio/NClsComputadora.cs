using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
        public String Apagar(ClsComputadora computadora)
        {
            return "Apagando computadora";
        }
        public String Acción(ClsComputadora computadora)
        {
            return "Abriendo programa";
        }
        public String Web(ClsComputadora computadora)
        {
            return "Cargando pagina";
        }

        public String EncenderComputadora(ClsComputadora computadora)
        {
            return "La computadora con memoria RAM de " + computadora.Memoria_ram + " y micro procesador " + computadora.Procesador + " esta encendida";
        }
    }
}
