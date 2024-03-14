
public abstract class Singleton<T> where T : class, new()
{
    private static T _instance;
    public static T instance { get { return _instance ?? (_instance = new T()); } }

    protected Singleton() { }
};