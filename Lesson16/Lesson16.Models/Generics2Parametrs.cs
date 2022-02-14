using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class Generics2Parametrs<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }

        public Generics2Parametrs(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public void PrintT1()
        {
            Console.WriteLine($"Value of T1 parameter = {Value1}");
        }
        public void PrintT2()
        {
            Console.WriteLine($"Value of T2 parameter = {Value2}");
        }

        public void ChangeT1Value(T1 newValue)
        {
            Value1 = newValue;
        }
        public void ChangeT2Value(T2 newValue)
        {
            Value2 = newValue;
        }


    }
}
