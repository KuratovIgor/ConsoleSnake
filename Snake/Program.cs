using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);
            Console.CursorVisible = false;

            List<Wall> wallList = new List<Wall>();
            bool isLose = false;

            Wall wallsOfArena = new Wall(80, 25);
            wallsOfArena.Draw();
            wallList.Add(wallsOfArena);

            Point tailOfSnake = new Point(4, 5, '*');
            Snake snake = new Snake(tailOfSnake, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Yellow;
            food.Draw();
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                foreach(Wall wall in wallList)
                {
                    if (wall.IsHit(snake) || snake.IsHitTail())
                    {
                        isLose = true;
                        break;
                    }
                }

                if (isLose)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    ShowLose();
                    break;
                }

                if (snake.IsEat(food))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.ReadKey();
        }

        private static void ShowLose()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(10, 1, '='));
            points.Add(new Point(12, 2, '='));
            points.Add(new Point(14, 3, '='));
            points.Add(new Point(18, 3, '='));
            points.Add(new Point(20, 2, '='));
            points.Add(new Point(22, 1, '='));
            points.Add(new Point(16, 4, '='));
            points.Add(new Point(16, 5, '='));
            points.Add(new Point(16, 6, '='));
            points.Add(new Point(16, 7, '='));
            points.Add(new Point(16, 8, '='));
            points.Add(new Point(16, 9, '='));
            points.Add(new Point(16, 10, '='));

            points.Add(new Point(30, 1, '='));
            points.Add(new Point(32, 1, '='));
            points.Add(new Point(34, 1, '='));
            points.Add(new Point(36, 1, '='));
            points.Add(new Point(38, 1, '='));
            points.Add(new Point(40, 1, '='));
            points.Add(new Point(42, 1, '='));
            points.Add(new Point(30, 1, '='));
            points.Add(new Point(30, 2, '='));
            points.Add(new Point(30, 3, '='));
            points.Add(new Point(30, 4, '='));
            points.Add(new Point(30, 5, '='));
            points.Add(new Point(30, 6, '='));
            points.Add(new Point(30, 7, '='));
            points.Add(new Point(30, 8, '='));
            points.Add(new Point(30, 9, '='));
            points.Add(new Point(30, 10, '='));
            points.Add(new Point(42, 2, '='));
            points.Add(new Point(42, 3, '='));
            points.Add(new Point(42, 4, '='));
            points.Add(new Point(42, 5, '='));
            points.Add(new Point(42, 6, '='));
            points.Add(new Point(42, 7, '='));
            points.Add(new Point(42, 8, '='));
            points.Add(new Point(42, 9, '='));
            points.Add(new Point(42, 10, '='));
            points.Add(new Point(32, 10, '='));
            points.Add(new Point(34, 10, '='));
            points.Add(new Point(36, 10, '='));
            points.Add(new Point(38, 10, '='));
            points.Add(new Point(40, 10, '='));

            points.Add(new Point(50, 1, '='));
            points.Add(new Point(50, 2, '='));
            points.Add(new Point(50, 3, '='));
            points.Add(new Point(50, 4, '='));
            points.Add(new Point(50, 5, '='));
            points.Add(new Point(50, 6, '='));
            points.Add(new Point(50, 7, '='));
            points.Add(new Point(50, 8, '='));
            points.Add(new Point(50, 9, '='));
            points.Add(new Point(50, 10, '='));
            points.Add(new Point(62, 1, '='));
            points.Add(new Point(62, 2, '='));
            points.Add(new Point(62, 3, '='));
            points.Add(new Point(62, 4, '='));
            points.Add(new Point(62, 5, '='));
            points.Add(new Point(62, 6, '='));
            points.Add(new Point(62, 7, '='));
            points.Add(new Point(62, 8, '='));
            points.Add(new Point(62, 9, '='));
            points.Add(new Point(62, 10, '='));
            points.Add(new Point(52, 10, '='));
            points.Add(new Point(54, 10, '='));
            points.Add(new Point(56, 10, '='));
            points.Add(new Point(58, 10, '='));
            points.Add(new Point(60, 10, '='));

            points.Add(new Point(5, 14, '='));
            points.Add(new Point(5, 15, '='));
            points.Add(new Point(5, 16, '='));
            points.Add(new Point(5, 17, '='));
            points.Add(new Point(5, 18, '='));
            points.Add(new Point(5, 19, '='));
            points.Add(new Point(5, 20, '='));
            points.Add(new Point(5, 21, '='));
            points.Add(new Point(5, 22, '='));
            points.Add(new Point(5, 23, '='));
            points.Add(new Point(7, 23, '='));
            points.Add(new Point(9, 23, '='));
            points.Add(new Point(11, 23, '='));
            points.Add(new Point(13, 23, '='));

            points.Add(new Point(21, 14, '='));
            points.Add(new Point(23, 14, '='));
            points.Add(new Point(25, 14, '='));
            points.Add(new Point(27, 14, '='));
            points.Add(new Point(29, 14, '='));
            points.Add(new Point(31, 14, '='));
            points.Add(new Point(33, 14, '='));
            points.Add(new Point(33, 15, '='));
            points.Add(new Point(33, 16, '='));
            points.Add(new Point(33, 17, '='));
            points.Add(new Point(33, 18, '='));
            points.Add(new Point(33, 19, '='));
            points.Add(new Point(33, 20, '='));
            points.Add(new Point(33, 21, '='));
            points.Add(new Point(33, 22, '='));
            points.Add(new Point(33, 23, '='));
            points.Add(new Point(21, 15, '='));
            points.Add(new Point(21, 16, '='));
            points.Add(new Point(21, 17, '='));
            points.Add(new Point(21, 18, '='));
            points.Add(new Point(21, 19, '='));
            points.Add(new Point(21, 20, '='));
            points.Add(new Point(21, 21, '='));
            points.Add(new Point(21, 22, '='));
            points.Add(new Point(21, 23, '='));
            points.Add(new Point(23, 23, '='));
            points.Add(new Point(25, 23, '='));
            points.Add(new Point(27, 23, '='));
            points.Add(new Point(29, 23, '='));
            points.Add(new Point(31, 23, '='));

            points.Add(new Point(37 + 4, 14, '='));
            points.Add(new Point(39 + 4, 14, '='));
            points.Add(new Point(41 + 4, 14, '='));
            points.Add(new Point(43 + 4, 14, '='));
            points.Add(new Point(45 + 4, 14, '='));
            points.Add(new Point(47 + 4, 14, '='));
            points.Add(new Point(49 + 4, 14, '='));
            points.Add(new Point(37 + 4, 15, '='));
            points.Add(new Point(37 + 4, 16, '='));
            points.Add(new Point(37 + 4, 17, '='));
            points.Add(new Point(37 + 4, 18, '='));
            points.Add(new Point(39 + 4, 18, '='));
            points.Add(new Point(41 + 4, 18, '='));
            points.Add(new Point(43 + 4, 18, '='));
            points.Add(new Point(45 + 4, 18, '='));
            points.Add(new Point(47 + 4, 18, '='));
            points.Add(new Point(49 + 4, 18, '='));
            points.Add(new Point(49 + 4, 19, '='));
            points.Add(new Point(49 + 4, 20, '='));
            points.Add(new Point(49 + 4, 21, '='));
            points.Add(new Point(49 + 4, 22, '='));
            points.Add(new Point(49 + 4, 23, '='));
            points.Add(new Point(47 + 4, 23, '='));
            points.Add(new Point(45 + 4, 23, '='));
            points.Add(new Point(43 + 4, 23, '='));
            points.Add(new Point(41 + 4, 23, '='));
            points.Add(new Point(39 + 4, 23, '='));
            points.Add(new Point(37 + 4, 23, '='));

            points.Add(new Point(57 + 4, 14, '='));
            points.Add(new Point(59 + 4, 14, '='));
            points.Add(new Point(61 + 4, 14, '='));
            points.Add(new Point(63 + 4, 14, '='));
            points.Add(new Point(65 + 4, 14, '='));
            points.Add(new Point(67 + 4, 14, '='));
            points.Add(new Point(69 + 4, 14, '='));
            points.Add(new Point(57 + 4, 14, '='));
            points.Add(new Point(57 + 4, 15, '='));
            points.Add(new Point(57 + 4, 16, '='));
            points.Add(new Point(57 + 4, 17, '='));
            points.Add(new Point(57 + 4, 18, '='));
            points.Add(new Point(57 + 4, 19, '='));
            points.Add(new Point(57 + 4, 20, '='));
            points.Add(new Point(57 + 4, 21, '='));
            points.Add(new Point(57 + 4, 22, '='));
            points.Add(new Point(57 + 4, 23, '='));
            points.Add(new Point(57 + 4, 18, '='));
            points.Add(new Point(57 + 4, 18, '='));
            points.Add(new Point(59 + 4, 18, '='));
            points.Add(new Point(61 + 4, 18, '='));
            points.Add(new Point(63 + 4, 18, '='));
            points.Add(new Point(65 + 4, 18, '='));
            points.Add(new Point(67 + 4, 18, '='));
            points.Add(new Point(69 + 4, 18, '='));
            points.Add(new Point(57 + 4, 23, '='));
            points.Add(new Point(57 + 4, 23, '='));
            points.Add(new Point(59 + 4, 23, '='));
            points.Add(new Point(61 + 4, 23, '='));
            points.Add(new Point(63 + 4, 23, '='));
            points.Add(new Point(65 + 4, 23, '='));
            points.Add(new Point(67 + 4, 23, '='));
            points.Add(new Point(69 + 4, 23, '='));

            foreach (Point point in points)
            {
                point.Draw();
            }
        }
    }
}
