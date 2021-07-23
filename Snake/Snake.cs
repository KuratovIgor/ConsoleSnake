using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        private Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            lineOfPoints = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                lineOfPoints.Add(point);
            }
        }

        public void Move()
        {
            Point tail = lineOfPoints[0];
            lineOfPoints.Remove(tail);
            Point head = GetNextPoint();
            lineOfPoints.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point nextPoint = new Point(lineOfPoints[lineOfPoints.Count - 1]);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                _direction = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow)
                _direction = Direction.UP;
            if (key == ConsoleKey.DownArrow)
                _direction = Direction.DOWN;
        }

        public bool IsEat(Point food)
        {
            Point head = GetNextPoint();

            if (head.IsHit(food))
            {
                food.SymbolOfPoint = head.SymbolOfPoint;
                lineOfPoints.Add(food);
                return true;
            }
            else
                return false;
        }

        public bool IsHitTail()
        {
            var head = lineOfPoints[lineOfPoints.Count - 1];

            for (int i = 0; i < lineOfPoints.Count - 2; i++)
            {
                if (head.IsHit(lineOfPoints[i]))
                    return true;
            }

            return false;
        }
    }
}
