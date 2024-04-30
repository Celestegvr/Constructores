using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresC_
{
    //Clase Automovil
    class Automovil
    {
        //dando valores a los atributos del automovil
        //la variable es public la cual se puede ver fuera de la clase
        public string modelo, color;
        public int numpuertas;

        // EL CONSTRUCTRO DEBE TENER EL MISMO NOMBRE DE LA CLASE

        /*La variable contructor llamado Automovil tiene con parametros de string y 
         enteros creado para inicializar los objetos*/
       public Automovil(string modeloPa, string ColorPa, int numpuertasPa)
        {
       /* SE CREAN 3 PARAMETROS, PARA GESTIONAR LOS ARGUMENTOS QUE SE ENVIARAN DESDE
          EXTERIOR
        */
       //se imprimira el mensaje
        Console.WriteLine(" SE INVOCA AL CONSTRUCTOR\n");

            //mostrara los valores asignados a los parametros
            modelo = modeloPa;
            color = ColorPa;
            numpuertas = numpuertasPa;

            //this.numpuertas = numpuertasPa;
        }

    }
}
