// Показать натуральные числа от M до N, N и M заданы

string Segment(int M, int N)
{
    if (M == N + 1) return string.Empty;
    else return Segment(M, N - 1) + " " + N;
}

Console.WriteLine(Segment(1, 5));


// Написать программу вычисления функции Аккермана
// только для положительных и малых чисел

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    else
      if (a != 0 && b == 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));
}

Console.WriteLine(Akkerman(3, 5));

// Найти сумму элементов от M до N, N и M заданы

int Summa(int M, int N)
{
    if (M == N) return N;
    else return N + Summa(M, N - 1);
}

Console.WriteLine(Summa(1, 5));


// Написать программу возведения числа А в целую степень B

int Pow(int A, int B)
{
    if (B == 1) return A;
    else return A * Pow(A, B - 1);
}

Console.WriteLine(Pow(3, 4));


// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

string ShowFibonacci(int a, int b, int n)
{
    if (n == 0) return string.Empty;
    else return a + " " + ShowFibonacci(b, a + b, --n);
}

Console.WriteLine(ShowFibonacci(1, 5, 8));