using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num1, num2, producto;
            Console.WriteLine("Ingrese un número");
            num1= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            num2= Convert.ToInt16(Console.ReadLine());
            producto = calculo(num1,num2);
            Console.WriteLine("el producto de los numeros es {0}",producto);

       }
       static int productof = 0;
       public static int calculo(int numero1, int numero2)
       {
            for(int i = 1; i<= numero2; i++)
            {
                productof += numero1;
            }
            return productof;
       }
    }
}
