   M S B A M L   `   `   `  ����W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FSBaseStation.ViewsFSBaseStation.Views  5      %    FSBaseStation.Views.ConnectView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:FSBaseStation.Views     5      
�������  J� InputBindings  5	      �� 5
   
   
 �� Key$ Return��6    �� Command 6"   �� *SerialPortConnectCommand+ �� CommandParameter 6O   ��  �� ElementName$ serialPorts�� �� Path$ SelectedItem�.��5      �  � ColumnDefinitions 5   
   �� 5      $��0.85* �6   $
��1000��6-   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   $	��130��6'   �� 5      $
��0.7* �6   $��50��6*   �� 5      $
��0.7* �6   $��80��6*   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��4��6!   $��0��62   
���iii�$��2��6S   $��10q�6g    �� RadiusX$ 10��6s   	 �� RadiusY$	 10��6�   �� 5   
   -   5        
 ��Name$
 serialPorts��5      $��0��6�   $��1��6�   
�������$��	25,0,25,5q�6�   ��6)   �� *AvailablePorts+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��0��6   $��0��6!   $��18(�6T   $��Center=�6b   $��Center=�6}   ��61   �� *Info+$ OneWay=�6}   �� 5   
   $��2��6   $��0��6   $��	25,5,25,5q�6/   
���������6Y   �� *SerialPortConnectCommand+��6�   �� $ serialPorts��$ SelectedItem���6�   �� *ConnectionButtonConntent+5      5      