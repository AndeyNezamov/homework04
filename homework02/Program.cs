int Sum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum = sum + (number % 10);
        number /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine(sum);