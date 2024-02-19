using ConsoleApp;

namespace UnitTests;

[TestClass]
public class LogicTest
{
    [DataTestMethod]
    [DataRow(0, 0, true)]
    [DataRow(0, 1, false)]
    [DataRow(true, true, true)]
    [DataRow("Test", "Test", true)]
    [DataRow("Test", "TEST", false)]
    public void AreEqual(object first, object second, bool expected)
    {
        var actual = Logic.AreEqual(first, second);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Max_IsBigger()
    {
        var actual = Logic.Max(10, 1);
        Assert.AreEqual(10, actual);
    }
}