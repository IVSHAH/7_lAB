Console.WriteLine("Здравствуйте!");
Console.WriteLine("Перове число:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите оператор (+,-,*,/,^):*");
char op = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Второе число:");
double x2 = Convert.ToDouble(Console.ReadLine());
double res = 0;
switch (op)
{
    case'+':
        res = x1 + x2;
        break;
    case '-':
        res = x1 - x2;
        break;
    case '*':
        res = x1 * x2;
        break;
    case '/':
        res = x1 / x2;
        break;
    case '^':
        res = Math.Pow(x1, x2);
        break;
    default:
        Console.WriteLine("Неверный оператор");
        break;
}
Console.WriteLine("Результат:" + res);

