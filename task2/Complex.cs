using System;

namespace task2
{
    class Complex
    {
        private readonly double _x;
        private readonly double _y;
        private readonly int _i;
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString(){
        if(_y >= 0)
            return $"{_x}+{_y}i^{_i}";
        else 
            return $"{_x}{_y}i^{_i}";
        }
        public Complex()
        {

        }
        public Complex(double x, double y)
        {
            _x = x;
            _y = y;
            _i = 1;
        }
        public Complex(double x, double y, int i)
        {
            _x = x;
            _y = y;
            _i = i;
        }
        public static Complex operator +(Complex a) => a;
        public static Complex operator -(Complex a) => new Complex(-(a._x), -(a._y),a._i);
        public static Complex operator +(Complex a, Complex b) => new Complex(a._x + b._x, a._y + b._y,a._i);
        public static Complex operator -(Complex a, Complex b) => new Complex(a._x - b._x, a._y - b._y,a._i);
        public static Complex operator *(Complex a, Complex b) => new Complex(a._x*b._x*b._y, a._y*b._y*b._x, a._i+b._i);
        public static Complex operator /(Complex a, Complex b) => new Complex(a._x/b._x,a._y/b._y,a._i-b._i);
    }
}
