using System.Text;

namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int cost = 50;

            if (cost == 5 ) 
            {
             Console.WriteLine("Число не равно 50");
            }
            if (cost <10 ) 
            {
              Console.WriteLine("Число больше 10");
            }
            if(cost <= 25 ) 
            {

                Console.WriteLine("Число меньше или равно 25");
            }
            if (cost == 50)
            {
                Console.WriteLine("Число равно 50");
            }
            if (cost > 50)
            {
                Console.WriteLine("Число больше 50");
            }
            if (cost != 100)
            {
                Console.WriteLine("Число не равно 100");
            }


            switch (cost)
            
            {
                case 5: Console.WriteLine("Число равно 5");

                    break;



                case 10:

                    Console.WriteLine("Число равно 10");

                    break;


                case 25:

                    Console.WriteLine("Число равно 25");
                    break;

               case 50:
                    Console.WriteLine("Число равно 50");
                        break;
                
                case 100:
                    Console.WriteLine("Число равно 100");
                        break;
                    

            }


        }
    }
}

