using CSharpMath.SkiaSharp;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace ClassLibrary1
{
    public class MathView : SKGLView
    {
        SkiaMathPainter painter = new SkiaMathPainter { LaTeX = "e=mc^2" };
        public MathView()
        {
            base.HeightRequest = 500;
        }

        protected override void OnPaintSurface(SKPaintGLSurfaceEventArgs e)
        {
            e.Surface.Canvas.DrawCircle(0f, 0f, 100f, new SKPaint { Color = new SKColor(255, 0, 0) });
            // painter.Draw(e.Surface.Canvas, 0f, 0f);
            e.Surface.Canvas.DrawCircle(300f, 0f, 100f, new SKPaint { Color = new SKColor(255, 255, 0) });
        }
    }

    public class App: Application
    {
        public App()
        {
            base.MainPage = new ContentPage
            {
                Content = new MathView()
            };
        }
    }
}
