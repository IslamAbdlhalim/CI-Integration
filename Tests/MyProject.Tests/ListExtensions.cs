
using Xunit;

namespace MyProject.Tests;

public class ListExtensions
{
    [Fact]
    public void ConcatenateStrings_ListOfStrings_ReturnsConcatenatedString()
    {
        List<string> mockList = new List<string>() { "Cat", "Dog", "Elephant"};
        
        Assert.Equal("Cat,Dog,Elephant,", mockList.ConcatenateStrings());
    }
    
}
