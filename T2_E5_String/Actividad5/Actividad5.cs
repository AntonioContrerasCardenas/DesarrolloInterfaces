using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            return String.Join("", vs);

            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {

            Array.Sort(vs);
            return String.Join("",vs);
            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {

            int contador = 0;


            foreach (var item in vs)
            {
                for (int i = 0; i < item.Length; i++)
                {

                    if(item[i] == v)
                    {
                        contador++;
                    }
                    
                }
            }


            return contador;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            if(vs1.Length != vs2.Length) 
                return new int[vs1.Length];

            int[] result = new int[vs2.Length];

            for (int i = 0; i < vs1.Length; i++)
            {
                result[i] = vs1[i] + vs2[i];
            }

            return result;

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            if (vs1.Length != vs2.Length)
                return new int[vs1.Length];

            int[] result = new int[vs2.Length];

            for (int i = 0; i < vs1.Length; i++)
            {
                result[i] = vs1[i] * vs2[i];
            }

            return result;

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            string entradaLimpia = entrada.ToLower().Replace(" ","");

            int i = 0;
            int j = entradaLimpia.Length - 1;

            while (i < j)
            {
                if (entradaLimpia[i] != entradaLimpia[j])
                    return false;
                i++;
                j--;
            }

            return true;

            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            if(entrada.Length == 0) return 0;

            string[] entradaS = entrada.Split(" ");
            return entradaS.Length;

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            if (entrada.Length == 0) return 0;

            entrada = entrada.Replace(" ", "");

            return entrada.Length;

            throw new NotImplementedException();
        }
    }
}
