using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ListaEnlazadaDoble
{
    internal class ListaD
    {
        private NodoD primero = null;
        private NodoD ultimo = null;

        public void Insertar(string nom, byte ed)
        {
            NodoD nuevo = new NodoD();
            nuevo.Nombre = nom;
            nuevo.Edad = ed;

            if(primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {

            }
        }
    }
}
