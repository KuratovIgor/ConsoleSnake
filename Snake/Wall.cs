using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Wall
    {
        private List<Figure> wallList = new List<Figure>();

        public Wall(int mapWidth, int mapHeight)
        {
            HorizonalLine upWall = new HorizonalLine(1, mapWidth, 0, '+');
            HorizonalLine downWall = new HorizonalLine(1, mapWidth, mapHeight - 1, '+');
            VerticalLine leftWall = new VerticalLine(0, mapHeight, 1, '+');
            VerticalLine rightWall = new VerticalLine(0, mapHeight, mapWidth - 1, '+');

            wallList.Add(upWall);
            wallList.Add(downWall);
            wallList.Add(leftWall);
            wallList.Add(rightWall);
        }

        public Wall(int x, int y, int length)
        {
            HorizonalLine upWall = new HorizonalLine(x, x + length, y, '+');
            HorizonalLine downWall = new HorizonalLine(x, x + length, y + length, '+');
            VerticalLine leftWall = new VerticalLine(y, y + length, x, '+');
            VerticalLine rightWall = new VerticalLine(y, y + length, x + length, '+');

            wallList.Add(upWall);
            wallList.Add(downWall);
            wallList.Add(leftWall);
            wallList.Add(rightWall);
        }

        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }

            return false;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var wall in wallList)
            {
                wall.Draw();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
