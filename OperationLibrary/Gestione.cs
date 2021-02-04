using System;
namespace OperationLibrary
{
    public class Gestione
    {
        public static int Somma(int a,int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
        public static int Sottrzzione(int a, int b)
        {
            int differnza = 0;
            differnza = a - b;
            return differnza;

        }
        public static int moltiplicazione(int a, int b)
        {
            int molt = a * b;
            return molt;
        }
        public static double divisione (double a,double b)
        {
          
          if (b==0)
          {
                return double.NaN;
          }
          else
          {
                double dividi = a / b;
                return dividi;
          }

           
        }
    }
}
