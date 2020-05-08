using System;
using System.Collections;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        delegate double CalAreaPointer(int i);
        delegate bool MyDelegate(int i);
        static bool GreaterThan5(int i) { return i > 5; }
        static void Main(string[] args)
        {
            var values = new[] { 5, 6, 3, 7, 8, 9 };
            IEnumerable<int> filtered = RunNumbersThroughGautlet(values, GreaterThan5); //bool GreaterThan5(int i) { return i > 5; } equals  i => i > 5
            foreach (var item in filtered)
            {
                Console.WriteLine(item);

            }


            #region DELEGATE IN C#

            var myClass = new MyClass();
            myClass.LongRunnigMethod(CallBack);
       

            CalAreaPointer calAreaPointer = new CalAreaPointer(
                delegate (int i) { return i * i; });

            Console.WriteLine(calAreaPointer(5));

            CalAreaPointer calAreaPointer1 = i => i * i;
            Console.WriteLine(calAreaPointer1(10));


            #endregion

            Console.ReadLine();
        }
        #region Delegate CallBack

        static public void CallBack(int i)
        {
            Console.WriteLine(i.ToString());
        }

        #endregion

        private static IEnumerable<int> RunNumbersThroughGautlet(int[] values, MyDelegate gautlet)
        {
            foreach (var v in values)
            {
                if (gautlet(v))
                    yield return v;
            }
        }
    }

    class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunnigMethod(CallBack obj)
        {
            for (int i = 0; i < 10; i++)
            {
                obj(i);
            }
        }

    }

}
