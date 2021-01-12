using System;
using ABB_BL;

namespace ABB_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            Nodo raiz = arbol.Insertar(6,null);
            arbol.Insertar(2,raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);


            arbol.Transversa(raiz);
            Console.Read();
            Console.WriteLine("el menor de toda la cadena es =  {0}",arbol.EncontraMinimo(raiz));
            Console.WriteLine("La suma total de los nodos derecha es  =  {0}",arbol.SumarNodosDerecha(raiz));
            Console.WriteLine("La suma total de los nodos izquierda es  =  {0}", arbol.SumarNodosIzquierda(raiz));

            Console.WriteLine("la cantidad de nodos total es  = {0}",arbol.CantidadNodos(raiz));
            Console.WriteLine("la cantidad de hojas es  =  {0}", arbol.ContarHojas(raiz));
            Console.WriteLine("la cantidad de  nivel es  =  {0}", arbol.ContarHojas(raiz));
           
        }
    }
}
