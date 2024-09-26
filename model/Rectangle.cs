using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct.model
{
    struct Rectangle
    {
        public int length;
        public int width;
        public Rectangle(int lengths, int widths)
        {
            length = lengths;
            width = widths;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"width {width}, height {length}");
        }

    }
}
