//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int A, int B)
{
    int num = 1;
    for (int i = 0; i < B; i++)
    {
        num = num * A;
    }

    return num;
}

int number_a = ReadInt("Введите первое число");
int number_b = ReadInt("Введите второе число");
int num = Exponentiation(number_a, number_b);

System.Console.WriteLine(num);

