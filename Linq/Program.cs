using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    //LINQ - 1

    /*internal class LinqProg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello people!");

            int[] arr = { 4, 5, 6, 10, 3, 2, 1, 14 };

            IEnumerable<int> n = arr.Where(
              p => p % 2 == 0).Select(p => p);

            foreach (var i in n) //enhanced for loop
            {
                Console.WriteLine(i);
            }

            int count = arr.Count(x => x > 5);
            int avg = (int)arr.Average(x => x); 
            int max = arr.Max(x => x);

            Console.WriteLine("Average is : " + avg);
            Console.WriteLine("Maximum is : " + max); //maximum number using inbuilt function

            IEnumerable<int> maxim = (from a in arr select max).Take(1); //to print only once, else it prints arr.length times

            foreach(var i in maxim) //finding maximum number using for loop
            {
                Console.WriteLine("Maxim is " + i);
            }

            Console.WriteLine("count is : " + count);
            Console.ReadKey();
        }
    } */

    //LINQ - 2

    internal class LinqProg2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i am glad");
                XDocument pd = XDocument.Load("C:\\Users\\aayut\\source\\repos\\Linq\\Linq\\file.xml");

                //this connects to start or root point that is the table
                var products = pd.Elements();

 //--------------------------------------------------------------------------------------------------------------------------------------

                //Q1
                Console.WriteLine("display products price >40000 using lamda function");
                var result = products.Elements("Product")
                    .Where(x => (int)x.Element("price") > 40000)
                    .Select(x =>
                            new //if you are picking multiple columns then 'new' keyword is compulsary
                            {
                                Name = x.Element("pname").Value,
                                price = x.Element("price").Value,
                                dom = x.Element("dom").Value, //filters the data that has to be printed
                                doe = x.Element("doe").Value, 
                            }
                    );

                foreach (var r in result)
                {
                    Console.WriteLine(r);
                };
                Console.WriteLine();

            var prods = pd.Elements();

            Console.WriteLine("Products : ");
            var res = prods.Elements("Product")
                .Where(x => (int)x.Element("price") > 40000)
                .Select(x => new
                {
                    Name = x.Element("pname").Value,
                    Price = x.Element("price").Value,

                });

            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine();
//---------------------------------------------------------------------------------------------------------------------------------

                //Q2
                Console.WriteLine("display all products using lambda function");
                var result2 = products.Elements("Product")
                    .Select(x =>
                    new
                    {
                        Name = x.Element("pname").Value,
                        price = x.Element("price").Value,
                        dom = x.Element("dom").Value,
                        doe = x.Element("doe").Value,
                    }
                  );

                foreach (var r in result2)
                {
                    Console.WriteLine(r);
                };
                Console.WriteLine();

//---------------------------------------------------------------------------------------------------------------------------------


            //Q3
            Console.WriteLine("display products manufactured after 10-07-14 using lambda function");
                var result3 = products.Elements("Product")
                    .Where(x => DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null))
                    .Select(x =>
                    new
                    {
                        Name = x.Element("pname").Value,
                        price = x.Element("price").Value,
                        dom = x.Element("dom").Value,
                        doe = x.Element("doe").Value,
                    }
                 );

                foreach (var r in result3)
                {
                    Console.WriteLine(r);
                };
                Console.WriteLine();

//---------------------------------------------------------------------------------------------------------------------------------

            //Q4
            Console.WriteLine("display product names manufactured after 10-07-14 using query");
                var pr = from x in products.Elements("Product")
                         where DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null)
                         let nm = (string)x.Element("pname")
                         select nm;

                foreach (var r in pr)
                {
                    Console.WriteLine(r);
                };
                Console.WriteLine();

//---------------------------------------------------------------------------------------------------------------------------------

            //Q5
            var v = from x in products.Elements("Product")
                        where (int)x.Element("price") > 40000
                        select new 
                        { 
                            Name = (string)x.Element("pname"), 
                            Price = (int)x.Element("price") 
                        };

                v.ToList().ForEach(
                    y => Console.WriteLine(y.Name + " " + y.Price)
                );

                Console.WriteLine();
                Console.ReadKey();

//---------------------------------------------------------------------------------------------------------------------------------

        }
    }
}
