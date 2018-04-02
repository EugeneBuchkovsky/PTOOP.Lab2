using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public interface IDrawer
	{
		void Draw(SKCanvas canvas, SKPaint paint, int x, int y);
	}
}
