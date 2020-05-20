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





    
    