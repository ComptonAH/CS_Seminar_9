int RecursiveSumma(int number)
{
    int sum = number%10;
    int lengthNumber = Convert.ToString(number).Length;
    if (lengthNumber == 1) return sum;
    number = number/10;
    return sum + RecursiveSumma(number);
}

Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = RecursiveSumma(number);

Console.WriteLine(sum);