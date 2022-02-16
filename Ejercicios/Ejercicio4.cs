using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    /*
    Programa que declare un vector de diez elementos enteros y pida números para rellenarlo 
    hasta que se llene el vector o se introduzca un número negativo. Entonces se debe imprimir 
    el vector (sólo los elementos introducidos).
    */
    public class Ejercicio4
    {
        public static void RellenarVector(){
            
            int[] vector = new int[10];

            int i = 0, contador = 0;

            do{

                System.Console.WriteLine("Introduce un numero (negativo para terminar)");

                vector[i] = int.Parse(Console.ReadLine());

                i++;

                contador++;

            }while(i < 10 && vector[i-1] >= 0);

            i = 0;

            while(i < contador && vector[i] >= 0){

                System.Console.WriteLine(vector[i]);

                i++;
            }

        }
    }
}