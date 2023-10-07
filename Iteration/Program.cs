
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





// -----------------------------------
// --------- Other Sample ------------
// -----------------------------------



static void PrintList(List<int> nums)
{
    Console.WriteLine("----------------");

    foreach (var number in nums)
    {
        Console.WriteLine(number);
    }
}

static void Sample1()
{
    List<int> numbers = new List<int>()
    {
        1, 5, 12, -4, 0, 20, 42, -11, 1, 1, 94, 70, 66, -52, 15
    };

    PrintList(numbers);

    // filter all numbers that are greater than 18 and list it afterwards
    List<int> a1 = numbers.Where(n => n > 18).ToList();
    PrintList(a1);

    // filter all numbers that are greater than 18 and less equal to 99 and list it aferwards
    List<int> a2 = numbers.Where(n => n > 18 && n <= 99).ToList();
    PrintList(a2);

    //use can simplify and use "var" instead and the type will be inferred
    var a3 = numbers.Where(n => n > 18 && n <= 99).ToList();
    PrintList(a2);

    //we could use "var" here as well! 
    int a4 = numbers.Where(n => n == 5).First(); //now we only ask for one object instead of list
    Console.WriteLine(a4);

    int a5 = numbers.Where(n => n == 50000).FirstOrDefault(); //If it doesn't find anything, it wont throw an exception and instead return the default value of the type which is 0 here
    Console.WriteLine(a5);
}




// -----------------------------------
// --------- Other Sample ------------
// -----------------------------------






static void Sample2()
{
    // create an instance of array (the difference is the fixed size here as opposed to indifiente list options)
    int[] nums = new int[4];
    nums[0] = 1; // add 1 to the begening of the array (array starts from zero)
    nums[3] = 33333; //add this to the third index of array (at this case the last parameter in the array)

    //print the length of array
    Console.WriteLine(nums.Length);

    // iterate through an array
    foreach (var number in nums)
    {
        Console.WriteLine(number);
    }
}

