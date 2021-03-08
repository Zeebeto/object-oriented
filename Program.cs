using System;

namespace object_oriented
{
    class Program
    {
        int Width;
        int Height;
        static void Main(string[] args)
        {
            var x = new Box 
            {
                Width = 50,
                Height = 30,
            };
            x.show();
            Console.WriteLine(x.Height + " " + x.Width);
        }
    }
}
