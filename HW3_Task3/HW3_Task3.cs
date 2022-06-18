Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
void Method(int N)
{
    for (int i=1; i<=N; i++)
    {
        int s = Convert.ToInt32(Math.Pow(i,3));
        Console.WriteLine($"{s}");
    }
}
Method(number);
