using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Solve_Menue_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Menue = new List<int>();
            ;

            while (true)
            {
                Console.WriteLine(" P - Print numbers");
                Console.WriteLine(" A - Add a number");
                Console.WriteLine(" M - Display mean of the numbers");// متوسط
                Console.WriteLine(" S- Display the smallest number");
                Console.WriteLine("L- Display the largest number");
                Console.WriteLine(" Q - Quit");
                // string[] CharOfMenue = { "P", "A", "", "S", "L", "Q" };
                Console.WriteLine(" Chosse any char ");
                string C;
                C = Console.ReadLine().ToUpper() ;
                switch (C)
                {
                    case "P":

                        if (Menue.Count == 0)
                            Console.WriteLine("[] - the list is empty\n");

                        else
                        {
                            Console.WriteLine("[" + string.Join(", ", Menue) + "]\n");
                        }
                        break;


                    case "A":
                        Console.WriteLine("Enter the number of values you want to add:\n");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            for (int i = 0; i < num; i++)
                            {
                                Console.Write($"Enter number {i + 1}: \n");
                                if (int.TryParse(Console.ReadLine(), out int input))
                                {
                                    Menue.Add(input);
                                    Console.WriteLine($"{input} added\n");
                                }
                                else
                                {
                                    Console.WriteLine("invalid number, try again\n");
                                    i--; // retry this iteration
                                }
                            }
                            Console.WriteLine("your numbers entered are: [" + string.Join(", ", Menue) + "]\n");
                        }
                        else
                        {
                            Console.WriteLine("invalid input\n");
                        }
                        break;

                    case "M":

                        if (Menue.Count == 0)
                        {
                            Console.WriteLine("can't calculate mean  Menue is empty\n");
                        }
                        else if (Menue.Count >= 1)
                        {
                            double Average = Menue.Sum() / Menue.Count;
                            Console.WriteLine("Mean is :"+Average);
                        }
                        break;
                    case "S":

                        if (Menue.Count == 0)
                        {
                            Console.WriteLine("can't get any number menue is empty\n");
                        }
                        else if (Menue.Count >= 1)
                        {
                            int smallNumber = 0;
                            for (int i = 0; i < Menue.Count; i++)
                            {
                                if (smallNumber < i)
                                    smallNumber = i;
                                Console.WriteLine($"The smallest number is [{i}]\n");
                            }
                        }
                        break;
                    case "L":

                        if (Menue.Count == 0)
                        {
                            Console.WriteLine("can't get any number menue is empty\n");
                        }
                        else if (Menue.Count >= 1)
                        {
                            int largNumber = 0;
                            for (int i = 0; i < Menue.Count; i++)
                            {
                                if (largNumber > i)
                                    largNumber = i;
                                Console.WriteLine($" The largest number is :[{i}]\n");
                            }
                        }
                        break;
                    case "Q":
                        Menue.Clear();
                        break;

                    default:
                        Console.WriteLine(" invalid input\n");
                        break;
                }
            }

        }

    }
}
