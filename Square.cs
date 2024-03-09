using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction
{
    public class Square:Figure
    {
        private int _side;

        public Square(int side)
        {
            Side = side;
        }

        public int Side {

            get
            {
                return _side; 
            }


            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    Console.WriteLine("Side Menfi Ola Bilmez!");
                }
            }
        }


        public override double CalcArea()
        {
            _side = _side * _side;
            return _side;
        }

        //public override void CalcArea()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
