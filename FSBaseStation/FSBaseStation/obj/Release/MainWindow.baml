   M S B A M L   `   `   `  ���� W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FSBaseStationFSBaseStation  C&clr-namespace:FSBaseStation.ViewModelsFSBaseStation.ViewModels  9!clr-namespace:FSBaseStation.ViewsFSBaseStation.Views      FSBaseStation.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:FSBaseStation     =
viewmodels&clr-namespace:FSBaseStation.ViewModels     3views!clr-namespace:FSBaseStation.Views       � Title$"  Formula Student Base Station��$	��550��$	��550��$	��900��$	��900��
���iii� � WindowStyle$
 None=� � AllowsTransparency . '  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 35Q� � 	Resources  �� DataType/   )FSBaseStation.ViewModels.ConnectViewModel%   FSBaseStation.Views.ConnectView � DataContext1   +FSBaseStation.ViewModels.DashboardViewModel'   !FSBaseStation.Views.DashboardView/   )FSBaseStation.ViewModels.KistlerViewModel%   FSBaseStation.Views.KistlerView+   %FSBaseStation.ViewModels.ECUViewModel!	   FSBaseStation.Views.ECUView5
   /FSBaseStation.ViewModels.RightInverterViewModel+   %FSBaseStation.Views.RightInverterView4   .FSBaseStation.ViewModels.LeftInverterViewModel*   $FSBaseStation.Views.LeftInverterView3   -FSBaseStation.ViewModels.TemperatureViewModel)   #FSBaseStation.Views.TemperatureView0   *FSBaseStation.ViewModels.SettingsViewModel&    FSBaseStation.Views.SettingsView-   'FSBaseStation.ViewModels.AlertViewModel#   FSBaseStation.Views.AlertView��%g  (��       *, +)(�� 3     *, +)(�� h     *, +)(�� �     *, +)(�� �     *,
 +)(��     *, +)(�� ;    *, +)(�� r    *, +)(�� �    *, +)�� ConnectViewTemplate��"  .R�   �� �� DashboardViewTemplate��"  .R�   �� �� KistlerViewTemplate��"  .R�   �� �� ECUViewTemplate��"  .R�	   �� �� RightInverterViewTemplate��" 
 .R�   �� �� LeftInverterViewTemplate��"  .R�   �� �� TemperatureViewTemplate��"  .R�   �� �� SettingsViewTemplate��"  .R�   �� �� AlertViewTemplate��"  .R�   �� .���  � ColumnDefinitions �� $	��185 ��� $��* �	 � RowDefinitions	 �� $��35 ��� $
��0.2* �$	��110���� $��* ��� $��50 �.+�� $	��Top=�$��2��$��35�����	#FF4F4F4F.+��� $��FS Base Station��
   IsHitTestVisibleInChrome
 .  
�������$��DemiBold"�$��18(�$
��Left=�$��Center=�$��8,0,0,0q��� 
 . $��Center=�$��Right=� �� Orientation$ 
Horizontal=�$��35��.+��� -   $��MinimizeButton��   ControlButtons#��[  $��35��$��35��$��-��$
��Bold"�$��23(�
������ $��0q� � ToolTip$ Minimize���� -   $��MaximizeButton��#��[  $��35��$��35��$��+��$��DemiBold"�$��21(�
������ $��0q�$ Restore Down���� -   $��CloseButton��#��[  $��35��$��35��$��x��$��DemiBold"�$��18(�
������ $��0q�$ Close���� $��1��$��1��$
��Bold"�$��46(�$
��Left=�$��Center=�$��15,0,0,0q����� *WindowTitle+�� -    ��Name$ WindowContent��$��2��$��1��$��2������ *WindowContent+�� $��1��$��4��.+���   
sideButton#��[ $��45��
���iii�$��18(����� *DashboardViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *DashboardVisibility+�� $��3q�$��35��$��35��$��Images/Dashboard_64.png���� $��	Dashboard��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *ECUViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *ECUVisibility+�� $��3q�$��35��$��35��$"��Images/Steering_wheel_64.png���� $	��ECU��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *KistlerViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *KistlerVisibility+�� $��3q�$��35��$��35��$��Images/Car_64.png���� $��Kistler��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *RightInverterViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *RightInverterVisibility+�� $��3q�$��35��$��35��$��Images/motor_64.png���� $��Right Inverter��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *LeftInverterViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *LeftInverterVisibility+�� $��3q�$��35��$��35��$��Images/motor_64.png���� $��Left Inverter��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *TemperatureViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *TemperatureVisibility+�� $��3q�$��35��$��35��$��Images/Temperature_64.png���� $��Temperature��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *ConnectViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *ConnectVisibility+�� $��3q�$��35��$��35��$��Images/Connect_64.png���� $��Connect��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��
���iii�$��18(����� *SettingsViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��5��$��40��
���  ��$��0,0,4,0q�y��� *SettingsVisibility+�� $��3q�$��35��$��35��$��Images/Settings_64.png���� $��Settings��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"��� #��[ $��45��$��0��$��3��$��18(�$��Bottom=����� *AlertStatus+���� *AlertViewCommand+.���� $ 
Horizontal=�$	��185��.+��� $��40,0,0,0q�$��35��$��35������ *
AlertImage+�� $��Alerts��$��Center=�$��4,0,0,0q�$��20(�$��DemiBold"�