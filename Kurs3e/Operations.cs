using System;
using System.Collections.Generic;
using System.Text;

namespace Kurs3e
{
    class Operations
    {
        int sum;
        DateTime timeOperat;
        Operations next;

        internal Operations Next { get => next; set => next = value; }
        public DateTime TimeOperat { get => timeOperat; set => timeOperat = value; }
        public int Sum { get => sum; set => sum = value; }

        public Operations(int sum1, DateTime time)// конструктор
        {
            Sum = sum1;
            TimeOperat = time;
        }




    }
}
