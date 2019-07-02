using System;

namespace Vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = {0, 2, 4, 6, 8, 10};
            int requerido = 4;
            int n;
            for ( n = 0 ; n <=5 ; n++) {
                if (numeros[n] == requerido){
                Console.WriteLine (n);
                }
            }
        }
    }
}
