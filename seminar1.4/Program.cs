Console.WriteLine("Введите целое число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number < 2)
{
    Console.WriteLine($"Введённое число {number} меньше 2");
}
else
{
    Console.WriteLine($"Четные числа от 1 до {number}(включительно):");
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}