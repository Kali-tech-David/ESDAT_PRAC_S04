using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ListaEnlazadaDoble
{
    internal class NodoD
    {
        private string nombre;
        private byte edad;
        private NodoD siguiente;
        private NodoD anterior;

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        internal NodoD Siguiente { get => siguiente; set => siguiente = value; }
        internal NodoD Anterior { get => anterior; set => anterior = value; }
    }
}
