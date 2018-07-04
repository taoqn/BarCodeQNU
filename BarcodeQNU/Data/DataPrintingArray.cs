using Syncfusion.UI.Xaml.Controls.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeQNU.Data
{
    public class DataPrintingArray : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); }

        private int _printFrom;
        private int _printTo;
        private short _countPrint;
        private BarcodeSymbolType _typeBarCode;

        public int PrintFrom { get => _printFrom; set { _printFrom = value; RaisePropertyChanged("PrintFrom"); } }
        public int PrintTo { get => _printTo; set { _printTo = value; RaisePropertyChanged("PrintTo"); } }
        public short CountPrint { get => _countPrint; set { _countPrint = value; RaisePropertyChanged("CountPrint"); } }
        public BarcodeSymbolType TypeBarCode
        {
            get => _typeBarCode;
            set { try { _typeBarCode = value; RaisePropertyChanged("TypeBarCode"); } catch { } }
        }

        public DataPrintingArray()
        {
            _printFrom = 1;
            _printTo = 5;
            _countPrint = 2;
            _typeBarCode = BarcodeSymbolType.Code128B;
        }
    }
}
