using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Node<T>
    {
        T ValorNodo = default(T);
        Node<T> hijo_izq = null;
        Node<T> hijo_der = null;

        public Node(T ValNode)
        {
            ValorNodo = ValNode;
        }
        public void NodeSons(Node<T> hi, Node<T> hd)
        {
            hijo_izq = hi;
            hijo_der = hd;
        }

        public Node<T> HijoIoD(int hijo)
        {
            if (hijo == 0)
            {
                return hijo_izq;
            }
            if (hijo == 1)
            {
                return hijo_der;
            }
            else
            {
                Console.WriteLine("Error, valor para hijo incorrecto, solo 0 o 1.");
                return null;
            }
        }
    }

}
