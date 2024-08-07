using Collections.App;

namespace Collections.Tests;
public class ProgramTests
{
    [Fact]
    public void GenerateRandomNumbers_ShouldReturnArrayOfGivenLength()
    {
        int length = 10;
        int[] result = Program.GenerateRandomNumbers(length);
        Assert.Equal(length, result.Length);
    }

    [Fact]
    public void PrintArray_ShouldPrintAllElements()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        using (var sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            Program.PrintArray(array);
            var result = sw.ToString().Trim();
            var expected = string.Join(Environment.NewLine, array);
            Assert.Equal(expected, result);
        }
    }

    [Fact]
    public void CreateNameList_ShouldReturnListOfNames()
    {
        List<string> result = Program.CreateNameList();
        Assert.NotNull(result);
        Assert.True(result.Count > 0);
    }

    [Fact]
    public void PrintList_ShouldPrintAllNames()
    {
        List<string> list = new List<string> { "Alice", "Bob", "Charlie" };
        using (var sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            Program.PrintList(list);
            var result = sw.ToString().Trim();
            var expected = string.Join(Environment.NewLine, list);
            Assert.Equal(expected, result);
        }
    }

    [Fact]
    public void CreateNameAgeDictionary_ShouldReturnDictionary()
    {
        Dictionary<string, int> result = Program.CreateNameAgeDictionary();
        Assert.NotNull(result);
        Assert.True(result.Count > 0);
    }

    [Fact]
    public void PrintDictionary_ShouldPrintAllKeyValuePairs()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };
        using (var sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            Program.PrintDictionary(dictionary);
            var result = sw.ToString().Trim();
            var expected = string.Join(Environment.NewLine, dictionary.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
            Assert.Equal(expected, result);
        }
    }

    [Fact]
    public void FindOldestPerson_ShouldReturnOldestPerson()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };
        var result = Program.FindOldestPerson(dictionary);
        Assert.Equal("Charlie", result.Key);
        Assert.Equal(35, result.Value);
    }

    [Fact]
    public void CalculateAverage_ShouldReturnCorrectAverage()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double result = Program.CalculateAverage(numbers);
        Assert.Equal(3.0, result, 2);
    }
}
