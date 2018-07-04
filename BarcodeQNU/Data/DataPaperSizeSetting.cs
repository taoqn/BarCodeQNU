using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using BarcodeQNU.Model;
using BarcodeQNU.Properties;

namespace BarcodeQNU.Data
{
    public class DataPaperSizeSetting : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); }

        private int _paperSizeW;
        private int _paperSizeH;
        private int _barcodeSizeW;
        private int _barcodeSizeH;
        private float _marginLeft;
        private float _marginTop;
        private Horizontal _horizo;
        private List<Horizontal> _horizos;

        public int PaperSizeW { get => _paperSizeW; set { _paperSizeW = value; RaisePropertyChanged("PaperSizeW"); } }
        public int PaperSizeH { get => _paperSizeH; set { _paperSizeH = value; RaisePropertyChanged("PaperSizeH"); } }
        public int BarcodeSizeH { get => _barcodeSizeH; set { _barcodeSizeH = value; RaisePropertyChanged("BarcodeSizeH"); } }
        public int BarcodeSizeW { get => _barcodeSizeW; set { _barcodeSizeW = value; RaisePropertyChanged("BarcodeSizeW"); } }
        public float MarginLeft { get => _marginLeft; set { _marginLeft = value; RaisePropertyChanged("MarginLeft"); } }
        public float MarginTop { get => _marginTop; set { _marginTop = value; RaisePropertyChanged("MarginTop"); } }
        public Horizontal Horizo { get => _horizo; set { _horizo = value; RaisePropertyChanged("Horizo"); } }
        public List<Horizontal> Horizos { get => _horizos; set { _horizos = value; RaisePropertyChanged("Horizos"); } }

        public DataPaperSizeSetting()
        {
            _paperSizeW = (int)Settings.Default["SizeWidth"];
            _paperSizeH = (int)Settings.Default["SizeHeight"];
            _barcodeSizeH = (int)Settings.Default["BarcodeH"];
            _barcodeSizeW = (int)Settings.Default["BarcodeW"];
            _marginLeft = (float)Settings.Default["MarginLeft"];
            _marginTop = (float)Settings.Default["MarginTop"];

            LoadHorizontal();
        }

        void LoadHorizontal()
        {
            _horizos = new List<Horizontal>()
            {
                new Horizontal() { Name = "Trái", Value = HorizontalAlignment.Left },
                new Horizontal() { Name = "Giữa", Value = HorizontalAlignment.Stretch },
                new Horizontal() { Name = "Phải", Value = HorizontalAlignment.Right }
            };
            _horizo = _horizos[1];
            if (Settings.Default["HorizontalAlignment"] == null)
            {
                _horizo = _horizos[1];
            }
            else
            {
                switch (Settings.Default["HorizontalAlignment"].ToString())
                {
                    case "Left":
                        _horizo = _horizos[0];
                        break;
                    case "Stretch":
                        _horizo = _horizos[1];
                        break;
                    case "Right":
                        _horizo = _horizos[2];
                        break;
                }
            }
        }
    }
}
