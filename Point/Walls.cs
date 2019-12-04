using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '*');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '*');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '*');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '*');
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

            Random rnd = new Random();
            int x = rnd.Next(1, mapWidth - 6);
            int y = rnd.Next(1, mapHeight - 6);

            HorizontalLine randomLine = new HorizontalLine(x, x+3, y, '_');
            wallList.Add(randomLine);
            VerticalLine randomVertical = new VerticalLine(y+5, y + 5, x-6, '|');
            wallList.Add(randomVertical);
            

        }

        public void DrawWalls()
        {
            foreach (Figure wall in wallList)
            {
                wall.DrawFigure();
            }


        }

        public bool IsHitByFigure(Figure figure) //seinade jaoks
        {
            foreach (Figure wall in wallList)
            {
                if (wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
