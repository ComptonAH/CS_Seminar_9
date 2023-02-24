string RecursiveSequence(int M, int N)
{
    string Sequence = string.Empty;
    Sequence = Convert.ToString(M) + " ";
    if (M == N) return Sequence = $"{N}";
    return Sequence + RecursiveSequence(M + 1, N);
}

Console.WriteLine("Enter the begining of the sequence:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the end of the sequence:");
int N = Convert.ToInt32(Console.ReadLine());

string RecSeq = RecursiveSequence(M, N);
Console.WriteLine("{0}", RecSeq.Replace(' ', ','));