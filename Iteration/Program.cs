
List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(10);
numbers.Add(-5);
numbers.Add(6);

Console.WriteLine(numbers.Count);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------");

numbers.Remove(10);
numbers.Remove(-5);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// --------- Other Sample ------------

static void Sample()
{
    int[] nums = new int[4];
    nums[0] = 1;
    nums[3] = 33333;

    Console.WriteLine(nums.Length);

    foreach (var number in nums)
    {
        Console.WriteLine(number);
    }
}

