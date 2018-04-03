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
			canvas.DrawOval(new SKRect(x - 100, y - 50, x + 100, y + 50), paint);
		}
	}
}
