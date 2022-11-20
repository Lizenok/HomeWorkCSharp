Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int Start = 1;
if (Number > 0)
{   
    Start = 2;
    while (Start <= Number)
    {
        Console.Write(Start + " ");
        Start = Start + 2;
    }
}
else
{
    Start = 0;
    while (Start >= Number)
    {
        Console.Write(Start + " ");
        Start = Start - 2;
    } 
}