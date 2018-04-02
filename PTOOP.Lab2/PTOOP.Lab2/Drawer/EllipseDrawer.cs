using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public class EllipseDrawer : BaseDrawer
	{
		public EllipseDrawer()
		{
		}

		public override void Draw(SKCanvas canvas, SKPaint paint, int x, int y)
		{
			canvas.DrawOval(new SKRect(x - 30, y - 10, x + 30, y + 10), paint);
		}
	}
}
