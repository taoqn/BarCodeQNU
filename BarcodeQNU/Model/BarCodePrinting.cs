using BarcodeQNU.Layout;
using Syncfusion.UI.Xaml.Controls.Barcode;
using System;
using System.ComponentModel;

namespace BarcodeQNU.Model
{
    public class BarCodePrinting : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); }

        private int? _stt;
        private string _code;
        private short _count;
        private bool _selected;
        private BarcodeSymbolType _typeBarCode;
        private ILayoutPaper _layoutPaper;
        private int _per;
        private bool _success;

        public int? STT { get => _stt; set { _stt = value; RaisePropertyChanged("STT"); } }
        public string Code {
            get => _code;
            set {
                try
                {
                    _code = value;
                    RaisePropertyChanged("Code");
                }
                catch
                {

                }
            }
        }
        public short Count { get => _count; set { _count = value; RaisePropertyChanged("Count"); } }
        public bool Selected { get => _selected; set { _selected = value; RaisePropertyChanged("Selected"); } }
        public BarcodeSymbolType TypeBarCode { get => _typeBarCode;
            set {
                try
                {
                    _typeBarCode = value; RaisePropertyChanged("TypeBarCode");
                }
                catch
                {

                }
            }
        }
        public ILayoutPaper LayoutPaper { get => _layoutPaper; set { _layoutPaper = value; RaisePropertyChanged("LayoutPaper"); } }
        public int Per { get => _per; set { _per = value; RaisePropertyChanged("Per"); } }
        public bool Success { get => _success; set { _success = value; RaisePropertyChanged("Success"); } }

        public BarCodePrinting()
        {
        }

        public BarCodePrinting(BarCodePrinting barCode)
        {
            _stt = barCode.STT;
            _code = barCode.Code;
            _count = barCode.Count;
            _selected = barCode.Selected;
            _typeBarCode = barCode.TypeBarCode;
            _layoutPaper = barCode.LayoutPaper;
            _success = barCode.Success;
        }

    }
}
