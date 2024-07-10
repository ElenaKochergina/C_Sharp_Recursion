//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

void Main()
 {
    int number1 = ReadInt("Введите первое число из данных чисел (0, 1, 2, 3): ");
    int number2 = ReadInt("Введите второе число из данных чисел (0, 1, 2, 3): ");
    System.Console.WriteLine(PrintNumber(number1, number2));
 }
     int PrintNumber(int m, int n) {
        // Базовый случай
        if (m == 0) {
            return n + 1;
        } // Шаг рекурсии / рекурсивное условие
        else if (n == 0 && m > 0) {
            return PrintNumber(m - 1, 1);
        } // Шаг рекурсии / рекурсивное условие
        else {
            return PrintNumber(m - 1, PrintNumber(m, n - 1));
        }
    }
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
 Main();
