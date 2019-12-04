using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class HorizontalLine : Figure
    {
       

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            

            for (int i = xLeft; i <= xRight; i++)
            {
                MyPoint newPoint = new MyPoint(i, y, symbol);
                pointList.Add(newPoint);
            }


        }

       /* public void DrawHorizontalLine()
        {
            foreach (MyPoint point in pointList)
            {
                point.Draw();
            }
        } */
    }
}
