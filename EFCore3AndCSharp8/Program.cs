using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using EFCore3AndCSharp8.Data;
using EFCore3AndCSharp8.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore3AndCSharp8
{
   

    class Program
    {
        #region test
        //// Simple business object.
        //public class Person
        //{
        //    public int id;
        //    public string firstName;
        //    public string lastName;
        //}

        //static List<Person> testList = new List<Person>
        //{

        //    new Person() {id = 1, firstName = "hasan", lastName = "zaman"},
        //    new Person() {id = 2, firstName = "ahmad", lastName = "saiful"},
        //    new Person() {id = 3, firstName = "mobin", lastName = "rupani"},

        //};

        //#region Asynchrounous Streams  

        //private static async IAsyncEnumerable<int> FetchIotData()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        await Task.Delay(1000); //Simulate waiting for data to come through. 
        //        yield return i;
        //    }
        //}

        //#endregion

        //#region DefaultIfEmptyEx1

        //public class Pet
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}

        //public static void DefaultIfEmptyEx1()
        //{
        //    List<Pet> pets =
        //        new List<Pet>
        //        {
        //            new Pet {Name = "Barley", Age = 8},
        //            new Pet {Name = "Boots", Age = 4},
        //            new Pet {Name = "Whiskers", Age = 1}
        //        };

        //    // This query selects only those pets that are 10 or older.
        //    // In case there are no pets that meet that criteria, call
        //    // DefaultIfEmpty(). This code passes an (optional) default
        //    // value to DefaultIfEmpty().
        //    string[] oldPets =
        //        pets.AsQueryable()
        //            .Where(pet => pet.Age >= 10)
        //            .Select(pet => pet.Name)
        //            .DefaultIfEmpty("[EMPTY]")
        //            .ToArray();

        //    string first = oldPets[0];
        //    Console.WriteLine(first);
        //}



        //#endregion

    
        //delegate string Who(Person p); 
        #endregion

        static async Task Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<EFPerformanceTest>();


            #region MyRegion

            //Who who = delegate (Person p)
            //{
            //    return p.id == 1 ? "Hasan" : "Else";
            //};

            //Who who1 = p => p.id == 1 ? "Hasan l" : "Else";

            //Console.WriteLine(who(new Person() { id = 1 }));
            //Console.WriteLine(who1(new Person() { id = 1 }));
            //Func<Person, bool> f = delegate(Person person) { return person.id == 1;};

            //var ss = testList.FirstOrDefault(f);


            //#region IEnumerable from .SELECT()
            ////var result = testList.Select(t => { return t; });
            //#endregion

            //#region DefaultIfEmptyEx1

            ////DefaultIfEmptyEx1();

            //#endregion

            //#region   Asynchrounous Streams

            ////await foreach (var dataPoint in FetchIOTData())
            ////{
            ////    Console.WriteLine(dataPoint);

            //#endregion

            //#region   nullable reference type

            ////#nullable enable

            ////        string nulltest = null;

            ////        //Range operator
            ////        var people = new[] { "ak", "hasanuzzaman", "hye", "farjana bintay" };
            ////        //var filteredPeople = people[0..2];

            ////        Range filteredPeople = ..3;

            ////        foreach (var p in people[filteredPeople])
            ////        {
            ////            Console.WriteLine($"Value : {nulltest}" + p);
            ////        }
            ////#nullable restore

            //#endregion

            //#region Static local function

            ////Console.WriteLine(LocalFunc("Hasan", "Zaman"));
            ////static string LocalFunc(string fName, string lName) => $"{fName},{lName}";

            //#endregion

            //#region Switch

            ////var s = Console.ReadLine();
            //////Switch
            ////var ss = s switch
            ////{
            ////    "1" => "One",
            ////    "2" => "Two",
            ////    "3" => "Three",
            ////    _ => "No case"
            ////};

            //#endregion 

            #endregion
        }


    }

    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn()]
    public class EFPerformanceTest
    {
        //var s = new Stopwatch();
        //s.Start();

        ////Console.WriteLine("First query");

        ////var unitToProfiles = await _context.UnitToProfiles
        ////    .Where(e => e.ProfileID == 1
        ////                && e.Unit.RecordStatus == 1
        ////                && e.Unit.UnitTypeRef.HasEngine)
        ////    .Select(up => new UnitToProfile
        ////    {
        ////        ProfileID = up.ProfileID,
        ////        UnitID = up.UnitID,
        ////        Unit = new Unit()
        ////        {
        ////            RecordStatus = up.Unit.RecordStatus,
        ////            UnitTypeRef = up.Unit.UnitTypeRef,
        ////            UnitToUnitCombinations = up.Unit.UnitToUnitCombinations
        ////                .Select(uc => new UnitToUnitCombination()
        ////                {
        ////                    UnitCombinationID = uc.UnitCombinationID,
        ////                    UnitID = uc.UnitID
        ////                })
        ////        }
        ////    })
        ////    .ToListAsync();


        //s.Stop();
        //    var ts = s.ElapsedMilliseconds;
        //Console.WriteLine("\n");
        //    Console.WriteLine("\n");


        //    Console.WriteLine("Second query");
        //    var s1 = new Stopwatch();
        //s1.Start();

        //    //var unitToProfiles1 = await _context.UnitToProfiles
        //    //.Include(e => e.Unit).ThenInclude(e => e.UnitTypeRef)
        //    //.Include(e => e.Unit).ThenInclude(e => e.UnitToUnitCombinations).ThenInclude(e => e.UnitCombination)
        //    //.Where(e => e.ProfileID == 1
        //    //            && e.Unit.RecordStatus == 1
        //    //            && e.Unit.UnitTypeRef.HasEngine)
        //    //.ToListAsync();


        //    s1.Stop();
        //    var ts1 = s1.ElapsedMilliseconds;

        //Console.ReadLine();

        //    //s1.Stop();
        //    //var ts1 = s1.ElapsedMilliseconds;

        [Benchmark]
        public async Task<List<UnitToProfile>> NewMethod()
        {
            CatsDbContext _context = new CatsDbContext();
            //var unitToProfiles = await _context.UnitToProfiles
            //    .Join(_context.Units,
            //        up => up.UnitID,
            //        u => u.ID,
            //        (up, u) => new
            //        {
            //            UnitToProfile = new UnitToProfile
            //            {
            //                ProfileID = up.ProfileID,
            //                UnitID = up.UnitID,
            //            },
            //            Unit = new Unit()
            //            {
            //                RecordStatus = up.Unit.RecordStatus,
            //                UnitTypeRef = up.Unit.UnitTypeRef,
            //                UnitToUnitCombinations = up.Unit.UnitToUnitCombinations
            //                    .Select(uc => new UnitToUnitCombination()
            //                    {
            //                        UnitCombinationID = uc.UnitCombinationID,
            //                        UnitID = uc.UnitID
            //                    })
            //            }
            //        })
            //    .Where(e => e.UnitToProfile.ProfileID == 1
            //                && e.Unit.RecordStatus == 1
            //                && e.Unit.UnitTypeRef.HasEngine)
            //    .Select(up => new UnitToProfile
            //    {
            //        ProfileID = up.UnitToProfile.ProfileID,
            //        UnitID = up.UnitToProfile.UnitID,
            //        Unit = up.Unit
            //    })
            //    .ToListAsync();

            var unitToProfiles = await _context.UnitToProfiles
                .Include(e => e.Unit).ThenInclude(e => e.UnitTypeRef)
                .Include(e => e.Unit).ThenInclude(e => e.UnitToUnitCombinations).ThenInclude(e => e.UnitCombination)
                .Where(e => e.ProfileID == 1
                            && e.Unit.RecordStatus == 1
                            && e.Unit.UnitTypeRef.HasEngine)
                .ToListAsync();


            return unitToProfiles;
        }
    }
}