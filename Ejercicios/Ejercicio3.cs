using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    /*
    Se quiere realizar un programa que lea por teclado las 5 notas obtenidas por un alumno 
    (comprendidas entre 0 y 10). A continuación debe mostrar todas las notas, la nota media, 
    la nota más alta que ha sacado y la menor.
    */
    public class Ejercicio3
    {
        public static void NotasObtenidas(){
            
            int[] notas = new int[5];
            
            int nota_mayor, nota_menor, nota_media, suma = 0;

            for(int i = 0; i < 5; i++){

                System.Console.WriteLine("Ingrese la nota numero "+ (i + 1));

                notas[i] = int.Parse(Console.ReadLine());
            }

            suma = notas.Sum();

            nota_media = suma / 5;

            nota_mayor = notas[0];

            for(int i = 0; i < 5; i++){

                if(nota_mayor < notas[i]){
                    
                    nota_mayor = notas[i];

                }
            }

            nota_menor = notas[0];

            for(int i = 0; i < 5; i++){

                if(nota_menor > notas[i]){
                    
                    nota_menor = notas[i];
                    
                }
            }

            System.Console.WriteLine($"La nota media es: {nota_media}\nLa nota mas alta es: {nota_mayor}\nLa nota menor es: {nota_menor}");
        }
    }
}