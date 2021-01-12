using System;
using System.Collections.Generic;
using System.Text;

namespace ABB_BL
{
    public class Arbol
    {
        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;

        public Arbol()
        {
            raiz = null;
        }

        internal Nodo Raiz { get => raiz; set => raiz = value; }

        //insertar 
        public Nodo Insertar(int pDato, Nodo pNodo)
        {

            Nodo temp = null;

            // si no hay a quien insertar entons creamos el nodo 
            if (pNodo == null)
            {
                temp = new Nodo();
                temp.Dato = pDato;

                return temp;
            }
            if (pDato < pNodo.Dato)
            {
                pNodo.Izquierda = Insertar(pDato, pNodo.Izquierda);
            }
            if (pDato > pNodo.Dato)
            {
                pNodo.Derecha = Insertar(pDato, pNodo.Derecha);
            }
            return pNodo;
        }


        //transversa ller de izquierda derecha raiz
        public void Transversa(Nodo pNodo)
        {
            if (pNodo == null)
                return;

            // me proceso primero 
            for (int n = 0; n < i; n++)
                Console.Write("  ");

            Console.WriteLine(pNodo.Dato);

            // si tengo a la izquierda

            if (pNodo.Izquierda != null)
            {
                i++;
                Console.Write(" izquierda ->");
                Transversa(pNodo.Izquierda);
                i--;
            }
            if (pNodo.Derecha != null)
            {
                i++;
                Console.Write("derecha ->");
                Transversa(pNodo.Derecha);
                i--;
            }
        }
        public int EncontraMinimo(Nodo pNodo)
        {
            if (pNodo == null)
            {
                Console.Write("No se encontraron valores en el arbol");
                return 0;
            }
            trabajo = pNodo;
            int minimo = trabajo.Dato;
            while (trabajo.Izquierda != null)
            {
                trabajo = trabajo.Izquierda;
                minimo = trabajo.Dato;
            }
            return minimo;
        }
        public int SumarNodosIzquierda(Nodo pNodo)
        {
            if (pNodo == null)
            {
                Console.Write("No se encontraron valores en el arbol");
                return 0;
            }
            trabajo = pNodo;
            int suma = trabajo.Dato;
            trabajo = trabajo.Izquierda;
            suma = suma + trabajo.Dato;
  

            return suma;
        }
        public int SumarNodosDerecha(Nodo pNodo)
        {
            if (pNodo == null)
            {
                Console.Write("No se encontraron valores en el arbol");
                return 0;
            }
            trabajo = pNodo;
            int suma = trabajo.Dato;
            trabajo = trabajo.Derecha;
            suma = suma + trabajo.Dato;


            return suma;
        }

        // Contar nodos 
        public int CantidadNodos(Nodo recorrido)
        {
            int contador = 0;
            if (recorrido.Derecha  != null) 
            {
                contador++;
            }
            if (recorrido.Izquierda != null)
            {
                contador++;
            }

            return contador;
        }

        public int ContarHojas(Nodo pNodo)
        {
            trabajo = pNodo;
            int contador = trabajo.Dato;
            int acomulador = 0;
            if (pNodo == null) {
                return 0;
            }
            if (pNodo  != null)
            {
                acomulador++;
                
            }
            acomulador = acomulador + acomulador;
            return acomulador;
           
        }
        public void Nivel(Nodo recorrido,int nivel)
        {
          
            if (recorrido != null)
            {
                Nivel(recorrido.Izquierda ,nivel +1);
                Nivel(recorrido.Derecha ,nivel+1);
                Nivel(raiz, 1);
                Console.WriteLine();
            }
        }
     
    }

}

