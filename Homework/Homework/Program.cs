﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static int process(int i)
        {
            int result;
            if(i > 1)
            {
                result = i * process(i - 1);
            } else
            {
                result = 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int j;
            Console.Write("Put you number");
            j = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(process(j));
            Console.ReadKey();
        }
    }
}
