using System;
using System.Threading;

namespace lab66
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            Console.WriteLine("\n Inside main()\n");
            string typeOfShape = Console.ReadLine();
	
            int i = 0;

            for(;i<0xffffff;i++);
            switch(typeOfShape){
                case "square":
                    Shapes.DrawSquare();
                    break;
                case "circle":
                    shapes.DrawCircle();
                    break;
            }
        }
    }
}

class Shapes
{
    public void DrawCircle()
    {
        for(int i = 0; i < 1000000000; i++)
        {
            //process of drawing
            Thread.Sleep(100);
        }

        return;
    }

    public static void DrawSquare()
    {
        for(int i = 0; i < 1000000000; i++)
        {
            //process of drawing
            Thread.Sleep(100);
        }
    }
}