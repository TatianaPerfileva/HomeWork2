Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6)  
    {
        Console.WriteLine("рабочий день");
    }
else if (number < 8)
    {
        Console.WriteLine("выходной день");
    }
else
    {
        Console.WriteLine("неверный ввод");
    }