namespace Models;

public class User
{
    private string Name { get; set; }
    private int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    private bool IsAllowedToVote()
    {
        if (Age >= 18 && Age < 99)
        {
            return true;
        }

        return false;
    }

    public void PrintIfEligible()
    {
        bool isAllowed = IsAllowedToVote();

        if (isAllowed)
        {
            Console.WriteLine(Name + " is eligible to vote!");
        }
    }
}