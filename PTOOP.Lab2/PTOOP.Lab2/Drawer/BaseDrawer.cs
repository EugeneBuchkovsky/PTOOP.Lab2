using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public abstract class BaseDrawer : IDrawer
	{
		public abstract void Draw(SKCanvas canvas, SKPaint paint, int x, int y);
	}
}
