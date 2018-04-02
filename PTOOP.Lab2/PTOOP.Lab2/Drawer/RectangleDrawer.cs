using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public class RectangleDrawer : BaseDrawer
	{
		public RectangleDrawer()
		{
		}

		public override void Draw(SKCanvas canvas, SKPaint paint, int x, int y)
		{
			canvas.DrawRect(new SKRect(x - 30, y - 10, x + 30, y + 10), paint);
		}
	}
}
