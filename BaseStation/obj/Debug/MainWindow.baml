   M S B A M L   `   `   `  ����N  JSideMenuListControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:SideMenuListControl.Custom_Controls#SideMenuListControl.Custom_Controls  5   	   $    SideMenuListControl.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:SideMenuListControl.Custom_Controls     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��185 �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��75 �6   �� 5      $��75 �6   �� 5      $��* �6   .+�5   
   9   3SideMenuListControl.Custom_Controls.SideMenuControl  -   5          Name$ MenuList��5       9   3SideMenuListControl.Custom_Controls.SideMenuControl   SelectionChanged$&  SideMenuControl_SelectionChanged��6c   $��3��62   $��20(�6C      SelectedIndex$ 0��6Q   6c    � 5   
   -   5          �Name$ frame��5      $��1��6   $��Stretch=�6/   $��Stretch=�6M     � NavigationUIVisibility$ Hidden=�6i   $��2��6�   $��0��6�   $��3��6�   �� 5   
   -   5        $��availablePorts��5      $��1��6*   $��1��6:   $��15q�6G   �� 5   
   -   5        $��connectbutton��5      $��Connect��6'   $��2��6:   $��1��6J   $��15q�6W   6c   �� 5   
   -   5        $��received��5      $��1��6#   $��2��63   $��3��6G   $��15q�6T   �� 5   
   -   5        $��title��5      $��1��6"   $��2��62   $��
Connection��6F   
���iii�$��	UltraBold"�6m   $��50(�6�   5      5      