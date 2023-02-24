string RecursiveSequence(int N, int count)
{
    string Sequence = string.Empty;
    Sequence = Convert.ToString(count) + " ";
    if (count == N) return Sequence = $"{count}";
    return Sequence + RecursiveSequence(N, count + 1);
}

Console.WriteLine("Enter the end of the sequence:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
string RecSeq = RecursiveSequence(N, count);
Console.WriteLine("{0}", RecSeq.Replace(' ', ','));