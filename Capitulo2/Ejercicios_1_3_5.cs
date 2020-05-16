using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicio_del_libro_C_1_2_3.Capitulo2
{
    class Ejercicios_1_3_5
    {
        //Ejercicio 1 Capitulo 2
        public void perimetro()
        {
            int n_lados;
            float longitudLados;
            float Perimetro;

            Console.WriteLine("Cantidad de lados: ");
            n_lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Longitud de lados:");
            longitudLados = Convert.ToSingle(Console.ReadLine());

            Perimetro = n_lados * longitudLados;

            Console.WriteLine("El Perimetro del poligono es: " + Perimetro);
            Console.ReadLine();
        }

        //Ejercicio 3 Capitulo 2
        public void grados_a_radianes()
        {
            int grado = 0;
            double radianes = 0f;

            Console.WriteLine("Temperatura en Grados: ");
            grado = Convert.ToInt32(Console.ReadLine());

            radianes = (Math.PI / 180) * grado;

            Console.WriteLine("Usted introdujo {0} grados que esto equivale a {1} radian", grado, radianes);
        }

        //Ejercicio 5 Capitulo 2
        public void Convertir_Dolar_a_Euro()
        {
            int Opc;
            float Dolar = 0, Euro = 0;
            float Taza = 0, Cambio = 0;

            Console.WriteLine("\n1.dolares a euro");
            Console.WriteLine("\n2.euros a dolares");
            Opc = Convert.ToInt32(Console.ReadLine());

            switch (Opc)
            {
                case 1:
                    Console.WriteLine("Digite cantidad de dolares:");
                    Dolar = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Taza de euros:");
                    Taza = Convert.ToSingle(Console.ReadLine());
                    Cambio = Dolar / Taza;

                    Console.WriteLine("El cambio en euros es de:" + Cambio + ":\t euros");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Digite cantidad de euros:");
                    Euro = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Taza del Dolar:");
                    Taza = Convert.ToSingle(Console.ReadLine());
                    Cambio = Euro / Taza;

                    Console.WriteLine("El cambio en dolar es de:" + Cambio + ":\tDolares");
                    Console.ReadKey();
                    break;
            }
        }
    }
}