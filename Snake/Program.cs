﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);
			Console.SetBufferSize(80, 25);

			HorizontalLine upline = new HorizontalLine(0,78,0,'+');
			HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
			VerticalLines leftline = new VerticalLines(0, 24, 0, '+');
			VerticalLines rightline = new VerticalLines(0, 24, 78, '+');

			upline.Draw();
			downline.Draw();
			leftline.Draw();
			rightline.Draw();


			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();
			snake.Move();
			Console.ReadLine();
		}
	}
}
