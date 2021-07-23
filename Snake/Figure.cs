using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> lineOfPoints;

        public virtual void Draw()
        {
            foreach (Point point in lineOfPoints)
            {
                point.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var point in lineOfPoints)
            {
                if (figure.IsHit(point))
                    return true;
            }

            return false;
        }

        private bool IsHit(Point point)
        {
            foreach(var p in lineOfPoints)
            {
                if (p.IsHit(point))
                    return true;
            }

            return false;
        }
    }
}
