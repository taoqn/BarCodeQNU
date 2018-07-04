using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;

namespace BarcodeQNU.Layout
{
    public class LayoutDataMatrix : PdfDataMatrixBarcode, ILayoutPaper
    {
        //const
        private const float _dimension = 3.5f;
        private const int _X = 110;
        private const int _Y = 50;

        public LayoutDataMatrix(string txt)
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
            this.XDimension = _dimension;
        }

        public Type GetObjectType()
        {
            return GetType();
        }
    }
}
