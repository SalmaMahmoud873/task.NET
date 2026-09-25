using System;
using System.Linq;
using System.Runtime.InteropServices;
using Day02_LINQ_task;
using static
Day02_LINQ_task.ListGenerators;
using System.IO;


namespace Day02_LINQ_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1.
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region 2.
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region 3.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((name, index) => name.Length < index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            #region LINQ - Element Operators

            #region 1.
            //var firstOutOfStock = ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutOfStock); 
            #endregion

            #region 2.
            //var firstProductOver1000 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(firstProductOver1000); 
            #endregion

            #region 3.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var SecondGreaterthan5 = Arr.Where(n => n > 5).ElementAt(1);
            //Console.WriteLine(SecondGreaterthan5);  
            #endregion
            #endregion

            #region LINQ - Aggregate Operators

            #region 1.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int oddCount = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine(oddCount); 
            #endregion

            #region 2.
            //var customerOrders = CustomerList.Select(c => new
            //{
            //    CustomerName = c.Name,
            //    OrdersCount = c.Orders.Count()
            //});

            //foreach (var customer in customerOrders)
            //{
            //    Console.WriteLine(customer.CustomerName+" : "+customer.OrdersCount);
            //} 
            #endregion

            #region 3.
            //var categoryProducts = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductCount = g.Count()
            //    });
            //foreach (var category in categoryProducts)
            //{
            //    Console.WriteLine(category.Category + " : " + category.ProductCount);
            //} 
            #endregion

            #region 4.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int total = Arr.Sum();

            //Console.WriteLine(total); 
            #endregion

            #region 5.

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine(totalCharacters);  
            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1.
            //var result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region 2.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3.

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName+" : " + product.UnitsInStock);
            //}
            #endregion

            #region 4.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .OrderBy(x => x.Length)
            //    .ThenBy(x => x);

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region 5.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = words
            //    .OrderBy(x => x.Length)
            //    .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 6.

            //var result = ProductList.OrderBy(p => p.Category)
            // .ThenByDescending(p => p.UnitPrice);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.Category + " : " + product.ProductName + " : " + product.UnitPrice);
            //}

            #endregion

            #region 7.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(x => x.Length)
            //    .ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 8.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(x => x[1] == 'i').Reverse();

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1.
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 2.
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //} 
            #endregion

            #region 3.

            //var result = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    p.Category,
            //    Price = p.UnitPrice
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.Category} - {item.Price}");
            //} 
            #endregion

            #region 4.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((value, index) => new
            //{
            //    Number = value,
            //    InPlace = value == index
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.InPlace}");
            //} 

            #endregion

            #region 5.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(a => numbersB
            //    .Where(b => a < b)
            //    .Select(b => new
            //    {
            //        A = a,
            //        B = b
            //    }));

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //} 
            #endregion

            #region 6.
            //var result = CustomerList.SelectMany(c => c.Orders)
            // .Where(o => o.Total < 500.00);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //} 
            #endregion

            #region 7.
            //var result = CustomerList.SelectMany(c => c.Orders)
            //  .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //} 
            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1.
            //var result = ListGenerators.CustomerList

            //    .Where(c => c.Address == "Washington")

            //    .SelectMany(c => c.Orders)

            //    .Take(3);

            //foreach (var order in result)
            //    Console.WriteLine(order); 
            #endregion

            #region 2.
            //var result = ListGenerators.CustomerList

            //    .Where(c => c.Address == "Washington")

            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //foreach (var order in result)
            //    Console.WriteLine(order); 
            #endregion

            #region 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region 4.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region 5.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion
            #endregion

            LINQ - Quantifiers
        }
    }
}
