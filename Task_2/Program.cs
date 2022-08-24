Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

if (number > 100 && number < 1000)
        {
            number = number % 10;
            System.Console.WriteLine($"Третье число = {number}");
        }
else{
    Console.WriteLine($"Число {number} не трехзначное");
}


