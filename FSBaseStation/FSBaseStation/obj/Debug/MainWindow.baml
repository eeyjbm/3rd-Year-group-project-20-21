   M S B A M L   `   `   `  ����W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FSBaseStationFSBaseStation  5   	   C&clr-namespace:FSBaseStation.ViewModelsFSBaseStation.ViewModels  5   	   9!clr-namespace:FSBaseStation.ViewsFSBaseStation.Views  5   	       FSBaseStation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:FSBaseStation     5   	   =
viewmodels&clr-namespace:FSBaseStation.ViewModels     5   	   3views!clr-namespace:FSBaseStation.Views     5   	     � Title$"  Formula Student Base Station��5
   	   $	��550��6.   $	��550��6>   $	��900��6K   $	��900��6Z   
���iii� � WindowStyle$
 None=�6{    � AllowsTransparency . '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 35Q�6    � 	Resources 5       �� DataType/   )FSBaseStation.ViewModels.ConnectViewModel%   FSBaseStation.Views.ConnectView � DataContext1   +FSBaseStation.ViewModels.DashboardViewModel'   !FSBaseStation.Views.DashboardView/   )FSBaseStation.ViewModels.KistlerViewModel%   FSBaseStation.Views.KistlerView+   %FSBaseStation.ViewModels.ECUViewModel!	   FSBaseStation.Views.ECUView5
   /FSBaseStation.ViewModels.RightInverterViewModel+   %FSBaseStation.Views.RightInverterView4   .FSBaseStation.ViewModels.LeftInverterViewModel*   $FSBaseStation.Views.LeftInverterView3   -FSBaseStation.ViewModels.TemperatureViewModel)   #FSBaseStation.Views.TemperatureView0   *FSBaseStation.ViewModels.SettingsViewModel&    FSBaseStation.Views.SettingsView-   'FSBaseStation.ViewModels.AlertViewModel#   FSBaseStation.Views.AlertView��%  (��       5   4   *, +)(�� X     5   6   *, +)(�� �     5   4   *, +)(�� 
    5   0   *, +)(�� ^    5   :   *,
 +)(�� �    5   9   *, +)(��     5!   8   *, +)(�� u    5$   5   *, +)(�� �    5'   2   *, +)�� 5   
   ConnectViewTemplate��"  64   .R�5         6    �� 5      �� 5   
   DashboardViewTemplate��"  66   .R�5         6"   �� 5      �� 5   
   KistlerViewTemplate��"  64   .R�5         6    �� 5      �� 5   
   ECUViewTemplate��"  60   .R�5      	   6   �� 5      �� 5   
   RightInverterViewTemplate��" 
 6:   .R�5         6&   �� 5      �� 5   
   LeftInverterViewTemplate��"  69   .R�5         6%   �� 5       �� 5!   
   TemperatureViewTemplate��"  68   .R�5"         6$   �� 5#      �� 5$   
   SettingsViewTemplate��"  65   .R�5%         6!   �� 5&      �� 5'   
   AlertViewTemplate��"  62   .R�5(         6   �� 5)      5*      .��5+      �  � ColumnDefinitions 5-   
   �� 5.      $	��185 �6   �� 5/      $��* �6   	 � RowDefinitions	 51   
   �� 52      $��35 �6   �� 53      $
��0.2* �6   $	��110��6+   �� 54      $��* �6   �� 55      $��50 �6   .+�58   
   � $	��Top=�6   $��2��6'   $��35��6;   ���	#FF4F4F4F.+�59      �� $��FS Base Station��6   
   IsHitTestVisibleInChrome
 .  
�������$��DemiBold"�5:      $��18(�6.   $
��Left=�6<   $��Center=�6W   $��8,0,0,0q�6r   �� 5<      
 . $��Center=�6F   $��Right=�6a    �� Orientation$ 
Horizontal=�5=      $��35��62   .+�5>      �� -   5        $��MinimizeButton��5?   (      ControlButtons#��[  5>      $��35��6A   $��35��6L   $��-��6X   $
��Bold"�6e   $��23(�5?      
������ $��0q�6W    � ToolTip$ Minimize��6k   �� 5@      -   5        $��MaximizeButton��5A   '   #��[  5@      $��35��6A   $��35��6L   $��+��6Y   $��DemiBold"�6e   $��21(�5A      
������ $��0q�6V   $ Restore Down��6j   �� 5B      -   5        $��CloseButton��5C   '   #��[  5B      $��35��6A   $��35��6L   $��x��6X   $��DemiBold"�6d   $��18(�5C      
������ $��0q�6S   $ Close��6g   5D      5E      �� 5G   
   $��1��62   $��1��6?   $
��Bold"�6O   $��46(�6a   $
��Left=�6o   $��Center=�6�   $��15,0,0,0q�6�   ��6   �� *WindowTitle+6�   �� 5I   
   -   5         ��Name$ WindowContent��5I      $��2��60   $��1��6=   $��2��6N   ��6_   �� *WindowContent+�� 5J   
   $��1��6   $��4��6"   .+�5K      ��   
sideButton#��[ 6   $��45��69   
���iii�$��18(�6[   ��6i   �� *DashboardViewCommand+.��5L      �� $ 
Horizontal=�6   $	��185��67   .+�5M      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *DashboardVisibility+�� 5N      $��3q�6   $��35��6(   $��35��63   $��Images/Dashboard_64.png��6?   �� 5O      $��	Dashboard��6    $��Center=�61   $��4,0,0,0q�6L   $��20(�6]   $��DemiBold"�6k   5P      5Q      �� 5R      #��[ 6   $��45��69   
���iii�$��18(�6[   ��6i   �� *ECUViewCommand+.��5S      �� $ 
Horizontal=�6   $	��185��67   .+�5T      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *ECUVisibility+�� 5U      $��3q�6   $��35��6(   $��35��63   $"��Images/Steering_wheel_64.png��6?   �� 5V      $	��ECU��6    $��Center=�6+   $��4,0,0,0q�6F   $��20(�6W   $��DemiBold"�6e   5W      5X      �� 5Y      #��[ 6   $��45��69   
���iii�$��18(�6Z   ��6h   �� *KistlerViewCommand+.��5Z      �� $ 
Horizontal=�6   $	��185��67   .+�5[      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *KistlerVisibility+�� 5\      $��3q�6   $��35��6(   $��35��63   $��Images/Car_64.png��6?   �� 5]      $��Kistler��6    $��Center=�6/   $��4,0,0,0q�6J   $��20(�6[   $��DemiBold"�6i   5^      5_      �� 5`      #��[ 6   $��45��69   
���iii�$��18(�6[   ��6i   �� *RightInverterViewCommand+.��5a      �� $ 
Horizontal=�6   $	��185��67   .+�5b      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *RightInverterVisibility+�� 5c      $��3q�6   $��35��6(   $��35��63   $��Images/motor_64.png��6?   �� 5d      $��Right Inverter��6    $��Center=�66   $��4,0,0,0q�6Q   $��20(�6b   $��DemiBold"�6p   5e      5f      �� 5g      #��[ 6   $��45��69   
���iii�$��18(�6Z   ��6h   �� *LeftInverterViewCommand+.��5h      �� $ 
Horizontal=�6   $	��185��67   .+�5i      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *LeftInverterVisibility+�� 5j      $��3q�6   $��35��6(   $��35��63   $��Images/motor_64.png��6?   �� 5k      $��Left Inverter��6    $��Center=�65   $��4,0,0,0q�6P   $��20(�6a   $��DemiBold"�6o   5l      5m      �� 5n      #��[ 6   $��45��69   
���iii�$��18(�6[   ��6i   �� *TemperatureViewCommand+.��5o      �� $ 
Horizontal=�6   $	��185��67   .+�5p      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *TemperatureVisibility+�� 5q      $��3q�6   $��35��6(   $��35��63   $��Images/Temperature_64.png��6?   �� 5r      $��Temperature��6    $��Center=�63   $��4,0,0,0q�6N   $��20(�6_   $��DemiBold"�6m   5s      5t      �� 5u      #��[ 6   $��45��69   
���iii�$��18(�6[   ��6i   �� *ConnectViewCommand+.��5v      �� $ 
Horizontal=�6   $	��185��67   .+�5w      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *ConnectVisibility+�� 5x      $��3q�6   $��35��6(   $��35��63   $��Images/Connect_64.png��6?   �� 5y      $��Connect��6    $��Center=�6/   $��4,0,0,0q�6J   $��20(�6[   $��DemiBold"�6i   5z      5{      �� 5|      #��[ 6   $��45��69   
���iii�$��18(�6[   ��6i   �� *SettingsViewCommand+.��5}      �� $ 
Horizontal=�6   $	��185��67   .+�5~      �� $��5��6    $��40��6*   
���  ��$��0,0,4,0q�6E   y�6V   �� *SettingsVisibility+�� 5      $��3q�6   $��35��6(   $��35��63   $��Images/Settings_64.png��6?   �� 5�      $��Settings��6    $��Center=�60   $��4,0,0,0q�6K   $��20(�6\   $��DemiBold"�6j   5�      5�      5�      �� 5�   
   #��[ 6   $��45��65   $��0��6d   $��3��6t   $��18(�6�   $��Bottom=�6�   ��6A   �� *AlertStatus+��6�   �� *AlertViewCommand+.��5�      �� $ 
Horizontal=�6   $	��185��63   .+�5�      �� $��40,0,0,0q�6   $��35��6+   $��35��66   ��6B   �� *
AlertImage+�� 5�      $��Alerts��6   $��Center=�6*   $��4,0,0,0q�6E   $��20(�6V   $��DemiBold"�6d   5�      5�      5�      5�      