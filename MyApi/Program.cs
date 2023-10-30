using Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/user/getAll", () =>
{
    return Results.Ok(Store.Users);
});

app.MapGet("/user/get/{id}", (int id) =>
{
    var foundUser = Store.Users.First(u => u.Id == id);
    return Results.Ok(foundUser);
});

app.MapPost("/user/save", (User user) =>
{
    Store.Users.Add(user);
    return Results.Ok();
});

app.MapPut("/user/update", (User user) =>
{
    var foundUser = Store.Users.First(u => u.Id == user.Id);
    foundUser.Name = user.Name;
    foundUser.Age = user.Age;
    return Results.Ok();
});

app.MapDelete("/user/delete/{id}", (int id) =>
{
    var foundUser = Store.Users.First(u => u.Id == id);
    Store.Users.Remove(foundUser);
    return Results.Ok();
});

app.Run();