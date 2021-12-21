// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
// набрать вес или всё в норме.
// 5. б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. - Не осилил.

Console.Write("Введите рост: ");
int h = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вес: ");
int w = int.Parse(Console.ReadLine() ?? "");
int imt = (h * h) / w;
Console.WriteLine(imt);
if(imt < 620 && imt > 320)
{
    Console.WriteLine($"Всё в норме");
}
else if (imt > 620)
{
    Console.WriteLine($"Маленький вес надо набрать");
}
else if (imt < 320)
{
    Console.WriteLine("Большой вес надо худеть");
}