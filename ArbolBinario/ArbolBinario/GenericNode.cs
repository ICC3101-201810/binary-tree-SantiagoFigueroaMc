using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class GenericNode<T>
    {
        Node<T> NodoInicial;
        public GenericNode()
        {
            Node<T> NodoInicial = new Node<T>(null);
        }
        public Node<T> CrearNodo(T val)
        {
            Node<T> NewNodo = new Node<T>(val);
            return NewNodo;
        }

        public void AsignarHijos(Node<T> nodo, Node<T> HijoIzquierdo, Node<T> HijoDerecho)
        {
            nodo.NodeSons(HijoIzquierdo, HijoDerecho);
        }

        public void InsertarNodo(List<int> direccion, T ValorNuevoNodo)
        {
            Node<T> nodo_actual = NodoInicial;
            foreach (int next_dir in direccion)
            {
                nodo_actual = nodo_actual.HijoIoD(next_dir);
                if (nodo_actual == null)
                {
                    Console.WriteLine("La direccion es muy larga. Debe terminar en un nodo hijo que aun no es padre.");
                    break;
                }
            }
            CrearNodo(ValorNuevoNodo);
            
        }
    }
}
