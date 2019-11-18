using System;
using System.Collections;
using System.Collections.Generic;

namespace DatastructuresandAlgorithms
{
    public class CustomCollection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public new int Count()
        {
            return InnerList.Count;
        }

        public new void Clear()
        {
            InnerList.Clear();
        }
        static public void usingCollection()
        {
            CustomCollection names = new CustomCollection();
            names.Add("Joe");
            names.Add("Tay");
            names.Add("Falkor");
            names.Add("Pickels");

            foreach (object name in names)
            {
                Console.WriteLine($"{name}");
            }
            //Console.WriteLine($"The number of names is: {0}", names.Count());

        }
    }
}

