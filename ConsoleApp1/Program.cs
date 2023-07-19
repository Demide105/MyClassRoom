using ConsoleApp1;

List<int> придумать_случайные_оценки(int inu = 6)
{
    List<int> ints = new List<int>{};
    Random rnd = new Random();
    for (int i = 0; i < inu; i++)
    {
        ints.Add(rnd.Next(1, 6));
    }
    return ints;
}
float просчёт_среднего_балла(List<int> массив_оценок)
{
    float b = 0;
    for (int i = 0; i < массив_оценок.Count; i++)
    {
        b = b + массив_оценок[i];
    }
    return (float)b / (float)массив_оценок.Count;
}
List<string> массив_имён_учеников = new List<string> { "Алик", "Александр", "Айнур", "Агата", "Артемий", "Аид", "Устин", "Урсула", "Умар", "Шерлок", "Шелли" };
string предумать_случайное_имя()
{
    Random random = new Random();
    return массив_имён_учеников[random.Next(0, массив_имён_учеников.Count)];
}
int придумать_случайный_рост()
{
    Random random = new Random();
    return random.Next(90, 250);
}
Classученик придумать_ученика()
{
    Classученик list = new Classученик  (предумать_случайное_имя(), придумать_случайные_оценки(), придумать_случайный_рост());
    return list;
}
List<Classученик> придумать_учеников(int сколько_учеников)
{
    List<Classученик> list1 = new List<Classученик> { };
    for(int i = 0;i < сколько_учеников;i++)
        list1.Add(придумать_ученика());
    return list1;
}


Classкабинет list = new Classкабинет(придумать_учеников(10));
list.рассадить_учеников(); 

while (true)
{
    int y = int.Parse(Console.ReadLine());
    if (y == 1)
    {
        Console.WriteLine("Впишите нового ученика");
        list.ученики.Add(new Classученик(Console.ReadLine(), new List<int> { }, 0));
    }
    else if (y == 2)
    {
        Console.WriteLine("Удалить ученика");
        list.ученики.RemoveAt(int.Parse(Console.ReadLine()));
    }
    else if (y == 3)
    {
        Console.WriteLine("Измените имя ученика");
        int k = int.Parse(Console.ReadLine());
        if (k >= list.ученики.Count || k < 0)
            continue;
        list.ученики[k].имя = Console.ReadLine();
    }
    else if (y == 4)
    {
        break;
    }
    else if (y == 5)
    {
        int m = 0;
        for (int i = 0; i < list.ученики.Count; i++)
        {
            if (i == 5)
            {
                m = m + 1;
            }
        }
        float r = ((float)m / (float)list.ученики.Count) * 100f;
        Console.WriteLine(r);
    }
    else if (y == 6)
    {
        int m = 0;
        for (int i = 0; i < list.ученики.Count; i++)
        {
            m = m + list.ученики[i].рост;
        }
        int c = m / list.ученики.Count;
        Console.WriteLine(c);
    }
    else if (y == 7)
    {
        int количествоучеников = 0;
        int c = 0;
        for (int q = 130; q <= 200; q = q + 10) {
            int h = 0;
            for (int i = 0; i < list.ученики.Count; i++)
            {
                if (list.ученики[i].рост == q)
                {
                    h = h + 1;
                }
            }
            if (количествоучеников < h)
            {
                количествоучеников = h;
                c = q;
            }
        }
        float r = ((float)количествоучеников / (float)list.ученики.Count) * 100f;
        Console.WriteLine(r);
        Console.WriteLine(c);
        Console.WriteLine(количествоучеников);
    }
    else if (y == 8)
    {
        for (int i = 0;i < list.ученики.Count; i++)
        {
            Console.WriteLine(list.ученики[i].имя);
            for (int o = 0; o < list.ученики[i].оценка.Count;o++)
            {
                Console.WriteLine(list.ученики[i].оценка[o]);
            }
        }
    }
    else if (y == 9)
    {
        for (int q = 0;q < list.ученики.Count; q++)
        {
            Console.WriteLine(list.ученики[q].имя);
            Console.WriteLine(просчёт_среднего_балла(list.ученики[q].оценка));
        }

    }
    else if (y == 10)
    {
        List<int> массив_всех_оценок = new List<int> { };
        for (int e  = 0;e < list.ученики.Count; e++)
        {
            массив_всех_оценок.AddRange(list.ученики[e].оценка);
        }
        Console.WriteLine(просчёт_среднего_балла(массив_всех_оценок));
    }
    else if (y == 11)
    {
        for(int i = 0;i < list.парты.Count;i++)
        {
            Console.WriteLine("парта номер " + i);
            Console.WriteLine(list.парты[i].ученик1?.имя);
            if (list.парты[i].ученик2 is not null)
            {
                Console.WriteLine(list.парты[i].ученик2?.имя);
            }
        }
    }
    else if(y == 12)
    {
        list.доска.написать_на_доске(Console.ReadLine());
    }
    else if(y == 13)
    {
        Console.WriteLine(list.доска.посмотреть_на_доску());
    }
    else if (y == 14)
    {
        list.доска.очистить_доску();
    }
    else if( y == 15)
    {
        for (int i = 0;i < list.ученики.Count;i++)
        {
            list.ученики[i].р();
        }
    }
}
foreach (var item in list.ученики)
{
    Console.WriteLine(item);
}
for (int i = 0; i < list.ученики.Count; i++)
{

}
    while (true)
{
    int k = int.Parse(Console.ReadLine());
    if (k >= list.ученики.Count || k < 0)
        break;
    string h = Console.ReadLine();
    Console.WriteLine(list.ученики[k].имя);
    if (h == "оценка")
    {
        int l = int.Parse(Console.ReadLine());
        if (l > 5)
        {
            Console.WriteLine("Нет такой оценки");
        }
    }
    else if (h == "рост")
    {
        int j = int.Parse(Console.ReadLine());
        if (j > 250)
        {
            Console.WriteLine("Неможет быть такого роста");
        }
    }

}
for (int i = 0; i < list.ученики.Count; i++)
{
    Console.WriteLine(list.ученики[i].имя);
    Console.WriteLine(list.ученики[i].рост);
    Console.WriteLine(list.ученики[i].оценка);
}
