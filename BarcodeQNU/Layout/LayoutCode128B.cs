using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;

namespace BarcodeQNU.Layout
{
    public class LayoutCode128B : PdfCode128Barcode, ILayoutPaper
    {
        //const
        private const int _barcodeToTextGapHeight = 1;
        private const int _barHeight = 32;
        private const PdfBarcodeTextAlignment _textAlignment = PdfBarcodeTextAlignment.Center;
        private const PdfFontFamily _fontFamily = PdfFontFamily.Courier;
        private const int _fontSize = 13;
        private const PdfFontStyle _fontStyle = PdfFontStyle.Bold;

        public LayoutCode128B(string txt)
        {
            Text = txt;
        }

        public Image GetImage()
        {
            if (!Text.Equals(""))
                return ToImage();
            else
                return null;
        }

        public Type GetObjectType()
        {
            return GetType();
        }

        public void SetDefault()
        {
            BarcodeToTextGapHeight = _barcodeToTextGapHeight;
            BarHeight = _barHeight;
            TextAlignment = _textAlignment;
            Font = new PdfStandardFont(_fontFamily, _fontSize, _fontStyle);
        }
    }
}