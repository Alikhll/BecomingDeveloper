using Iterations;

List<int> numbers = new List<int>(); // create a list of integers

numbers.Add(1); // add 1 to the list
numbers.Add(10); // add 10 to the list
numbers.Add(-5);
numbers.Add(6);

// print the count of list
Console.WriteLine("Count: " + numbers.Count);

//iterate through the list and print all of them
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------");

// remove 10 from the list (if 10 doesnt exist, it'll throw an exception! will be discussed later
numbers.Remove(10);
numbers.Remove(-5); // remove -5 from the list

//iterate through the list again
foreach (var number in numbers)
{
    Console.WriteLine(number);
}




///////////////////////
///////////////////////
///////////////////////


//TroubleShootingSample.Trouble1();