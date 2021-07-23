using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yPointUp, int yPointDown, int xPoint, char drawingSymbol)
        {
            lineOfPoints = new List<Point>();

            for (int y = yPointUp; y < yPointDown; y++)
                lineOfPoints.Add(new Point(xPoint, y, drawingSymbol));
        }
    }
}
