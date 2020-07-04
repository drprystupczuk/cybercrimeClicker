using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Estructura
{
    class ClaseNodo
    {

        public string NombreAnalisis;
        
        public ClaseNodo posicionSiguiente; //posición de memoria del siguiente nodo

        public ClaseNodo() //inicializa cualquier objeto que se crea de la clase
        {
            NombreAnalisis = "";
            posicionSiguiente = null;
            
        }
    }
}
