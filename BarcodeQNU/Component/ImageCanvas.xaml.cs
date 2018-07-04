using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarcodeQNU.Component
{
    /// <summary>
    /// Interaction logic for ImageCanvas.xaml
    /// </summary>
    public partial class ImageCanvas : Canvas
    {
        public ImageCanvas()
        {
            InitializeComponent();
        }

        public ImageSource CanvasImageSource
        {
            get { return (ImageSource)GetValue(CanvasImageSourceProperty); }
            set { SetValue(CanvasImageSourceProperty, value); }
        }

        public static readonly DependencyProperty CanvasImageSourceProperty =
            DependencyProperty.Register("CanvasImageSource", typeof(ImageSource),
            typeof(ImageCanvas), new FrameworkPropertyMetadata(default(ImageSource)));

        protected override void OnRender(System.Windows.Media.DrawingContext dc)
        {
            dc.DrawImage(CanvasImageSource, new Rect(this.RenderSize));
            base.OnRender(dc);
        }
    }
}
