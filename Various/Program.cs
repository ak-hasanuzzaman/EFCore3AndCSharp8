using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;


namespace Various
{

    static class Program
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> items, Predicate<TSource> gauntlet)
        {
            Console.WriteLine("Where");
            foreach (TSource item in items)
            {
                if (gauntlet(item))
                    yield return item;
            }
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> items,
            Func<TSource, TResult> transform)
        {
            //Console.WriteLine("Select");
            foreach (TSource item in items)
            {
                yield return transform(item);
            }
        }

        private static List<Person> testList;

        public static void GetUpdate(int i) =>
            Console.WriteLine(i.ToString());

        delegate bool IsMyPerson(Person p);

        static List<Customer> customers = new List<Customer>();
        static List<Order> orders = new List<Order>();

        public class asfdsdf
        {
            public asfdsdf(string customerName, int customerId)
            {
                CustomerName = customerName;
                CustomerId = customerId;
            }

            public int CustomerId { get; set; }
            public string CustomerName { get; set; }

        }

        public static asfdsdf fi(Customer c)
        {
            return new asfdsdf(c.CustomerName, c.CustomerId);
        }

        static void Main(string[] args)
        {
            FillCustomerWithOrders();


            var __result = customers
                .GroupJoin(orders,
                    c => c.CustomerId,
                    o => o.CustomerId,
                    (c, customerOrders) => new { c, customerOrders })
                .Select(g => new { g.c, customerOrdersCount = g.customerOrders.Count() })
                .Where(c => c.customerOrdersCount > 1)
                .OrderByDescending(o => o.customerOrdersCount)
                .Select(r => new { Name = r.c.CustomerName, Count = r.customerOrdersCount });




            foreach (var r in __result)
            {
                Console.WriteLine(r.Name + " : " + r.Count);
            }





            //var result = customers
            //    .Join(orders, c => c.CustomerId, o => o.CustomerId
            //        , (c, o) => new { c, o })
            //    .GroupBy(g => g.c, g => g.o)
            //    .Select(g => new { g, NumberOfOrders = g.Count() })
            //    .OrderByDescending(o => o.NumberOfOrders)
            //    .Select(r => new { Customer = r.g.Key.CustomerName, Count = r.NumberOfOrders });










































            //var res = customers
            //    .Where(c => c.CustomerId > 2)
            //    .Select(c => new { Name = c.CustomerName, Id = c.CustomerId });

            //var res1 = Enumerable.Select(Enumerable.Where(customers, c => c.CustomerId > 1), c => c);
            //var res2 = Enumerable.Select(customers, fi);
            //foreach (var r in res1)
            //{
            //    //Console.WriteLine(r.CustomerId + ":" + r.CustomerName);
            //}


            ////var results = from c in customers
            ////              join o in orders
            ////                  on c.CustomerId equals o.CustomerId into thisCustomerOrders
            ////              let numOrders = thisCustomerOrders.Count()
            ////                  orderby numOrders descending
            ////              select new { c.CustomerName, NumOrders = numOrders };

            //var results = customers
            //        .GroupJoin(orders,
            //            c => c.CustomerId,
            //            o => o.CustomerId,
            //            (c, o) => new
            //            {
            //                c,
            //                thisCustomersOrders = o.Count()
            //            })
            //        .OrderByDescending(ti => ti.c.CustomerName)
            //        .Select(ti2 => new
            //        {
            //            ti2.c.CustomerName,
            //            NumOrders = ti2.thisCustomersOrders
            //        });

            //foreach (var r in results)
            //{
            //    //Console.WriteLine(r.CustomerName + ":" + r.NumOrders);
            //}

            ////var _results = from c in customers
            ////               join o in orders
            ////                   on c.CustomerId equals o.CustomerId
            ////               group o by c into g
            ////               let numOrders = g.Count()
            ////               orderby numOrders descending
            ////               select new { g.Key.CustomerName, NumOrders = numOrders };

            //var _results = customers
            //    .Join(orders,
            //        c => c.CustomerId,
            //        o => o.CustomerId,
            //        (c, o) => new
            //        { c, o })
            //    .GroupBy(ti => ti.c, ti => ti.o)
            //    .Select(g => new
            //    {
            //        g,
            //        NumOrders = g.Count()
            //    })
            //    .OrderByDescending(ti => ti.NumOrders)
            //    .Select(tp2 => new { tp2.g.Key.CustomerName, tp2.NumOrders });


            //foreach (var r in _results)
            //{
            //    //Console.WriteLine(r.CustomerName + ":" + r.NumOrders);
            //}


            /*
            int[] things = { 5, 10, 20, 30 };

            var result = things
                .Where(t => t > 5)
                .Select(r => r + 6);

            IEnumerator<int> rator = result.GetEnumerator();
            //while (rator.MoveNext())
            //{
            //    Console.WriteLine(rator.Current);
            //}

            IEnumerable<int> result2 = Select(Where(things, i => i > 5), i => i + 6);
            IEnumerator<int> rator1 = result2.GetEnumerator();

            while (rator1.MoveNext())
            {
                Console.WriteLine(rator1.Current);
            }
            */

            //FillPersons();


            #region 1.DELETEAGE
            /*
            var pp = testList.FirstOrDefault();
            //1. 
            //var testDelegate = new TestDelegate();
            //testDelegate.LongRunnig(GetUpdate);

            //2. 
            //IsMyPerson isMyPerson = p => p.id == 1; ;

            //3. 
            IsMyPerson isMyPerson = delegate (Person p)
            {
                return p.id == 1;
            };

            Console.WriteLine(isMyPerson(pp));

            //4. 
            IsMyPerson d = IsMyPerson1;
            Console.WriteLine(d(pp)); 

            */
            #endregion


            //2. YIELD RETURN

            /*  foreach (var num in GetItems())
              {
                  Console.WriteLine(num);
              }
              */

            #region .WHERE() AND .SELECT()

            #endregion


            #region MyRegion
            /*
            Console.WriteLine("Pre increment");
            int a = 400;
            int b, c;
            var x = (++a);
            b = 5 + x;
            Console.WriteLine("The value of a : {0}", a);
            Console.WriteLine("The value of b : {0}", b);
            c = 5 + (--a);
            Console.WriteLine("The value of a : {0}", a);
            Console.WriteLine("The value of c : {0}", c);

            Console.WriteLine("Post increment");
            a = 400;
            var y = (a++);
            b = 5 + y;
            Console.WriteLine("The value of a : {0}", a);
            Console.WriteLine("The value of b : {0}", b);

            FillPersons();

            foreach (var p in Filter())
            {
                Console.WriteLine(p.firstName);
            }
             */

            #endregion
            Console.ReadLine();
        }


        private static IEnumerable<int> GetItems()
        {
            int i = 0;
            while (i < 5)
            {
                yield return ++i;
            }
        }

        static bool IsMyPerson1(Person p)
        {
            var r = p.id == 1;
            return r;
        }

        #region yield
        private static IEnumerable<Person> Filter()
        {
            foreach (var p in testList)
            {
                if (p.id > 1)
                    yield return p;
            }

        }
        private static void FillCustomerWithOrders()
        {
            customers = new List<Customer>()
            {
                new Customer() {CustomerId = 1, CustomerName = "CK"},
                new Customer() {CustomerId = 2, CustomerName = "Biofuel"},
                new Customer() {CustomerId = 3, CustomerName = "PREEM"},
                new Customer() {CustomerId = 4, CustomerName = "ENOC"},
                new Customer() {CustomerId = 5, CustomerName = "ORLAND"},
            };

            orders = new List<Order>()
            {
                new Order(){ Id =1, CustomerId = 1, Number = "A1125"},
                new Order(){ Id =2, CustomerId = 1, Number = "A1125"},
                new Order(){ Id =3, CustomerId = 1, Number = "A1126"},
                new Order(){ Id =5, CustomerId = 2, Number = "A1127"},
                new Order(){ Id =6, CustomerId = 2, Number = "A1128"},
                new Order(){ Id =4, CustomerId = 3, Number = "A1129"},
                new Order(){ Id =5, CustomerId = 3, Number = "A1130"},

                new Order(){ Id =6, CustomerId = 4, Number = "A1141"},
                new Order(){ Id =7, CustomerId = 5, Number = "A1142"},
            };

        }

        private static List<Person> FillPersons()
        {

            testList = new List<Person>
            {
                new Person() {id = 1, firstName = "hasan", lastName = "zaman"},
                new Person() {id = 2, firstName = "ahmad", lastName = "saiful"},
                new Person() {id = 3, firstName = "mobin", lastName = "rupani"},
            };
            return testList;
        }

        public class Person
        {
            public int id;
            public string firstName;
            public string lastName;
        }

        public class Customer
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }

        }

        class Order
        {
            public string Number { get; set; }
            public int Id { get; set; }
            public int CustomerId { get; set; }

        }
        #endregion

    }

    class TestDelegate
    {
        public delegate void CallBack(int i);

        public void LongRunnig(CallBack callBack)
        {
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                    callBack(i);
            }
        }

    }
}
