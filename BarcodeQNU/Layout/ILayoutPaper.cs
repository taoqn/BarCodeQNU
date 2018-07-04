using Syncfusion.UI.Xaml.Controls.Barcode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeQNU.Layout
{
    public interface ILayoutPaper
    {
        void SetDefault();
        Image GetImage();
        Type GetObjectType();
    }
}