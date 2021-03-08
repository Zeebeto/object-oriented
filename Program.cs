using System;

namespace object_oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Box
            {
                Width = 50,
                Height = 30,
            }; 
            var y = new Box
            {
                Width = 6,
                Height = 9,
            };
            x.show();
            y.show();
        }
    }
}
