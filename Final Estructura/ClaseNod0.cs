using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Estructura
{
    class ClaseNodo1
    {

        public string NombreAnalisis;
       public ClaseNodo1 posicionAnterior; //posición de memoria del anterior

        public ClaseNodo1()
        {

            NombreAnalisis = "";
            posicionAnterior = null;
        }

    }
}
