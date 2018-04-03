using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using PTOOP.Lab2.Drawer;

namespace PTOOP.Lab2
{
	public partial class PTOOP_Lab2Page : ContentPage
	{
		private Button _dotBtn;
		private Button _circleBtn;
		private Button _rectBtn;
		private Button _ellipseBtn;
		private Button _triBtn;
		private Button _lineBtn;

		private IDrawer drawer;

		public SKCanvasView canvasView;

		public PTOOP_Lab2Page()
		{
			InitializeComponent();

			var btnLayout = new StackLayout { Orientation = StackOrientation.Horizontal, VerticalOptions = LayoutOptions.StartAndExpand, Margin = new Thickness(20), HeightRequest = 100 };

			Title = "Lab 2";

			canvasView = new SKCanvasView();
			canvasView.VerticalOptions = LayoutOptions.StartAndExpand;
			canvasView.HeightRequest = 400;
			canvasView.PaintSurface += OnCanvasViewPaintSurface;
			//Content = canvasView;

			_dotBtn = new Button { Text = "Dot", BackgroundColor = Color.White };
			_dotBtn.Clicked += (o,e) => 
			{ 
				drawer = new DotDrawer();
				SetDefaultColor();
				_dotBtn.BackgroundColor = Color.Azure;
			};

			_circleBtn = new Button { Text = "Circle", BackgroundColor = Color.White };
			_circleBtn.Clicked += (o, e) => 
			{ 
				drawer = new CircleDrawer(); 
				SetDefaultColor();
				_circleBtn.BackgroundColor = Color.Azure;
			};

			_rectBtn = new Button { Text = "Rectangle", BackgroundColor = Color.White };
			_rectBtn.Clicked += (o, e) => 
			{ 
				drawer = new RectangleDrawer(); 
				SetDefaultColor();
				_rectBtn.BackgroundColor = Color.Azure;
			};

			_ellipseBtn = new Button { Text = "Ellipse", BackgroundColor = Color.White };
			_ellipseBtn.Clicked += (o, e) => 
			{ 
				drawer = new EllipseDrawer(); 
				SetDefaultColor();
				_ellipseBtn.BackgroundColor = Color.Azure;
			};

			_triBtn = new Button { Text = "Triangle", BackgroundColor = Color.White };
			_triBtn.Clicked += (o, e) => 
			{ 
				drawer = new TriangleDrawer(); 
				SetDefaultColor();
				_triBtn.BackgroundColor = Color.Azure;
			};

			_lineBtn = new Button { Text = "Line", BackgroundColor = Color.White };
			_lineBtn.Clicked += (o, e) => 
			{ 
				drawer = new LineDrawer(); 
				SetDefaultColor();
				_lineBtn.BackgroundColor = Color.Azure;
			};


			btnLayout.Children.Add(_dotBtn);
			btnLayout.Children.Add(_circleBtn);
			btnLayout.Children.Add(_rectBtn);
			btnLayout.Children.Add(_ellipseBtn);
			btnLayout.Children.Add(_triBtn);
			btnLayout.Children.Add(_lineBtn);

			var mainstack = new StackLayout { Orientation = StackOrientation.Vertical };
			mainstack.Children.Add(btnLayout);
			mainstack.Children.Add(canvasView);

			this.Content = mainstack;

			//var gesture = new TapGestureRecognizer();
			//gesture.Tapped += (sender, e) =>
			//{
				
			//	//ScaleCoef = ScaleCoef == 1 ? 3 : 1;
			//	//hslCanvasView.InvalidateSurface();
			//};
			//gesture.NumberOfTapsRequired = 2;
			//canvasView.GestureRecognizers.Add(gesture);
		}

		private void SetDefaultColor()
		{
			_dotBtn.BackgroundColor  = Color.White;
			_circleBtn.BackgroundColor  = Color.White;
			_rectBtn.BackgroundColor = Color.White;
			_ellipseBtn.BackgroundColor = Color.White;
			_triBtn.BackgroundColor = Color.White;
			_lineBtn.BackgroundColor = Color.White;

			canvasView.InvalidateSurface();
		}

		void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
		{
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			canvas.Clear();

			SKPaint paint = new SKPaint
			{
				Style = SKPaintStyle.Stroke,
				Color = Color.Red.ToSKColor(),
				StrokeWidth = 10
			};

			if (drawer != null)
				drawer.Draw(canvas, paint, info.Width / 2, info.Height / 2);
		}
	}
}
