using System;

namespace DatastructuresandAlgorithms
{
    public class PlaceholderDataType
    {
        /*
        Placeholder is the use of a Generic Data Type that lets you pass in any type of data and the
        system will know what to do with it. Instead of declaring everything's type, i.e. int, string, float,
        you can call it a generic type, for example in Swap<T>, the <T> is a generic type and the arguments are
        "ref" meaning you're referring to a generic object (with no type).
        */
        public static void place_and_swap()
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");

            Swap<int>(ref num1, ref num2);

            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");

            string str1 = "Joint";
            string str2 = "Bong";

            Console.WriteLine($"string 1: {str1}");
            Console.WriteLine($"string 2: {str2}");

            Swap<string>(ref str1, ref str2);

            Console.WriteLine($"string 1: {str1}");
            Console.WriteLine($"string 2: {str2}");

        }

        // The ol' switch-a-roo
        static void Swap<T>(ref T val1,
                            ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }

    /*
        You can also create Generic Classes as well. The class definition will contain a generic type placeholder, T,
        after the class name: Node<T>
        Any time the class is referenced, you have to pass in the type placeholder:
    */
    public class Node<T>
    {
        T data;
        Node<T> link;
        public Node(T data, Node<T> link)
        {
            this.data = data;
            this.link = link;
        }

        // Implementing this class: 

        Node<string> node1 = new Node<string>("Joe", null);
        Node<string> node2 = new Node<string>("Taylor", node1);
    }
}