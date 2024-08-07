using ControlFlow.App;

namespace ControlFlow.Tests;

public class ProgramTests
{
    [Fact]
    public void TestIsDog()
    {
        Assert.True(Program.IsDog("dog"));
        Assert.True(Program.IsDog("Dog"));
        Assert.False(Program.IsDog("cat"));
    }

    [Fact]
    public void TestGetAnimalSound()
    {
        Assert.Equal("bark", Program.GetAnimalSound("dog"));
        Assert.Equal("meow", Program.GetAnimalSound("cat"));
        Assert.Equal("moo", Program.GetAnimalSound("cow"));
        Assert.Equal("baa", Program.GetAnimalSound("sheep"));
        Assert.Equal("unknown sound", Program.GetAnimalSound("lion"));
    }

    [Fact]
    public void TestPrintAnimalSound10Times()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        Program.PrintAnimalSound10Times("bark");
        var result = sw.ToString().Trim();
        var expected = string.Join(Environment.NewLine, Enumerable.Repeat("bark", 10));
        Assert.Equal(expected, result);
    }
}
