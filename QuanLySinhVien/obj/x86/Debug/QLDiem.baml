   M S B A M L   `   `   `  ����  QuanLySinhVien    QuanLySinhVien.QLDiem   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Quản Lý Bảng Điểm��5   	   $
��Bold"�6$   $��Times New Roman)�66   $	��650��6f   $	��550��6r   .��5      � ��5   
   �� 5      .��5      �  � Color$ Beige��6    � Offset$	 0.0Q�6-   � 5	      $
 Blue��6   $	 1.0Q�6,   5
      .+�5   
   �� -   5        $��label1��5   g   $��Nhập Mã Sinh Viên :��6   $��26��6.   $
��Left=�6:   $��60,5,0,0q�6U   $	��Top=�6u   $��Times New Roman)�6�   $��14(�6�   �� 5   
   -   5        $��txtMasv��5   L   $��26��6   $��Center=�6   $��0,5,0,0q�6;   $	��Top=�6[   $	��200��6s   {�. 6   �� 5   
   -   5        $��btSearch��5   _   $��Tìm kiếm��6   $��26��6$   $��Right=�60   $��	0,5,100,0q�6L   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $��label2��5   _   $��BẢNG ĐIỂM��6   $��28��6$   $��Center=�60   $��0,38,0,0q�6M   $	��Top=�6m   $��Times New Roman)�6�   $
��Bold"�6�   $��18(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dataGrid1��5   m      AutoGenerateColumns .  $	��413��6/   $��Center=�6<   $��
12,67,12,0q�6Y   $	��Top=�6~   $	��556��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Sinh Viên��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *maSV+  5      $ Mã Môn Học��6%   $	 200 69    6E   �� *maMon+  5      $ Điểm lần 1��6%   $ 80 69    6D   �� *
diemLan1+  5      $ Điểm lần 2��6%   $ 80 69    6D   �� *
diemLan2+5      5      5      