using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        private int _mapWidth;
        private int _mapHeight;
        private char _symbolOfFood;

        Random rand = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symbolOfFood)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            _symbolOfFood = symbolOfFood;
        }

        public Point CreateFood()
        {
            int x = rand.Next(2, _mapWidth - 2);
            int y= rand.Next(2, _mapHeight - 2);

            return new Point(x, y, _symbolOfFood);
        }
    }
}
