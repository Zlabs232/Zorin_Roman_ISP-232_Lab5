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

            void Sum(int x, int y)
            {
                int result = x + y;
                Console.WriteLine($"{x} + {y} = {result}");
            }

            Sum(10, 20);

            Console.Write("Введите переменную x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите переменную y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Sum(x, y);

            void printPerson(string nameP, int age)
            {
                Console.WriteLine($"Имя: {nameP}, возраст: {age}");
            }
            printPerson("Роман", 18);

            void Person(string name, int age = 18, string vuz = "BФ BолГУ") =>
                Console.WriteLine($"Имя: {name} \nВозраст: {age} \nВуз: {vuz}");

            Person(name: "Александр");
            Person(name: "Иван", age: 30);
            Person(name: "Дмитрий", age: 20, vuz: "МГУ");

            Person(age: 30, name: "Иван");
            Person(vuz: "МГУ", age: 20, name: "Дмитрий");

            string getMessage()
            {
                return "Hello";
            }
            Console.WriteLine(getMessage());

            int Sum2(int a, int b)
            {
                return a + b;
            }

            Sum2(10, 20);

            int number = Convert.ToInt32(Console.ReadLine());

            void CheckValue(int number)
            {
                if (number < 0)
                {
                    Console.WriteLine("Отрицательное число");
                    return;
                }
                Console.WriteLine("Положительное число");
            }

            CheckValue(number);

            string mes = getMessage();
            Console.WriteLine(mes);

            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            PrintMessage(getMessage());

            //string GetMessage()
            //{                         string GetMessage() => "hello";
            //    return "hello";
            //}

            //int Sum3(int x, int y)
            //{                         int Sum3(int x, int y) => x + y;
            //    return x + y;
            //}

            void PrintPerson(string name, int age)
            {
                if (age > 120 || age < 1)
                {
                    Console.WriteLine("Недопустимый возраст");
                    return;
                }
                Console.WriteLine($"Имя: {name} Возраст: {age}");
            }

            PrintPerson(name: "Алексей", age: 32);
            PrintPerson(name: "Dunkan", age: 1234);

            Random random = new Random();
            int numb = random.Next(0, 100);
            Console.WriteLine($"Случайное число: {numb}");
            double randomDouble = random.NextDouble();
            Console.WriteLine($"Случайное число: {randomDouble}");

            void ShowWelcomeMessage() => Console.WriteLine("Добро пожаловать в консольный прогноз погоды!");
            void ShowGoodbyeMessage() => Console.WriteLine("Спасибо за использование нашего прогноза! Хорошего дня!");
            
            string getWeather()
            {
                string[] weathers = { "Солнечно", "Облачно", "Дождь", "Снег", "Гроза"};
                Random random = new Random();
                int index = random.Next(weathers.Length);
                return weathers[index];
            }
            ShowWelcomeMessage();
            Console.WriteLine($"Погода на сегодня: {getWeather()}");
            ShowGoodbyeMessage();

            Console.WriteLine();

            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }

            int factorial = Factorial(n:4);
            int factorial2 = Factorial(n: 5);
            int factorial3 = Factorial(n: 6);

            Console.WriteLine($"Факториал числа 4 = {factorial}");
            Console.WriteLine($"Факториал числа 5 = {factorial2}");
            Console.WriteLine($"Факториал числа 6 = {factorial3}");

            void Compare(int[] numbers1, int[] numbers2)
            {
                int numbers1Sum = Sum(numbers1);
                int numbers2Sum = Sum(numbers2);

                if (numbers1Sum > numbers2Sum)
                    Console.WriteLine("сумма чисел из массива numbers1 больше");
                else if (numbers1Sum < numbers2Sum)
                    Console.WriteLine("сумма чисел из массива numbers2 больше");
                else
                    Console.WriteLine("суммы чисел обоих массивов равны");

                int Sum(int[] numbers)
                {
                    int res = 0;
                    foreach (int i in numbers)
                        res += i;
                    return res;

                }
            }

            int[] numbers1 = [1, 2, 3];
            int[] numbers2 = [3, 4, 5, 6, 7];
            Compare(numbers1, numbers2);
        }
    }
}