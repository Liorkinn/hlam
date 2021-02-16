using System;

namespace ClassLibrary3
{
    public class Class1
    {
        public class Liora
        {
            public double Calc(double a, double b, double c, double x)
            {

                if ((c < 0) && (b != 0)) //2
                {
                    return (a * Math.Pow(x, 2)) + (Math.Pow(b, 2) * x);

                } //3
                else if ((c > 0) && (b == 0)) //5
                {
                    return (x + a) / (x + c);
                }//6
                else //7
                {
                    return (a * x) / (c * Math.Pow(b, 2));
                } //8
            }
        }
    }
}
