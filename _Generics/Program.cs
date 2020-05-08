using System;
using System.Linq;
using System.Collections.Generic;

namespace _Generics
{
    class MyClassX<T>
    {

    }
    class Program
    {
        static void PrintItems<T>(List<T> items)
        {
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine(items.GetItem(i));
        }

        
        static void Main(string[] args)
        {
            // Type inference works on methods not on class types.
            // like PrintItems(intItems) can be called without the type but 
            //var mc = new MyClassX();//  Using the generic type 'MyClassX<T>' requires 1 type arguments  but the one below works
            var mc = new MyClassX<int>();

            //List<int> intItems = new List<int>();
            //intItems.Add(1);
            //intItems.Add(2);
            //intItems.Add(3);

            //PrintItems(intItems);

            //List<string> strItems = new List<string>();
            //strItems.Add("test1");
            //strItems.Add("test2");
            //strItems.Add("test3");

            //PrintItems(strItems);

            ProduceA<MyClass2>();
            ProduceA<MyClass1>();

            Console.ReadLine();
        }

        /// <summary>
        ///  Generic Constraints
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>

        static T ProduceA<T>() where T : MyClass2, new()
        {
            T value = new T();
            return value;
        }

        class MyClass { public MyClass() { } }
        class MyClass2 : MyClass { public MyClass2() { } }

        class MyClass1 : MyClass2 { public MyClass1() { } }


        /// <summary>
        /// Basic generics
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class List<T>
        {
            T[] items = new T[3];
            private int currentIndex;

            public void Add(T item)
            {
                if (currentIndex == items.Length)
                    Grow();

                items[currentIndex++] = item;
            }
            public T GetItem(int index)
            {
                return items[index];
            }
            private void Grow()
            {
                T[] temp = new T[items.Length * 2];
                Array.Copy(items, temp, items.Length);
                items = temp;
            }

            public int Length
            {
                get { return items.Length; }
            }
        }
    }
}
