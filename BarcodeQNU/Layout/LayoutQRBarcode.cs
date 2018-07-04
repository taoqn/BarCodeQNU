using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;

namespace BarcodeQNU.Layout
{
    public class LayoutQRBarcode : PdfQRBarcode, ILayoutPaper
    {
        //const
        private const int _barHeight = 45;
        private const int _X = 110;
        private const int _Y = 50;

        public LayoutQRBarcode(string txt)
        {
            Text = txt;
        }

        private PointF point;
        public PointF Point { get => point; set => point = value; }

        public Image GetImage()
        {
            if (!Text.Equals(""))
                return ToImage();
            else
                return null;
        }

        public void SetDefault()
        {
            Point = new PointF(_X, _Y);
            Size = new SizeF(_barHeight, _barHeight);
        }

        public Type GetObjectType()
        {
            return GetType();
        }
    }
}
