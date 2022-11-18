Random rand = new Random();
int number;
number = rand.Next(0, 1000000);
Console.WriteLine("Случайное число:" + number);
if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
 else if (number < 1000)
    {  
        Console.WriteLine("Третья цифра:" + number%10);
    } 
 else if (number < 10000)
    {
        Console.WriteLine("Третья цифра:" + number%100/10);
    }  
 else if (number < 100000)
    {
        Console.WriteLine("Третья цифра:" + number%1000/100);
    }      
else if (number < 1000000)
    {
        Console.WriteLine("Третья цифра:" + number%10000/1000);
    }