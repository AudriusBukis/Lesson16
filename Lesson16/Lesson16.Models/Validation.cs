using System;

namespace Lesson16.Models
{
    public class Validation
    {
               
   
        public static void Valitate<T>(T input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
        }
        
    }
}
