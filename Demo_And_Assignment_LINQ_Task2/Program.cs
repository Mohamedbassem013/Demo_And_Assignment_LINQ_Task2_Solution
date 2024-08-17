using Demo_And_Assignment_LINQ_Task2;
using System.Collections;
using static Demo_And_Assignment_LINQ_Task2.ListGenerator;

namespace Demo_LINQ_Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1.Filteration Operators - [where -- OfType] - Differed
            
            // Where

            //Fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);
            //
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax
            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock == 0
            //             select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //var Result =ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //var Result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //             select p;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //indexed Where
            // indexed Where Only Valid in Fluent Syntax
            //Can't Be Written Using Query Syntax [Query Expression]

            // Note : p = product and I = Position
            //var Result =ListGenerator.ProductsList.Where((P, I) => P.UnitsInStock == 0 && I < 10);
            //    Result =ListGenerator.ProductsList.Where((P, I) => I < 5 && P.UnitsInStock > 0);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }


            // OfType

            ///ArrayList list = new ArrayList() { "Ahme", 1, "Ali", 12, "Mahmoud", 1.5, 'A' };

            //List as a Sequance

            //var result1 = list.OfType<int>();
            //var result2 = list.OfType<string>();
            //var result3 = list.OfType<double>();
            //var result4 = list.OfType<char>();

            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2.Transformation Operators - Select / SelectMany

            // Select
            //var Result = ProductList.Select(p => p.ProductName);

            //Result = from p in ProductList
            //         select p.ProductName;


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //var Result =ListGenerator.ProductsList.Select(p => 
            //new
            //{
            //    p.ProductID,
            //    p.ProductName
            //});


            // SelectMany
            //var Result = ListGenerator.CustomersList.SelectMany(c => c.Orders); // If The Property Is A List Or Array 

            //var Result = from c in ListGenerator.CustomersList
            //         from o in c.Orders
            //         select o;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //var Result =ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0)
            //                                .Select(p => new
            //                                {
            //                                    p.ProductID,
            //                                    p.ProductName,
            //                                    NewPrice = p.UnitPrice - p.UnitPrice * .1m
            //                                });

            // indexed Select
            //Can't Be Written Using Query Syntax [Query Expression]

            //var Result =ListGenerator.ProductsList.Select((p, I) => new { I, Name = p.ProductName });


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3.Ordering Operators  - Differed
            // fluent syntax
            //var Result = ListGenerator.ProductsList.OrderBy(p => p.UnitPrice); // Ascending
            // Result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitPrice); // descending

            // Query Syntax
            //var Result = from p in ListGenerator.ProductsList
            //         orderby p.UnitsInStock descending
            //         select p;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // fluent syntax
            //var Result =ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock).ThenByDescending(p => p.UnitPrice);

            // Query Syntax
            //var Result = from p in ListGenerator.ProductsList 
            //          orderby p.UnitsInStock, p.UnitPrice descending
            //          select new
            //          {
            //              p.UnitsInStock,
            //              p.UnitPrice,
            //              p.ProductName
            //          };

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }

            // Reverse

            //var Result = ListGenerator.ProductsList.Reverse<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4.Elements operators - immediate Execution

            //ListGenerator.ProductsList = new List<Product>();

            // Frist
            //var Result = ListGenerator.ProductsList.First();// May Throw Exception
            //Console.WriteLine(Result);
            // Sequence contains no elements

            // Last
            //var Result = ListGenerator.ProductsList.Last();
            //Console.WriteLine(Result);

            //var Result =ListGenerator.ProductsList.FirstOrDefault();
            //    Result = ListGenerator.ProductsList.LastOrDefault();


            //var Result = ListGenerator.ProductsList.First(p => p.UnitsInStock == 0);
            //    Result = ListGenerator.ProductsList.Last(p => p.UnitsInStock == 1000);
            //Console.WriteLine(Result);

            //var Result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //    Result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000, new Product() { ProductName = "Default proudct" });
            //    Result = ListGenerator.ProductsList.LastOrDefault();


            //var Result = ListGenerator.ProductsList.ElementAt(22);
            //Result = ListGenerator.ProductsList.ElementAt(1000);// May Throw Exception

            //var Result = ListGenerator.ProductsList.ElementAtOrDefault(1000);

            //ListGenerator.ProductsList = new List<Product>() { new Product() { ProductName = "Only one product" } };
            //ListGenerator.ProductsList = new List<Product>();// May Throw Exception if there is Zero or more than one elements

            //var Result = ListGenerator.ProductsList.Single();
            //Console.WriteLine(Result);
            // Sequence contains no elements
            // Sequence contains more than one elements

            //var Result = ListGenerator.ProductsList.SingleOrDefault();// May Throw Exception if than are more than one elements
            //    Result = ListGenerator.ProductsList.SingleOrDefault(new Product() { ProductName = "Only one product" });


            //var Result = ListGenerator.ProductsList.Single(p => p.UnitsInStock == 0); //May Throw Exception if there is Zero or more than one elements Matching The Condistio

            //var Result = ListGenerator.ProductsList.SingleOrDefault(p => p.ProductID == 22);
            //    Result = ListGenerator.ProductsList.SingleOrDefault(p => p.ProductID == 22, 
            //                       new Product(){ ProductName = "hamadaa", ProductID = 22 });


            //var Result = ListGenerator.ProductsList.DefaultIfEmpty();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region 5.Casting operators - immediate Execution

            //List<Product> list = ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0).ToList();

            //Product[] array = ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0).ToArray();

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<long, Product> Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0)
            //                                            .ToDictionary(p => p.ProductID);

            //HashSet<Product> Result = ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0).ToHashSet();

            //ILookup<long , Product> Result = ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0).ToLookup(p => p.ProductID);

            #endregion

            #region 6.Aggregate operators - immediate Execution

            // Count - Max - Min - Avarage - Sum


            // Count
            //var Result = ListGenerator.ProductsList.Count(); //Aggregate Operators
            //Result = ListGenerator.ProductsList.Count; // property
            //Result = ListGenerator.ProductsList.Count(p => p.UnitsInStock == 0);


            // Sum
            //var Result = ListGenerator.ProductsList.Sum(p => p.UnitPrice);
            //    Result = ListGenerator.ProductsList.Sum(p => p.UnitsInStock);


            //Avarage
            //var Result = ListGenerator.ProductsList.Average(p => p.UnitPrice);

            // Max
            // var Result = ListGenerator.ProductsList.Max(); // Must impelement IComparable
            // var  Result = ListGenerator.ProductsList.Max(p=> p.UnitPrice);
            // var  Result = ListGenerator.ProductsList.Max(p=> p.UnitsInStock);
            // var Result = ListGenerator.ProductsList.MaxBy(p => p.UnitsInStock); // You will get the product with the highest price // .Net 6.0 ==> C# 10.0
            // Console.WriteLine(Result);


            // Min
            // var Result = ListGenerator.ProductsList.Min();// Must impelement IComparable
            //var Result = ListGenerator.ProductsList.Min(p => p.UnitPrice);
            //var Result = ListGenerator.ProductsList.Min(p => p.UnitsInStock);

            //var Result = ListGenerator.ProductsList.OrderBy(p => p.ProductName).FirstOrDefault(); // Acending
            //    Result = ListGenerator.ProductsList.MinBy(p => p.UnitPrice);
            //    Result = ListGenerator.ProductsList.MinBy(p => p.UnitsInStock);// .Net 6.0 ==> C# 10.0

            // Aggregate
            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Omar" , "Mohamed" };
            //var Result  = Names.Aggregate((str01, str02) => $"{str01} {str02}");
            //Console.WriteLine(Result);

            #endregion

            #region 7.Generation operators

            // The Only Way To Call as => Class Member Methods Through "Enumerable"

            //var Result = Enumerable.Range(1, 100); // 1.....100
            //    Result = Enumerable.Range(10, 100); // 10.....109

            //var Result = Enumerable.Repeat(new Product() { ProductName = "Repeat product"}, 100);

            //var Result = Enumerable.Empty<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 8.Set operators - Union Family

            // union family

            // var seq01 = Enumerable.Range(0, 100); // 0..99
            // var seq02 = Enumerable.Range(50, 100); // 50..149
            //
            // var Result = seq01.Union(seq02); // Without Any duplication
            //
            //     Result = seq01.Concat(seq02); // With Duplication Like union All in sql
            //
            //     Result = Result.Distinct();
            //
            //Result = seq01.Intersect(seq02);
            //Result = seq01.Except(seq02);

            //Result = seq02.Except(seq01);

            // foreach (var item in Result)
            //  {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region 9.Quantifier operators - Return Boolean

            // Any - All - SequenceEqual - Contains

            // Any() -> Return true if there is at least one elements [in the sequence or Match the condation]

            //ListGenerator.ProductsList = new List<Product>();

            // var Result = ListGenerator.ProductsList.Any(p => p.UnitPrice == 0 );

            // All() -> Return true if All elements Match the condation or sequence is Empty
            // var Result = ListGenerator.ProductsList.All(p => p.UnitPrice > 0);

            //SequenceEqual
            // var seq01 = Enumerable.Range(0, 100); // 0..99
            // var seq02 = Enumerable.Range(0, 100); // 0..99
            //// var seq02 = Enumerable.Range(50, 100); // 50..149
            // Console.WriteLine(seq01.SequenceEqual(seq02));


            // Contains
            // var Result =seq01.Contains(1);

            #endregion

            #region 10.Zip operator

            // Zipping Operator
            // Zip

            //List<string> Words = new List<string> { "Ten", "Twenty", "Thirty" , "Fourty" }; 

            //List<int> numbers = new List<int> { 10, 20 , 30 , 40 , 50 , 60 }; 

            // var Result = Words.Zip(numbers, (W, N) => $"{N} => {W}");

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion

            #region 11.Grouping operator

            //var Result = ListGenerator.ProductsList.GroupBy(P => P.Category);

            // Query Syntax
            //var Result = from p in ListGenerator.ProductsList
            //             group p by p.Category;

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine($"......{product}");
            //    }
            //}

            //var Result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into Category
            //             where Category.Count() > 5
            //             select new { CategoryName = Category.Key, countOfCategory = Category.Count() };

            //var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0)
            //       .GroupBy(p => p.Category)
            //       .OrderByDescending(c => c.Count())
            //       .Where(c => c.Count() > 5)
            //       .Select(c => new { CategoryName = c.Key, countOfCategory = c.Count() });
            //foreach (var item in Result)
            //{
            //     Console.WriteLine(item);
            //}
            #endregion

            #region 12.Partitioning operator - Take , TackLast , Skip , SkipLast , TakeWhile , SkipWhile

            // Partitioning operator ->[ Take , TackLast , Skip , SkipLast , TakeWhile , SkipWhile]

            // Take - TackLast
            //var Result = ListGenerator.ProductsList.Take(2);
            //   Result = ListGenerator.ProductsList.TakeLast(2);
            //    Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).Take(3);
            //    Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).TakeLast(4);

            // Skip - SkipLast
            // var Result = ListGenerator.ProductsList.Skip(2);
            //     Result = ListGenerator.ProductsList.SkipLast(2);
            //     Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).Skip(2);
            //     Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).SkipLast(3);



            // TakeWhile - SkipWhile
            //int[] numbers = { 9, 6, 1, 2, 3, 4, 5 };

            //var Result = numbers.TakeWhile((N) => N % 3 == 0 );

            //var Result = numbers.SkipWhile((N) => N % 3 == 0);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }

            //int[] numbers = { 5, 4, 1, 3, 9, 6, 7 , 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N > I);

            #endregion

            #region 13.Let / Into 

            //Using in Query Syntax

            // [aeiouAEIOU]
            List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Mona", "Aya", "Mariam", "Touqqe", "Sally", "Mahmoued", "Osama" };

            //var Result = from Name in Names
            //             select Regex.Replace(Name, "[aeiouAEIOU]", string.Empty)
            //             into NoVolNames
            //             // into : Start Query With introducing New Range Variable (NoVolNames)
            //             where NoVolNames.Length > 3
            //             select NoVolNames;

            //var Result = from Name in Names
            //             let NoVolNames = Regex.Replace(Name, "[aeiouAEIOU]", string.Empty)
            //             // Let : Continue Query With Adding New Range Variable (NoVolNames)
            //             where NoVolNames.Length > 3
            //             select NoVolNames;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


        }
    }
}