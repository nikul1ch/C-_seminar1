Console.WriteLine("Введите первое число число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Второе число {number2} больше первого числа {number1}");
}
else Console.WriteLine("Введённые числа равны");