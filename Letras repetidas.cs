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

    }
}
