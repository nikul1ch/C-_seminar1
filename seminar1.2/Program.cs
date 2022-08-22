Console.WriteLine("Введите первое число число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Число {number1} больше чисел {number2} и {number3}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Число {number2} больше чисел {number1} и {number3}");
}
else Console.WriteLine($"Число {number3} больше чисел {number1} и {number2}");