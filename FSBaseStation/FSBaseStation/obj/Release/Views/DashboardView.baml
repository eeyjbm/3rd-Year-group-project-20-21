   M S B A M L   `   `   `  ���� W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:FSBaseStation.ViewsFSBaseStation.Views  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf C&clr-namespace:FSBaseStation.PropertiesFSBaseStation.Properties  '    !FSBaseStation.Views.DashboardView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:FSBaseStation.Views     Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     =
properties&clr-namespace:FSBaseStation.Properties     
�������.���   � ColumnDefinitions  �� $��* �$
��1000���� $��* �$
��1000���� $��* �$
��1000�� � RowDefinitions �� $
��0.4* ��� $
��1.8* ��� $
��0.4* ��� $
��1.8* �.+��� $��0��$��4��$��0��$��2��
���iii�$��2��$��10q� �� RadiusX$ 10�� �� RadiusY$ 10���� $��0��$��0��$��Left Inverter Speed (RPM)��$��15(�$��Center=�$��Center=�$��0,10,0,0q�  LiveCharts.Wpf.Gauge  $��1��$��0��$��	20,5,10,5q�   GaugeActiveFill
 ��  �   GaugeBackground
 �����   From �� '  !FSBaseStation.Properties.Settings   Default �� Source# Z 	 �� Path$	 GaugeLeftInverterSpeedMin�	
   To
 �� # Z $	 GaugeLeftInverterSpeedMax�   Value �� *LeftInverterSpeed+�� $��0��$��1��$ ��Right Inverter Speed (RPM)��$��15(�$��Center=�$��Center=�$��0,10,0,0q�  $��1��$��1��$��	10,5,20,5q�
 ��  �
 ����� �� # Z $ 	 GaugeRightInverterSpeedMin�
 �� # Z $ 	 GaugeRightInverterSpeedMax� �� *RightInverterSpeed+�� $��2��$��0��$$��Left Inverter Mechanical Power��$��15(�$��Center=�$��Center=�$��0,00,0,0q�  $��3��$��0��$��	20,5,10,5q�
 ��  �
 ����� �� # Z $!	 GaugeLeftMechanicalPowerMin�
 �� # Z $!	 GaugeLeftMechanicalPowerMax� �� *LeftInverterMechanicalPower+�� $��2��$��1��$%��Right Inverter Mechanical Power��$��15(�$��Center=�$��Center=�$��0,0,0,0q�  $��3��$��1��$��	10,5,20,5q�
 ��  �
 ����� �� # Z $"	 GaugeRightMechanicalPowerMin�
 �� # Z $"	 GaugeRightMechanicalPowerMax� �� *RightInverterMechanicalPower+�� $��0��$��4��$��3��
���iii�$��2��$��10q�$ 10��$ 10���� $��0��$��3��$��Velocity X Axis��$��15(�$��Center=�$��Center=�$��0,10,0,0q�  $��1��$��3��$��	20,5,20,5q�
 ��  �
 ����� �� # Z $	 GaugeVelocityXMin�
 �� # Z $	 GaugeVelocityXMax� �� *KistlerVelX+�� $��2��$��3��$��Velocity Y Axis��$��15(�$��Center=�$��Center=�$��0,0,0,0q�  $��3��$��3��$��	20,5,20,5q�
 ��  �
 ����� �� # Z $	 GaugeVelocityYMin�
 �� # Z $	 GaugeVelocityYMax� �� *KistlerVelY+