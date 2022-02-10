using Xunit;
using BusinessLogic;
using System;

namespace BusinessLogicTests;

public class CustomerTest
{

    [Theory]
    [InlineData("Bill", "Paul", "Bill Paul")]
    [InlineData("Bill", "", "Bill")]
    public void FullNameShouldHaveFirstAndLast(string FirstName, string LastName, string expectedResult)
    {
        Customer cust = new Customer(FirstName, LastName);

        //check the expected first and last names
        Assert.True(cust.GetFullName().Equals(expectedResult));
    }

    [Fact]
    public void NameShouldBeRequired()
    {
        var act = () => new Customer(string.Empty, string.Empty);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);
    
        //check if it throws the exception and the message properly
        Assert.Equal("The field FirstName is required", exception.Message);
    }
    
}