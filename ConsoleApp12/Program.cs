using System.Diagnostics;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Find all products that are out of stock.

            //var s=from p in ListGenerator.ProductsList
            //      where p.UnitsInStock == 0
            //      select p;
            //foreach (var unit in s) { 
            //    Console.WriteLine(unit);

            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var s = from p in ListGenerator.ProductsList
            //        where p.UnitsInStock != 0 && p.UnitPrice > 3.00m
            //        select p;
            //foreach (var unit in s)
            //{
            //    Console.WriteLine(unit);

            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var s = from item in Arr.Select((value, index) => new { Name = value, Index = index })
            //        where item.Name.Length < item.Index
            //        select item.Name;

            //foreach (var name in s)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            /////////////////////////////////////////////////////////
            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var x=Arr1.Count(p=>p%2==0);

            //    Console.WriteLine(x);

            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var x=from p in ListGenerator.CustomersList 
            //      select (p.CustomerID, p.Orders.Count());
            //foreach (var name in x)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var x = from p in ListGenerator.ProductsList
            //        group p by p.Category;
            //foreach (var name in x)
            //{
            //    Console.WriteLine($"Category: {name.Key}, Count: {name.Count()}");

            //}

            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var x = Arr.Sum();
            //Console.WriteLine(x);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int totalChars = words.Sum(word => word.Length);
            //Console.WriteLine($"Total characters: {totalChars}");

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var x = words.Min(z => z.Length);
            //Console.WriteLine(x);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var x = words.Max(z => z.Length);
            //Console.WriteLine(x);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var x = words.Average(z => z.Length);
            //Console.WriteLine(x);
            #endregion

            ///////////////////////////////
            #region 1. Sort a list of products by name
            //var x = ListGenerator.ProductsList.OrderBy(p => p.ProductName);
            //foreach (var name in x)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in sorted)
            //{
            //    Console.WriteLine(w);
            //}
            #endregion


            #region 3. Sort a list of products by units in stock from highest to lowest
            //var x = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var name in x)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var x = Arr.OrderBy(p => p.Length).ThenBy(p => p);
            //foreach (var name in x)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var x = Arr.OrderBy(p => p.Length).ThenBy(p => p, StringComparer.OrdinalIgnoreCase);
            //foreach (var name in x)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var x = ListGenerator.ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var name in x)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i') .Reverse();                                         

            //Console.WriteLine(string.Join(", ", result));
            #endregion
            //////////////////////////////
            #region 1. Return a sequence of just the names of a list of products.
            //var x=from p in ListGenerator.ProductsList
            //      select p;
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var x = from p in words
            //        select  p.ToUpper();
            //var xxx = from p in words
            //        select  p.ToLower();
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var x = from p in ListGenerator.ProductsList
            //            select new
            //{
            //    p.ProductID,
            //     p.ProductName,
            //     Price = p.UnitPrice   
            // }; 
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var x = Arr.Select((value, index) => new { value, index })
            //.Where(item => item.value == item.index);
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs =from a in numbersA
            //        from b in numbersB
            //        where a < b
            //        select new { A = a, B = b };

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var x= from p in ListGenerator.ProductsList
            //       where (p.UnitPrice == 500.00m)
            //       select p;
            #endregion

            #region 7. Select all orders where the order was made in 1998 or late
            var x = from p in ListGenerator.ProductsList
                    from o in Order
                    where (o.OrderDate < 1998)
                    select p;
            #endregion
        }
    }
}
