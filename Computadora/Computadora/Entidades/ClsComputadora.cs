using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private int memoria_ram;
        private int procesador;
        private String dico_duro;
        private String placa_madre;
        private String disipador_calor;

        private String monitor;
        private String teclado;
        private String mouse;
        private String upc;
        private String audio;

        public int Memoria_ram { get => memoria_ram; set => memoria_ram = value; }
        public int Procesador { get => procesador; set => procesador = value; }
        public string Dico_duro { get => dico_duro; set => dico_duro = value; }
        public string Placa_madre { get => placa_madre; set => placa_madre = value; }
        public string Disipador_calor { get => disipador_calor; set => disipador_calor = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mouse { get => mouse; set => mouse = value; }
        public string Upc { get => upc; set => upc = value; }
        public string Audio { get => audio; set => audio = value; }
    }
}
