   M S B A M L   `   `   `  ���� E  ABarcodeQNU, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BarcodeQNU.DataBarcodeQNU.Data  ;"clr-namespace:BarcodeQNU.ComponentBarcodeQNU.Component  A%clr-namespace:BarcodeQNU.ChildControlBarcodeQNU.ChildControl  3clr-namespace:BarcodeQNU.ModelBarcodeQNU.Model  3clr-namespace:BarcodeQNU.ToolsBarcodeQNU.Tools  d `Syncfusion.SfBarcode.WPF, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89{Sclr-namespace:Syncfusion.UI.Xaml.Controls.Barcode;assembly=Syncfusion.SfBarcode.WPF#Syncfusion.UI.Xaml.Controls.Barcode     BarcodeQNU.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null:Mahapps,http://metro.mahapps.com/winfx/xaml/controls  a ]Syncfusion.SfGrid.WPF, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a	 ]Syncfusion.Shared.Wpf, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c896
syncfusion!http://schemas.syncfusion.com/wpf   	 0formdataclr-namespace:BarcodeQNU.Data   	 <ComponentCustom"clr-namespace:BarcodeQNU.Component   	 <ChildControl%clr-namespace:BarcodeQNU.ChildControl   	 S
 OMahApps.Metro.IconPacks, Version=2.2.0.12, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks 
 *Modelclr-namespace:BarcodeQNU.Model 
 *Toolsclr-namespace:BarcodeQNU.Tools 
 aBarcodeSclr-namespace:Syncfusion.UI.Xaml.Controls.Barcode;assembly=Syncfusion.SfBarcode.WPF 
 -   + 	 %Syncfusion.Windows.Shared.SkinStorage    VisualStyle$  
Office2013�� � Title$ QNU_BARCODE��$	��596��$
��1000�� � WindowStartupLocation$ CenterScreen=� � Icon$ Icon\logo.ico�� � DataContext &    BarcodeQNU.Data.DataListPrinting   � 	Resources '  !BarcodeQNU.Tools.PrinterConverter   ConvertPrinter  RibbonButtonStyle �� 
TargetType4  .Syncfusion.Windows.Tools.Controls.RibbonButton �� Property �� Value3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl  TextBlockStyle  RibbonButtonLabelStyle��%�  &	        &	      '  �     &	     &	 Y      �� "  .���  � ��$ 2,10,2,0q���  �@ SizeForm$ Large=���  �@ IconType$
 Icon=���  � ��$
 Bold"��� "  .���  � �� �	#FF2B579A��  � �� �	#FF2B579A��  � ��$
 Bold"���  � ��$ 14(���  � ��
 ������� " ��.���  � ��$ 20,2,0,0q���  � ��
 ������� "  .���  � ��$ 0,20,0,5q�4  .Syncfusion.Windows.Tools.Controls.RibbonWindow	   	StatusBar	 7  1Syncfusion.Windows.Tools.Controls.RibbonStatusBar  .@�� ���	#FF2B579A
 � ColumnDefinitions
 �� $��* ��� $��* ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�$	��Top=�.+��� #��[ $��Chọn tất cả :���� -   $��checkll��{�.  $��20,3,0,0q�$��Center=�$��Center=� d� 	IsChecked �� *
CheckedAll+�� $��1��$ 
Horizontal=�$	��Top=�.+��� #��[ $��Số lượng :���� #��[ ���� *ListPrintingCount+�� $��2��$ 
Horizontal=�$	��Top=�.+��� #��[ $��Quá trình xử lý :��� $��20,3,0,0q�$	��150��$��12�� ! ProgressBarStyleStopAnimation#��[  � Value �� *	Percent+�� -   $��ButtonCloseProgressBar��$��Dừng��$��10,0,0,0q�$y�Hidden=�
�������
���  ��
���  ��$
��Bold"�.��� -   $��Window_Main��{��� *IsEnableAll+.+�� -   $��Container_Main�� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+�.  (Syncfusion.Windows.Tools.Controls.Ribbon  -   $��m_ribbon��$��0��$	��Top=�.@�1	  +Syncfusion.Windows.Tools.Controls.RibbonTab	   	  Caption$ CHÍNH�� 	  	IsChecked . .@�1
  +Syncfusion.Windows.Tools.Controls.RibbonBar
   
  Header$ 	Thao Tác��.@�  -   #��[    Label$ Thêm��   	LargeIcon$ Icon/add-icon.png��  -   #��[ $ 
Danh Sách��$ Icon/add-database.png��  -	   #��[ $
 Xóa��$ Icon/delete-icon.png��
  $ Giá Trị Cho Danh Sách��.@�  -
   $ Số lượng��#��[    	SmallIcon$ Icon/sort_up_down2.png��5  /Syncfusion.Windows.Tools.Controls.RibbonTextBox  -   $��RibbonTexTBox_Count��$��70��$��2q�$��Center=�  -   $ Loại BarCode��#��[ $ Icon/Barcode-icon.png��6  0Syncfusion.Windows.Tools.Controls.RibbonComboBox  -   $ ��RibbonComboBox_TypeBarCode��$	��100��$��2q�$��Center=�����   BarcodeSymbolTypeFromEnum �� Source# [ 
  $ Cài Đặt Máy In��.@�  $ 	Máy in: ��#��[ $  Icon/select-print-icon.png��  -   $	��200��$��2q�$��Stretch=�$��Center=� �� IsDropDownOpen .   �� 
IsReadOnly .   �� 
IsEditable .  $��Center=����� *ListPrinter+ �� SelectedItem �� *	Printer+ �� 	Converter# [  
  $  ��.@�  -   #��[ $ In��$ Icon/Laser_Printer.ico��� $��1��.+�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -     Name$ DataGrid��   SelectionUnit$	 Row=�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   NavigationMode$
 Cell=�   SelectionMode$ Single=�   AutoGenerateColumns .      ColumnSizer$
  Star=�!   	RowHeight$! 80Q�"   
SourceType&    BarcodeQNU.Model.BarCodePrinting""  #   SelectedItem# �� *
Printing+$   ItemsSource$ �� *ListPrinting+%   Columns% 0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  (  "Syncfusion.UI.Xaml.Grid.GridColumn&   AllowFiltering& .  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase'   AllowSorting' .  (   AllowEditing( .  )   TextAlignment$) Center=�*   Width$* 50Q�+   HorizontalAlignment$+ Center=�,   HeaderTemplate, �� .R��� -    �� *	IsChecked+- �� ElementName$- checkll��.   CellTemplate. �� .R��� -   $��Center=�$��Center=� �� *
Selected+,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  /   
HeaderText$	/ STT��0   MappingName$	0 STT��$) Center=�$* 50Q�  $	/ MÃ��$
0 Code��$) Center=�0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase1   TextWrapping$
1 Wrap=�2   	CellStyle2 �� &   Syncfusion.UI.Xaml.Grid.GridCell"  .���  � ��
 ��  ���  � ��
 �������  � ��$ 14(���  � ��$
 Bold"���  � ��$ Courier New)�  $/ BARCODE��$
0 Code��. �� .R��� $	��150��$��60��.+�3  -Syncfusion.UI.Xaml.Controls.Barcode.SfBarcode  3   DisplayText3 .  $��5q�$��5q�4   Text4 �� 5 �� Path$
5 Code�6   	Symbology6 �� $5 TypeBarCode�  $/ LOẠI��$0 TypeBarCode��. �� .R��� $��30������ # [  �� $5 TypeBarCode�  $/ SỐ LƯỢNG��$0 Count��. �� .R�*  $MahApps.Metro.Controls.NumericUpDown  $	��100��$��30��  NumericUpDown#��[ 7   Minimum$7 1Q�8   Maximum$8 50Q�9   Interval$9 1Q�:   Value: �� $5 Count�  $/ TRẠNG THÁI��$	0 Per��. �� .R��� $��Center=�$��Center=�.+��� $ 
Horizontal=�$��Center=�.+��� $��Center=�$��Center=����� *Per+�� $��Center=�$��Center=�$��%��� $	��150��$��15��#��[  �� *Per+  $/  ��$0 Count��$	* 100Q�. �� .R��� -   $��30��$��30��
���  ��
���  ��
�������$
��Bold"�$
��Xóa��&    BarcodeQNU.Component.ModalDialog  -   ;  Name$; ModalDialog_DeleteBarcode��&    BarcodeQNU.Component.ModalDialog<   OKModal$'< !ModalDialog_DeleteBarcode_OKModal��=   ShowButtonFooter$= HiddenClose=�>   
Context_OK$
> Xóa��?   Context_Cancel$? Không��@   
HeaderText$ @ Xóa danh sách mã này ?��  -   $%; ModalDialog_DeleteBarcode_Index��$-< 'ModalDialog_DeleteBarcode_Index_OKModal��$= HiddenClose=�$
> Xóa��$? Không��$@ Xóa mã này ?��  -   $; ModalDialog_PrintBarcode��$&<  ModalDialog_PrintBarcode_OKModal��$= HiddenClose=�$> 
Đồng ý��$? Không��$@ In danh sách mã ?��  -   $; ModalDialog_AddBarcode��$$< ModalDialog_AddBarcode_OKModal��$> Thêm��$? Thoát��$@ 	Thêm Mã��A   Children.A 0   *BarcodeQNU.ChildControl.AddPrintingBarcode  $	��800��$	��290��  -   $ ; ModalDialog_AddListBarcode��$(< "ModalDialog_AddListBarcode_OKModal��$> Thêm��$? Thoát��$@ Thêm Danh Sách��.A 4   .BarcodeQNU.ChildControl.AddListPrintingBarcode  $	��300��$	��300��  -   $; ModalDialog_PaperSetting��$&<  ModalDialog_PaperSetting_OKModal��B   
CloseModal$)B #ModalDialog_PaperSetting_CloseModal��C   ExitAllModal$+C %ModalDialog_PaperSetting_ExitAllModal��$
> Lưu��$? Thoát��$@ Cài Đặt Trang In��.A 3   -BarcodeQNU.ChildControl.SettingLayoutPrinting  $	��900��$	��350��