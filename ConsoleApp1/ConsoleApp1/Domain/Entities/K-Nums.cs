using System.Numerics;

namespace ConsoleApp1.Domain.Entities
{
    public struct K_Nums
    {
        public double Real;   
        public double Imag;

        public K_Nums(double r,double i) 
        {
            Real = r;
            Imag = i;
        }
        public static K_Nums operator+(K_Nums a,K_Nums b)
        {
            return new K_Nums(a.Real + b.Real, a.Imag + b.Imag);
        }
        public static K_Nums operator -(K_Nums a, K_Nums b)
        {
            return new K_Nums(a.Real - b.Real, a.Imag - b.Imag);
        }
        public static K_Nums operator/(K_Nums a, K_Nums b)
        {
            return new K_Nums(a.Real / b.Real, a.Imag / b.Imag);
        }
        public static K_Nums operator *(K_Nums a, K_Nums b)
        {
            return new K_Nums(a.Real * b.Real, a.Imag * b.Imag);
        }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
