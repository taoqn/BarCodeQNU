using BarcodeQNU.Layout;
using BarcodeQNU.Model;
using Syncfusion.UI.Xaml.Controls.Barcode;

namespace BarcodeQNU.Tools
{
    class LayoutConvert 
    {
        public static ILayoutPaper Convert(BarCodePrinting value)
        {
            if (value == null) return null;
            ILayoutPaper layout = null;
            BarCodePrinting printing = value as BarCodePrinting;
            switch (printing.TypeBarCode)
            {
                case BarcodeSymbolType.Codabar:
                    layout = new LayoutCodabar(printing.Code);
                    break;
                case BarcodeSymbolType.Code11:
                    layout = new LayoutCode11(printing.Code);
                    break;
                case BarcodeSymbolType.Code128A:
                    layout = new LayoutCode128A(printing.Code);
                    break;
                case BarcodeSymbolType.Code128B:
                    layout = new LayoutCode128B(printing.Code);
                    break;
                case BarcodeSymbolType.Code128C:
                    layout = new LayoutCode128C(printing.Code);
                    break;
                case BarcodeSymbolType.Code32:
                    layout = new LayoutCode32(printing.Code);
                    break;
                case BarcodeSymbolType.Code39:
                    layout = new LayoutCode39(printing.Code);
                    break;
                case BarcodeSymbolType.Code39Extended:
                    layout = new LayoutCode39Extended(printing.Code);
                    break;
                case BarcodeSymbolType.Code93:
                    layout = new LayoutCode93(printing.Code);
                    break;
                case BarcodeSymbolType.Code93Extended:
                    layout = new LayoutCode93Extended(printing.Code);
                    break;
                case BarcodeSymbolType.DataMatrix:
                    layout = new LayoutDataMatrix(printing.Code);
                    break;
                case BarcodeSymbolType.QRBarcode:
                    layout = new LayoutQRBarcode(printing.Code);
                    break;
                case BarcodeSymbolType.UpcBarcode:
                    layout = new LayoutUpcBarcode(printing.Code);
                    break;
            }
            layout.SetDefault();
            return layout;
        }
    }
}
