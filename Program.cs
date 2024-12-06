class Question 
{
    public string QText { get; set; }
    public string AText1 { get; set; }
    public string AText2 { get; set; }
    public string AText3 { get; set; }
    public string AText4 { get; set; }
    public int Bingo { get; set; }

    public Question(string qText, string aText1, string aText2, string aText3, string aText4, int bingo)
    {
        QText = qText;
        AText1 = aText1;
        AText2 = aText2;
        AText3 = aText3;
        AText4 = aText4;
        Bingo = bingo;
    }
}

class Person 
{
    public string Name { get; set; }
    public int Old {  get; set; }
    public int Bingo { get; set; }

    public Person(string name,  int old) 
    {
        Name = name;
        Old = old;
        Bingo = 0;
    }

    public void Points() 
    {
        Bingo++;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Old}, Количество правильных ответов: {Bingo}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество игроков:");
        int player = int.Parse(Console.ReadLine());

        List<Person> players = new List<Person>();
        for (int i = 0; i < player; i++)
        {
            Console.WriteLine($"Введите имя игрока {i + 1}:");
            string name = Console.ReadLine();
            Console.WriteLine($"Введите возраст игрока {i + 1}:");
            int age = int.Parse(Console.ReadLine());
            players.Add(new Person(name, age));
        }
        static List<Question> GenerateQuestions()
         {
            return new List<Question>
            {
                new Question("Самое большое млекопитающие на планете Земля?",
                         "Жираф", "Синий кит", "Слон", "Белая акула", 2),
                new Question("Каких животных в Австралии больше, чем численность населения?",
                         "Коала", "Эму", "Кенгуру", "Динго", 3),
                new Question("Какое млекопитающее считается самым бесстрашным? ",
                         "Лев", "Косатка", "Муровьед", "Медоед", 4),
                new Question("Самая большая порода попугаев?",
                         "Ара", "Жако", "Корелла", "Какаду", 1),
                new Question("Какое животное не является священным в какой либо стране?",
                         "Корова", "Лошадь", "Змея", "Орел", 4)
             };
         }
        List<Question> questions = GenerateQuestions();

        foreach (var p in players)
        {
            Console.WriteLine($"\nОчередь игрока: {p.Name}");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine(questions[i].QText);
                Console.WriteLine($"1. {questions[i].AText1}");
                Console.WriteLine($"2. {questions[i].AText2}");
                Console.WriteLine($"3. {questions[i].AText3}");
                Console.WriteLine($"4. {questions[i].AText4}");

                int answer = int.Parse(Console.ReadLine());

                if (answer == questions[i].Bingo)
                {
                    p.Points();
                    Console.WriteLine("Правильный ответ!");
                }
                else
                {
                    Console.WriteLine("Неправильный ответ.");
                }
            }
        }
        Console.WriteLine("\nРезультаты викторины:");
        int maxScore = 0;
        List<Person> winner = new List<Person>();
        foreach (var p in players)
        {
            p.ShowInfo();
            if (p.Bingo > maxScore)
            {
                maxScore = p.Bingo;
                winner = ;
            }
        }
        Console.WriteLine($"\nПобедитель: {winner.Name} с {winner.Bingo} правильными ответами!");
    }

    
}






























