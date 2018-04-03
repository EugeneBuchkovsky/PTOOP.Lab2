using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public class DotDrawer : BaseDrawer
	{
		public DotDrawer()
		{
		}

		public override void Draw(SKCanvas canvas, SKPaint paint, int x, int y)
		{
			canvas.DrawCircle(x, y, 1, paint);
		}
	}
}
