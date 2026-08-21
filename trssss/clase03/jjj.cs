using System;
using System.Collections.Generic;
using System.Text;

namespace trssss.clase03
{
    public class jjj
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("==EJERCICIO 16==");
            Console.WriteLine("========================");

            const string CLAVE_CORRECTA = "1234";

            Console.Write("Ingresa la contraseña: ");
            string claveIngresada = Console.ReadLine();

            if (claveIngresada == CLAVE_CORRECTA)
            {
                Console.WriteLine("Acceso permitido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }





            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 17====");
            Console.WriteLine("========================");

            Console.Write("Ingresa un año: ");
            int año = Convert.ToInt32(Console.ReadLine());

            if (año % 4 == 0)
            {
                Console.WriteLine("El año es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
            }


            Console.WriteLine("========================");
            Console.WriteLine("=EJERCICIO 18=");
            Console.WriteLine("========================");

            Console.Write("Ingresa el monto de la compra ($): ");
            double monto = Convert.ToDouble(Console.ReadLine());

            if (monto > 100)
            {
                double descuento = monto * 0.10;
                double totalConDescuento = monto - descuento;
                Console.WriteLine("Se aplicó un 10% de descuento. Total a pagar: $ " + totalConDescuento);
            }
            else
            {
                Console.WriteLine("Precio original sin descuento: $ " + monto);
            }


            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 19===");
            Console.WriteLine("========================");

            Console.Write("Ingresa el primer número entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine( " " + num1 + "es divisible exactamente entre " + num2);
            }
            else
            {
                Console.WriteLine( " " + num1 + "NO es divisible exactamente entre " + num2);
            }



            Console.WriteLine("========================");
            Console.WriteLine("====EJERCICIO 20===");
            Console.WriteLine("========================");

            Console.Write("Ingresa las horas trabajadas esta semana: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            if (horas > 40)
            {
                Console.WriteLine("Tiene horas extra");
            }
            else
            {
                Console.WriteLine("Jornada normal");
            }



            Console.WriteLine("========================");
            Console.WriteLine("====EJERCICIO 21===");
            Console.WriteLine("========================");

            Console.Write("Ingresa un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }


            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 22==");
            Console.WriteLine("========================");

            Console.Write("Ingresa el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else if (numero2 > numero3)
            {
                Console.WriteLine("El número mayor es: " + numero2);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + numero3);
            }






            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 23==");
            Console.WriteLine("========================");

            Console.Write("Ingresa la nota (0 a 100): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Calificación: A");
            }
            else if (nota >= 80)
            {
                Console.WriteLine("Calificación: B");
            }
            else if (nota >= 70)
            {
                Console.WriteLine("Calificación: C");
            }
            else if (nota >= 60)
            {
                Console.WriteLine("Calificación: D");
            }
            else if (nota >= 0)
            {
                Console.WriteLine("Calificación: F");
            }
            else
            {
                Console.WriteLine("Nota fuera del rango permitido.");
            }



            Console.WriteLine("========================");
            Console.WriteLine("====EJERCICIO 24==");
            Console.WriteLine("========================");

            Console.Write("Ingresa la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 0 && edad <= 12)
            {
                Console.WriteLine("Etapa: Niño");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Etapa: Adolescente");
            }
            else if (edad >= 18 && edad <= 64)
            {
                Console.WriteLine("Etapa: Adulto");
            }
            else if (edad >= 65)
            {
                Console.WriteLine("Etapa: Adulto mayor");
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }



            Console.WriteLine("========================");
            Console.WriteLine("====EJERCICIO 25====");
            Console.WriteLine("========================");

            Console.Write("Ingresa el primer número: ");
            double numer1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double numer2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nElige una opción (1-4):");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicación");
            Console.WriteLine("4: División");
            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Resultado: " + numer1 + numer2);
            }
            else if (opcion == 2)
            {
                Console.WriteLine($"Resultado: {numer1 - numer2}");
            }
            else if (opcion == 3)
            {
                Console.WriteLine($"Resultado: {numer1 * numer2}");
            }
            else if (opcion == 4)
            {
                if (numer2 != 0)    
                {
                    Console.WriteLine($"Resultado: {numer1 / numer2}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }



            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 26====");
            Console.WriteLine("========================");

            Console.Write("Ingresa un número del 1 al 7: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Miércoles");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Sábado");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Error: Número fuera del rango (1-7).");
            }




            Console.WriteLine("========================");
            Console.WriteLine("====EJERCICIO 27===");
            Console.WriteLine("========================");

            Console.Write("Ingresa el peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la estatura en metros (ej. 1.75): ");
            double estatura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (estatura * estatura);
            Console.WriteLine($"Tu IMC es: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Categoría: Bajo peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Categoría: Normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Categoría: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Categoría: Obesidad");
            }




            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 28===");
            Console.WriteLine("========================");

            Console.WriteLine("Seleccione el tipo de vehículo:");
            Console.WriteLine("1: Moto");
            Console.WriteLine("2: Auto");
            Console.WriteLine("3: Autobús");
            Console.WriteLine("4: Camión");
            Console.Write("Opción: ");
            int opction = Convert.ToInt32(Console.ReadLine());

            if (opction == 1)
            {
                Console.WriteLine("Monto a pagar: $2");
            }
            else if (opction == 2)
            {
                Console.WriteLine("Monto a pagar: $5");
            }
            else if (opction == 3)
            {
                Console.WriteLine("Monto a pagar: $10");
            }
            else if (opction == 4)
            {
                Console.WriteLine("Monto a pagar: $15");
            }
            else
            {
                Console.WriteLine("Opción de vehículo no válida.");
            }




            Console.WriteLine("========================");
            Console.WriteLine("===EJERCICIO 29===");
            Console.WriteLine("========================");

            Console.Write("Ingresa la longitud del lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la longitud del lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la longitud del lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es: Equilátero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es: Isósceles");
            }
            else
            {
                Console.WriteLine("El triángulo es: Escaleno");
            }


            Console.WriteLine("========================");
            Console.WriteLine("==EJERCICIO 30==");
            Console.WriteLine("========================");

            Console.Write("Ingresa el color del semáforo (rojo, amarillo, verde): ");
            string color = Console.ReadLine().ToLower();

            if (color == "rojo")
            {
                Console.WriteLine("Detenerse");
            }
            else if (color == "amarillo")
            {
                Console.WriteLine("Precaución");
            }
            else if (color == "verde")
            {
                Console.WriteLine("Avanzar");
            }
            else
            {
                Console.WriteLine("Color no válido para un semáforo.");
            }








        }
    }
}
