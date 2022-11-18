Random rand = new Random();
int number;
number = rand.Next(100, 1000);
Console.WriteLine("Случайное трехзначное число:" + number);
Console.WriteLine("Второе число:" + number/10%10);
