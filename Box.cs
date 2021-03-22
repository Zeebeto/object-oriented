using System;
using System.Collections.Generic;
using System.Text;

namespace object_oriented
{
    class Box
    {
        //husk å gjøre ting public om det skal kunne brukes utenfor denne classen og .cs filen
        public int Height;
        public int Width;

        internal void show()
        {
            Console.WriteLine("height = " + Height);
            Console.WriteLine("width = " + Width);

        }

        

    }
}

/*
 kode brukt i en annen class, som henter "box" og lager 2 objekter og viser dem med "show()"
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
 */
