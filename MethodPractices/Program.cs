using System;
using System.Collections.Generic;

namespace MethodPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicMethods methods = new DynamicMethods();
            Category category = new Category();
            Product product = methods.GetDynamicData(category);
            Console.WriteLine("Hello World!");
        }
    }
    public class DynamicMethods
    {
      public  dynamic GetDynamicData(dynamic data)
        {
            return data;
        }
      public  List<dynamic> GetDynamicData(List<dynamic> data)
        {
            return data;
        }
      public  Dictionary<dynamic,dynamic> GetDynamicData(Dictionary<dynamic, dynamic> data)
        {
            return data;
        }
    }
    public class Category
    {
        public int CategoryID { get; set; } = 1;
        public String Name { get; set; } = "Laptops";
    }
    public class Product
    {
        public int ProductID { get; set; } = 1;
        public String Name { get; set; } = "Dell Core i5";
    }
}
