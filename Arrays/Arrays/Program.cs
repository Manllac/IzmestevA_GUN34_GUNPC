﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Задание А
            //int[] fibonachi = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };

            //string[] month = new string[] { "January, February, March, April, May, June, July, August, September, October, November, December" };

            //int[,] a = new int[3, 3] {
            //    { 2, 3, 4 },     
            //    { 4, 9, 16 },    
            //    { 8, 27, 64 }    
            //};

            //double[][] array = new double[3][];
            //array[0] = new double[] { 1, 2, 3, 4, 5 };
            //array[1] = new double[] { Math.E, Math.PI };
            //array[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(100) };

            //// Задание Б
            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            //Array.Copy (array1 , array2, 3);
            //Console.WriteLine(array2[0]);
            //Console.WriteLine(array2[1]);
            //Console.WriteLine(array2[2]);

            //string[] sample = new string[] { " ", " " };
            //Array.Resize(ref array1, 10);
            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item + " ");
            //}


            // Задание 1

            int[] fibonachi = new int[8];

            fibonachi[0] = 0;
            fibonachi[1]= 1;

            for (int i =2; i<fibonachi.Length; i++)
            {
                fibonachi[i] = fibonachi[i-1] + fibonachi[i-2];
                Console.Write(fibonachi[i] + " ");
            }
            Console.WriteLine("\n");

            //Задание 2

            for (int i = 2; i<=20;i +=2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            //Задание 3 

            for (int i = 1; i <=5; i++)
            {
                for (int k = 1; k<=5; k++)
                {
                    Console.Write((i * k).ToString().PadLeft(3));
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //Задание 4

            string password = "qwerty";
            string userInput;

            do
            {
                Console.WriteLine("Enter the pssword:");
                userInput = Console.ReadLine();
                if (userInput != password)
                {
                    Console.WriteLine("Incorrect password!");
                }
            } while (userInput != password);
            Console.WriteLine("Password is correct!");
            
            Console.ReadKey ();
        }
    }
}
