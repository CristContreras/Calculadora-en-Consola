using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string valor1, valor2;
            bool errorIngreso = false;
            int opcion=0;
            char reset = 'N';
            string[] operaciones = new string[] { "Suma", "Resta", "Multiplicacion", "División" };
            decimal resultado;
            #endregion Variables

            do
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("Calculadora para 2 valores \n--------------------------\n\nElija la operación deseada\n");
                    Console.WriteLine(" 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Dividir\n");
                    Console.Write("Opcion: ");
                    bool esEntero = Int32.TryParse(Console.ReadLine(), out opcion);
                    if ((!esEntero) || (opcion > 4) || (opcion < 1))
                    {
                        Console.WriteLine("\nError: Debe ingresar un numero o ingreso un número incorrecto");
                        System.Threading.Thread.Sleep(3000);
                        errorIngreso = true;
                        Console.Clear();
                    }
                    else
                    {
                        errorIngreso = false;
                    }

                } while (errorIngreso == true);


                Console.WriteLine("\n----------------------------");
                if((opcion == 1)||(opcion==2)||(opcion==3)||(opcion==4))
                {
                    Console.Write("\nOperación elegida: " + operaciones[opcion - 1]+"\n");
                }
                do
                {

                    Console.Write("\nIngrese el primer numero: ");
                    valor1 = Console.ReadLine();
                    verificarValor1(valor1);

                } while (errorIngreso != false);
                do
                {
                    Console.Write("\nIngrese el segundo numero: ");
                    valor2 = Console.ReadLine();
                    verificarValor2(valor2);
                } while (errorIngreso != false);

                void verificarValor1(string valor)
                {
                    try
                    {
                        Convert.ToDecimal(valor1);
                        errorIngreso = false;


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debe ingresar solo numeros");
                        errorIngreso = true;

                    }
                }

                void verificarValor2(string valor)
                {
                    try
                    {
                        Convert.ToDecimal(valor2);
                        errorIngreso = false;


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debe ingresar solo numeros");
                        errorIngreso = true;

                    }
                }


                switch (opcion)
                {
                    case 1:

                        resultado = decimal.Add(Convert.ToDecimal(valor1), Convert.ToDecimal(valor2));
                        Console.WriteLine("\nResultado: " + resultado.ToString());
                        break;
                    case 2:

                        resultado = decimal.Subtract(Convert.ToDecimal(valor1), Convert.ToDecimal(valor2));
                        Console.WriteLine("\nResultado: " + resultado.ToString());
                        break;
                    case 3:
                        resultado = decimal.Multiply(Convert.ToDecimal(valor1), Convert.ToDecimal(valor2));
                        Console.WriteLine("\nResultado: " + resultado.ToString());
                        break;
                    default:
                        resultado = decimal.Divide(Convert.ToDecimal(valor1), Convert.ToDecimal(valor2));
                        Console.WriteLine("\nResultado: " + resultado.ToString("0.#"));
                        break;
                    
                }
                Console.Write("\nDesea hacer otra operación? - Presione S para hacer otra operación, o N para terminar: ");
                reset = Convert.ToChar(Console.ReadLine());
                
            } while ((reset == 'S')||(reset=='s'));
        }   
    }
}
