User user = new User();
user.Name = "abc";
user.Age = 12;

user.Print();

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Print()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
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