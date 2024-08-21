using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[,] mat = new int[2, 2];
            //Console.WriteLine("Enter Matrix elements: - ");
            //for(int i = 0; i < 2; i++)
            //{
            //    for(int j = 0; j < 2; j++)
            //    {
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(mat[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}



            //program to swap two matrices using 2D array: -
            //int[,] mat1 = new int[2, 2];
            //int[,] mat2 = new int[2, 2];
            //int[,] temp = new int[2, 2];
            //Console.WriteLine("Enter First Matrix Elements: - ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        mat1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Enter Secound Matrix Elements: - ");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        mat2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Before Swapping");
            //Console.WriteLine("First Matrix Elements:-");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(mat1[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}

            //Console.WriteLine("Secound Matrix Elements:-");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(mat2[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        temp[i, j] = mat1[i, j];
            //        mat1[i,j] = mat2[i, j];
            //        mat2[i,j] = temp[i, j];
            //    }
            //}

            //Console.WriteLine("After Swapping: - ");
            //Console.WriteLine("First Matrix Elements:-");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(mat1[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}

            //Console.WriteLine("Secound Matrix Elements:-");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(mat2[i, j]);
            //    }
            //    Console.WriteLine(" ");
            //}




            // Transpose of Matrix:-
            //    int[,] mat = new int[2, 2];
            //    int[,] trans = new int[2, 2];
            //    Console.WriteLine("Enter Matrix Elements: - ");
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            mat[i, j] = int.Parse(Console.ReadLine());
            //        }

            //    }

            //    Console.WriteLine("Matrix Elements: - ");
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            Console.Write(mat[i, j]);
            //        }
            //        Console.WriteLine(" ");
            //    }

            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            trans[j, i] = mat[i, j];
            //        }

            //    }

            //    Console.WriteLine();

            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            Console.Write(trans[i, j]);
            //        }
            //        Console.WriteLine(" ");
            //    }
            //}



            // Sum of two matrix:-
            int[,] mat1 = new int[2, 2];
            int[,] mat2 = new int[2, 2];
            int[,] temp = new int[2, 2];
            Console.WriteLine("Enter First Matrix Elements: - ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Secound Matrix Elements: - ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First Matrix Elements: - ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mat1[i, j]);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Secound Matrix Elements: - ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mat2[i, j]);
                }
                Console.WriteLine(" ");
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    temp[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            Console.WriteLine("Sum Matrix Elements: - ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(temp[i, j]);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
