   M S B A M L   `   `   `  ����W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FSBaseStation.ViewsFSBaseStation.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      C&clr-namespace:FSBaseStation.PropertiesFSBaseStation.Properties  5      *    $FSBaseStation.Views.LeftInverterView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:FSBaseStation.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      =
properties&clr-namespace:FSBaseStation.Properties     5      
�������.��5      �   � RowDefinitions  5   
   �� 5      $
��0.9* �6   $��80��6*   �� 5      $
��3.5* �6   �� 5      $
��0.5* �6   $��50��6*   �� 5      $
��0.7* �6   $��80��6*   �� 5      $
��3.5* �6   �� 5      $
��0.9* �6   $��50��6*    � ColumnDefinitions 5   
   �� 5      $��0.13* �6   $��50��6-   �� 5      $��* �6   �� 5      $��0.08* �6   $��35��6-   �� 5      $��* �6   .+�5   
   �� $��0��6   $��6��6!   $��0��62   $��4��6B   
���iii�$��2��6g   $��10q�6{    �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   �� 5   
   $��Inverter Speed��6   $��18(�6*   $��1��68   $��DemiBold"�6I   $��Center=�6_   $��Center=�6|   $��0,10,0,0q�6�   �� 5   
   $	��RPM��6   $��14(�6   $��1��6-   $��Center=�6;   $��Center=�6X   $��10,0,0,0q�6s    J� RenderTransformOrigin$ 0.5,0.5&�6�    � LayoutTransform 5      �� 5        �� Angle$	 270Q�6"   5"      #  LiveCharts.Wpf.CartesianChart  5#   
   $��1��6   $��1��6*   &   LiveCharts.Wpf.Charts.Base.Chart   DisableAnimations .    	Hoverable .  	   DataTooltip	 6e   Z� 
   Series
 5%        LiveCharts.Wpf.LineSeries     LineSmoothness$ 1Q�5'   !     LiveCharts.Wpf.Series   StrokeThickness$ 6Q�5(   !      Stroke �#F34336   Fill
 ����    Values 5%   !   �� *Graph1ChartValues+   PointGeometry 5&   !   Z� 5*   !      AxisX 5-        LiveCharts.Wpf.Axis     LabelFormatter 6   �� *Graph1DateTimeFormatter+   MaxValue 5.      �� *Graph1AxisMax+   MinValue 5/      �� *Graph1AxisMin+   Unit 50      �� *Graph1AxisUnit+   	Separator 51        LiveCharts.Wpf.Separator  52         Step 6(   �� *Graph1AxisStep+54      56      �� 57   
      CustomSlider#��[  6   $��2��67   $��1��6D    �� Orientation$ 
Horizontal=�6T   $	��250��6�    � SmallChange$ 1Q�6D   � Minimum$ 1Q�6T   � LargeChange$ 1Q�6`   �� TickFrequency$ 1Q�6p   �� AutoToolTipPlacement$ TopLeft=�6�   �� AutoToolTipPrecision$ 1��6�   � Maximum 6m   �� '  !FSBaseStation.Properties.Settings    Default! �� Source#! Z  " �� Path$" LeftInverterSpeedXLagMax�# � Value# 6�   �� #! Z  $" LeftInverterSpeedXLag�$ �� Mode$$ TwoWay=�6�  �� 59   
   $��Mechanical Power��6   $��18(�6,   $��DemiBold"�6:   $��Center=�6P   $��Center=�6m   $��3��6�   $��0,10,0,0q�6�   �� 5:   
   $��Watts��6   $��14(�6!   $��1��6/   $��2��6<   $��Center=�6L   $��Center=�6i   $��0,0,0,0q�6�   $ 0.5,0.5&�6�    5;      �� 5<      $	 270Q�6"   5>        5?   
   $��1��6    .  .  $��3��6l   	 6U   Z� 
 5A        $ 1Q�5C   !   $ 6Q�5D   !    �#F34336
 ����  5A   !   �� *Graph2ChartValues+ 5B   !   Z� 5F   !    5I         6   �� *Graph2DateTimeFormatter+ 5J      �� *Graph2AxisMax+ 5K      �� *Graph2AxisMin+ 5L      �� *Graph2AxisUnit+ 5M        5N       6(   �� *Graph2AxisStep+5P      5R      �� 5S   
   #��[  6   $��2��67   $��3��6D   $ 
Horizontal=�6T   $	��250��6�   $ 1Q�6X  $ 1Q�6h  $ 1Q�6t  $ 1Q�6�  $ TopLeft=�6�  $ 1��6�   6m   �� #! Z  $(" "LeftInverterMechanicalPowerXLagMax�# 6�   �� #! Z  $%" LeftInverterMechanicalPowerXLag�$$ TwoWay=�6�  �� 5U   
   $��Absolute Phase Current��6   $��18(�62   $��DemiBold"�6@   $��Center=�6V   $��Center=�6s   $��1��6�   $��3��6�   �� 5V   
   $
��Amps��6   $��14(�6    $��4��6.   $��0��6;   $��Center=�6K   $��Center=�6h   $��10,0,0,0q�6�   $ 0.5,0.5&�6�    5W      �� 5X      $	 270Q�6"   5Z        5[   
    .  .  $��1��6`   $��4��6p   	 6H   Z� 
 5]        $ 1Q�5_   !   $ 6Q�5`   !    �#F34336
 ����  5]   !   �� *Graph3ChartValues+ 5^   !   Z� 5b   !    5e         6   �� *Graph3DateTimeFormatter+ 5f      �� *Graph3AxisMax+ 5g      �� *Graph3AxisMin+ 5h      �� *Graph3AxisUnit+ 5i        5j       6(   �� *Graph3AxisStep+5l      5n      �� 5o   
   #��[  6   $��6��67   $��1��6D   $ 
Horizontal=�6T   $	��250��6�   $ 1Q�6b  $ 1Q�6r  $ 1Q�6~  $ 1Q�6�  $ TopLeft=�6�  $ 1��6�   6m   �� #! Z  $-" 'LeftInverterAbsolutePhaseCurrentXLagMax�# 6�   �� #! Z  $*" $LeftInverterAbsolutePhaseCurrentXLag�$$ TwoWay=�6�  �� 5r   
   $��Link Voltage DC��6   $��18(�6+   $��DemiBold"�69   $��Center=�6O   $��Center=�6l   $��3��6�   $��3��6�   �� 5s   
   $��Voltage��6   $��14(�6#   $��4��61   $��2��6>   $��Center=�6O   $��Center=�6l   $��0,0,0,0q�6�   $ 0.5,0.5&�6�    5t      �� 5u      $	 270Q�6"   5w        5x   
    .  .  $��3��6`   $��4��6p   	 6H   Z� 
 5z        $ 1Q�5|   !   $ 6Q�5}   !    �#F34336
 ����  5z   !   �� *Graph4ChartValues+ 5{   !   Z� 5   !    5�         6   �� *Graph4DateTimeFormatter+ 5�      �� *Graph4AxisMax+ 5�      �� *Graph4AxisMin+ 5�      �� *Graph4AxisUnit+ 5�        5�       6(   �� *Graph4AxisStep+5�      5�      �� 5�   
   #��[  6   $��6��67   $ 
Horizontal=�6D   $��3��6]   $	��250��6�   $ 1Q�6T  $ 1Q�6d  $ 1Q�6p  $ 1Q�6�  $ TopLeft=�6�  $ 1��6�   6m   �� #! Z  $&"  LeftInverterLinkVoltageDCXLagMax�# 6�   �� #! Z  $#" LeftInverterLinkVoltageDCXLag�$$ TwoWay=�6�  5�      5�      