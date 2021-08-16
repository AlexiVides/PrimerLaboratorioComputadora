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
    }
}
