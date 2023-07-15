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
            Console.WriteLine(имя);
            Console.WriteLine(оценка);
            Console.WriteLine(рост);
        }
        public Classученик(string имя1,List<int> _оценка , int _рост)
        {
            имя = имя1;
            оценка = _оценка;
            рост = _рост;
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
    internal class Classкабинет
    {
        public List<Classученик> ученики { get; set; }
        public List<Classпарты> парты { get; set; }
        public Classкабинет(List<Classученик> ученики1)
        {
            ученики = ученики1;
        }
    }
}
