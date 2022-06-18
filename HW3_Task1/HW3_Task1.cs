Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
void palindrome (int N)
{
    int a = number/1000;
    int b = number%100;
    if( a/10 == b%10 && a%10 == b/10)
    {
        Console.WriteLine("inputed number is a palindrome ");
    }
    else
    {
        Console.WriteLine("inputed number is not a palindrome");
    }
}

palindrome(number);