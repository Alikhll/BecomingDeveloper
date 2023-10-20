namespace Classes;

public class BasicSample
{
    public static void Sample1()
    {
        Lesson l1 = new Lesson();
        l1.Show();

        Lesson l2 = new Lesson("NewLesson");
        l2.Show();
    }
}


public class Lesson
{
    public string Title;

    public Lesson()
    {
        Title = "Default";
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