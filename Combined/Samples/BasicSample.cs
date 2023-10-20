namespace Combined;

public class AnotherUser
{
    public string Name;
    public int Age;

    public static void Sample()
    {
        var users = new List<AnotherUser>()
        {
            //instantiate directly using their public properties
            new AnotherUser() { Name = "aaa", Age = 12},
            new AnotherUser() { Name = "bbb", Age = 18},
            new AnotherUser() { Name = "ccc", Age = 55},
            new AnotherUser() { Name = "ddd", Age = 42},
        };

        var a1 = users.Where(u => u.Name == "aaa").ToList();
        var a2 = users.Where(u => u.Name == "aaa").First();
        var a3 = users.Where(u => u.Name == "aaa111").FirstOrDefault();

        var b1 = users.Where(u => u.Name.Contains("a")).ToList();
        var b2 = users.Where(u => u.Name.Contains("a") && u.Age > 18).ToList();
        var b3 = users.Where(u => (u.Name.Contains("a") && u.Age > 18) || u.Name == "bbb").ToList();

        var c1 = users.Where(u => u.Name.StartsWith("a")).ToList();
        var c2 = users.Where(u => u.Name.Length == 3).ToList();
        var c3 = users.Where(u => u.Age > 18 && u.Age < 99).ToList();
    }
}