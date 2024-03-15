using Assignment2;

ProcessNumbers();

static void ProcessNumbers()
{
    Store store = new Store();
    store.Data = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    int evenNumbers = 0;
    int oddNumbers = 0;

    foreach (var item in store.Data)
    {
        if (item % 2 == 1)
        {
            Console.WriteLine($"{item} is an odd number");
            oddNumbers = oddNumbers + item;
        }
        else
        {
            Console.WriteLine($"{item} is an even number");
            evenNumbers = evenNumbers + item;
        }
    }
    Console.WriteLine($"Total even numbers: {evenNumbers}");
    Console.WriteLine($"Total odd numbers: {oddNumbers}");
}