using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;

namespace BarcodeQNU.Layout
{
    public class LayoutUpcBarcode : PdfCodeUpcBarcode, ILayoutPaper
    {
        //const
        private const int _barHeight = 35;
        private const int _X = 110;
        private const int _Y = 50;

        private const float _barcodeToTextGapHeight = 1;

        public LayoutUpcBarcode(string txt)
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
            EnableCheckDigit = false;
            EncodeStartStopSymbols = false;
            BarcodeToTextGapHeight = _barcodeToTextGapHeight;
            BarHeight = _barHeight;
        }

        public Type GetObjectType()
        {
            return GetType();
        }
    }
}
