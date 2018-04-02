using System;
using SkiaSharp;

namespace PTOOP.Lab2.Drawer
{
	public class TriangleDrawer : BaseDrawer
	{
		public TriangleDrawer()
		{
		}

		public override void Draw(SKCanvas canvas, SKPaint paint, int x, int y)
		{
            using (var path = new SKPath())
            {
                path.MoveTo(x, y);
                path.LineTo(x - 30, y);
                path.LineTo(x, y - 50);
                path.LineTo(x + 30, y);
                path.LineTo(x, y);
                path.Close();

                canvas.DrawPath(path, paint);
            }
		}
	}
}
