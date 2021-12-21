//Сугробов 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
// С помощью цикла do while ограничить ввод пароля тремя попытками.
{
int i = 3;
do
    {
        Console.Write("Введите Логин: ");
    string login = (Console.ReadLine()??"");
    Console.Write("Введите Пароль: ");
    string password = (Console.ReadLine() ??"");
        if(login == "root" && password == "GeekBrains")
        Console.WriteLine("Верно");
        else
        Console.WriteLine("Не верно");
        Console.WriteLine($"Осталось попыток: {(--i).ToString()}");
    // i--;
    }
while (i > 0 );
}