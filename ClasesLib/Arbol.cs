using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class Arbol
    {
        public Nodo raiz_principal = null;

        public void Insertar(Persona p)
        {
            InsertarRecursivo(ref raiz_principal, p);
        }
        public void InsertarRecursivo(ref Nodo raiz, Persona p)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = p;

                raiz = nuevo;
                MessageBox.Show("Paciente registrado con exito!");
            }
            else
            {
                if (p < raiz.dato)
                {
                    InsertarRecursivo(ref raiz.izq, p);
                }
                else if (p > raiz.dato)
                {
                    InsertarRecursivo(ref raiz.der, p);
                }
                else
                {
                    MessageBox.Show("Paciente ya esta registrado previamente");
                }
            }
        }

        public void Listar(ref ListBox ls)
        {
            ls.Items.Clear();
            InOrdenRecursivo(raiz_principal, ref ls);
        }
        public void InOrdenRecursivo(Nodo raiz, ref ListBox ls)
        {
            if (raiz != null)
            {
                InOrdenRecursivo(raiz.izq, ref ls);
                ls.Items.Add(raiz.dato);
                InOrdenRecursivo(raiz.der, ref ls);
            }
        }

        public Persona Buscar(int d)
        {
            Persona p = new Persona();
            p.dni = d;

            return BuscarRecursivo(raiz_principal, p);
        }
        public Persona BuscarRecursivo(Nodo raiz, Persona p)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                if (p < raiz.dato)
                {
                    return BuscarRecursivo(raiz.izq, p);
                }
                else if (p > raiz.dato)
                {
                    return BuscarRecursivo(raiz.der, p);
                }
                else
                {
                    return raiz.dato;
                }
            }
        }
    }
}
