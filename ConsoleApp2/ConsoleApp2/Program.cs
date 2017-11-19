using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{    
    class MyArr
    {
        int[,] arr;
        public int rows, cols;
        public int Length;

        public MyArr(int rows,int cols)
        {
            this.rows = rows;
            this.cols = cols;
            arr = new int[this.rows, this.cols];
            Length = rows * cols;
        }
        public int this[int index1,int index2]
        {
            set
            {
                arr[index1, index2] = value;
            }
            get
            {
                return arr[index1, index2];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.WriteLine("Arr1: \n");
            MyArr arr1 = new MyArr(4,5);
            for (int i=0;i<arr1.rows;i++)
            {
                for (int j=0;j<arr1.cols;j++)
                {
                    arr1[i, j] = ran.Next(1, 20);
                    Console.Write(arr1[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
