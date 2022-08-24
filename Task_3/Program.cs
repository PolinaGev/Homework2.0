string[] arr = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите число от 1 до 7: ");

int number = int.Parse(Console.ReadLine());

if (number > 5 && number <= 7)
{
Console.WriteLine($"{number} день недели это - {arr[number - 1]} выходной день");
}

else if (number > 7 || number < 1)
{
Console.WriteLine("Неверное число.");
}
else
{
Console.WriteLine($"{number} день недели это - {arr[number - 1]} не выходной день");
}