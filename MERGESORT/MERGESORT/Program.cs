using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            word();
        }
        static void Result(int[] numba)
        {
            for(int i=0; i<numba.Length;i++)
            {
                Console.WriteLine(numba[i]);
            }
            Console.WriteLine();
        }
        static void MargeAndSort(int[] Numbers)
        {
            if (Numbers.Length <= 1) return;
            int middleNumber = Numbers.Length / 2;
            int[] leftNumbers = new int[middleNumber];
            int[] rightNumbers = new int[Numbers.Length - middleNumber];

            Array.Copy(Numbers, 0, leftNumbers, 0, middleNumber);
            Array.Copy(Numbers, middleNumber, rightNumbers, 0, Numbers.Length - middleNumber);

            MargeAndSort(leftNumbers);
            MargeAndSort(rightNumbers);
            FinalOutPut(leftNumbers, rightNumbers,Numbers);
        }
        static void FinalOutPut(int[] left, int[] right, int[] masterArray)
        {
            int x = 0;int y = 0; int z = 0;
            while(x<left.Length && y<right.Length)
            {
                if (left[x] <= right[y])
                {
                    masterArray[z] = left[x];
                    x++;
                }
                else

                {
                    masterArray[z] = right[x];
                    y++;
                }
                z++;
            } 
            
            while(x<left.Length)
            {
                masterArray[z] = left[x];
                x++;
                z++;
            }
            while(y<right.Length)
            {
                masterArray[z] = right[y];
                y++;
                z++;
            }
        }
        static void word()
        {
            string pass = "4676";
           
            for(int i =0;i<4;)
            {
                Console.WriteLine("Please Enter Your Password:");
                string password = Console.ReadLine();
                if (password==pass)
                {
                    Console.WriteLine("You are allowed to use this Program");
                    Nex();
                    break;
                }
                else
                {
                    Console.WriteLine("You are remainin with (0)", 4 - i, "Chances");
                    i++;
                }
            }
        }
        static void Nex()
        {
            Console.WriteLine("Enter the Number of Arrays to be stored in the Arrays less than 100: ");
            int option = int.Parse(Console.ReadLine());
            int[] Numbers = new int[option];
            for (int i = 0; i < Numbers.Length;)
            {
                if (option <= 100)
                {
                    Console.WriteLine("Kindly Enter the Number that needs to be entered:");
                    int nas = int.Parse(Console.ReadLine());
                    Numbers[i] = nas;
                    i++;
                }
                else
                {
                    Console.WriteLine("You are not in the range");
                }
            }

            Console.WriteLine("*********WELCOME TO THE NUMBER SORTING MACHINE*********");
            Console.WriteLine("Below are the Original numbers in the Array:");
            Result(Numbers);
            Console.WriteLine("The sorted numbers for the above digits are really as follows: ");
            MargeAndSort(Numbers);
            Result(Numbers);
        }
    } 
}
