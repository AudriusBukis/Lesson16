using System;
using Lesson16.Models;

namespace Lesson16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson 16");

            Validation2<string, int> test = new("vardas", 5);


            Console.WriteLine(test);
            
           // Validation.Valitate<string>(null);

            var selfMadeList = new MyArray<int>();
            for (int i = 0; i < 500; i++)
            {
                selfMadeList.AddElement(i);
            }
            selfMadeList.RemuveElement(1);
            selfMadeList.RemuveElement(3);

            Generics2Parametrs<int, string> test2parametrs = new (21, "Audrius");
            test2parametrs.PrintT1();
            test2parametrs.ChangeT1Value(35);
            test2parametrs.PrintT1();
            test2parametrs.PrintT2();
            test2parametrs.ChangeT2Value("Bukis");
            test2parametrs.PrintT2();
             

            Generator generator = new();
            var rectangle = new FourSideGeometricFigure("rectangle", 15.2, 0.9);
            generator.Show(rectangle);
            ReturnType type = new();
            type.Validate(50, 51.5);

           
            League<Team> lkl = new("Krepsinis");
            lkl.AddTeam(new Team("Siauliai", 10, 5, 0, 5));
            lkl.AddTeam(new Team("Rytas", 10, 8, 0, 2));
            lkl.AddTeam(new Team("Sakiai", 10, 4, 0, 6));
            lkl.AddTeam(new Team("Zalgiris", 10, 9, 0, 1));
            lkl.AddTeam(new Team("Sakiai", 10, 4, 0, 6));

            Console.WriteLine(lkl.getSport());
            lkl.PrintTable();
        }
    }
}
