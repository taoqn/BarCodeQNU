using System.Drawing.Printing;

namespace BarcodeQNU.Model
{
    public class PrinterSet
    {
        public BarCodePrinting BarCode { get; set; }
        public PrinterSettings PrinterSettings { get; set; }
        public PaperSize PaperSize { get; set; }
        public MLandscape Landscape { get; set; }
        public Horizontal Horizontal { get; set; }
    }
}
