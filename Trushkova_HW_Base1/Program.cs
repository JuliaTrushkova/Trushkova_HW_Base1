// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


while (true)
{


    double SideFromClient(int num)
    {
        try
        {
            Console.WriteLine($"Введите {num}-ю сторону прямоугольника:");
            return Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Show(ex.Message);
        }
    }

    void Show(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}