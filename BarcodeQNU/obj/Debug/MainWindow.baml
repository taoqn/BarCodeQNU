   M S B A M L   `   `   `  ����E  ABarcodeQNU, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BarcodeQNU.DataBarcodeQNU.Data  5   	   ;"clr-namespace:BarcodeQNU.ComponentBarcodeQNU.Component  5
   	   A%clr-namespace:BarcodeQNU.ChildControlBarcodeQNU.ChildControl  5   	   3clr-namespace:BarcodeQNU.ModelBarcodeQNU.Model  5   	   3clr-namespace:BarcodeQNU.ToolsBarcodeQNU.Tools  5   	   d `Syncfusion.SfBarcode.WPF, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89{Sclr-namespace:Syncfusion.UI.Xaml.Controls.Barcode;assembly=Syncfusion.SfBarcode.WPF#Syncfusion.UI.Xaml.Controls.Barcode 5   	       BarcodeQNU.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null:Mahapps,http://metro.mahapps.com/winfx/xaml/controls  5   	   a ]Syncfusion.SfGrid.WPF, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a	 ]Syncfusion.Shared.Wpf, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c896
syncfusion!http://schemas.syncfusion.com/wpf   	 5   	   0formdataclr-namespace:BarcodeQNU.Data   	 5   	   <ComponentCustom"clr-namespace:BarcodeQNU.Component   	 5
   	   <ChildControl%clr-namespace:BarcodeQNU.ChildControl   	 5   	   S
 OMahApps.Metro.IconPacks, Version=2.2.0.12, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks 
 5   	   *Modelclr-namespace:BarcodeQNU.Model 
 5   	   *Toolsclr-namespace:BarcodeQNU.Tools 
 5   	   aBarcodeSclr-namespace:Syncfusion.UI.Xaml.Controls.Barcode;assembly=Syncfusion.SfBarcode.WPF 
 5   	   -   5        + 	 %Syncfusion.Windows.Shared.SkinStorage    VisualStyle$  
Office2013��5   	    � Title$ QNU_BARCODE��5   	   $	��596��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � Icon$ Icon\logo.ico��6.    � DataContext 5      &    BarcodeQNU.Data.DataListPrinting  5   
    � 	Resources 5      '  !BarcodeQNU.Tools.PrinterConverter   ConvertPrinter  RibbonButtonStyle �� 
TargetType4  .Syncfusion.Windows.Tools.Controls.RibbonButton �� Property �� Value3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl  TextBlockStyle  RibbonButtonLabelStyle��%�  &	        &	      '  �     &	 �    &	 F      5   
   6!   �� 5   
   "  6*   .�5      ��  � ��$ 2,10,2,0q�6'   �� 5       �@ SizeForm$ Large=�6)   �� 5       �@ IconType$
 Icon=�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   "  6   .�5      ��  � �� �	#FF2B579A6,   �� 5       � �� �	#FF2B579A6+   �� 5        � ��$
 Bold"�6+   �� 5!       � ��$ 14(�6)   �� 5"       � ��
 �����6+   5#      �� 5$   
   " ��6'   .�5%      ��  � ��$ 20,2,0,0q�6'   �� 5&       � ��
 �����6+   5'      �� 5(   
   "  6/   .�5)      ��  � ��$ 0,20,0,5q�6'   5*      5+      4  .Syncfusion.Windows.Tools.Controls.RibbonWindow	   	StatusBar	 5-      7  1Syncfusion.Windows.Tools.Controls.RibbonStatusBar  5.   
   .@�5/      � ���	#FF2B579A
 � ColumnDefinitions
 50      �� 51      $��* �6'   �� 52      $��* �6'   �� 53      $��* �6'   .+�55      �� $��0��6    �� Orientation$ 
Horizontal=�6-   $	��Top=�6F   .+�56      �� #��[ 6    $��Chọn tất cả :��6H   �� 57      -   5        $��checkll��57      {�.  $��20,3,0,0q�6a   $��Center=�6s   $��Center=�6�    d� 	IsChecked 6.   �� *
CheckedAll+6�   58      �� 59      $��1��6   $ 
Horizontal=�6-   $	��Top=�6F   .+�5:      �� #��[ 6    $��Số lượng :��6H   �� 5;      #��[ 6    ��6H   �� *ListPrintingCount+5<      �� 5=      $��2��6   $ 
Horizontal=�6-   $	��Top=�6F   .+�5>      �� #��[ 6    $��Quá trình xử lý :��6H   � 5?      $��20,3,0,0q�6"   $	��150��6N   $��12��6Z    ! ProgressBarStyleStopAnimation#��[ 6f    � Value 64   �� *	Percent+6f   �� 5@      -   5        $��ButtonCloseProgressBar��5@      $��Dừng��6;   $��10,0,0,0q�6J   $y�Hidden=�6�   
�������
���  ��
���  ��$
��Bold"�6�   5A      5B      5C      .��5F      � -   5        $��Window_Main��5F      {�6   �� *IsEnableAll+.+�5G   
   � -   5        $��Container_Main��5G       � RowDefinitions 5H      �� 5I      $
��Auto �6    �� 5J      $��* �6    �� 5K      $
��Auto �6    .+�5N      .  (Syncfusion.Windows.Tools.Controls.Ribbon  -   5        $��m_ribbon��5N   -   $��0��6    $	��Top=�6=   .@�5O      1	  +Syncfusion.Windows.Tools.Controls.RibbonTab	   	  Caption$ CHÍNH��6'    	  	IsChecked . .@�5P      1
  +Syncfusion.Windows.Tools.Controls.RibbonBar
   
  Header$ 	Thao Tác��6+   .@�5T        -   5        #��[ 5T   2      Label$ Thêm��6]      	LargeIcon$ Icon/add-icon.png��6j   6�     5U      -   5        #��[ 5U   2   $ 
Danh Sách��6]   $ Icon/add-database.png��6o   6�     5V      -	   5        #��[ 5V   2   $
 Xóa��6]   $ Icon/delete-icon.png��6i   6�   5W      
  5X      $ Giá Trị Cho Danh Sách��6+   .@�5Y        -
   5        $ Số lượng��5Y   [   #��[ 6l      	SmallIcon$ Icon/sort_up_down2.png��6�   5  /Syncfusion.Windows.Tools.Controls.RibbonTextBox  5Z      -   5        $��RibbonTexTBox_Count��5Z   3   $��70��6N   $��2q�6Y   $��Center=�6d     5\      -   5        $ Loại BarCode��5\   Z   #��[ 6o   $ Icon/Barcode-icon.png��6�   6  0Syncfusion.Windows.Tools.Controls.RibbonComboBox  5]      -   5        $ ��RibbonComboBox_TypeBarCode��5]   4   $	��100��6�   $��2q�6�   $��Center=�6�   ��6V   ��   BarcodeSymbolTypeFromEnum �� Source# [ 6�   5_      
  5`      $ Cài Đặt Máy In��6+   .@�5b        $ 	Máy in: ��62   #��[ 6C   $  Icon/select-print-icon.png��6s     5c      -   5        $	��200��5c   a   $��2q�6m   $��Stretch=�6�   $��Center=�6   �� IsDropDownOpen .   �� 
IsReadOnly .   �� 
IsEditable .  $��Center=�6]  ��6x   �� *ListPrinter+ �� SelectedItem 6�   �� *	Printer+ �� 	Converter# [  6]  5n      
  5o      $  ��6+   .@�5q        -   5        #��[ 5q   S   $ In��6~   $ Icon/Laser_Printer.ico��6�   5r      5w      5�      � 5�      $��1��6   .+�5�      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ DataGrid��5�         SelectionUnit$	 Row=�6'   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   NavigationMode$
 Cell=�6;      SelectionMode$ Single=�6Q      AutoGenerateColumns .      ColumnSizer$
  Star=�5�   :   !   	RowHeight$! 80Q�6M   "   
SourceType&    BarcodeQNU.Model.BarCodePrinting""  5�   L   #   SelectedItem# 5�   1   �� *
Printing+$   ItemsSource$ 5�      �� *ListPrinting+%   Columns% 5�      0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  (  "Syncfusion.UI.Xaml.Grid.GridColumn&   AllowFiltering& .  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase'   AllowSorting' .  (   AllowEditing( .  )   TextAlignment$) Center=�6y   *   Width$* 50Q�6�   +   HorizontalAlignment$+ Center=�6�   ,   HeaderTemplate, 5�      �� 5�   "   .R�5�   &   �� -   5         5�   /   �� *	IsChecked+- �� ElementName$- checkll��6   5�   #   .   CellTemplate. 5�      �� 5�   "   .R�5�   &   �� -   5        $��Center=�5�   �   $��Center=�6�    6/   �� *
Selected+6�   5�   #   5�      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  5�      /   
HeaderText$	/ STT��64   0   MappingName$	0 STT��6E   $) Center=�6W   $* 50Q�6n     5�      $	/ MÃ��64   $
0 Code��6D   $) Center=�6W   0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase1   TextWrapping$
1 Wrap=�6n   2   	CellStyle2 5�      �� 5�   "   &   Syncfusion.UI.Xaml.Grid.GridCell"  6(   .�5�   &   ��  � ��
 ��  �6C   �� 5�   &    � ��
 �����6C   �� 5�   &    � ��$ 14(�6A   �� 5�   &    � ��$
 Bold"�6C   �� 5�   &    � ��$ Courier New)�6C   5�   #   5�        5�      $/ BARCODE��68   $
0 Code��6M   . 5�      �� 5�   "   .R�5�   &   �� $	��150��61   $��60��6=   .+�5�   *   3  -Syncfusion.UI.Xaml.Controls.Barcode.SfBarcode  3   DisplayText3 .  $��5q�6�   $��5q�6�   4   Text4 6<   �� 5 �� Path$
5 Code�6   	Symbology6 6W   �� $5 TypeBarCode�6�   5�   '   5�   #   5�        5�      $/ LOẠI��68   $0 TypeBarCode��6J   . 5�      �� 5�   "   .R�5�   &   �� $��30��6/   ��6;   �� # [  6�   �� $5 TypeBarCode�5�   #   5�        5�      $/ SỐ LƯỢNG��68   $0 Count��6N   . 5�      �� 5�   "   .R�5�   &   *  $MahApps.Metro.Controls.NumericUpDown  $	��100��6<   $��30��6H     NumericUpDown#��[ 6T   7   Minimum$7 1Q�6{   8   Maximum$8 50Q�6�   9   Interval$9 1Q�6�   :   Value: 6�   �� $5 Count�5�   #   5�        5�      $/ TRẠNG THÁI��68   $	0 Per��6P   . 5�      �� 5�   "   .R�5�   &   �� $��Center=�61   $��Center=�6L   .+�5�   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5�   .   �� $��Center=�64   $��Center=�6O   ��6l   �� *Per+�� 5�   .   $��Center=�64   $��Center=�6O   $��%��6l   5�   +   � 5�   *   $	��150��6L   $��15��6X   #��[ 6d    66   �� *Per+6d   5�   '   5�   #   5�        5�      $/  ��68   $0 Count��6F   $	* 100Q�6Z   . 5�      �� 5�   "   .R�5�   &   �� -   5        $��30��5�   -   $��30��68   
���  ��
���  ��
�������$
��Bold"�6�   $
��Xóa��6�   5�   #   5�      5�      5�      5�      &    BarcodeQNU.Component.ModalDialog  5�   
   -   5        ;  Name$; ModalDialog_DeleteBarcode��5�   &   &    BarcodeQNU.Component.ModalDialog<   OKModal$'< !ModalDialog_DeleteBarcode_OKModal��6�   =   ShowButtonFooter$= HiddenClose=�6I   >   
Context_OK$
> Xóa��6h   ?   Context_Cancel$? Không��6y   @   
HeaderText$ @ Xóa danh sách mã này ?��6�   6�     5�   
   -   5        $%; ModalDialog_DeleteBarcode_Index��5�   &   $-< 'ModalDialog_DeleteBarcode_Index_OKModal��6�   $= HiddenClose=�6O   $
> Xóa��6n   $? Không��6   $@ Xóa mã này ?��6�   6�     5�   
   -   5        $; ModalDialog_PrintBarcode��5�   &   $&<  ModalDialog_PrintBarcode_OKModal��6�   $= HiddenClose=�6H   $> 
Đồng ý��6g   $? Không��6{   $@ In danh sách mã ?��6�   6�     5�   
   -   5        $; ModalDialog_AddBarcode��5�   &   $$< ModalDialog_AddBarcode_OKModal��6�   $> Thêm��6F   $? Thoát��6X   $@ 	Thêm Mã��6o   A   Children.A 5�      0   *BarcodeQNU.ChildControl.AddPrintingBarcode  $	��800��6.   $	��290��6:   5�        5�   
   -   5        $ ; ModalDialog_AddListBarcode��5�   &   $(< "ModalDialog_AddListBarcode_OKModal��6�   $> Thêm��6J   $? Thoát��6\   $@ Thêm Danh Sách��6s   .A 5�      4   .BarcodeQNU.ChildControl.AddListPrintingBarcode  $	��300��62   $	��300��6>   5�        5�   
   -   5        $; ModalDialog_PaperSetting��5�   &   $&<  ModalDialog_PaperSetting_OKModal��6�   B   
CloseModal$)B #ModalDialog_PaperSetting_CloseModal��6�   C   ExitAllModal$+C %ModalDialog_PaperSetting_ExitAllModal��6�   $
> Lưu��6H   $? Thoát��6Y   $@ Cài Đặt Trang In��6p   .A 5�      3   -BarcodeQNU.ChildControl.SettingLayoutPrinting  $	��900��61   $	��350��6=   5�      5�      5�      