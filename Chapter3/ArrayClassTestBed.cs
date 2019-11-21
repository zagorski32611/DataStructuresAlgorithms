using System;

namespace DatastructuresandAlgorithms
{
    public class CArray
    {
        private int[] arr;
        private int arrSizeMinusOne;
        private int numElements;

        public CArray(int size)
        {
            arr = new int[size];
            arrSizeMinusOne = size - 1;
            numElements = 0;
        }

        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i <= arrSizeMinusOne; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        public void Clear()
        {
            for (int i = 0; i <= arrSizeMinusOne; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }

        public static void newArray()
        {
            // This code with randomly assign numbers to the array:
            CArray nums = new CArray(5);
            Random rnd = new Random(100);

            for (int i = 0; i < 5; i++)
            {
                nums.Insert((int)(rnd.NextDouble() * 100));
            }
            
            Console.WriteLine("New Array:");
            nums.DisplayElements();

            Console.WriteLine("Bubble Sorting:");
            nums.BubbleSort();

            Console.WriteLine("After Bubble Sorting:");
            nums.DisplayElements();

            
            for (int i = 0; i < 5; i++)
            {
                nums.Insert((int)(rnd.NextDouble() * 100));
            }


            Console.WriteLine("New array:");
            nums.DisplayElements();

            Console.WriteLine("Selection Sort:");
            nums.SelectionSort();
            nums.DisplayElements();

            for (int i = 0; i < 5; i++)
            {
                nums.Insert((int)(rnd.NextDouble() * 100));
            }
            Console.WriteLine("New Array:");
            nums.DisplayElements();

            Console.WriteLine("Insertion Sort:");
            nums.InsertionSort();
            nums.DisplayElements();


        }

        public void BubbleSort()
        {
            int temp;
            for (int outer = arrSizeMinusOne; outer >= 1; outer--)
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


        public void SelectionSort()
        {
            int smallest;
            int temp;

            for (int outer = 0; outer <= arrSizeMinusOne; outer++)
            {
                smallest = outer;
                for(int inner = outer + 1; inner <= arrSizeMinusOne; inner++)
                {
                    if(arr[inner] < arr[smallest])
                    {
                        smallest = inner;
                    }

                    temp = arr[outer];
                    arr[outer] = arr[smallest];
                    arr[smallest] = temp;
                }
            }
        }

        public void InsertionSort()
        {
            int inner;
            int temp;
            for (int outer = 1; outer <= arrSizeMinusOne; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
            }
        }
    }
}