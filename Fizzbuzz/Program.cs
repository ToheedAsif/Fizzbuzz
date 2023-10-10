for (int x = 1; x <= 100; x++) 
{ 
    string result = "";

    if (x % 3 == 0) 
    {
        result += "Fizz";
    }

    if (x % 5 == 0) 
    {
        result += "Buzz";
    }

    if (x % 7 == 0) 
    {
        result += "Bang";
    }

    if (x % 13 == 0) 
    {
        result += "Fezz";
    }

    if (x % 11 == 0) 
    {
        result = "Bong";
        
    }


    if (result.Length == 0)
    {
        Console.WriteLine(x);
    }
    else
    {
        Console.WriteLine(result);
    }
}
