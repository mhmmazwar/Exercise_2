﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{

    class Program
    {
        
        int[] arr = new int[20];

        int n;
        
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of the element in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("----------------------");

            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

       
        }
    }
}