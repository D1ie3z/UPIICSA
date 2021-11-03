using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Discografia
{
    class Grupo
    {
        //ATRIBUTOS ← ESTO ES LO QUE TIENE DE CARACTERISTICAS LA CLASE
        /*EJEMPLO: Coche → Marca, Color, etc...*/
         private string _disco;

        //CONSTRUCTOR (PD: PARA CREARLO DEN CLICK DERECHO A LA CLASE>>ACCIONES RAPIDAS>>GENERAR CONSTRUCTOR)
        public Grupo(string disco)
        {
            this._disco = disco;
        }
        //ENCAPSULAMIENTO DE NOMBRE      
        public string disco { get => _disco; set => _disco = value; }

        public override string ToString()
        {
          return "Album: "+ disco; //REGRESA EL VALOR PARA IMPRIMIRLO 
        }
    }
}
