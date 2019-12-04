using System;
using System.Threading;

namespace Point
{
    class MyPoint
    {
        public int x;
        public int y;
        public char symbol;

        public MyPoint(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public MyPoint(MyPoint _p)
        {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void MovePoint(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(MyPoint point)
        {
            return point.x == x && point.y == y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Point p1 = new Point(10, 10, '*');
             p1.Draw();
             Point p2 = new Point(10, 11, '*');
             p2.Draw();
             Point p3 = new Point(10, 12, '*');
             p3.Draw();
             Point p4 = new Point(10, 13, '*');
             p4.Draw();
             Point p5 = new Point(10, 14, '*');
             p5.Draw();

             Point p6 = new Point(11, 10, '*');
             p6.Draw();
             Point p7 = new Point(12, 10, '*');
             p7.Draw();
             Point p8 = new Point(13, 10, '*');
             p8.Draw();
             Point p9 = new Point(14, 10, '*');
             p9.Draw(); */

            /* for (int i = 5; i < 10; i++)
              {
                  MyPoint newPoint = new MyPoint(i, 5, '*');
                  newPoint.Draw();
                  MyPoint newPoint2 = new MyPoint(5, i, '*');
                  newPoint2.Draw();
              } */
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);



            /* HorizontalLine topLine = new HorizontalLine(0, 78, 0, '*');
             Console.ForegroundColor = ConsoleColor.Yellow;
             topLine.DrawFigure();
             HorizontalLine buttomLine = new HorizontalLine(0, 78, 24, '*');
             Console.ForegroundColor = ConsoleColor.Yellow;
             buttomLine.DrawFigure();

             VerticalLine leftLine = new VerticalLine( 0, 24, 0, '*');
             Console.ForegroundColor = ConsoleColor.Blue;
             leftLine.DrawFigure();
             VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
             Console.ForegroundColor = ConsoleColor.Magenta;
             rightLine.DrawFigure(); */
           
            Walls walls = new Walls(80, 25);
            
            walls.DrawWalls();
            
            MyPoint tail = new MyPoint(6, 5, '#');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.DrawFigure();

           
            FoodCatering foodCatered = new FoodCatering(80, 25, '$');
            Console.ForegroundColor = ConsoleColor.Red;
            MyPoint food = foodCatered.CaterFood();
            food.Draw();

            int Count = 0;
            
            

            while (true)
            {

                if (walls.IsHitByFigure(snake))
                {
                    break;
                }
                
                
                if (snake.Eat(food))
                {
                   food = foodCatered.CaterFood();  
                   Console.ForegroundColor = ConsoleColor.Red;
                   food.Draw();
                   Console.Beep();
                   Count++;
                   

                }
               

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    snake.MoveSnake();
                   
                }
                ShowScore(Count);
                Thread.Sleep(100 - Count*3);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReadUserKey(key.Key);
                    
                }

                
            }

            WriteGameOver();
            FinalScore(Count);
            
            
           
            Console.ReadLine();

        }
        public static void WriteGameOver()
        {
            
            Console.Clear();
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(xOffset, yOffset++);
            ShowMessage("=========", xOffset, yOffset++);
            ShowMessage("GAME OVER", xOffset, yOffset++);
            ShowMessage("=========", xOffset, yOffset++);
           
            

        }

        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        public static void ShowScore(int Counter)
        {
            int xOffset =82;
            int yOffset =3;
            ShowMessage($"Score: {Counter} ", xOffset, yOffset);
            
        }
        public static void FinalScore(int Counter)
        {
            int xOffset = 35;
            int yOffset = 12;
            ShowMessage($"Score: {Counter} ", xOffset, yOffset);
           
        }


        
    
    }
   
}
