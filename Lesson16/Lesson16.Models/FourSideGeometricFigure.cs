using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public FourSideGeometricFigure(string name, double @base, double heigth)
        {
            Name = name;
            Base = @base;
            Height = heigth;
        }

        public double GetArea()
        {
            return Height * Base;
        }

        public override string ToString()
        {
            return $" Geometric Figure = {Name} " +
                   $" Base = {Base} " +
                   $" Height =  {Height} " +
                   $" Area = {GetArea()} " ;

        }
    }
}
