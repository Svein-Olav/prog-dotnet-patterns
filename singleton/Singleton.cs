// Singleton class in singleton pattern
public class Singleton
{
    private static Singleton? instance = null;
    private static readonly object padlock = new object();
    private Singleton() { }
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (padlock)
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }                                            
            }
            return instance;
        }
    }

    public string  DoSomething()
    {
        Console.WriteLine("Hello from Singleton!");
        return "Hello from Singleton!";
    }
}
