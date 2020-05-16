using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_del_libro_C_1_2_3.Capitulo3
{
    class Ejercicios_1_4
    {

        //Ejercicio 1 Capitulo 3
        public void Par_o_Impar()
        {
            float n = 0f;

            Console.WriteLine("Porfavor digite el numero a evaluar");
            n = float.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("EL numero que usted ha ingresado es Un numero par");
            }
            else
            {
                Console.WriteLine("EL numero que usted ha ingresado es Un numero impar");
            }
        }

        //Ejercicio 4 Capitulo 3
        public void Dia_de_Semana()
        {
            int n;
            Console.WriteLine("Digite un numero del (1 al 7)");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Domingo!!");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Lunes!!");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Martes!!");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Miercoles!!");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Jueves!!");
                    Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine("Viernes!!");
                    Console.ReadLine();
                    break;

                case 7:
                    Console.WriteLine("Sabado");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta, el numero no pertenese a los dias de la semana");
                    break;
            }
        }
    }
}