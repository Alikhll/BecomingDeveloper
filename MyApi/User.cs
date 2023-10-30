namespace Models;

public class User
{
    public int Id;
    public string Name;
    public int Age;
}

public class Store
{
    public static List<User> Users = new List<User>();
}