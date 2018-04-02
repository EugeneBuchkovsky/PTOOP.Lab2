using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public class LineDrawer : BaseDrawer
	{
		public LineDrawer()
		{
		}

		public override void Draw(SKCanvas canvas, SKPaint paint, int x, int y)
		{
			canvas.DrawLine(new SKPoint(x - 30, y), new SKPoint(x + 30, y), paint);
		}
	}
}
