//1 task

/* Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }

    else
    {
        Console.Write($"{m} ");
    }
    PrintNaturalNumbers(m + 1, n);

}
PrintNaturalNumbers(m, n);

 */
//task2
/* Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return akkerman(m - 1, 1);
    }
    else
    {
        return akkerman(m - 1, akkerman(m, n - 1));
    }
}
Console.Write($"Функция Аккермана равно {akkerman(m, n)} "); */




//task3
//Console.Write("Введите значение : ");
//Convert.ToInt32(Console.ReadLine());
int[] arr = { 1, 3, 4, 5 };
void ReverseArray(int[] arr, int count = 1)
{
    if (count > arr.Length - 1)
    {
        return;
    }
    else
    {
        ReverseArray(arr, count + 1);
        Console.Write(" " + arr[count]);
    }
}




