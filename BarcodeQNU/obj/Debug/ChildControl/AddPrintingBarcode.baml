   M S B A M L   `   `   `  ����E  ABarcodeQNU, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BarcodeQNU.DataBarcodeQNU.Data  5      d `Syncfusion.SfBarcode.WPF, Version=15.4460.0.20, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89{Sclr-namespace:Syncfusion.UI.Xaml.Controls.Barcode;assembly=Syncfusion.SfBarcode.WPF#Syncfusion.UI.Xaml.Controls.Barcode 5      0    *BarcodeQNU.ChildControl.AddPrintingBarcode   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null:Mahapps,http://metro.mahapps.com/winfx/xaml/controls  5      ,formdataclr-namespace:BarcodeQNU.Data  5      aBarcodeSclr-namespace:Syncfusion.UI.Xaml.Controls.Barcode;assembly=Syncfusion.SfBarcode.WPF  5        � DataContext  5      "  BarcodeQNU.Data.DataPrinting  5   
    � 	Resources 5
       �� 
TargetType   stack_control �� Property �� Value  label_title_control��%�   &	        &	 s     �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   �� 5       � ��$ 0,5,0,0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$
 Left=�64   �� 5       � ��$
 Bold"�6+   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��500 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   $��10q�6   .+�5      �� 
�������
�������$��1q�6B    �� CornerRadius$ 8��6V   ._�5      3  -Syncfusion.UI.Xaml.Controls.Barcode.SfBarcode  $	��250��6$   $	��250��60      Text 6=   �� *Printing.Code+	   	Symbology	 6\   �� *Printing.TypeBarCode+5      5       � 5!   
   $��1��6   $��10q�6   .+�5"      �� 
�������
�������$��1q�6B   $ 8��6V   ._�5#      �� $��10,20,10,20q�6   $
��Left=�62   .+�5$      �� #��[  6!   .+�5%      �� $��Nhập mã :��6    #��[ 64   �� 5&      $	��210��6A   *  $MahApps.Metro.Controls.TextBoxHelper
   ClearTextButton
 . ��6"   �� *Printing.Code+6M   5'      �� 5(      #��[  6!   .+�5)      �� $��Số lượng :��6    #��[ 65   *  $MahApps.Metro.Controls.NumericUpDown  5*        NumericUpDown#��[ 6Q      Minimum$ 1Q�6x      Maximum$ 50Q�6�      Interval$ 1Q�6�      Value 60   �� *Printing.Count+6�   5+      �� 5,      #��[  6!   .+�5-      �� $��Chọn loại Barcode :��6    #��[ 6>   �� 5.      $	��210��6m   ��6#   ��   BarcodeSymbolTypeFromEnum �� Source# [  �� SelectedItem 6y   �� *Printing.TypeBarCode+5/      �� 50      #��[  6!   .+�51      �� $��Layout :��6    #��[ 63   �� 52      ��6    �� *Printing.TypeBarCode+53      54      55      56      57      58      