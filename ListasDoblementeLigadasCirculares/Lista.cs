namespace ListasDoblementeLigadasCirculares
{
    internal class Lista
    {
        Nodo inicio = new Nodo();
        Nodo fondo = new Nodo();

        public Lista()
        {
            inicio = null;
            fondo = null;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingresar dato del nuevo node: ");
            nuevo.dato = int.Parse(Console.ReadLine());
            if (inicio == null)
            {
                inicio = nuevo;
                fondo = nuevo;
                inicio.next = inicio;
                inicio.back = fondo;
            }
            else
            {
                fondo.next = nuevo;
                nuevo.back = fondo;
                nuevo.next = inicio;
                fondo = nuevo;
                inicio.back = fondo;
            }
            Console.WriteLine("\n Has agregado un nodo\n\n");
        }
        public void desplegarListaPU()
        {
            Nodo actual = new Nodo();
            actual = inicio;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.next;
                } while (actual != inicio);
            }
            else
            {
                Console.WriteLine("\n Está vacío \n");
            }
        }
        public void desplegarListaUP()
        {
            Nodo actual = new Nodo();
            actual = fondo;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.back;
                } while (actual != fondo);
            }
            else
            {
                Console.WriteLine("\n Está vacío \n");
            }
        }
    }
}