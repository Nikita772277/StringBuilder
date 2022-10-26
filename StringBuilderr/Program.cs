using System.Text;

Console.WriteLine("Введите текст");
string data=Console.ReadLine();
StringBuilder sb=new StringBuilder(data);
string text = sb.ToString();
Menu();
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Заменить какой-либо символ на другой");
    Console.WriteLine($"2) Удалить символ");
    Console.WriteLine($"3) Добавить строку");
    Console.WriteLine($"4) Посмотреть получившийся текст");
    Console.WriteLine($"5) Узнать позицию символа");
    Console.WriteLine();
}
void Menu()
{ 
    while (true)
    {
    text = sb.ToString();
        GetMenu();
        string choice = Console.ReadLine();
        Console.WriteLine();
        bool c = int.TryParse(choice, out var a);
        if (c == true)
        {
            if (a == 1)
            {
                Replace();
            }
            else if (a == 2)
            {
                Remove();
            }
            else if (a == 3)
            {
                Append();
            }
            else if (a == 4)
            {
                Console.WriteLine($"{sb}");
            }
            else if (a == 5) 
            {
                Position();
            }
            else
            {
                Console.WriteLine($"Выберите пункт списка");
            }
        }
        else
        {
            Console.WriteLine($"Выберите пункт списка");
        }
    }
}
void Replace()
{
   
    int number = 0;
    foreach (char i in text)
    {
        number++;
    }
    if (number != 0)
    {

        Console.WriteLine($"Введите какой символ вы хотите заменить");
        Console.WriteLine();
        string replace = Console.ReadLine();
        Console.WriteLine();
        if (replace == "" || replace == " ")
        {
            Console.WriteLine($"Вы нечего не ввели");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Введите на какой символ заменить");
            string replac = Console.ReadLine();
            sb.Replace(replace, replac);
        }
    }
    else 
    {
        Console.WriteLine($"Строка пуста");
    }
}
void Remove()
{
    int number = 0;
    foreach (char i in text)
    {
        number++;
    }
    if (number != 0)
    {
        Console.WriteLine($"Введите с какого символа по счёту (включительно)");
        Console.WriteLine();
        string remov = Console.ReadLine();
        bool a = int.TryParse(remov, out int b);
        Console.WriteLine();
        if (b <= number)
        {
            if (remov == "" || remov == " ")
            {
                Console.WriteLine($"Вы нечего не ввели");
            }
            else
            {
                if (a == true)
                {
                    Console.WriteLine($"Сколько символов после него удалить (включительно)");
                    string remove = Console.ReadLine();
                    bool a1 = int.TryParse(remove, out int b1);
                    Console.WriteLine();
                    if (a1 == true)
                    {
                        sb.Remove(b - 1, b1);
                    }
                    else
                    {
                        Console.WriteLine($"Вы ввели не число");
                    }
                }
                else
                {
                    Console.WriteLine($"Вы ввели не число");
                }
            }
        }
        else
        {
            Console.WriteLine($"Символа с такой позицией нет");
        }
    }
    else
    {
        Console.WriteLine("Строка пуста");
    }
}
void Append()
{
    Console.WriteLine($"Введите что добавить");
    Console.WriteLine();
    string replac = Console.ReadLine();
    sb.Append(replac);
}
void Position()
{
    int n = 1;
    int number = 0;
    int p = 0;
    foreach (char i in text)
    {
        number++;
    }
    if (number != 0)
    {
        int c = 0;
        Console.WriteLine();
        Console.WriteLine($"Узнать позицию какого символа вы хотите");
        Console.WriteLine();
        string a = Console.ReadLine();
        if (a == "" || a == " ")
        {
            Console.WriteLine($"Вы нечего не ввели");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Позиции символа {a}:");
            foreach (char i in text)
            {
                c++;
                if (a.Contains(i))
                {
                    Console.WriteLine();
                    Console.WriteLine($"{n++}) {c}");
                    
                    p++;
                    continue;
                }
            }
            if (p == 0) { Console.WriteLine("Введённый символ не найден в тексте"); }
        }
    }
    else
    {
        Console.WriteLine("Строка пуста");
    }
}