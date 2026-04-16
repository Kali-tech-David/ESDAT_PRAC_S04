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
                primero.Siguiente = null;
                ultimo = nuevo;
                ultimo.Siguiente = null;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }
        public void Mostrar(ListView l)
        {
            NodoD actual = primero;

            while(actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Nombre);
                item.SubItems.Add(actual.Edad.ToString());
                l.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

        public NodoD Buscar(string nom)
        {
            NodoD actual = primero;

            while(actual != null)
            {
                if(actual.Nombre == nom)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }
    }
}
