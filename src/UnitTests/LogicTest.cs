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
    public void TestMethod1(object first, object second, bool expected)
    {
        var actual = Logic.AreEqual(first, second);
        Assert.AreEqual(expected, actual);
    }
}