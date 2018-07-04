using BarcodeQNU.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using BarcodeQNU.Properties;

namespace BarcodeQNU.Data
{
    public class DataListPrinting : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); }

        private bool _isEnableAll;
        private Nullable<Boolean> _checkedAll;
        private BarCodePrinting _printing;
        private List<BarCodePrinting> _listPrinting;
        private MLandscape _landscape;
        private List<MLandscape> _landscapes;
        private PaperSize _paperSize;
        private PrinterSettings _printer;
        private List<string> _listPrinter;
        private int _percent;
        private int _listPrintingCount;

        public bool IsEnableAll { get => _isEnableAll; set { _isEnableAll = value; RaisePropertyChanged("IsEnableAll"); } }
        public Nullable<Boolean> CheckedAll { get => _checkedAll; set { _checkedAll = value; RaisePropertyChanged("CheckedAll"); } }
        public BarCodePrinting Printing { get => _printing; set { _printing = value; RaisePropertyChanged("Printing"); } }
        public List<BarCodePrinting> ListPrinting { get => _listPrinting; set { _listPrinting = value; RaisePropertyChanged("ListPrinting"); } }
        public MLandscape Landscape { get => _landscape; set { _landscape = value; RaisePropertyChanged("Landscape"); } }
        public List<MLandscape> Landscapes { get => _landscapes; set { _landscapes = value; RaisePropertyChanged("Landscapes"); } }
        public PaperSize PaperSize { get => _paperSize; set { _paperSize = value; RaisePropertyChanged("PaperSize"); } }
        public PrinterSettings Printer { get => _printer; set { _printer = value; RaisePropertyChanged("Printer"); } }
        public List<string> ListPrinter { get => _listPrinter; set { _listPrinter = value; RaisePropertyChanged("ListPrinter"); } }
        public int Percent { get => _percent; set { _percent = value; RaisePropertyChanged("Percent"); } }
        public int ListPrintingCount { get => _listPrintingCount; set { _listPrintingCount = value; RaisePropertyChanged("ListPrintingCount"); } }

        public DataListPrinting()
        {
            // Check All
            _checkedAll = true;
            _isEnableAll = true;
            // List<BarCodePrinting> 
            _listPrinting = new List<BarCodePrinting>();
            //Example();
            _listPrintingCount = _listPrinting.Count;
            // Load Printer
            LoadPrinter();
            // Load Landspace
            LoadLandspace();
        }

        void LoadPrinter()
        {
            _listPrinter = new List<string>();
            foreach (string strPrinterName in PrinterSettings.InstalledPrinters)
            {
                _listPrinter.Add(strPrinterName);
            }
            string ps = Settings.Default["PrinterName"] as string;
            if (ps == null)
            {
                _printer = new PrinterSettings();
                _paperSize = _printer.PaperSizes[0];
                //
                Settings.Default["PrinterName"] = _printer.PrinterName;
                Settings.Default["PaperName"] = _paperSize.PaperName;
                Settings.Default.Save();
            }
            else
            {
                _printer = new PrinterSettings() { PrinterName = ps };
                string paperName = Settings.Default["PaperName"] as string;
                foreach (PaperSize pps in _printer.PaperSizes)
                {
                    if (paperName.Equals(pps.PaperName))
                    {
                        PaperSize = pps;
                    }
                }
            }
        }

        void LoadLandspace()
        {
            _landscapes = new List<MLandscape>()
            {
                new MLandscape() { Name = "Nằm ngang", Value = false },
                new MLandscape() { Name = "Nằm dọc", Value = true }
            };
            if (Settings.Default["Landspace"] == null)
            {
                _landscape = _landscapes[0];
            }
            else
            {
                if (Settings.Default["Landspace"].ToString().Equals("False"))
                {
                    _landscape = _landscapes[0];
                }
                else
                {
                    _landscape = _landscapes[1];
                }
            }
        }

        string getRandom()
        {
            return DateTime.Now.Millisecond + "2";
        }

        public void Example()
        {
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 1,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Codabar
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 2,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code11
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 3,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code128A
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 4,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code128B
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 5,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code128C
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 6,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code32
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 7,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code39
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 8,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code39Extended
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 9,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code93
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 10,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.Code93Extended
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 11,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.DataMatrix
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 12,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.QRBarcode
            });
            _listPrinting.Add(new BarCodePrinting()
            {
                STT = 13,
                Code = getRandom(),
                Count = 1,
                Selected = true,
                TypeBarCode = Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType.UpcBarcode
            });
        }
    }
}