
int Fullnumb(string text)
{
Console.Write(text + ": ");
int numb = Convert.ToInt32(Console.ReadLine());
return numb;
}

int numberM = Fullnumb("Введите начальное число m");
int numberN = Fullnumb("Введите начальное число n");

int AFunct(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AFunct(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AFunct(numberM - 1, AFunct(numberM, numberN - 1));
return AFunct(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел ({numberM},{numberN}) = {AFunct(numberM, numberN)}");
