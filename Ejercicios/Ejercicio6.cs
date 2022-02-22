using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    /*
    Crea un programa que pida un número al usuario un número de mes (por ejemplo, el 4) 
    y diga cuántos días tiene (por ejemplo, 30) y el nombre del mes. Debes usar un vector. 
    Para simplificarlo vamos a suponer que febrero tiene 28 días.
    */
    public class Ejercicio6
    {
        public static void NumeroMes(){

            string[] mes = new string[12];

            int numero;
            
            mes[0] = "Enero";

            mes[1] = "Febrero";

            mes[2] = "Marzo";

            mes[3] = "Abril";

            mes[4] = "Mayo";

            mes[5] = "Junio";

            mes[6] = "Julio";

            mes[7] = "Agosto";

            mes[8] = "Septiembre";

            mes[9] = "Octubre";

            mes[10] = "Noviembre";

            mes[11] = "Diciembre";

            System.Console.WriteLine("Ingrese un numero: ");

            numero = int.Parse(Console.ReadLine());

            switch(numero){

                case 1: System.Console.WriteLine("El mes "+ mes[0] +" de tiene 31 dias."); break;

                case 2: System.Console.WriteLine("El mes "+ mes[1] +" de tiene 28 dias."); break;

                case 3: System.Console.WriteLine("El mes "+ mes[2] +" de tiene 31 dias."); break;        
                    
                case 4: System.Console.WriteLine("El mes "+ mes[3] +" de tiene 30 dias."); break;

                case 5: System.Console.WriteLine("El mes "+ mes[4] +" de tiene 31 dias."); break;

                case 6: System.Console.WriteLine("El mes "+ mes[5] +" de tiene 30 dias."); break;

                case 7: System.Console.WriteLine("El mes "+ mes[6] +" de tiene 31 dias."); break;

                case 8: System.Console.WriteLine("El mes "+ mes[7] +" de tiene 31 dias."); break;

                case 9: System.Console.WriteLine("El mes "+ mes[8] +" de tiene 30 dias."); break;

                case 10: System.Console.WriteLine("El mes "+ mes[9] +" de tiene 31 dias."); break;

                case 11: System.Console.WriteLine("El mes "+ mes[10] +" de tiene 30 dias."); break;

                case 12: System.Console.WriteLine("El mes "+ mes[11] +" de tiene 31 dias."); break;

                default: System.Console.WriteLine("Numeros de mes erroneo. Solo numero del 1 al 12"); break;

            }
        }
    }
}