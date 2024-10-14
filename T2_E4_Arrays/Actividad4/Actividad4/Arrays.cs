using System;
using System.Collections.Generic;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {

            if (array.Length == 0)
                return 0;

            int minimo = array[0];

            for (int i = 1; i<array.Length; i++){
                if (array[i] < minimo)
                {
                    minimo = array[i];
                }
            }

            return minimo;

            throw new NotImplementedException();
        }
        public static int[] invertirArray(int[] array)
        {
        
            // O
            // Array.Reverse(array);

            int[] arrayInvertido = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayInvertido[i] = array[array.Length-i-1];
            }

            return arrayInvertido;
            throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {

            //O se podria usar solamente 
            //return Array.IndexOf(array, valor);

            if (array.Length == 0) return -1;

            for (int i = 0; i < array.Length; i++)
            {
                if(valor == array[i])
                   return i;
            }

            return -1;
            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {
            var diccionarioModa = new Dictionary<int, int>();

            foreach (int i in entrada)
            {
                if (diccionarioModa.ContainsKey(i))
                {
                    diccionarioModa[i]++;
                }
                else
                {
                    diccionarioModa.Add(i, 1);
                }
            }

            int moda = 0;

            foreach (var item in diccionarioModa)
            {
                if(item.Value > moda)
                {
                    moda = item.Key;
                }
            }

            return moda;
            throw new NotImplementedException();
        }
    }
}
