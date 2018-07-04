using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;

namespace BarcodeQNU.Layout
{
    class LayoutCode128A : PdfCode128ABarcode, ILayoutPaper
    {
        //const
        private const int _barHeight = 32;
        private const int _X = 110;
        private const int _Y = 50;
        private const PdfBarcodeTextAlignment _textAlignment = PdfBarcodeTextAlignment.Center;
        private const PdfFontFamily _fontFamily = PdfFontFamily.TimesRoman;
        private const int _fontSize = 13;
        private const PdfFontStyle _fontStyle = PdfFontStyle.Bold;

        public LayoutCode128A(string txt)
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

            BarHeight = _barHeight;
            TextAlignment = _textAlignment;
            Font = new PdfStandardFont(_fontFamily, _fontSize, _fontStyle);
        }

        public Type GetObjectType()
        {
            return GetType();
        }
    }
}
