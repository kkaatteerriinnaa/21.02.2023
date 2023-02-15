using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc[] arr = new ICalc[10];
            Random n = new Random();
            int valueToCompare = 25;
            for (int i =0;i<arr.Length;i++)
            {
                arr[i] = n.Next(1, 100);
            }
            foreach (ICalc a in arr)
            {
                a.Less(int valueToCompare);
                a.Greater(int valueToCompare);
                Console.WriteLine("Меньше"+a.Less);
                Console.WriteLine("Больше" + a.Greater);
            }
            foreach (IOutput2 a in arr)
            {
                a.ShowEven();
                a.ShowOdd();
            }
            foreach (IOutput2 a in arr)
            {
                a.CountDistinct();
                a.EqualToValue(int valueToCompare);
            }
        }
    }

    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
        int Count { get; set; }
    }
    class Array : ICalc
    {
        int count;
        public Array(int a)
        {
            count = a;
        }
        public int Less(int valueToCompare)
        {
            count++;
            return count;
        }
        public int Greater(int valueToCompare)
        {
            count++;
            return count;
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
    }
    class Array2 : IOutput2
    {
        int even;
        int odd;
        public Array2(int a, int b)
        {
            even = a;
            odd = b;
        }
        public int Even
        {
            get
            {
                return even;
            }
            set
            {
                even = value;
            }
        }
        public int Odd
        {
            get
            {
                return odd;
            }
            set
            {
                odd = value;
            }
        }
        void ShowEven()
        {
            Console.Write(even + " ");
        }
        void ShowOdd()
        {
            Console.Write(odd + " ");
        }
    }
    class Array3 : ICalc2
    {
        int count;
        int equal;
        public Array3(int a, int b)
        {
            count = a;
            equal = b;
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int Equal
        {
            get
            {
                return equal;
            }
            set
            {
                equal = value;
            }
        }
        int CountDistinct()
        {
            count ++;
            return count;
        }
        int EqualToValue(int valueToCompare)
        {
            equal++;
            return equal;
        }

    }
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
        int Even { get; set; }
        int Odd { get; set; }
    }

    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
        int Even { get; set; }
        int Odd { get; set; }
    }
}
