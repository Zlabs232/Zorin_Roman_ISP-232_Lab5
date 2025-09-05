namespace Lab4
{
    class Lab4
    {
        static void SayHello()
        {
            Console.WriteLine("Hello"); //void SayHello() => Console.WriteLine("Hello");
        }
        static void Game()
        {
            string myGame = "ARK: Survival Evolved";
            Console.WriteLine(myGame);
        }

        static void Main()
        {
            Game();

            Console.WriteLine("Введите своё имя: ");
            string? name = Console.ReadLine();
            Console.Write("Введите ваш язык(русский, английский, немецкий): ");
            string language = Console.ReadLine()!.ToLower();

            void SayHelloRu() => Console.WriteLine($"Привет, {name}!");
            void SayHelloEn() => Console.WriteLine($"Hello, {name}!");
            void SayHelloDe() => Console.WriteLine($"Guten Tag, {name}!");

            switch (language)
            {
                case "английский": SayHelloEn(); break;
                case "русский": SayHelloRu(); break;
                case "немецкий": SayHelloDe(); break;
                default: Console.WriteLine("Язык не найден!"); break;
            }
            void print(string message)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("Как тебя зовут?");
            Console.Write("Введите своё имя: ");
            string? name2 = Console.ReadLine();
            print(message:$"Твоё имя: {name2}");
        }
    }
}