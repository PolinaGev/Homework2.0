Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

while (number >= 100)
        {
            number /= 10;
        }

        int result = number % 10;

System.Console.WriteLine($"Второе число = {result}");
