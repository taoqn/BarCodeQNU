   M S B A M L   `   `   `  ���� E  ABarcodeQNU, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BarcodeQNU.DataBarcodeQNU.Data  3    -BarcodeQNU.ChildControl.SettingLayoutPrinting   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null:Mahapps,http://metro.mahapps.com/winfx/xaml/controls  ,formdataclr-namespace:BarcodeQNU.Data    � DataContext  *   $BarcodeQNU.Data.DataPaperSizeSetting   � 	Resources  �� 
TargetType   stack_control �� Property �� Value  grid_control  label_title_control��%�   &	        &	 "     &	 E     �� " ��.���  � ��$ 5q��� " �.���  � ��$ 10q��� " ��.���  � ��$
 Left=���  � ��$
 Bold"�.���  � ColumnDefinitions �� $	��500 ��� $��* � � RowDefinitions �� $��* �.+�� $��0��$��10q�.+��� 
�������
�������$��1q� �� CornerRadius$ 8��._�� -   $��	gird_view��$��Center=�$��Center=����� *
PaperSizeW+���� *
PaperSizeH+.+��� 
�������
�������$��1q�$ 8��._��� 
�������
���  ��$��1q����� *BarcodeSizeW+���� *BarcodeSizeH+._��� -   $��img_view��$��Stretch=����� *BarcodeSizeW+���� *BarcodeSizeH+���� *Horizo.Value+��  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��Width : ��$
��Bold"��� ���� *
PaperSizeW+�� $��|��$
��Bold"��� $��	Height : ��$
��Bold"��� ���� *
PaperSizeH+�� $��|��$
��Bold"��� $��Barcode W : ��$
��Bold"��� ���� *BarcodeSizeW+�� $��|��$
��Bold"��� $��Barcode H : ��$
��Bold"��� ���� *BarcodeSizeH+� $��1��$��10q�.+��� 
�������
�������$��1q�$ 8��._��  �� $��* ��� $��* ��� $��* ��� $��* �.+�� $��0��#��[  �� $��* ��� $��* � �� $��* ��� $��* �.+�� $��2��$��0��.+��� $!��Kích thước khổ giấy��#��[ $��Center=�$��Center=�� $��0��$��1��$��0,0,5,0q� �� $��* ��� $
��2.5* �.+��� $��Ngang��$��0��#��[ $��Center=�*  $MahApps.Metro.Controls.NumericUpDown  $��1��  NumericUpDown#��[ 	   Minimum$	 10Q�
   Interval$
 1Q�   Value �� *
PaperSizeW+� $��1��$��1��$��5,0,0,0q� �� $��* ��� $
��2.5* �.+��� $��Dọc��$��0��#��[ $��Center=�  $��1��#��[ $	 10Q�$
 1Q� �� *
PaperSizeH+� $��1��#��[  �� $��* ��� $��* � �� $��* ��� $��* �.+�� $��2��$��0��.+��� $��Kích thước Barcode��#��[ $��Center=�$��Center=�� $��0��$��1��$��0,0,5,0q� �� $��* ��� $
��2.5* �.+��� $��Ngang��$��0��#��[ $��Center=�  $��1��#��[ $	 10Q�$
 1Q� �� *BarcodeSizeW+� $��1��$��1��$��5,0,0,0q� �� $��* ��� $
��2.5* �.+��� $��Dọc��$��0��#��[ $��Center=�  $��1��#��[ $	 10Q�$
 1Q� �� *BarcodeSizeH+� $��2��#��[  �� $��* ��� $��* �.+�� $��0��.+��� $��Căn chỉnh��#��[ $��Center=�$��Center=��� $��1�� �� DisplayMemberPath$
 Name������ *	Horizos+ �� SelectedItem �� *Horizo+