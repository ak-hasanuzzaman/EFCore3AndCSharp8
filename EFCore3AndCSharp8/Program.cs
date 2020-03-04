using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EFCore3AndCSharp8.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCore3AndCSharp8
{
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
    class Program
    {
        #region Asynchrounous Streams  

        private static async IAsyncEnumerable<int> FetchIotData()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);//Simulate waiting for data to come through. 
                yield return i;
            }
        }
        #endregion

        #region DefaultIfEmptyEx1
        public class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void DefaultIfEmptyEx1()
        {
            List<Pet> pets =
                new List<Pet>{ new Pet { Name="Barley", Age=8 },
                new Pet { Name="Boots", Age=4 },
                new Pet { Name="Whiskers", Age=1 } };

            // This query selects only those pets that are 10 or older.
            // In case there are no pets that meet that criteria, call
            // DefaultIfEmpty(). This code passes an (optional) default
            // value to DefaultIfEmpty().
            string[] oldPets =
                pets.AsQueryable()
                    .Where(pet => pet.Age >= 10)
                    .Select(pet => pet.Name)
                    .DefaultIfEmpty("[EMPTY]")
                    .ToArray();

            string first = oldPets[0];
            Console.WriteLine(first);
        }
        #endregion

        #region Delegate CallBack
        static public void CallBack(int i)
        {
            Console.WriteLine(i.ToString());
        }
        #endregion

        delegate double CalAreaPointer(int i);

        static async Task Main(string[] args)
        {
            #region DELEGATE IN C#

            //var myClass = new MyClass();
            //myClass.LongRunnigMethod(CallBack);


            CalAreaPointer calAreaPointer = new CalAreaPointer(
                delegate (int i) { return i * i; });

            Console.WriteLine(calAreaPointer(5));

            CalAreaPointer calAreaPointer1 = i => i * i;
            Console.WriteLine(calAreaPointer1(10));


            #endregion

            #region DefaultIfEmptyEx1

            //DefaultIfEmptyEx1();

            #endregion

            #region   Asynchrounous Streams

            //await foreach (var dataPoint in FetchIOTData())
            //{
            //    Console.WriteLine(dataPoint);

            #endregion

            #region   nullable reference type

            //#nullable enable

            //        string nulltest = null;

            //        //Range operator
            //        var people = new[] { "ak", "hasanuzzaman", "hye", "farjana bintay" };
            //        //var filteredPeople = people[0..2];

            //        Range filteredPeople = ..3;

            //        foreach (var p in people[filteredPeople])
            //        {
            //            Console.WriteLine($"Value : {nulltest}" + p);
            //        }
            //#nullable restore

            #endregion

            #region Static local function

            //Console.WriteLine(LocalFunc("Hasan", "Zaman"));
            //static string LocalFunc(string fName, string lName) => $"{fName},{lName}";

            #endregion

            #region Switch

            //var s = Console.ReadLine();
            ////Switch
            //var ss = s switch
            //{
            //    "1" => "One",
            //    "2" => "Two",
            //    "3" => "Three",
            //    _ => "No case"
            //};

            #endregion
        }

    }
}