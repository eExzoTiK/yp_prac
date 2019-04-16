using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Receipt
    {
        public int Number;
        public string Date;
        public float Sum;

        public Receipt()
        {
            Number = 1;
            Date = "15.04.2019";
            Sum = 50.0f;
        }

        public void Add()
        {
            Console.WriteLine("Номер квитанции: " + Number);
            Console.WriteLine("Дата: " + Date);
            Console.WriteLine("Сумма: " + Sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Receipt first = new Receipt();

            first.Add();

            Console.Read();
        }
    }
}
