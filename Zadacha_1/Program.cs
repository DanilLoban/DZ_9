// See https://aka.ms/new-console-template for more information
int Numbers(int N)
{
    if(N < 0)
    {
        Console.Write("Не натуральное число");
    }
    if(N == 1)
    {
        return 1;
    }
    else 
    {
        Console.Write(N + " ");
        return Numbers(N - 1);
    }
}
Console.WriteLine(Numbers(20));