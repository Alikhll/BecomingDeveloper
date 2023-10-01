using Models;

var users = new List<User>()
{
    new User("aaa", 12),
    new User("bbb", 19),
    new User("ccc", 102),
    new User("ddd", 25),
};

users.Add(new User("Another", 16));

// foreach (var user in users)
// {
//     user.PrintIfEligible();
// }

for (int i = 0; i < users.Count; i++)
{
    users[i].PrintIfEligible();
}