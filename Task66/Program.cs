Console.WriteLine("Задайте значение промежутка числами M и N");

int Fullnumb(string text)
{
Console.Write(text + ": ");
int numb = Convert.ToInt32(Console.ReadLine());
return numb;
}

int numb1 = Fullnumb("Введите значение числа M(Начало числового отрезка)");
int numb2 = Fullnumb("Введите значение числа N(Конец числового отрезка)");

if(numb1>numb2)
{
    Console.WriteLine("Некорректный ввод данных! M не должно быть больше N.");
}
else
{
    int sum = numb1;
    for(int i = numb1; i < numb2; i++)
    {
        numb1++;
        sum += numb1;
    }
    Console.WriteLine($"Суммой натуральных элементов в промежутке от M до N является число: {sum}");
}