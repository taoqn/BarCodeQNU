using BarcodeQNU.Layout;
using BarcodeQNU.Model;
using Syncfusion.UI.Xaml.Controls.Barcode;

namespace BarcodeQNU.Data
{
    class DataPrinting
    {
        private BarCodePrinting _printing;
        public BarCodePrinting Printing { get => _printing; set => _printing = value; }

        public DataPrinting()
        {
            _printing = new BarCodePrinting();
            _printing.Count = 2;
            _printing.Selected = true;
            _printing.TypeBarCode = BarcodeSymbolType.Code128B;
        }

    }
}
