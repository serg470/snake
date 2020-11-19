using System;
using System.Collections.Generic;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1, 3, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();

			Point p3 = new Point(7, 9, '@');
			p3.Draw();

			Point p4 = new Point(2, 6, '&');
			p4.Draw();

			List<int> numList = new List<int>();
			numList.Add(5);
			numList.Add(6);
			numList.Add(7);

			int x = numList[0];
			int y = numList[1];
			int z = numList[2];


			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);
			pList.Add(p3);
			pList.Add(p4);


			Console.ReadLine();
		}
	}
}
