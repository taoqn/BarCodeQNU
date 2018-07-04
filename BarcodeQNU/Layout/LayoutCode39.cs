using Syncfusion.Pdf.Barcode;
using Syncfusion.Pdf.Graphics;
using System;
using System.Drawing;

namespace BarcodeQNU.Layout
{
    public class LayoutCode39 : PdfCode39Barcode, ILayoutPaper
    {
        //const
        private const int _barHeight = 30;
        private const PdfBarcodeTextAlignment _textAlignment = PdfBarcodeTextAlignment.Center;
        private const PdfFontFamily _fontFamily = PdfFontFamily.TimesRoman;
        private const int _fontSize = 10;
        private const PdfFontStyle _fontStyle = PdfFontStyle.Bold;

        public LayoutCode39(string txt)
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
            BarHeight = _barHeight;
            //TextAlignment = _textAlignment;
            Font = new PdfStandardFont(_fontFamily, _fontSize, _fontStyle);
            //this.
            
        }
    }
}
