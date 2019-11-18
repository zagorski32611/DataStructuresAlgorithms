using System;
using System.Collections;
using System.Collections.Generic;

namespace DatastructuresandAlgorithms
{
    public class Question2 : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Remove(Object item)
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


        public void Insert(object item)
        {
            int maxIndex = InnerList.LastIndexOf(InnerList);
            InnerList.Insert(maxIndex, item);
        }

        public object Contains(object item)
        {
            var search = SearchFunction(item);
            if (search == item)
            {
                return search;
            }
            else
            {
                return "Cannot find object";
            }
        }

        public object IndexOf(object item)
        {
            var searchresult = SearchFunction(item);
            if (searchresult == item)
            {
                return searchresult;
            }
            else
            {
                return "Cannot find object";
            }
        }

        public void RemoveAt(object item)
        {
            var index = InnerList.IndexOf(item);
            InnerList.RemoveAt(index);
        }


        public object SearchFunction(object item)
        {
            for (int i = 0; i < InnerList.Count; i++)
            {
                var x = InnerList[i];
                if (item == x)
                {
                    return InnerList.IndexOf(x);
                }
            }
            return "Cannot find object";
        }

        static public void usingCollection()
        {
            Question2 names = new Question2();
            names.Add("Joe");
            names.Add("Tay");
            names.Add("Falkor");
            names.Add("Pickels");

            var pick = names.IndexOf("Pickels");

            Console.WriteLine($"{pick}");

            //foreach(object name in names)
            //{
            //    Console.WriteLine($"{name}");
            //}
            //Console.WriteLine($"The number of names is: {0}", names.Count());

        }
    }
}

/*
Old Contains Function
            foreach(var x  in InnerList)
            {
                if(item == x)
                {
                    return item;
                }
                else
                {
                    continue;
                }
            }
            return "Cannot find object";
*/
