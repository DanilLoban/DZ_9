// See https://aka.ms/new-console-template for more information
int Numbers(int M, int N)
{
    if(M < 0) Console.Write("Не натуральное число");
    if(N < 0) Console.Write("Не натуральное число");
    if(M >= N) return M;
    else 
    {
        return M + Numbers(M + 1, N);
    }
}
Console.WriteLine(Numbers(1, 10));