using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    internal class Rectangular:Figure
    {
        private int _width;
        public int Width
        {

            get
            {
                return _width;
            }


            set
            {

                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Menfi Ola bilmez");
                }
            }
        }
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {

                if (value > 0)
                {
                    _length= value;
                }
                else
                {
                    Console.WriteLine("Menfi Ola Bilmez!");
                }
            }


        }
        public Rectangular(int width, int length)
        {
            Width= width;
            Length= length;

        }
        public override double CalcArea()
        {
            double area=Width*Length;
            return area;
        }
    }
}
