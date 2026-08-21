using System;
using System.Collections.Generic;
using System.Text;

namespace trssss.clase02
{
    public class uno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("=EJERCICIO 1=");
            Console.WriteLine("========================");
            string nombre = " Mayte";
            Console.WriteLine("Bienvenido a Programación II," + nombre);



            Console.WriteLine("========================");
            Console.WriteLine("EJERCICIO 2");
            Console.WriteLine("========================");
            const double PI = 3.14159;
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            double area = PI * Math.Pow(radio, 2);
            Console.WriteLine("El área del círculo es: " + area );



            Console.WriteLine("========================");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("========================");

            Console.Write("Ingrese su año de nacimiento: ");
            int añoNacimiento = int.Parse(Console.ReadLine());
            int añoActual = DateTime.Now.Year;

            int edad = añoActual - añoNacimiento;
            Console.WriteLine($"Su edad aproximada es: {edad} años");



            Console.WriteLine("========================");
            Console.WriteLine("EJERCICIO 4");
            Console.WriteLine("========================");
            const double IVA = 0.13;
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            double precioFinal = precio + (precio * IVA);
            Console.WriteLine("El precio final con IVA (13%) es: " + precioFinal);




            Console.WriteLine("========================");
            Console.WriteLine("EJERCICIO 5");
            Console.WriteLine("========================");
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Suma: " + num1 + num2);
            Console.WriteLine($"Resta: " {num1 - num2}");
            Console.WriteLine("Multiplicación: " + num1 * num2);
            Console.WriteLine("División: " + num1 / num2);



            Console.WriteLine("========================");
            Console.WriteLine("EJERCICIO 6");
            Console.WriteLine("========================");
            Console.Write("Ingrese la nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio final es:" + promedio );




            Console.WriteLine("========================");
            Console.WriteLine("EJERCICIO 7");
            Console.WriteLine("========================");
            int a = 5;
            int b = 10;
            int intercambio = a;
            a = b;
            b = intercambio;

            Console.WriteLine($"Ahora 'a' vale: {a} y 'b' vale: {b}");




            Console.WriteLine("========================");
            Console.WriteLine("=EJERCICO 8=");
            Console.WriteLine("========================");
            Console.Write("Ingresa la temperatura en Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Usamos 9.0 / 5.0 para asegurar divisiones con decimales exactos
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit);



            Console.WriteLine("========================");
            Console.WriteLine("=EJERCICIO 9=");
            Console.WriteLine("========================");
            Console.Write("Ingresa la cantidad total de minutos: ");
            int minutosTotales = Convert.ToInt32(Console.ReadLine());

            int horas = minutosTotales / 60;
            int minutosRestantes = minutosTotales % 60;

            Console.WriteLine($"Equivale a: {horas} hora(s) y {minutosRestantes} minuto(s).");


            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 10===");
            Console.WriteLine("========================");
            Console.Write("Ingresa el primer número (dividendo): ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número (divisor): ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int residuo = numero1 % numero2;

            Console.WriteLine("El residuo de dividir " + numero1 + " " + "entre " + numero2 + " " + "es:" + residuo);




            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 11===");
            Console.WriteLine("========================");
            Console.Write("Ingresa tu edad: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }




            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 12===");
            Console.WriteLine("========================");
            Console.Write("Ingresa un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }



            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 13===");
            Console.WriteLine("========================");

            Console.Write("Ingresa el primer número: ");
            int numer1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int numer2 = Convert.ToInt32(Console.ReadLine());

            if (numer1 > numer2)
            {
                Console.WriteLine($"El número mayor es: {numer1}");
            }
            else if (numer2 > numer1)
            {
                Console.WriteLine($"El número mayor es: {numer2}");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }





            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 14===");
            Console.WriteLine("========================");

            Console.Write("Ingresa un número: ");
            double numro = Convert.ToDouble(Console.ReadLine());

            if (numro > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numro < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }



            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 15===");
            Console.WriteLine("========================");

            Console.Write("Ingresa la nota final (1 al 100): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 51)
            {
                Console.WriteLine("Aprobado.");
            }
            else
            {
                Console.WriteLine("Reprobado.");
            }



        }
    }
}
