using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


           // Создайте массив numbers целых чисел и заполните его значениями: 1, 2, 3, 4, 5.
            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

           // Выведите первый и третий элементы из массива numbers с помощью Console.WriteLine().

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);

            // Создайте массив fruits строковых значений и заполните его фруктами: "Apple", "Banana", "Orange".

            string[] fruits = new string[3];

              fruits[0] = "Apple";
              fruits[1] = "Banana";
              fruits[2] = "Orange";
            // Выведите все фрукты из массива fruits с помощью Console.WriteLine().
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            //Измените значение третьего элемента массива fruits на "Mango".
            fruits[2] = "mango";
            //Выведите измененные значения всех фруктов из массива fruits с помощью Console.WriteLine()
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);

            // Выведите количество элементов в массиве numbers и массиве fruits с помощью Console.WriteLine().
            var length = fruits.Length;
            Console.WriteLine(length);


            //Создайте пустой лист с именем fruits типа List<string>.
            List<string> fruits2 = new List<string>();

            //Добавьте в лист fruits следующие фрукты: "Apple", "Banana", "Orange".
            fruits2.Add("Apple");
            fruits2.Add("Banana");
            fruits2.Add("Orange");
            //Выведите первый и третий элементы из листа fruits с помощью Console.WriteLine().
            Console.WriteLine(fruits2[0]);
            Console.WriteLine(fruits2[2]);
            //Добавьте в лист fruits фрукт "Mango".
            fruits2.Add("Mango");
            //Выведите все фрукты из листа fruits с помощью Console.WriteLine().
            Console.WriteLine(fruits2[0]);
            Console.WriteLine(fruits2[1]);
            Console.WriteLine(fruits2[2]);
            Console.WriteLine(fruits2[3]);
            //Удалите фрукт "Banana" из листа fruits.
            fruits2.Remove("Banana");
            //Выведите количество элементов в листе fruits с помощью Console.WriteLine().
            Console.WriteLine(fruits2.Count);






        }
    }
}
