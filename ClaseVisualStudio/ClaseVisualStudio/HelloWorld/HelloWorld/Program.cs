using System;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    class Program
    {

       
        

        static void Main(string[] args)
        {

            double len2D;
            len2D = Geometry.GetVector2DLength(1.0, 1.0);

            Console.WriteLine("El vector mide " + len2D);

            double len3D;
            len3D = Geometry.GetVector3DLength(1.0, 1.0, 1.0);

            Console.WriteLine("El vector mide " + len3D);

            double AreaResultCircle;

            AreaResultCircle = Geometry.GetCircleArea(4.0);

            Console.WriteLine("El area del circulo es " + AreaResultCircle);

            double AreaResultRectangle;

            AreaResultRectangle = Geometry.GetRectangleArea(4.0, 5.0);

            Console.WriteLine("El area del rectángulo es " + AreaResultRectangle);

            int sol;

            sol = Utils.GetMinValue(1, 7);

            Console.WriteLine("El menor es " + sol);

            int sol2;

            sol2 = Utils.GetMaxValue(8, 9);

            Console.WriteLine("El mayor es " + sol2);

            bool sol3;

            sol3 = Utils.IsEven(4);

            Console.WriteLine("El numero introducido es: " + sol3);








        }
    }
}
