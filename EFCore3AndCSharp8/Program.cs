using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EFCore3AndCSharp8.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCore3AndCSharp8
{
    class Program
    {
        #region Asynchrounous Streams  
        static async IAsyncEnumerable<int> FetchIOTData()
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

        static async Task Main(string[] args)
        {

            #region Asynchrounous Streams  

            //        #region DefaultIfEmptyEx1
            //        DefaultIfEmptyEx1();
            //       


            //        await foreach (var dataPoint in FetchIOTData())
            //        {
            //            Console.WriteLine(dataPoint);
            //        }

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


            //Static local function
            //Console.WriteLine(LocalFunc("Hasan", "Zaman"));

            //static string LocalFunc(string fName, string lName) => $"{fName},{lName}";




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
            try
            {
                var stopWatch = new Stopwatch();

                stopWatch.Start();

                //1. N+1 problem demonstration.

                using (var db = new CatsDbContext())
                {
                    var owners = db.Owners
                        .Where(o => o.Name.Contains("hasan"))
                        .ToList();
                    foreach (var owner in owners)
                    {
                        db.Entry(owner)
                            .Collection(o => o.Cats)
                            .Load();

                        var cats = db.Cats
                            .Where(c => c.Name.Contains("Hamlet") && c.OwnerId == owner.OwnerId)
                            .ToList();
                    }
                }

                var time = stopWatch.ElapsedMilliseconds;
                Console.WriteLine("Elapsed time : " + time);


                //2. Resolution of N+1 via .Include(). Which is not the most efficient but better

                stopWatch = Stopwatch.StartNew();

                using (var db = new CatsDbContext())
                {
                    var owners = db.Owners
                        .Where(o => o.Name.Contains("hasan"))
                        .Include(o => o.Cats)
                        .ToList();

                    foreach (var owner in owners)
                    {
                        var cats = db.Cats
                            .Where(c => c.Name.Contains("Hamlet"))
                            .ToList();
                    }
                }

                var time1 = stopWatch.ElapsedMilliseconds;
                Console.WriteLine("Elapsed time : " + time1);

                //3. Resolution of N+1 via .Select()/projection, Which is the better approach.

                stopWatch = Stopwatch.StartNew();

                using (var db = new CatsDbContext())
                {
                    var owners = db.Owners
                        .Where(o => o.Name.Contains("hasan"))
                        .Select(o => new
                        {
                            Cats = o.Cats.Where(c => c.Name.Contains("Hamlet"))
                                .ToList()
                        }).ToList();

                }

                var time2 = stopWatch.ElapsedMilliseconds;
                Console.WriteLine("Elapsed time : " + time2);

                Console.ReadLine();
            }
            catch (Exception e)
            {
            }
        }

    }

}