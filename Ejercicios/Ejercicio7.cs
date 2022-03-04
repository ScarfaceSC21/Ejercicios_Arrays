using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    /*
    Programa que declare tres vectores ‘vector1’, ‘vector2’ y ‘vector3’ de cinco enteros cada uno, 
    pida valores para ‘vector1’ y ‘vector2’ y calcule vector3=vector1+vector2.
    */
    public class Ejercicio7
    {
        public static void SumarVectores(){
            
            int[] vector1 = new int[5];

            int[] vector2 = new int[5];

            int[] vector3 = new int[5];

            for(int i = 0; i < vector1.Length; i++){

                System.Console.WriteLine("Ingresa un valor al vector 1 en la posicion [" + i + "]");

                vector1[i] = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingresa un valor al vector 2 en la posicion [" + i + "]");

                vector2[i] = int.Parse(Console.ReadLine());

            }

            for(int i = 0; i < vector3.Length; i++){

                vector3[i] = vector1[i] + vector2[i];

            }

            foreach(int var in vector3){

                System.Console.WriteLine(var);
            }

        }
    }
}