using System;

namespace DatastructuresandAlgorithms
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }

        public static void newArray()
        {
            // This code does not randomly assign an integer to an index. There's nothing to search, it's in order:
            //CArray nums = new CArray(50);
            //for (int i = 0; i <= 49; i++)
            //{
            //    nums.Insert(i);
            //}
            //nums.DisplayElements();

            // This code with randomly assign numbers to the array:
            CArray nums = new CArray(10);
            Random rnd = new Random(100);

            for (int i = 0; i < 10; i++)
            {
                nums.Insert((int)(rnd.NextDouble() * 100));
            }
            
            Console.WriteLine("Before Sorting:");
            nums.DisplayElements();

            Console.WriteLine("During Sorting:");
            nums.BubbleSort();

            Console.WriteLine("After Dorting:");
            nums.DisplayElements();
            
        }

        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                this.DisplayElements();
            }
        }

        
    }
}