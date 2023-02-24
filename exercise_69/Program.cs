int RecursiveExponintation(int number, int power, int count)
{
    if (count == power) return number;
    return number * RecursiveExponintation(number,power,count+1);
}

Console.WriteLine("Enter the number you want to raise to a power:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the power of the number:");
int power = Convert.ToInt32(Console.ReadLine());
int count = 1;

int result = RecursiveExponintation(number,power,count);

Console.WriteLine(result);