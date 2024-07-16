//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

   void Main()
{
    int M = ReadInt("Введите число M из отрезка [ M; N]: ");
    int N = ReadInt("Введите число N из отрезка [ M; N]: ");
    PrintNumbers(M, N); 
}
    static void PrintNumbers(int M, int N)
    {
        if (M > N) //рекурсия завершится, если выполнится условие
        {
            return;
        }
           Console.WriteLine(M);

        PrintNumbers(M + 1, N); //рекурсивный вывод для следующего значения
    }
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();