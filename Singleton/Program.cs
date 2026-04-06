Console.WriteLine("Before accessing instance");

var singleton1 = Singleton.Instance;

Console.WriteLine("After accessing instance");

var singleton2 = Singleton.Instance;

sealed class Singleton
{
    private static Singleton _instance = default!;
    public static Singleton Instance { 
        get
        {
            if (_instance is null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    } 

    private Singleton()
    {
        Console.WriteLine("Instantiating singleton");
    }
}