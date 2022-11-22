int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int randomNumber = GetRandomNumberInRange(1, 7);
if(randomNumber == 6)
{
    Console.WriteLine($"День под номером {randomNumber} - да");
}
else
{
   if(randomNumber == 7)
    {
        Console.WriteLine($"День под номером {randomNumber} - да");
    }
    else
    {
        Console.WriteLine($"День под номером {randomNumber} - нет"); 
    }
}
