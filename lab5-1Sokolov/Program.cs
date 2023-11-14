//Вариант 6 легкий уровень
char[,] mas = new char[2, 6];
Random r = new Random();
int c = 0;
for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 6; j++)
	{
        mas[i, j] = (char) r.Next(32,138);
        Console.Write(mas[i,j] + " ");
        if (mas[i,j] == '+')  c++;
        if (mas[i, j] == '-') c++;
        if (mas[i, j] == '*') c++;
    }
    Console.WriteLine();
}
Console.WriteLine("Количество +,-,* =" + c);