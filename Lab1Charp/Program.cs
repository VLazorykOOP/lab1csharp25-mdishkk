using System;
void Task1() {
    Console.Write("Enter (v): ");
    double v = Convert.ToDouble(Console.ReadLine());

    if (v < 0)
    {
        Console.WriteLine("Invalid input!");
    }
    else
    {
        double a = Math.Cbrt(v); 
        Console.WriteLine($"Cube edge: {a:F2}");
    }
}

void Task2()
{
    Console.Write("Enter a two-digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 10 || number > 99)
    {
        Console.WriteLine("Invalid input!");
    }
    else
    {
        int digit1 = number / 10;  
        int digit2 = number % 10;  
        int sum = digit1 + digit2;

        if (sum % 2 != 0)
        {
            Console.WriteLine($"The sum of the digits ({digit1} + {digit2} = {sum}) is odd.");
        }
        else
        {
            Console.WriteLine($"The sum of the digits ({digit1} + {digit2} = {sum}) is even.");
        }
    }
}

void Task3() 
{
    Console.Write("Enter x coordinate: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter y coordinate: ");
    double y = Convert.ToDouble(Console.ReadLine());

    if (x >= -100 && x <= 100 && y <= 0 && y >= -Math.Abs(x))
    {
        Console.WriteLine("The point is inside the triangle.");
    }
    else
    {
        Console.WriteLine("The point is outside the triangle.");
    }
}

void Task4()
{
    Console.Write("Enter the number of days (n > 0): ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 0)
    {
        Console.WriteLine("Error: n must be greater than 0.");
    }
    else
    {
        DateTime pastDate = DateTime.Today.AddDays(-n);
        Console.WriteLine($"The date {n} days ago was: {pastDate.ToString("yyyy-MM-dd")}");
    }
}

void Task5()
{
    Console.Write("Enter first integer: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second integer: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = (a + b) * (a + b);

    Console.WriteLine($"The square of the sum ({a} and {b}) = {result}");
}

void Task6()
{
    Console.Write("Enter a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double n = Math.Pow(b, 2) + 1;
    double m = a + b;

    if (m == 0)
    {
        Console.WriteLine("Can`t divide by 0!");
    }
    else
    {
        double result = 5 + (b / n) + ((a - b) / m);
        Console.WriteLine($"Result: {result}");
    }
}


Console.WriteLine("0 - Task_1");
Console.WriteLine("1 - Task_2");
Console.WriteLine("2 - Task_3");
Console.WriteLine("3 - Task_4");
Console.WriteLine("4 - Task_5");
Console.WriteLine("5 - Task_6\n");
string _task = Console.ReadLine();
int task;

if (int.TryParse(_task, out task) && task >= 0 && task <= 5)
{
    task = int.Parse(_task);
    switch (task)
    {
        case 0:
            Task1();
            break;
        case 1:
            Task2();
            break;
        case 2:
            Task3();
            break;
        case 3:
            Task4();
            break;
        case 4:
            Task5();
            break;
        case 5:
            Task6();
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input");
}