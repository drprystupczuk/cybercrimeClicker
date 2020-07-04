using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Estructura
{
    class ClassPila
    {
        ClaseNodo1 pPrimero; //posición de memoria

        ClaseNodo1 pUltimo;

        ClaseNodo1 pNuevo;
        
        public ClassPila()
        {
            //if (pPrimero == null && pUltimo == null)
            //{
            //    Crear();
            //}
            //else
            //{
            //    Insertar();
            //}
        }

        public void Crear(string NombreAnalisis)
        {
            if (pPrimero == null)
            {
                pNuevo = new ClaseNodo1();

                if (pNuevo != null)
                {
                    //registrar los valores que enviamos desde la interfaz o aleatoriamente

                    pNuevo.NombreAnalisis = NombreAnalisis; //envío parametros desde la interfaz
                    
                    pNuevo.posicionAnterior = null;

                    pPrimero = pNuevo;
                    pUltimo = pNuevo;
                }
                else
                {
                    //no hay espacio en memoria
                }

            }
            else
            { 
                //llama a insertar
                Insertar(NombreAnalisis);
            }
        }

        public void Insertar(string NombreAnalisis)
        {
            if (pUltimo != null)
            {
                pNuevo = new ClaseNodo1();
                if (pNuevo != null)
                {
                    //registrar los valores que enviamos desde la interfaz o aleatoriamente

                    pNuevo.NombreAnalisis = NombreAnalisis; //envío parametros desde la interfaz
                    
                    pNuevo.posicionAnterior = pUltimo;

                    pUltimo = pNuevo;
                }
                else
                {
                    //mensaje no hay espacio en memoria
                }
            }
            else
            {
                Crear(NombreAnalisis);
            }
        }

        public void Listar(ListBox Lista)
        {
            ClaseNodo1 pAuxiliar = new ClaseNodo1();

            if (pUltimo != null)
            {
                pAuxiliar = pUltimo;

                while (pAuxiliar != null)
                {
                    //mostraria la informacion 
                    Lista.Items.Add(pAuxiliar.NombreAnalisis);

                    pAuxiliar = pAuxiliar.posicionAnterior; //indica el nodo que está antes de él
                }

            }
            else
            { 
                //no hay elementos
            }
        }
    }
}
