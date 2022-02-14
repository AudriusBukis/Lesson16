using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class Generator
    {
        
        public void Show<T>(T inputElement)
        {
            Console.WriteLine($"{inputElement}");
        }
    }
}
