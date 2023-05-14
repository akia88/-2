// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int NewNumber(int N)
{
    int digit1 = N / 100;
    int digit3 = N % 10;
    int result = digit1 * 10 + digit3;

    return result;
}
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное числр: {number}");
int result = NewNumber(number);

Console.WriteLine(result);