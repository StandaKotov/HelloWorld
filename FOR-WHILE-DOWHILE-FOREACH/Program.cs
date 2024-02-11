namespace FOR_WHILE_DOWHILE_FOREACH
{
    using System;

class Program
{
    static void Main()
{
    // Цикл FOR:
    for (int i = 1; i <= 10; i++) // Создаем цикл от 1 до 10
    {
        if (i % 2 == 0) // Проверяем четность текущего числа
        {
            Console.WriteLine("Число " + i + " четное"); // Выводим сообщение о четности
        }
        else
        {
            Console.WriteLine("Число " + i + " нечетное"); // Выводим сообщение о нечетности
        }
    }

    // Цикл WHILE:
    int count = 1; // Инициализируем переменную
    while (count <= 10) // Цикл, показывает значение меньше или равно 10
    {
        if (count % 3 == 0) // Проверяем кратность 3
        {
            Console.WriteLine("Число " + count + " кратно 3"); // Выводим сообщение о кратности
        }
        else
        {
            Console.WriteLine("Число " + count + " не кратно 3"); // Выводим сообщение о некратности
        }
        count++; // Увеличиваем значение счетчика
    }

    // Цикл DO-WHILE:
    int guess; // Объявляем переменную для догадки
    do
    {
        Console.Write("Угадайте число: "); // Запрашиваем число от пользователя
        guess = Convert.ToInt32(Console.ReadLine()); // Считываем и преобразуем в число

        if (guess < 5)
        {
            Console.WriteLine("Загаданное число больше");
        }
        else if (guess > 5)
        {
            Console.WriteLine("Загаданное число меньше");
        }
        else
        {
            Console.WriteLine("Угадали!"); // Выводим сообщение об угадке
            break; // Выходим из цикла
        }
    } while (true);

    // Цикл FOREACH:
    int[] numbers = { 10, 20, 30, 40, 50 }; // Массив чисел
    foreach (int number in numbers) // Перебираем каждое число в массиве
    {
        if (number > 30)
        {
            Console.WriteLine("Элемент " + number + " больше 30");
        }
        else
        {
            Console.WriteLine("Элемент " + number + " меньше или равен 30");
        }
   
    }
}

}
}

