namespace Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Store
{
    public static List<User> Users = new List<User>();
}