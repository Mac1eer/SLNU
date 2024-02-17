static double Function(double x) //Создаем метод для записи фуккции, принимающая дробное значение 
{
    return 3 * Math.Pow(x, 4) + 4 * Math.Pow(x, 3) - 12 * x * x + 1; //Сама функция
}
static double MethodBisection(double a, double b, double tol) //Создаем метод для итераций 
{
    if (Function(a) * Function(b) >= 0)
    {
        throw new Exception("Функция имеет одинаковый знак в точках a и b."); //Проверяет, совподает ли знак функции при значениях а и b, и если да, выводит исключение 
    }
    double c = a; //Присваиваем "с" значение "а", чтобы в последствии вернуть "с"
    while ((b - a) >= tol) //Начало итераций
    {
        c = (a + b) / 2; //Вычисление среднего значения
        if (Function(c) * Function(a) > 0)
        {
            a = c;
        }
        else
        {
            b = c;
        }
    }
    return c;
}
        Console.WriteLine("Введите a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        int b = Convert.ToInt32(Console.ReadLine());
        double tol = 0.0001;
        double result = MethodBisection(a, b, tol);
        Console.WriteLine($"Ответ: {result}");



