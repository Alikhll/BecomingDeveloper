User u = new User();
u.Name = "abc";
u.Age = 12;

u.Print();

User.StaticPrint();

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Print()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }

    public static void StaticPrint()
    {
        Console.WriteLine("I am static method!");
    }
}


// --------- Sample ----------

static void Sample()
{
    Lesson l1 = new Lesson();
    l1.Show();

    Lesson l2 = new Lesson("NewLesson");
    l2.Show();
}

public class Lesson
{
    public string Title { get; set; }

    public Lesson()
    {
        Title = "Default"
    }

    public Lesson(string title)
    {
        Title = title;
    }

    public void Show()
    {
        Console.WriteLine(Title);
    }
}