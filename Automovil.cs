using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresC_
{
    //Clase de nombre Program
    internal class Program
    {
        //Main
        static void Main(string[] args)
        {
        // se crean los objetos y se le asigna el valor a la variable constructor.
        Automovil AutoNisan= new Automovil("Grand I10", "Gris",4);
        Automovil AutoFerrari = new Automovil("SX 2050", "Rojo",2);


            //información sobre dos instancias de la clase
        Console.WriteLine("EL MODELO DEL VEHICULO-->{0}, Color {1}, Numero de Puertas-->{2}\n", AutoFerrari.modelo, AutoFerrari.color, AutoFerrari.numpuertas);
        Console.WriteLine("EL MODELO DEL VEHICULO-->{0}, Color {1}, Numero de Puertas-->{2}\n", AutoNisan.modelo, AutoNisan.color, AutoNisan.numpuertas);

            // Se asignan valores a los objetos que intancian la clase

        /*MIREN COMO SI LO HACEMOS ASI AUMENTA LAS LINEAS DE CODIGO
                Automovil AutoNisan = new Automovil();
                Automovil AutoFerrari = new Automovil();
                AutoNisan.modelo = "Grand I10";
                AutoNisan.color = "Gris";
                AutoNisan.numpuertas = 4;

                AutoFerrari.modelo = "SX 2050";
                AutoFerrari.color = "Rojo";
                AutoFerrari.numpuertas = 2;
        */

        /*
               // INSTANCIAMOS LA CLASE. CREAMOS UN OBJETO
                  Automovil modelvehicu = new Automovil("Hiunday Grand I10","Rojo", 4);

               // SE IMPRIME EL VALOR INICIAL DEL MODELO 
                  Console.WriteLine("EL MODELO DEL VEHICULO-->{0}, Color {1}, Numero de Puertas-->{2}\n", modelvehicu.modelo,modelvehicu.color,modelvehicu.numpuertas);
        */

            // REVISAR QUE SE IMPRIME EL VALOR INICIAL 

            Console.ReadKey();

        }
    }
}
