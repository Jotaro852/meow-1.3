using System;
using System.Collections.Generic; // использовать List<T>
class work_1_3
{
    static void Main()
    {
        List<string> array = new List<string>(); // создание динамического, пустого массива
        
        while (true) // бесконечная функция
        {
            Console.Write("Введите число: "); // вывод инфы
            string data = Console.ReadLine(); // данные пользователя
            if (string.IsNullOrEmpty(data)) // елси введена пустота
            {
                break; // конец ф-ии
            }
            array.Add(data); // добавляем эллемент в лист
        }
        
        string shortest = array[0]; // для самого короткого
        string longest = array[0]; // для самого длинного
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i].Length < shortest.Length) // длинаа i листа < длинны shortest
            {
                shortest = array[i]; // записываем в shortest i лисат
            }

            if (array[i].Length > longest.Length) // длинаа i листа < длинны longest
            {
                longest = array[i]; // записываем в longest i лисат
            }
        }
        
        var str = string.Join(" ", array); // var - переменная без какого-либо типа данных (разделитель, значение)
        Console.WriteLine(str); // вывод str
        Console.WriteLine($"Самый короткий элемент: {shortest} \t Самый длинный элемент: {longest}"); // вывод мин числа
    }
}