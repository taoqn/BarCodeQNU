using System.Windows.Controls;
using BarcodeQNU.Data;
using BarcodeQNU.Layout;

namespace BarcodeQNU.ChildControl
{
    /// <summary>
    /// Interaction logic for SettingLayoutPrinting.xaml
    /// </summary>
    public partial class SettingLayoutPrinting : UserControl
    {
        public SettingLayoutPrinting()
        {
            InitializeComponent();
            DataPaperSizeSetting dataPaperSizeSetting = DataContext as DataPaperSizeSetting;

            LayoutCode128B layout = new LayoutCode128B("01234");
            layout.SetDefault();
            img_view.Source = Tools.ImageConverter.Convert(layout.GetImage());
        }
    }
}
