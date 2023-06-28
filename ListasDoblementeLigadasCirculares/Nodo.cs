using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    class Nodo
    {
        private int Dato;
        private Nodo Next;
        private Nodo Back;

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }
        public Nodo next
        {
            get { return Next; }
            set { Next = value; }
        }

        public Nodo back
        {
            get { return Back; }
            set { Back = value; }
        }
    }
}