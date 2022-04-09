using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a la Calculadora. By: Pablo Morales");
            double resu;
            char operacion;
            int num1, num2;

            Console.Write("Por favor ingresa el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Por favor ingresa la operacion a realizar ['+' , '-' , '*' , '/']: ");
            operacion = char.Parse(Console.ReadLine());

            Console.Write("Por favor ingresa el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());


            switch (operacion)
            {
                case '+':
                    resu = num1 + num2;
                    Console.WriteLine("El Resultado de la suma es: " + resu);
                    break;

                case '-':
                    resu = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resu);
                    break;

                case '*':
                    resu = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es: " + resu);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        resu = (double)num1 / num2;
                        Console.WriteLine("El resultado de la division es: " + resu);
                    }
                    else
                    {
                        Console.WriteLine("ERROR! no se puede dividir por cero.");
                    }
                    break;

                default:
                    Console.WriteLine("ERROR! Operacion invalida");
                    break;
            }
        }
    }
}
