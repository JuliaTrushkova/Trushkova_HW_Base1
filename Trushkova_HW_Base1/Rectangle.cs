using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        private double side1, side2;        

        public Rectangle(double side1, double side2)
        {
            this.side1 = CheckforZero(side1);
            this.side2 = CheckforZero(side2);
        }

        public double Side1
        {
            get { return this.side1; }
            set { this.side1 = CheckforZero((double)value); }
        }

        public double Side2
        {
            get { return this.side2; }
            set { this.side2 = CheckforZero((double)value); }
        }

        public double Area
        {
            get { return CheckforZero(AreaCalculator()); }
        }

        public double Perimeter
        {
            get
            { return CheckforZero(PerimeterCalculator()); }
        }

        double AreaCalculator()
            => side1 * side2;

        double PerimeterCalculator()
            => (side1 + side2) * 2;

        double CheckforZero(double num)
        {
            if (num != 0)
            {
                return num;
            }
            else
            {
                throw new Exception("Сторона прямоугольнка не может равняться 0");
            }
        }
    }
}
