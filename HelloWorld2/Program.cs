namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Числовые
            int a = 2;
            int b = 2;
            int sum = a + b;
            Console.WriteLine(sum);
            int sum2 = a / b;
            Console.WriteLine(sum2);
            int sum3 = a * b;
            Console.WriteLine(sum3);

            // Строки
            string S1 = "Stas";
            string s2 = "Kotow";
            string Name = S1 + " " + s2;

            Console.WriteLine(Name);

            // ЛОгические

            bool l1 = true;
            bool l2 = false;

            bool resl = l1 && l2;
            Console.WriteLine(resl);

            bool resl1 = l1 != l2;
            Console.WriteLine(resl1);

            bool resl2 = l1 || l2;
            Console.WriteLine(resl2);

            

            bool resl3 = a >= b;

            Console.WriteLine(resl3);

            bool resl4 = a <= b;
            Console.WriteLine(resl4);

            bool resl5 = a < b;
            Console.WriteLine(resl5);

            bool resl6 = a > b;
            Console.WriteLine(resl6);

            



        }
    }
}

