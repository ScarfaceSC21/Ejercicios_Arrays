using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    /*
    Crear un vector de 5 elementos de cadenas de caracteres, 
    inicializa el vector con datos leídos por el teclado. 
    Copia los elementos del vector en otro vector pero en orden inverso,
    y muéstralo por la pantalla.
    */
    public class Ejercicio2
    {
        public static void OrdenInverso(){

            string[] cadena = new string[5];

            string[] cadena_inversa = new string[5];

            string linea = "";

            for(int i = 0; i < cadena.Length; i++){

                System.Console.WriteLine("Ingresa un texto");

                linea = Console.ReadLine();

                cadena[i] = linea;
            }

            int k = 4;

            for(int j = 0; j < 5; j++){

                cadena_inversa[j] = cadena[k];

                k--;

            }

            System.Console.WriteLine("Cadena en Orden Original:");

            foreach(string var in cadena){

                System.Console.WriteLine(var);

            }

            System.Console.WriteLine("Cadena en Orden Inverso");

            foreach(string var in cadena_inversa){

                System.Console.WriteLine(var);

            }
        }
    }
}