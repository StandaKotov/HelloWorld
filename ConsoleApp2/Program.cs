using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("введите ваше имя");

            string name = Console.ReadLine();

      

            Console.WriteLine("Введите вашу фамилию");
            
            string suname = Console.ReadLine();

            
            Console.WriteLine("Введите ваш возраст");

            string age = Console.ReadLine();

            int conevrtedAge = int.Parse(age);

            Console.WriteLine("Введите вашу профессию");
            string profession = Console.ReadLine();


            Console.WriteLine("Привет, " + name+ " " + suname +" " + "я не думал что вам" + " " + age + "." + profession +" " + "-"+ " " + "это очень интересная профессия" );
            
        }
    }
}
