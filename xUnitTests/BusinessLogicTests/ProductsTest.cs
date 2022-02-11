using Xunit;
using BusinessLogic;
using System;
using System.Collections.Generic;

namespace BusinessLogicTests;



public class ProductsTest
{
    
   [Theory]
   [MemberData(nameof(ProductsTest.Data), MemberType = typeof(ProductsTest))]
   public void ShouldNeedReplenishmentWhenStockIsLowerThanMinimium(string Name, int UnitsInStock, int MinimumStockPlanned, bool expectedResult) 
   {
       var prod = new Product(Name, UnitsInStock, MinimumStockPlanned);
       var needRepl = prod.NeedReplenish();
       Assert.Equal<bool>(expectedResult, needRepl);
   }

   public static IEnumerable<object []> Data =>
     new List<object []>
   {
        new object[] {"Pencil", 10, 50, true},
        new object[] {"Eraser", 50, 25, false},
        new object[] {"Ruler", 15, 25, true},
        new object[] {"Crayons", 150, 50, false},
        new object[] {"Notebook", 250, 50, false}
   };
}