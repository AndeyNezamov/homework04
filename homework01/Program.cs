int degree(int number1, int number2)
{
    int result = 1;
    for(int i = 1; i <= number2; i++)
        result *=number1;
    return result;
    
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int Degree = Convert.ToInt32(Console.ReadLine());
int result = degree(number, Degree);
Console.WriteLine(result);