//Сугробов 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

Console.Write("Введите число, ноль прекратит ввод: ");
int sum = 0;
int num = 0; 
do
{
    num = int.Parse(Console.ReadLine() ?? ""); // string.Empty
    if (num > 0 && num % 2 == 1)
    {
        sum += num; //sum = sum + num
    }
} while (num != 0);
 
Console.Write("Sum: " + sum);