using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        public int[] getInput(int size){

           
            int[] array = new int[size];

            for(int i= 0;i < size ;i++){
                array[i] = Convert.ToInt16(Console.ReadLine());
 
            }
            return array;
        }


         public void output(int[] input)
             {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }}


        public void Process(int[] input){
                 bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            }
        static void Main(string[] args)
        {
            BubbleSortFunction a = new BubbleSortFunction();
          
           int size; 
            Console.WriteLine("Put amount of number ");
            size = Convert.ToInt16(Console.ReadLine());

            int[] array = a.getInput(size);
            a.Process(array);
            a.output(array);

            
            
                 Console.ReadKey();
            }
            
        }
    }

