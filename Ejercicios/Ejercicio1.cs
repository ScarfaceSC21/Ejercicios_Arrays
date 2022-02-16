using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    /*
    Realizar un programa que defina un vector llamado “vector_numeros” de 10 enteros, 
    a continuación lo inicialice con valores aleatorios (del 1 al 10) y posteriormente 
    muestre en pantalla cada elemento del vector junto con su cuadrado y su cubo.
    */
    public class Ejercicio1
    {
        public static void Llenado(){

            Random aleatorio = new Random();

            int numero_aleatorio = aleatorio.Next(1,10);

            int[] vector_numeros = new int[10];

            for(int i = 0; i < vector_numeros.Length; i++){

                vector_numeros[i] = numero_aleatorio;

                numero_aleatorio = aleatorio.Next(1,10);

            }

            foreach(int var in vector_numeros){

                System.Console.WriteLine("Elemento del vector: " + var + "\nSu cuadrado: "+ Math.Pow(var,2) + "\nSu cubo: "+ Math.Pow(var,3)) ;

                System.Console.WriteLine();

            }

        }
    }
}