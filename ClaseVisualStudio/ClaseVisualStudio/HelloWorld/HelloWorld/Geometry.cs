

using System.IO.Compression;

namespace HelloWorld
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {

            double aux2D;
            double length2D;
            aux2D = (x * x) + (y * y);
            length2D = System.Math.Sqrt(aux2D);
            return length2D;
        
        
        
        
        }

        public static double GetVector3DLength(double x, double y,double z)
        {

            double aux3D;
            double length3D;
            aux3D = (x * x) + (y * y) + (z * z);
            length3D = System.Math.Sqrt(aux3D);
            return length3D;

        }


        public static double GetCircleArea(double r)
        {
            double AreaCircle;
            AreaCircle = System.Math.PI * r * r;
            return AreaCircle;
        
        
        
        }

        public static double GetRectangleArea(double width, double heigth)
        {
            double AreaRectangle;
            AreaRectangle = width * heigth;
            return AreaRectangle;
;        
        }

        public static double GetEllipseArea(double width2,double heigth2)
        {
            double AreaEllipse;
            AreaEllipse = System.Math.PI * (width2/2) * (heigth2/2);
            return AreaEllipse;
        
        }

    }
}
