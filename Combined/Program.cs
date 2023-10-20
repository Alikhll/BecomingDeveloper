// we use "using" to import whatever package (in that case we need "Models" that has been declared inside "User.cs")
using Models;

// here we create a list of "User" and directly instantiate some values into it
var users = new List<User>()
{
    //we instanciate using the constructor that has been provided and pass some information
    new User("aaa", 12),
    new User("bbb", 19),
    new User("ccc", 102),
    new User("ddd", 25),
};

// we can alway add or remove whatever into the list
users.Add(new User("Another", 16));

foreach (var user in users)
{
    user.PrintIfEligible();
}






// there is anothe way to iterate using "for" in this way
// create and index called "i" from 0 and after each iteration update the index using "i++"
// and this iteration is going to stop whenever this condition is not met anymore (i < users.Count)
for (int i = 0; i < users.Count; i++)
{
    // now we use and index to get the desired user from our list
    // and the call the "PrintIfEligible" methods afterwards
    users[i].PrintIfEligible();
}

