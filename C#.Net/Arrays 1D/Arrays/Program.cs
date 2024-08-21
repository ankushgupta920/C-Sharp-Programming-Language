using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[] arr = new int[5];
            //Console.WriteLine("Enter the array elements:- ");
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Array elements:- ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //}



            //program to insert element at any position of array:-
            //int[] arr = new int[100];
            //int size, pos, item;
            //Console.WriteLine("Enter the size of array:- ");
            //size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the array elemnets:- ");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter the position:- ");
            //pos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the element:- ");
            //item = int.Parse(Console.ReadLine());
            //for(int i = size; i>=pos; i--)
            //{
            //    arr[i] = arr[i - 1];
            //}
            //arr[pos-1] = item;
            //size++;
            //Console.WriteLine("Resultant Array is:- ");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(arr[i]);
            //    Console.Write(" ");
            //}



            // find the max:-
            //int[] arr = new int[100];
            //int size, max;
            //Console.WriteLine("Enter the size of array elements:- ");
            //size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Array elements:- ");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine("Max:- " + max);


            // Ascending :-
            int[] arr = new int[5];
            int temp;
            Console.WriteLine("Enter the array elements: - ");
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for(int j = i+1; j<5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array elements are: - ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
