using System;

namespace SnakeDraft
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.SetWindowSize(25, 25);
             Console.SetBufferSize(25, 25); // SetBufferSize kaotab ära scrollimisribad */

            /* //muudab konsooli taustavärvi
             Console.BackgroundColor = ConsoleColor.Gray;
             Console.Clear(); */
            //Declare point coordinates
            /*  int x1 = 10;
              int y1 = 10;
              int x2 = 50;
              int y2 = 30;
              char symbol1 = '*';

              char symbol2 = '<'; */

            /*  Console.SetCursorPosition(x1, y1);
              Console.ForegroundColor = ConsoleColor.DarkYellow;
              Console.Write(symbol1);

              Console.SetCursorPosition(x2, y2);
              Console.ForegroundColor = ConsoleColor.DarkBlue;
              Console.Write(symbol2); */

            Point p1 = new Point(15, 15, '%');
            p1.Draw();
            // Draw(p1.x, p1.y, p1.symbol);

            //  Draw(x1, y1, symbol1);
            //Draw(30, 30, '#');
            Point p2 = new Point(5, 5, '¤');
            p2.Draw();
             




            Console.ReadLine();
            
            
        }
        public static void Draw(int x, int y, char symbol)
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
