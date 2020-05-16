using System;
using Ejercicio_del_libro_C_1_2_3.Capitulo1;
using Ejercicio_del_libro_C_1_2_3.Capitulo2;
using Ejercicio_del_libro_C_1_2_3.Capitulo3;

namespace Ejercicios_del_libro_C_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Ejercicios_1_5 c1 = new Ejercicios_1_5();
            Ejercicios_1_3_5 c2 = new Ejercicios_1_3_5();
            Ejercicios_1_4 c3 = new Ejercicios_1_4();

            int cc = 0, ec = 0;
            do
            {

                Console.WriteLine("Ingrese el capitulo 1-2-3: ");
                cc = int.Parse(Console.ReadLine());
                if (cc == 1)
                {
                    Console.WriteLine("Capitulo 1 Ingrese el ejercicio 1-5: ");
                    ec = int.Parse(Console.ReadLine());
                    if (ec == 1) { c1.imprimir_nombre(); }
                    else
                    if (ec == 5) { c1.Mensajes_extras(); }

                }
                else

                if (cc == 2)
                {
                    Console.WriteLine("Capitulo 2 Ingrese el ejercicio 1-3-5:");
                    ec = int.Parse(Console.ReadLine());

                    if (ec == 1) { c2.perimetro(); }
                    else
                    if (ec == 3) { c2.grados_a_radianes(); }
                    else
                    if (ec == 5) { c2.Convertir_Dolar_a_Euro(); }

                }
                else

                if (cc == 3)
                {
                    Console.WriteLine("Capitulo 3 Ingrese el ejercicio 1-4: ");
                    ec = int.Parse(Console.ReadLine());

                    if (ec == 1) { c3.Par_o_Impar(); }
                    else
                    if (ec == 4) { c3.Dia_de_Semana(); }
                }

                Console.WriteLine("Presione 1 Para Continuar");
                Console.WriteLine("Presione 2 Para Salir");
                op = int.Parse(Console.ReadLine());
                System.Console.Clear();
            } while (op != 2);
        }
    }
}