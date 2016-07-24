﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upline = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '*');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '*');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '*');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

    }
}
