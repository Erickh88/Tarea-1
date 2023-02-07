using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Matrices
{
    internal class Program
    {
       public static float num1, num2; // variable globales
        
        static void Main(string[] args)
        {

            int[,] matrix = new int  [3, 3];
            float sumatoria = 0; //variable local
            string opcion = "s"; //variable local
            int[,] matrix2 = new[,] { { 1, 20, 3 }, { 50, 4, 6 } };
            Console.WriteLine("***************Matrix 1********************");
            for (int f = 0; f < 3; f++) //filas
            {
                for (int c = 0; c < 3; c++)//columnas
                {
                    Console.Write(matrix[f,c]+"");
                }
                Console.WriteLine();
            }
            Console.WriteLine("******************MATRIX 2******************");
            for (int f = 0; f < 2; f++) //Filas
            {
                for (int c = 0; c < 3; c++) //columnas
                {
                    Console.Write(matrix2[f,c]+"");
                    sumatoria += matrix2[f, c];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumatoria = {0}", sumatoria);
            Console.WriteLine("Promedio {0}", sumatoria /=matrix2.Length);

            int op = 0;
            do
            {
                Console.WriteLine("1-SUMAR");
                Console.WriteLine("2-MULTIPLICAR");
                Console.WriteLine("3-RESTAR");
                Console.WriteLine("4-DIVIDIR.");
                Console.WriteLine("Digite una opción:...");
                op = int.Parse(Console.ReadLine());

                switch (op) 
                {
                    case 1:
                        SolicitarDatos();
                        Console.WriteLine("Total de la suma:{0}", num1 + num2);
                        break;
                    case 2:
                        SolicitarDatos();
                        Console.WriteLine("Total de la multiplicación:{0}", num1 * num2);
                        break;
                    case 3:
                        SolicitarDatos();
                        Console.WriteLine("Total de la resta:{0}", num1 - num2);
                        break;
                    case 4:
                        SolicitarDatos();
                        Console.WriteLine("Total de la divición:{0}", num1 / num2);
                        break;                                                              
                   
                }      

    } while (op!=4);

            while (opcion!="n")
            {
                Console.Write("Digite monto para el prestamo");
                float monto = float.Parse(Console.ReadLine());

                Console.Write("Digite su salario:");
                float salario = float.Parse(Console.ReadLine());

                if ((monto >= 100000) && (salario < 100000))
                {
                    Console.WriteLine("No se le puede prestar");
                }
                else if ((monto >= 100000) && (salario >= 100000))
                {
                    Console.WriteLine("Se le puede prestar a 6 meses");
                }
                else if ((monto < 100000) && (salario >= 100000))
                {
                    Console.WriteLine("Se le puede prestar a 24 meses");
                }

                Console.WriteLine("Desea continuar?...");
                opcion = Console.ReadLine();
       
                
            }

            Console.ReadLine();

        }
        private static void SolicitarDatos()
        {
            Console.WriteLine("Digite num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite num2");
            num2 = int.Parse(Console.ReadLine());

        }        
    }
}
