   M S B A M L   `   `   `  ���� W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FSBaseStation.ViewsFSBaseStation.Views  %    FSBaseStation.Views.ConnectView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:FSBaseStation.Views     
�������  J� InputBindings  �� 
 �� Key$ Return�� �� Command �� *SerialPortConnectCommand+ �� CommandParameter ��  �� ElementName$ serialPorts�� �� Path$ SelectedItem�.���  � ColumnDefinitions �� $��0.85* �$
��1000���� $��* � � RowDefinitions �� $��* �$	��130���� $
��0.7* �$��50���� $
��0.7* �$��80���� $��2* �.+��� $��0��$��4��$��0��
���iii�$��2��$��10q� �� RadiusX$ 10��	 �� RadiusY$	 10���� -   
 ��Name$
 serialPorts��$��0��$��1��
�������$��	25,0,25,5q����� *AvailablePorts+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��0��$��0��$��18(�$��Center=�$��Center=����� *Info+$ OneWay=��� $��2��$��0��$��	25,5,25,5q�
����������� *SerialPortConnectCommand+���� $ serialPorts��$ SelectedItem����� *ConnectionButtonConntent+