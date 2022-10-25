using System.Text;

Console.WriteLine("Введите текст");
string data=Console.ReadLine();
StringBuilder sb=new StringBuilder(data);
Menu();
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Заменить какой-либо символ на другой");
    Console.WriteLine($"2) Удалить символ");
    Console.WriteLine($"3) Добавить строку");
    Console.WriteLine($"4) Посмотреть получившийся текст");
    Console.WriteLine();
}
void Menu()
{
    while (true)
    {

        GetMenu();
        string choice = Console.ReadLine();
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
    Console.WriteLine($"Введите какой символ вы хотите заменить");
    Console.WriteLine();
    string replace=Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"Введите на какой символ заменить");
    string replac = Console.ReadLine();
    sb.Replace(replace, replac);
}
void Remove()
{
    Console.WriteLine($"Введите с какого символа по счёту");
    Console.WriteLine();
    string Remov = Console.ReadLine();
    bool a=int.TryParse(Remov, out int b);
    Console.WriteLine();
    Console.WriteLine($"По какой");
    string Remove = Console.ReadLine();
    bool a1 = int.TryParse(Remov, out int b1);
    if (a == true && a == true)
    {
        sb.Remove(b-1, b1-1);
    }
    else
    {
        Console.WriteLine($"Введите номер символа");
    }
}
void Append()
{
    Console.WriteLine($"Введите что добавить");
    string replac = Console.ReadLine();
    sb.Append(replac);
}