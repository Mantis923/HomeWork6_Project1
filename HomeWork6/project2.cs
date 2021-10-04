
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class project2
    {

        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
          //  Reverse(numbers);
           
            PrintNumbers(numbers);
            
            Console.ReadLine();

        }
       
        static  void GenerateNumbers( int num )
        {
           int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
           
        }
        
       static void PrintNumbers( int []numbers)
        {


            foreach (int number in numbers);

            Console.WriteLine(numbers);
        } 

        /*
        static void Reverse(int[] a , int[]numbers)
        {
            int a = new int []numbers;



        }*/
    }
    
}
