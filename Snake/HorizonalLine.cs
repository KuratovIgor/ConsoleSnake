using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizonalLine : Figure
    {
        public HorizonalLine(int xPointLeft, int xPointRight, int yPoint, char drawingSymbol)
        {
            lineOfPoints = new List<Point>();

            for (int x = xPointLeft; x < xPointRight; x++)
                lineOfPoints.Add(new Point(x, yPoint, drawingSymbol));
        }
    }
}
