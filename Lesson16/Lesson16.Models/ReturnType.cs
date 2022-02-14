using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class ReturnType
    {
        public void Validate<T>(T inputNumber1, T inputNumber2)
        {

            Console.WriteLine($"first input type{inputNumber1.GetType()}, second input type{inputNumber2.GetType()}");

            
        }
    }
}
