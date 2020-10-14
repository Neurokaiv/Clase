

using System;

namespace HelloWorld
{
    class Ejercicios
    {

        // Ejercicio: Haz una funcion que imprima por pantalla 
        // Los numeros desde el 0 hasta el 99

        public static void Ejercicio01()

        {
            int contador = 0;
            while(contador < 100)
            {
                System.Console.WriteLine(contador);
                contador ++ ;

               
            }

        }
        public static void Ejercicio02()

        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i);
                i++;


            }
        
        }
        
        public static void Ejercicio03()

        {
            int i = 0;
            while(i < 100)

            {
                System.Console.WriteLine(i + i);
                i++ ;
            }


        }

        public static void Ejercicio04()

        {

            int i = 0;
            while (i < 100)
            {

                System.Console.WriteLine(i * 3 + 1);
                i++ ;
            }
        }
        
        public static void Ejercicio05()

        {
            int i = 0;
            while (i < 100)

            {
                System.Console.WriteLine(i * i);
                i++;


            }

        }
        

        public static void Ejercicio06()

        {
            int i = 0;
            while (i < 100)

            {
                

                if (Utils.IsEven(i))
                {
                    System.Console.WriteLine(-i);

                }
                else
                {

                    System.Console.WriteLine(i);
                }
                i++;
            }

     
        
        }
   
        public static void Ejercicio07()

        {
            int i = 0;
            int a=1;
            int aa=0;

           while (i<100)
            {

                System.Console.WriteLine(a+aa);
                int aux = aa;
                aa = a;
                a = a + aux;


                i++;
            }



        }
    
    
    }

}
