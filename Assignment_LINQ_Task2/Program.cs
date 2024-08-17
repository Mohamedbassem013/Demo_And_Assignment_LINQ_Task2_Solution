internal class Program
{
    private static void Main(string[] args)
    {

        #region LINQ - Restriction Operators

        #region 1. Find all products that are out of stock.

        // var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

        //     Result = from p in ListGenerator.ProductsList
        //              where p.UnitsInStock == 0
        //              select p;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region 2. Find all products that are in stock and cost more than 3.00 per unit.

        //var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);

        //    Result = from p in ListGenerator.ProductsList
        //               where p.UnitsInStock != 0 && p.UnitPrice > 3.00M
        //               select p;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 3. Returns digits whose name is shorter than their value.

        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var Result = Arr
        //    .Select((name, index) => new { Name = name, Value = index })
        //    .Where(x => x.Name.Length < x.Value)
        //    .Select(x => x.Name);

        //foreach (var item in Result)
        //{
        //    Console.Write($"\"{item}\", ");
        //}

        #endregion

        #endregion

        #region LINQ - Element Operators

        #region 01 Get first Product out of Stock 


        //var Result = ListGenerator.ProductsList.First(p => p.UnitsInStock == 0);

        //Result = (from P in ListGenerator.ProductsList
        //          where P.UnitsInStock == 0
        //          select P).FirstOrDefault();

        //Console.WriteLine(Result);
        #endregion

        #region 02 Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

        //var Result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

        //Result = (from p in ListGenerator.ProductsList
        //          where p.UnitPrice > 1000
        //          select p).FirstOrDefault();
        //Console.WriteLine(Result != null ? Result.ToString() : "No product found with UnitPrice > 1000");

        #endregion

        #region Retrieve the second number greater than 5 
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var Result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

        //Result = (from n in Arr
        //          where n > 5
        //          select n).Skip(1).FirstOrDefault();
        //Console.WriteLine(Result);
        #endregion

        #endregion

        #region LINQ - Aggregate Operators

        #region 1.Uses Count to get the number of odd numbers in the array

        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var Result = Arr.Where(A => A % 2 != 0).Count();

        //Result = (from I in Arr
        //          where I % 2 != 0
        //          select I).Count();

        //Console.WriteLine($"Count of odd numbers :{Result}");
        #endregion

        #region 2. Return a list of customers and how many orders each has.

        //var Result = ListGenerator.CustomersList.Select(C => new { Id = C.CustomerID, Name = C.CustomerName, orderNumbers = C.Orders.Count() });

        //Result = from C in ListGenerator.CustomersList
        //         select new
        //         {
        //             Id = C.CustomerID,
        //             Name = C.CustomerName,
        //             orderNumbers = (from O in C.Orders select O.OrderID).Count()
        //         };

        //foreach (var Item in Result)
        //{
        //    Console.WriteLine(Item);
        //}
        #endregion

        #region 3. Return a list of categories and how many products each has

        //var Result = ListGenerator.ProductsList.GroupBy(C => C.Category).Select(P => new { ProductKey = P.Key, productNumbers = P.Count() });

        //var Result01 = from P in ListGenerator.ProductsList
        //               group P by P.Category into G
        //               select new { ProductKey = G.Key, ProductNumbers = G.Count() };

        //Console.WriteLine("Using Fluent");
        //foreach (var Item in Result)
        //{
        //    Console.WriteLine(Item);
        //}
        //Console.WriteLine("Using Quary");
        //foreach (var Item in Result01)
        //{
        //    Console.WriteLine(Item);
        //}
        #endregion

        #region 4. Get the total of the numbers in an array.
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var Result = Arr.Sum();

        //Result = (from A in Arr
        //          select A).Sum();
        //Console.WriteLine($"Result : {Result}");

        #endregion

        #region point 5 , 6 , 7 ,8  Readfile ==> dictionary_english.txt
        //string Path = "dictionary_english.txt";
        //string[] Lines = File.ReadAllLines(Path);
        //Console.WriteLine("File read successfully.");


        #region 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
        //// Process words and their lengths
        //var words = Lines.Select(L => new { Word = L, Length = L.Length });
        //Console.WriteLine("Words processed successfully.");

        //// Iterate over each word and display the word and its length
        //foreach (var item in words)
        //{
        //    Console.WriteLine($"Word: {item.Word}, Length: {item.Length}");
        //}
        #endregion

        #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
        //var shortWord = Lines.Min(L => L.Length);
        //shortWord = (from word in Lines select word.Length).Min();
        //Console.WriteLine($"Shortest Word Length: {shortWord}");

        #endregion

        #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
        //var longWord = Lines.Max(L => L.Length);
        //longWord = (from word in Lines select word.Length).Max();
        //Console.WriteLine($"Longest Word Length: {longWord}");

        #endregion

        #region 8. Get the average length of the words in dictionary_english.txt 
        //var avgWord = Lines.Average(L => L.Length);
        //avgWord = (from word in Lines select word.Length).Average();
        //Console.WriteLine($"Average Word Length (Query Syntax): {avgWord}");
        #endregion



        #endregion

        #region 9. Get the total units in stock for each product category

        //var Result = ListGenerator.ProductsList.GroupBy(P => P.Category)
        //                        .Select(C => new
        //                        {
        //                            Category = C.Key,
        //                            UnitsInStock = C.Sum(p => p.UnitsInStock)
        //                        });

        //Result = from product in ListGenerator.ProductsList
        //         group product by product.Category into productGroup
        //         select new
        //         {
        //             Category = productGroup.Key,
        //             UnitsInStock = productGroup.Sum(p => p.UnitsInStock)
        //         };
        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.UnitsInStock}");
        //}

        #endregion

        #region 10. Get the cheapest price among each category's products

        //var Result = ListGenerator.ProductsList.GroupBy(P => P.Category)
        //                                       .Select(C => new
        //                                       {
        //                                           Category = C.Key,
        //                                           CheapestPrice = C.Min(P => P.UnitPrice)
        //                                       });

        //Result = from product in ListGenerator.ProductsList
        //         group product by product.Category into productGroup
        //         select new
        //         {
        //             Category = productGroup.Key,
        //             CheapestPrice = productGroup.Min(P => P.UnitPrice)
        //         };


        //foreach (var price in Result)
        //{
        //    Console.WriteLine($"Category: {price.Category}, Cheapest Price: {price.CheapestPrice}");
        //}
        #endregion

        #region 11. Get the products with the cheapest price in each category (Use Let)

        //var Result = from P in ListGenerator.ProductsList
        //             group P by P.Category into C
        //             let CheapProduct = C.OrderBy(p => p.UnitPrice).FirstOrDefault()
        //             select new
        //             {
        //                 Category = C.Key,
        //                 CheapProduct = CheapProduct
        //             };

        //foreach (var price in Result)
        //{
        //    Console.WriteLine($"Category: {price.Category}, Product: {price.CheapProduct?.ProductName}, Price: {price.CheapProduct?.UnitPrice}");
        //}


        #endregion

        #region 12. Get the most expensive price among each category's products

        //var Result = from product in ListGenerator.ProductsList
        //             group product by product.Category into productGroup
        //             select new
        //             {
        //                 Category = productGroup.Key,
        //                 ExpensivePrice = productGroup.Max(p => p.UnitPrice)
        //             };

        //foreach (var expensive in Result)
        //{
        //    Console.WriteLine($"Category: {expensive.Category}, Most Expensive Price: {expensive.ExpensivePrice}");
        //}

        #endregion

        #region 13. Get the products with the most expensive price in each category.

        //var Result = from P in ListGenerator.ProductsList
        //             group P by P.Category into E
        //             let ExpensiveProduct = E.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
        //             select new
        //             {
        //                 Category = E.Key,
        //                 ExpensiveProduct = ExpensiveProduct
        //             };

        //foreach (var expensive in Result)
        //{
        //    Console.WriteLine($"Category: {expensive.Category}, Product: {expensive.ExpensiveProduct?.ProductName}, Price: {expensive.ExpensiveProduct?.UnitPrice}");
        //}

        #endregion

        #region 14. Get the average price of each category's products.

        //var Result = ListGenerator.ProductsList.GroupBy(P => P.Category)
        //                                       .Select(C => new
        //                                       {
        //                                           Category = C.Key,
        //                                           AveragePrice = C.Average(p => p.UnitPrice)
        //                                       });

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");
        //}
        #endregion

        #endregion

        #region LINQ - Ordering Operators

        #region 1. Sort a list of products by name

        #region Sort Accending

        //var Result = ListGenerator.ProductsList.OrderBy(p => p.ProductName);

        //Result = from p in ListGenerator.ProductsList
        //           orderby p.ProductName
        //           select p;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region sort Descending

        //var Result = ListGenerator.ProductsList.OrderByDescending(p => p.ProductName);

        //Result = from p in ListGenerator.ProductsList
        //           orderby p.ProductName descending
        //           select p;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #endregion

        #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //IEnumerable<string> sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
        //foreach (var item in sortedArr)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 3. Sort a list of products by units in stock from highest to lowest.

        //var Result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);

        //Result = from p in ListGenerator.ProductsList
        //           orderby p.UnitsInStock descending
        //           select p;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var Result = Arr
        //    .OrderBy(name => name.Length)
        //    .ThenBy(name => name);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.

        //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //var Result = words
        //    .OrderBy(word => word.Length)
        //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
        //foreach (var word in Result)
        //{
        //    Console.WriteLine(word);
        //}

        #endregion

        #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

        //var Result = ListGenerator.ProductsList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);

        //Result = from p in ListGenerator.ProductsList
        //           orderby p.Category, p.UnitPrice descending
        //           select p;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //var Result = Arr
        //    .OrderBy(word => word.Length)
        //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var Result = Arr
        //    .Where(word => word.Length > 1 && word[1] == 'i')
        //    .Reverse();
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #endregion

        #region LINQ – Transformation Operators

        #region 1. Return a sequence of just the names of a list of products.

        //var Result =ListGenerator.ProductsList.Select(p => p.ProductName);

        //     Result = from p in ListGenerator.ProductsList
        //                   select p.ProductName;

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

        //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        //var wordInfo = words.Select(w => new
        //{
        //    Uppercase = w.ToUpper(),
        //    Lowercase = w.ToLower()
        //});

        //foreach (var info in wordInfo)
        //{
        //    Console.WriteLine($"Uppercase: {info.Uppercase}, Lowercase: {info.Lowercase}");
        //}
        #endregion

        #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

        //var Result = ListGenerator.ProductsList.Select(p => new
        //{
        //    Id = p.ProductID,
        //    Name = p.ProductName,
        //    Price = p.UnitPrice
        //});

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}");
        //}

        #endregion

        #region 4. Determine if the value of int in an array match their position in the array.

        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //bool valuesMatchPosition = Arr.Any((value, index) => value == index);

        //if (valuesMatchPosition)
        //{
        //    Console.WriteLine("There is at least one value that matches its position in the array.");
        //}
        //else
        //{
        //    Console.WriteLine("No value matches its position in the array.");
        //}

        #endregion

        #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

        //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        //int[] numbersB = { 1, 3, 5, 7, 8 };

        //var Result = from a in numbersA
        //            from b in numbersB
        //            where a < b
        //            select new { NumberA = a, NumberB = b };
        //Console.WriteLine("pairs Where a < b:");
        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"{item.NumberA} is Less Than {item.NumberB}");
        //}

        #endregion

        #region 6. Select all orders where the order total is less than 500.00.

        //var Result = ListGenerator.Order.Where(order => order.TotalAmount < 500.00m);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"Order ID: {item.OrderId}, Customer: {item.Customer}, Total Amount: ${item.TotalAmount}");
        //}

        #endregion

        #region 7. Select all orders where the order was made in 1998 or later.

        //var Result = order.Where(order => order.OrderDate.Year >= 1998);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"Order ID: {item.OrderId}, Customer: {item.Customer}, Order Date: {item.OrderDate.ToShortDateString()}");
        //}
        #endregion

        #endregion

        #region LINQ - Set Operators

        #region 1. Find the unique Category names from Product List

        //var Result = ListGenerator.ProductsList.Select(p => p.Category)
        //                                              .Distinct();

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}


        #endregion

        #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

        //var list1 = ListGenerator.ProductsList.Select(P => P.ProductName[0]);
        //var list2 = ListGenerator.CustomersList.Select(C => C.CustomerName[0]);
        //var Result = list1.Union(list2);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region 3. Create one sequence that contains the common first letter from both product and customer names.
        //var list1 = ListGenerator.ProductsList.Select(P => P.ProductName[0]);
        //var list2 = ListGenerator.CustomersList.Select(C => C.CustomerName[0]);
        //var Result = list1.Intersect(list2);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
        //var list1 = ListGenerator.ProductsList.Select(P => P.ProductName[0]);
        //var list2 = ListGenerator.CustomersList.Select(C => C.CustomerName[0]);
        //var Result = list1.Except(list2);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}


        #endregion

        #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

        //var list3 = ListGenerator.ProductsList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName);
        //var list4 = ListGenerator.CustomersList.Select(C => C.CustomerName.Length >= 3 ? C.CustomerName.Substring(C.CustomerName.Length - 3) : C.CustomerName);
        //var Result = list3.Concat(list4);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}


        #endregion


        #endregion

        #region LINQ - Partitioning Operators

        #region 1. Get the first 3 orders from customers in Washington

        //var Result = ListGenerator.CustomersList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3); ;

        //Result = (from c in ListGenerator.CustomersList
        //          where c.Region == "WA"
        //          from o in c.Orders
        //          select o).Take(3);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region 2. Get all but the first 2 orders from customers in Washington.

        //var Result = ListGenerator.CustomersList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2); ;

        //Result = (from c in ListGenerator.CustomersList
        //          where c.Region == "WA"
        //          from o in c.Orders
        //          select o).Skip(2);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var Result = numbers.TakeWhile((v, i) => v > i);
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 4.Get the elements of the array starting from the first element divisible by 3.
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var Result = numbers.Where(i => i % 3 == 0 && i != 0);
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region 5. Get the elements of the array starting from the first element less than its position.

        //int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var Result = nums.SkipWhile((v, i) => v >= i);
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #endregion

        #region LINQ - Quantifiers

        #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
        //string Path = "dictionary_english.txt";
        //string[] Lines = File.ReadAllLines(Path);
        //Console.WriteLine("File read successfully.");
        //var words = Lines.Any(l => l.Contains("ei"));
        //Console.WriteLine(words);

        #endregion

        #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

        //var Result = ListGenerator.ProductsList.GroupBy(p => p.Category).Where(I => I.Count(p => p.UnitsInStock == 0) > 0);
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //    foreach (var prod in item)
        //        Console.WriteLine(prod);
        //}

        #endregion

        #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

        //var result = from p in ListGenerator.ProductsList
        //             group p by p.Category into g
        //             where g.All(p => p.UnitsInStock > 0)
        //             select g;
        //result = ListGenerator.ProductsList.GroupBy(p => p.Category)
        //                                  .Where(g => g.All(p => p.UnitsInStock > 0));
        //foreach (var category in result)
        //{
        //    Console.WriteLine(category.Key);
        //    foreach (var product in category)
        //    {
        //        Console.WriteLine(product);
        //    }
        //}


        #endregion

        #endregion

        #region LINQ – Grouping Operators

        #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

        //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //var Result = numbers.GroupBy(n => n % 5);


        //Result = from n in numbers
        //         group n by n % 5 into g
        //         select g;
        //foreach (var item in Result)
        //{
        //    Console.WriteLine($"remainder of {item.Key} when divided by 5:");
        //    foreach (var number in item)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}

        #endregion

        #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

        //var Lines = System.IO.File.ReadAllLines("dictionary_english.txt");
        //var Result = Lines.GroupBy(l => l[0]);
        //Result = from l in Lines
        //         group l by l[0] into g
        //         select g;

        //foreach (var item in Result)
        //{
        //    foreach (var word in item)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}


        #endregion

        #region 3.Use Group By with a custom comparer that matches words that are consists of the same Characters Together

        //string[] arr = { "from", "salt", "earn", "last", "near", "form" };
        //var groupedWords = arr
        //.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));

        //groupedWords = from word in arr
        //               group word by new string(word.OrderBy(c => c).ToArray()) into g
        //               select g;

        //foreach (var group in groupedWords)
        //{
        //    Console.WriteLine($"....");
        //    foreach (var word in group)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}
        #endregion

        #endregion

    }
}