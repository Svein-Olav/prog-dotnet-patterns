namespace singleton.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
            var message = Singleton.Instance.DoSomething();
            Assert.Equal("Hello from Singleton!", message);
    }
}