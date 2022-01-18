// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");


while (true)
{
    try
    {
        double side1 = SideFromClient(1);
        double side2 = SideFromClient(2);

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Периметр прямоугольника со сторонами {side1} и {side2} равен {rectangle.Perimeter}");
        Console.WriteLine($"Площадь прямоугольника со сторонами {side1} и {side2} равна {rectangle.Area}");
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Show(ex.Message);
    }
}


double SideFromClient(int num)
{
    double side = 0;
    while (true)
    {        
        try
        {
            Console.WriteLine($"Введите {num}-ю сторону прямоугольника:");
            side = Convert.ToDouble(Console.ReadLine());
            break;
        }
        catch (Exception ex)
        {
            Show(ex.Message);
        }        
    }
    return side;
}

void Show(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}