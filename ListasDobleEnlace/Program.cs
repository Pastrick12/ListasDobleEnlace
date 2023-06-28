namespace ListasDobleEnlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista Lista1 = new Lista();
            Lista1.InsertarNodo();
            Lista1.InsertarNodo();
            Lista1.InsertarNodo();
            Lista1.InsertarNodo();
            Lista1.InsertarNodo();
            Console.WriteLine("\n PRIMERO AL ULTIMO");
            Lista1.desplegarListaPU();
            Console.WriteLine("\n ULTIMO AL PRIMERO");
            Lista1.desplegarListaUP();
            Console.WriteLine();

        }
    }
}
