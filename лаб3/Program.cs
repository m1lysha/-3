try
{
    Console.Write("Введите номер места товара: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"Секция={(x / 120) + 1}");
    Console.WriteLine($"Ярус={((x % 120) / 15) + 1}");
}
catch
{
    Console.WriteLine("Введите правильно!");
}
