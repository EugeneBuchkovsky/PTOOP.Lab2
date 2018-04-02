using System;
using PTOOP.Lab1.BLL.Interfaces;

namespace PTOOP.Lab1.BLL.Entities
{
	public class BaseFigure : IFigure
	{
		public int X { get; set; }

		public int Y { get; set; }

		public BaseFigure(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

	}
}
