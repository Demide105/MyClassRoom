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
}
