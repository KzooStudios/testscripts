using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Random rnd = new Random();
            int planettype = rnd.Next(0, 2);
            if (planettype ==  0)
            {
                Console.WriteLine("Planet Type: Gas Giant");
                int planetinhabit = rnd.Next(0, 2);
                if (planetinhabit == 0)
                {
                    Console.WriteLine("Inhabited: Yes");
                }
                else
                {
                    Console.WriteLine("Inhabited: No");
                }
            }
            else
            {
                Console.WriteLine("Planet Type: Solid Planet");
                int planetinhabit = rnd.Next(0, 2);
                if (planetinhabit == 0)
                {
                    Console.WriteLine("Inhabited: Yes");
                }
                else
                {
                    Console.WriteLine("Inhabited: No");
                }
            }
        }
    }
}