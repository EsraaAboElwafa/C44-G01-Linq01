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
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var s = from item in Arr.Select((value, index) => new { Name = value, Index = index })
                    where item.Name.Length < item.Index
                    select item.Name;

            foreach (var name in s)
            {
                Console.WriteLine(name);
            }

            #endregion
        }
    }
}
