using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    //Hacer un programa que inicialice un vector de números con valores aleatorios, 
    //y posterior ordene los elementos de menor a mayor.
    public class Ejercicio5
    {
        public static void OrdenarVector(){

            int[] vector = new int[5];

            Random aleatorio = new Random();

            int numeroAleatorio = aleatorio.Next(1,10);

            int temp;

            for(int i = 0; i < vector.Length; i++){

                vector[i] = numeroAleatorio;

                numeroAleatorio = aleatorio.Next(1,10);

            }

            System.Console.WriteLine("Vector Desordenado");

            foreach (int item in vector)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Vector Ordenado: ");

            for(int i = 0; i < vector.Length-1; i++){

                if(vector[i] > vector[i+1]){

                   temp = vector[i];

                   vector[i] = vector[i+1];

                   vector[i+1] = temp;
                }
            }

            foreach (var item in vector)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}