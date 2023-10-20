// we use namespace for packaging and we call it here "Models"
namespace Models;

public class User
{
    // we made these properties private, and they are not accesible outside of the class anymore
    // we only have access to them inside the class
    private string Name;
    private int Age;

    // we define a constructor and allow the consumer to provide some data
    // and then we put it into our private properties
    // so we strict the usage of our class, to ensure some sules for the consumer of this particular class
    // var u = new User("abc", 18); (it should be used in that way)
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // a private method to be used inside the class 
    private bool IsAllowedToVote()
    {
        if (Age >= 18 && Age < 99)
        {
            return true;
        }

        return false;
    }

    // the only public method can be called from outside of the class
    public void PrintIfEligible()
    {
        // we call this private method because we have access it only inside the class
        bool isAllowed = IsAllowedToVote();

        // check the result and if it's allowed we'll print it subsequently
        if (isAllowed)
        {
            Console.WriteLine(Name + " is eligible to vote!");
        }
    }
}