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
                Console.WriteLine(" D- Display the smallest number");
                Console.WriteLine("L- Display the largest number");
                Console.WriteLine("F- Enter Number to Find it ");
                Console.WriteLine("S- Sort Numbers in list");
                Console.WriteLine("R- Sort Numbers in list");
                Console.WriteLine(" Q - Quit");
                // string[] CharOfMenue = { "P", "A", "", "S", "L", "Q" };
                Console.WriteLine(" Chosse any char ");
                string C;
                C = Console.ReadLine().ToUpper();
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
                            Console.WriteLine("Mean is :" + Average);
                        }
                        break;
                    case "D":

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

                    case "F": // Sort
                        if (Menue.Count == 0)
                        {
                            Console.WriteLine("can't get any number menue is empty\n");
                        }
                        else if (Menue.Count >= 1)
                        {
                            Console.WriteLine("ENter Number to find it");
                            int FindNumber = int.Parse(Console.ReadLine());
                            if (Menue.Contains(FindNumber))
                            {
                                Console.WriteLine($" The  number is :[{FindNumber}] is found in our List you enterd!\n");
                            }
                            else
                                Console.WriteLine($"youer Number enterd({FindNumber}) is not found");
                        }
                        break;
                    case "S":
                        // Sort
                        if (Menue.Count == 0)
                        {
                            Console.WriteLine("can't get any number menue is empty\n");
                        }
                        else if (Menue.Count >= 1)
                            Menue.Sort();
                        Console.Write("[");
                        Console.Write(string.Join("/", Menue));
                        Console.Write("]\n");
                        break;  
                    //  Console.WriteLine(Menue);
                    case "R":
                        // Sort
                        if (Menue.Count == 0)
                        {
                     Console.WriteLine("can't get any number menue is empty\n");
                        }
                        else if (Menue.Count >= 1)
                            Menue.Reverse();
                        Console.Write("[");
                        Console.Write(string.Join("/", Menue));
                        Console.Write("]\n");
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




