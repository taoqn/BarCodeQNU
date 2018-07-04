using System.Windows;
using System.Collections.Generic;
using System.Drawing.Printing;
using System;
using System.ComponentModel;
using System.Threading;
using Syncfusion.Windows.Tools.Controls;
using BarcodeQNU.Data;
using BarcodeQNU.Model;
using BarcodeQNU.Tools;
using BarcodeQNU.Properties;

namespace BarcodeQNU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private BackgroundWorker bg_worker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();

            ModalDialog_AddBarcode.SetParent(Container_Main);
            ModalDialog_AddListBarcode.SetParent(Container_Main);
            ModalDialog_DeleteBarcode.SetParent(Container_Main);
            ModalDialog_DeleteBarcode_Index.SetParent(Container_Main);
            ModalDialog_PrintBarcode.SetParent(Container_Main);
            ModalDialog_PaperSetting.SetParent(Container_Main);

            bg_worker.WorkerReportsProgress = true;
            bg_worker.WorkerSupportsCancellation = true;
            bg_worker.DoWork += Bg_worker_DoWork;
            bg_worker.ProgressChanged += Bg_worker_ProgressChanged;
            bg_worker.RunWorkerCompleted += Bg_worker_RunWorkerCompleted;
        }

        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            //RibbonComboBox_Paper.SelectedIndex = getIndex(dataContext.PaperSize?.PaperName, dataContext.Printer.PaperSizes);
        }

        private int getIndex(string paperName, PrinterSettings.PaperSizeCollection paperSizeCollection)
        {
            int i = 0;
            foreach (PaperSize pps in paperSizeCollection)
            {
                if (pps.PaperName.Equals(paperName))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private void RibbonComboBox_Printer_LostFocus(object sender, RoutedEventArgs e)
        {
            Settings.Default["PrinterName"] = (DataContext as DataListPrinting).Printer.PrinterName;
            Settings.Default.Save();
        }

        private void RibbonComboBox_Paper_LostFocus(object sender, RoutedEventArgs e)
        {
            Settings.Default["PaperName"] = (DataContext as DataListPrinting).PaperSize?.PaperName;
            Settings.Default.Save();
        }

        private void RibbonComboBox_Landscapes_LostFocus(object sender, RoutedEventArgs e)
        {
            Settings.Default["Landspace"] = (DataContext as DataListPrinting).Landscape.Value;
            Settings.Default.Save();
        }

        private void RibbonButton_Add_Click(object sender, RoutedEventArgs e)
        {
            ModalDialog_AddBarcode.ShowHandlerDialog();
        }

        private void RibbonButton_PaperSize_Click(object sender, RoutedEventArgs e)
        {
            ModalDialog_PaperSetting.ShowHandlerDialog();
        }

        private void ModalDialog_AddBarcode_OKModal(object sender, RoutedEventArgs e)
        {
            ChildControl.AddPrintingBarcode ucontrol = ModalDialog_AddBarcode.Children[0] as ChildControl.AddPrintingBarcode;
            DataPrinting dataPrinting = ucontrol.DataContext as DataPrinting;
            if (dataPrinting.Printing.Code == null)
                return;
            DataListPrinting dataContext = DataContext as DataListPrinting;
            dataContext.ListPrinting.Add(new BarCodePrinting(dataPrinting.Printing));
            RefeshItems();
        }

        private void ModalDialog_AddListBarcode_OKModal(object sender, RoutedEventArgs e)
        {
            DataPrintingArray dataPrintingArray = (ModalDialog_AddListBarcode.Children[0] as ChildControl.AddListPrintingBarcode).DataContext as DataPrintingArray;

            int len = (dataPrintingArray.PrintTo.ToString().Length > 4) ? dataPrintingArray.PrintTo.ToString().Length : 4;
            string format = ("{0," + len + ":").PadRight(5 + len, char.Parse("0")) + "}";

            List<BarCodePrinting> arr_add = new List<BarCodePrinting>();
            for (int i = dataPrintingArray.PrintFrom; i <= dataPrintingArray.PrintTo; i++)
            {
                arr_add.Add(new BarCodePrinting() {
                    Code = String.Format(format, i),
                    Count = dataPrintingArray.CountPrint,
                    Selected = true,
                    TypeBarCode = dataPrintingArray.TypeBarCode
                });
            }
            (DataContext as DataListPrinting).ListPrinting.AddRange(arr_add);
            RefeshItems();
        }

        private void RibbonButton_AddList_Click(object sender, RoutedEventArgs e)
        {
            ModalDialog_AddListBarcode.ShowHandlerDialog();
        }

        private void RibbonButton_Set_Count_All_Click(object sender, RoutedEventArgs e)
        {
            foreach (BarCodePrinting print in (DataContext as DataListPrinting).ListPrinting)
            {
                print.Count = short.Parse(RibbonTexTBox_Count.Text);
            }
        }

        private void RibbonButton_Set_Type_All_Click(object sender, RoutedEventArgs e)
        {
            foreach (BarCodePrinting print in (DataContext as DataListPrinting).ListPrinting)
            {
                print.TypeBarCode = (Syncfusion.UI.Xaml.Controls.Barcode.BarcodeSymbolType)RibbonComboBox_TypeBarCode.SelectedItem;
            }
        }

        private void RibbonButton_Delete_Click(object sender, RoutedEventArgs e)
        {
            ModalDialog_DeleteBarcode.ShowHandlerDialog();
        }

        private void ModalDialog_DeleteBarcode_OKModal(object sender, RoutedEventArgs e)
        {
            List<BarCodePrinting> list = (DataContext as DataListPrinting).ListPrinting;
            List<BarCodePrinting> arr_delete = new List<BarCodePrinting>();
            foreach (BarCodePrinting print in list)
            {
                if (print.Selected)
                {
                    arr_delete.Add(print);
                }
            }
            foreach (BarCodePrinting print in arr_delete)
            {
                list.Remove(print);
            }
            RefeshItems();
        }

        private void Grid_button_delete_Click(object sender, RoutedEventArgs e)
        {
            ModalDialog_DeleteBarcode_Index.ShowHandlerDialog();
        }

        private void ModalDialog_DeleteBarcode_Index_OKModal(object sender, RoutedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            dataContext.ListPrinting.Remove(DataGrid.SelectedItem as BarCodePrinting);

            List<BarCodePrinting> list = (DataContext as DataListPrinting).ListPrinting;
            List<BarCodePrinting> arr_delete = new List<BarCodePrinting>();
            foreach (BarCodePrinting print in list)
            {
                if (print.STT.Value == (DataGrid.SelectedItem as BarCodePrinting).STT.Value)
                {
                    arr_delete.Add(print);
                }
            }
            foreach (BarCodePrinting print in arr_delete)
            {
                list.Remove(print);
            }
            RefeshItems();
        }

        private void RefeshItems()
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            int i = 1;
            foreach (BarCodePrinting print in dataContext.ListPrinting)
            {
                print.STT = i++;
            }
            dataContext.ListPrintingCount = dataContext.ListPrinting.Count;
            DataGrid.View.Refresh();
        }

        private void ModalDialog_PaperSetting_OKModal(object sender, RoutedEventArgs e)
        {
            ChildControl.SettingLayoutPrinting ucontrol = ModalDialog_PaperSetting.Children[0] as ChildControl.SettingLayoutPrinting;
            DataPaperSizeSetting dataPaperSizeSetting = ucontrol.DataContext as DataPaperSizeSetting;

            Settings.Default["SizeWidth"] = dataPaperSizeSetting.PaperSizeW;
            Settings.Default["SizeHeight"] = dataPaperSizeSetting.PaperSizeH;
            Settings.Default["BarcodeW"] = dataPaperSizeSetting.BarcodeSizeW;
            Settings.Default["BarcodeH"] = dataPaperSizeSetting.BarcodeSizeH;
            Settings.Default["HorizontalAlignment"] = dataPaperSizeSetting.Horizo.Value.ToString();
            Settings.Default.Save();
        }

        private void ModalDialog_PaperSetting_CloseModal(object sender, RoutedEventArgs e)
        {
            ChildControl.SettingLayoutPrinting ucontrol = ModalDialog_PaperSetting.Children[0] as ChildControl.SettingLayoutPrinting;
            DataPaperSizeSetting dataPaperSizeSetting = ucontrol.DataContext as DataPaperSizeSetting;

            dataPaperSizeSetting.PaperSizeW = (int)Settings.Default["SizeWidth"];
            dataPaperSizeSetting.PaperSizeH = (int)Settings.Default["SizeHeight"];
            dataPaperSizeSetting.BarcodeSizeW = (int)Settings.Default["BarcodeW"];
            dataPaperSizeSetting.BarcodeSizeH = (int)Settings.Default["BarcodeH"];

            switch (Settings.Default["HorizontalAlignment"].ToString())
            {
                case "Left":
                    dataPaperSizeSetting.Horizo = dataPaperSizeSetting.Horizos[0];
                    break;
                case "Stretch":
                    dataPaperSizeSetting.Horizo = dataPaperSizeSetting.Horizos[1];
                    break;
                case "Right":
                    dataPaperSizeSetting.Horizo = dataPaperSizeSetting.Horizos[2];
                    break;
            }
        }

        private void ModalDialog_PaperSetting_ExitAllModal(object sender, RoutedEventArgs e)
        {
            ChildControl.SettingLayoutPrinting ucontrol = ModalDialog_PaperSetting.Children[0] as ChildControl.SettingLayoutPrinting;
            DataPaperSizeSetting dataPaperSizeSetting = ucontrol.DataContext as DataPaperSizeSetting;

            dataPaperSizeSetting.PaperSizeW = (int)Settings.Default["SizeWidth"];
            dataPaperSizeSetting.PaperSizeH = (int)Settings.Default["SizeHeight"];
            dataPaperSizeSetting.BarcodeSizeW = (int)Settings.Default["BarcodeW"];
            dataPaperSizeSetting.BarcodeSizeH = (int)Settings.Default["BarcodeH"];

            switch (Settings.Default["HorizontalAlignment"].ToString())
            {
                case "Left":
                    dataPaperSizeSetting.Horizo = dataPaperSizeSetting.Horizos[0];
                    break;
                case "Stretch":
                    dataPaperSizeSetting.Horizo = dataPaperSizeSetting.Horizos[1];
                    break;
                case "Right":
                    dataPaperSizeSetting.Horizo = dataPaperSizeSetting.Horizos[2];
                    break;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            foreach (BarCodePrinting print in dataContext.ListPrinting)
            {
                print.Selected = true;
            }
            dataContext.CheckedAll = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            foreach (BarCodePrinting print in dataContext.ListPrinting)
            {
                print.Selected = false;
            }
            dataContext.CheckedAll = false;
        }

        private void DataGrid_CurrentCellActivating(object sender, Syncfusion.UI.Xaml.Grid.CurrentCellActivatingEventArgs e)
        {
            int row = e.CurrentRowColumnIndex.RowIndex - 1, col = e.CurrentRowColumnIndex.ColumnIndex;
            if (col == 0 || col == 4 || col == 5 || col == 7)
            {
                DataGrid.SelectedIndex = row;
                e.Cancel = true;
            }
        }

        //int i = 0;
        private void RibbonWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //DataGrid.Height = (e.NewSize.Height - 170);
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            int count_checked = 0;
            foreach (BarCodePrinting print in dataContext.ListPrinting)
            {
                if (print.Selected)
                {
                    count_checked++;
                }
            }
            if (count_checked == dataContext.ListPrinting.Count)
            {
                dataContext.CheckedAll = true;
            }
            else
            {
                dataContext.CheckedAll = null;
            }
        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            int count_unchecked = 0;
            foreach (BarCodePrinting print in dataContext.ListPrinting)
            {
                if (!print.Selected)
                {
                    count_unchecked++;
                }
            }
            if (count_unchecked == dataContext.ListPrinting.Count)
            {
                dataContext.CheckedAll = false;
            }
            else
            {
                dataContext.CheckedAll = null;
            }
        }

        private void RibbonButton_Print_Click(object sender, RoutedEventArgs e)
        {
            ModalDialog_PrintBarcode.ShowHandlerDialog();
        }

        private void ModalDialog_PrintBarcode_OKModal(object sender, RoutedEventArgs e)
        {
            ModalDialog_PrintBarcode.HideHandlerDialog();
            if (!bg_worker.IsBusy)
            {
                ChildControl.SettingLayoutPrinting ucontrol = ModalDialog_PaperSetting.Children[0] as ChildControl.SettingLayoutPrinting;
                DataPaperSizeSetting dataPaperSizeSetting = ucontrol.DataContext as DataPaperSizeSetting;
                List<object> listData = new List<object>();
                listData.Add(DataContext as DataListPrinting);
                listData.Add(dataPaperSizeSetting);
                bg_worker.RunWorkerAsync(listData);
                ButtonCloseProgressBar.Visibility = Visibility.Visible;
            }
        }

        private AutoResetEvent autoReset = new AutoResetEvent(false);

        private void Bg_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<object> listData = e.Argument as List<object>;

            DataListPrinting dataContext = listData[0] as DataListPrinting;
            DataPaperSizeSetting dataPaperSizeSetting = listData[1] as DataPaperSizeSetting;
            dataContext.IsEnableAll = false;

            List<BarCodePrinting> listprinting = dataContext.ListPrinting;
            int i = 1, max = listprinting.Count;
            foreach (BarCodePrinting printing in listprinting)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        printing.LayoutPaper = LayoutConvert.Convert(printing);
                        CodePrinter codePrinter = new CodePrinter(new PrinterSet()
                        {
                            PrinterSettings = dataContext.Printer,
                            Landscape = dataContext.Landscape,
                            PaperSize = new PaperSize("Customs Paper Size", dataPaperSizeSetting.BarcodeSizeW, dataPaperSizeSetting.BarcodeSizeH),
                            BarCode = printing,
                            Horizontal = dataPaperSizeSetting.Horizo
                        });
                        codePrinter.CodePrinter_EndPrint += CodePrinter_CodePrinter_EndPrint;
                        codePrinter.Print();

                        autoReset.WaitOne();
                        worker.ReportProgress(Convert.ToInt32(((double)i / max) * 100));

                        printing.Per = 100;
                        printing.Success = true;

                        Thread.Sleep(500);
                        i++;
                    }
                    catch { }
                }
            }
        }

        private void CodePrinter_CodePrinter_EndPrint(object sender, PrintEventArgs e)
        {
            autoReset?.Set();
        }

        private void Bg_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            dataContext.Percent = int.Parse(e.ProgressPercentage.ToString());
        }

        private void Bg_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataListPrinting dataContext = DataContext as DataListPrinting;
            if (e.Cancelled == true)
            {

            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {

            }
            ButtonCloseProgressBar.Visibility = Visibility.Hidden;
            dataContext.Percent = 0;
            dataContext.IsEnableAll = true;
        }

        private void ButtonCloseProgressBar_Click(object sender, RoutedEventArgs e)
        {
            if (bg_worker.WorkerSupportsCancellation)
            {
                bg_worker.CancelAsync();
                autoReset?.Set();
            }
        }

    }
}