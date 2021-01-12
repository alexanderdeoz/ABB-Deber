using System;

namespace ABB_BL
{
    public class Nodo
    {
        private int dato;
        private Nodo izquierda;
        private Nodo derecho;

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Izquierda { get => izquierda; set => izquierda = value; }
        internal Nodo Derecha { get => derecho; set => derecho = value; }

        public Nodo()
        {
            dato = 0;
            izquierda = null;
            derecho = null;
        }
    }
}
