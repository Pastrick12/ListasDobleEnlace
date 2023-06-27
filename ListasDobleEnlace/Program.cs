namespace ListaDobleEnlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista 1 = new Lista();
            1.insertarNodo();
            1.insertarNodo();
            1.insertarNodo();
            1.insertarNodo();
            1.insertarNodo();
            Console.WriteLine("\n PRIMERO AL ULTIMO");
            1.desplegarListaPU();
            Console.WriteLine("\n ULTIMO AL PRIMERO");
            1.desplegarListaUP();
            Console.WriteLine();

        }
    }
}

