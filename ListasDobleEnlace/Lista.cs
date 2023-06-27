using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobleEnlace
{
     class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();
        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato que contendra el nuevo Nodo; ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if ( primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
            }
            Console.WriteLine("\n Nuevo Nodo ingresado con exito");
        }
        public void desplegarListaPU()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual= actual.Siguiente;    
            }
        }
        public void desplegarListaUP()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual= actual.Atras;

            }
        }
    }
}
