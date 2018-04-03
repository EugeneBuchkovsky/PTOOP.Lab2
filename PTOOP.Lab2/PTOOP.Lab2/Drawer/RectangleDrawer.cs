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
			canvas.DrawRect(new SKRect(x - 100, y - 50, x + 100, y + 50), paint);
		}
	}
}
