using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        private int _x;
        private int _y;
        public char SymbolOfPoint { get; set; }

        public Point() { }

        public Point(int x, int y, char symbol)
        {
            _x = x;
            _y = y;
            SymbolOfPoint = symbol;
        }

        public Point(Point point)
        {
            _x = point._x;
            _y = point._y;
            SymbolOfPoint = point.SymbolOfPoint;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(SymbolOfPoint);
        }

        public void Clear()
        {
            SymbolOfPoint = ' ';
            Draw();
        }

        public void Move(int offSet, Direction direction)
        {
            if (direction == Direction.RIGHT)
                _x += offSet;

            if (direction == Direction.LEFT)
                _x -= offSet;

            if (direction == Direction.UP)
                _y -= offSet;

            if (direction == Direction.DOWN)
                _y += offSet;
        }

        public bool IsHit(Point food)
        {
            return _x == food._x && _y == food._y;
        }
    }
}
