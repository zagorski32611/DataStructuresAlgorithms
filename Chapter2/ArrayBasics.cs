using System;

namespace DatastructuresandAlgorithms
{
    public class ArrayBasics
    {
        // Declare an array:
        //string[] arrayname;

        // put the datatype then []. After that you need to initialize the array with length:
        // arrayname = new string[10];

        // Declare in one line: 
        string[] names = new string[10];

        // You can also declare, instantiate and populate an array in one line too:

        int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };

        // Setting and accessing array elements:
        // You can set the specific index of an array with a value:

        //names[0] = "Tay";
        //numbers[0] = 1;

        // the SetValue method also works: 
        //names.SetValue(0, "Joe");
        /*
        It is common to loop through an array in order to access every array element
        using a For loop. A frequent mistake programmers make when coding the loop
        is to either hard-code the upper value of the loop (which is a mistake because
        the upper bound may change if the array is dynamic) or call a function that
        accesses the upper bound of the loop for each iteration of the loop:
        (for int i = 0; i <= sales.GetUpperBound(0); i++)
        totalSales = totalSales + sales[i];
        */

        // The Array class provides some useful built in functions for retreiving meta data: 
        // Length: Returns the total number of elements in all dimensions of an array.
        // GetLength: Returns the number of elements in specified dimension of an array.
        // Rank: Returns the number of dimensions of an array.
        // GetType: Returns the Type of the current array instance.

        public void firstExample()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4 };

            Type arrayType = numbers.GetType();

            if (arrayType.IsArray)
            {
                Console.WriteLine($"The array type is: {0}", arrayType);
            }
            else
            {
                Console.WriteLine($"Not an array. It's: {0}", arrayType);
            }
        }

        public void MultiDimensionalArray()
        {
            // Arrays can have up to 32 dimensions. This is extremely rare. You'll only see 2 to 3 dimensional arrays in nature:
            int[,] grades = new int[4, 5];
            // grades consists of 4 rows and 5 columns
            // here's how to initiate and populate a 2-D array:
            int[,] listofgrades = new int[,]{
                                                {1, 82, 74, 89, 100},
                                                {2, 93, 96, 85, 86},
                                                {3, 83, 72, 95, 89},
                                                {4, 91, 98, 79, 88}
                                            };
        }

        public void ParameterArrays()
        {
            //
        }
    }
}