using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Classученик
    {
        public string имя { get; set; }
        public int рост { get; set; }
        public List<int> оценка { get; set; }
        public void р()
        {
            string oo = "";
            oo += имя + ", ";
            foreach (int o in оценка)
            {
                oo += o + ", ";
            }
            oo += рост + ", ";
            oo += имя_соседа();
            Console.WriteLine(oo);
        }
        public Classученик(string имя1,List<int> _оценка , int _рост)
        {
            имя = имя1;
            оценка = _оценка;
            рост = _рост;
        }
        public Classпарты? парта { get; set; }
        public string имя_соседа()
        {
            if (парта is null)
                return "";

            if(парта.количество_учеников() < 2)
                return "";

            if (this.Equals(парта.ученик1))
                return парта.ученик2.имя;

            return парта.ученик1.имя;
        }
    }
    internal class Classпарты
    { 
        public int количество_учеников()
        {
            int количество = 0;
            if (ученик1 is not null)
            {
                количество++;
            }
            if (ученик2 is not null)
            {
                количество++;
            }
            return количество;
        }
        public Classученик? ученик1 { get; set; }
        public Classученик? ученик2 { get; set; }
    }
    internal class Classдоска
    {
        public string текст { get; set; }
        public string посмотреть_на_доску() => текст;
        public void написать_на_доске(string w) => текст = w;
        public void очистить_доску() => текст = "";
    }
    internal class Classкабинет
    {
        public Classдоска доска { get; set; } = new Classдоска();
        public List<Classученик> ученики { get; set; }
        public List<Classпарты> парты { get; set; } = new List<Classпарты> { };
        public Classкабинет(List<Classученик> ученики1) => ученики = ученики1;
        public void рассадить_учеников()
        {
            парты.Clear();
            for (int i = 0;i < ученики.Count; i++)
            {
                if (парты.Count != 0 && парты[парты.Count-1].количество_учеников() == 1)
                {
                    парты[парты.Count-1].ученик2 = ученики[i];
                }
                else
                {
                    Classпарты парта = new Classпарты();
                    парта.ученик1 = ученики[i];
                    парты.Add(парта);
                }
                ученики[i].парта = парты[парты.Count - 1];
            }
        }
    }
}
