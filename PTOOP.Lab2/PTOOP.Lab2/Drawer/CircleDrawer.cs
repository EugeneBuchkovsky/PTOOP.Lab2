using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public class CircleDrawer : BaseDrawer
	{
		public CircleDrawer()
		{
		}

		public override void Draw(SKCanvas canvas, SKPaint paint, int x, int y)
		{
			canvas.DrawCircle(x, y, 50, paint);
		}
	}
}
