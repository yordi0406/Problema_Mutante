# Problema_Mutante
Problema 
Estos son los codigos a revisar
using System;
using System.Dynamic;

namespace Problema_Mutante
{
    class Programn
    {
        static void Main(string[] args)
        {
            Letras_repetidas frecuencia = new Letras_repetidas();

           
            string[,] matrizPrincipal = new[,] { { "A", "T", "G", "C", "G","A"}, { "C", "A", "G", "T", "A","C"},

                                                  { "C", "T", "A", "T", "G","T"},{ "A", "C", "A", "A", "G","G"},

                                                  { "T", "C", "C", "C", "T","A"},{ "T", "C", "A", "C", "T","G"} };

             string[] fila = new string[matrizPrincipal.GetLength(0)];


            for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrincipal.GetLength(0); j++)
                {
                    Console.Write(" " + matrizPrincipal[i, j]);
                }
                Console.WriteLine();
            }

            int sumahorizontal = 0;
            //Calculo Horizontal
            for  (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrincipal.GetLength(0); j++)
                {
                    fila[j] = matrizPrincipal[i, j];
                    //Console.WriteLine(" el resultado horizontal es " + fila[i]); 
                    
                }
                Console.WriteLine(frecuencia.ConteoLetras(fila));
                sumahorizontal = sumahorizontal + frecuencia.ConteoLetras(fila);
            }

            Console.WriteLine("El total Horizontal es " + sumahorizontal);

            for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrincipal.GetLength(0); j++)
                {
                    Console.Write(" " + matrizPrincipal[i, j]);
                }
                Console.WriteLine();
            }

            //Calculo Diagonal

            int sumadiagonalabajo = 0;
            int sumadiagonalArriba = 0;


            for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrincipal.GetLength(0); j++)
                {
                    fila[i] = matrizPrincipal[i, i];
                }

            }

            //for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            //{
            //    fila[i] = matrizPrincipal[i, i];
               

            //}
            //Console.WriteLine(frecuencia.ConteoLetras(fila));
            //sumadiagonal = sumadiagonal + frecuencia.ConteoLetras(fila);
            //Console.WriteLine(" El total Diagonal es " + sumadiagonal);
            for (int x= 0; x<3; x++)
            {
                for (int i = 0; i < (matrizPrincipal.GetLength(0) - x); i++)
                {
                    int a = i + x;
                    fila[i] = matrizPrincipal[a, i];
                    Console.WriteLine( " " + fila[i]);

                }
                Console.WriteLine(frecuencia.ConteoLetras(fila));
                sumadiagonalabajo = sumadiagonalabajo + frecuencia.ConteoLetras(fila);
                Console.WriteLine(" El total DiagonalAbajo es " + sumadiagonalabajo);
            }
            for (int x = 1; x < 3; x++)
            {
                for (int i = 0; i < (matrizPrincipal.GetLength(0) - x); i++)
                {
                    int a =  x +i;
                    fila[i] = matrizPrincipal[i, a];
                    Console.WriteLine(" " + fila[i]);

                }
                Console.WriteLine(frecuencia.ConteoLetras(fila));
                sumadiagonalArriba = sumadiagonalArriba + frecuencia.ConteoLetras(fila);
                Console.WriteLine(" El total DiagonalArriba es " + sumadiagonalArriba);
            }


            //Console.WriteLine(frecuencia.ConteoLetras(fila));
            //sumadiagonal = sumadiagonal + frecuencia.ConteoLetras(fila);
            //Console.WriteLine(" El total Diagonal es " + sumadiagonal);


            //Console.WriteLine(frecuencia.ConteoLetras(fila));
            //sumadiagonal = sumadiagonal + frecuencia.ConteoLetras(fila);
            //Console.WriteLine(" El total Diagonal es " + sumadiagonal);


            for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPrincipal.GetLength(0); j++)
                {
                    Console.Write(" " + matrizPrincipal[i, j]);

                }
                Console.WriteLine();
            }

            //calculo Vertical

            int sumavertical = 0;

            for (int j = 0; j < matrizPrincipal.GetLength(1); j++)
            {
                for (int i = 0; i < matrizPrincipal.GetLength(1); i++)
                {
                    fila[i] = matrizPrincipal[i, j];
                    //Console.WriteLine(" el resultado horizontal es " + fila[i]);
                }
                Console.WriteLine(" " + frecuencia.ConteoLetras(fila));
                sumavertical = sumavertical + frecuencia.ConteoLetras(fila);
            }

            Console.WriteLine( " El total Vertical es " + sumavertical );

            int sumaMutante = sumahorizontal + sumadiagonalArriba + sumavertical+ sumadiagonalabajo;

            if (sumaMutante > 1)
            {
                Console.WriteLine(" ES UN MUTANTE " );
            }
            else
            {
                Console.WriteLine(" ES HUMANO " );
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Problema_Mutante
{
    class Letras_repetidas
    {
        public int  ConteoLetras(string[] datos)
        {            
            string[] lista = new string[datos.Length];
           
            int valormutante = 0;

            for (int i = 0; i < datos.Length; i++)
            {
                int contador = 0;


                for (int j = 0; j < datos.Length; j++)
                {
                    if (datos[i] == datos[j] )
                    {
                        contador++;


                        if (numero(datos[i]))
                        {
                            lista[i] = datos[i];
                        }
                    }
                }
                if (lista[i] != " " ^ contador <4)
                {
                    valormutante = 1;
                   
                }
                
            }
        
            bool numero(string num)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] == num)
                    {
                        return false;
                    }

                }
                return true;
            }

            return valormutante;

        }
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problema_Mutante
{
    class MatrizVH:Letras_repetidas
    {
        public void CalculoMatriz()
        {

            string[] fila = new string[] { };

            string[,] matrizPrincipal = new string[,] { };

            
            for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {

                int contador = 0;
                contador = contador + i;
                fila[i] = matrizPrincipal[i, 0];

                Console.WriteLine(" el resultado horizontal es " + fila[i]);

            }
            for (int i = 0; i < matrizPrincipal.GetLength(0); i++)
            {
                fila[i] = matrizPrincipal[i, i];
                Console.WriteLine(" el resultado matriz diagonal  es " + fila[i]);
            }
            for (int j = 0; j < matrizPrincipal.GetLength(1); j++)
            {
                fila[j] = matrizPrincipal[1, j];
                Console.WriteLine(" el resultado vertical es " + fila[j]);
            }
        }
    }
}




