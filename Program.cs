// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void dz41(){
    Console.Write("Укажите кол-во чисел: ");
    int qty = Convert.ToInt32(Console.ReadLine());
    EnterNumbers(qty);
}

void EnterNumbers(int qty){
    int result = 0;
    for (int i = 0; i < qty; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            result = result + 1;
        }
    }
    Console.WriteLine(result);
}

dz41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void dz43()
{
    Console.Write("Введите b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());  
    Console.Write("Введите k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Intersection(b1, k1, b2, k2);
}

void Intersection(double b1, double k1, double b2, double k2){
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}

dz43();