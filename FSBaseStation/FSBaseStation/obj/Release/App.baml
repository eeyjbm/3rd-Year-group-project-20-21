   M S B A M L   `   `   `  ���� W  SFormula Student Base Station, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FSBaseStationFSBaseStation      FSBaseStation.App   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:FSBaseStation       �� 	Resources     HorizontalBrush �� 
StartPoint �� EndPoint � Color � Offset  RoundButtonDefaultBrush  RoundButtonPressedBrush  RoundButtonMouseOverBrush  RoundButtonTemplate �� 
TargetType �� Triggers P� Property P� Value	 �� 
TargetName
 �� Value �� Property  SliderButtonStyle �� 
TargetType  RoundButtonStyle  SliderThumbStyle  CustomSlider � RowDefinitions �Name � ColumnDefinitions �� Padding �� CornerRadius ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton 	 
sideButton ��Name 
 ControlButtons ��Name��%+  &	        &	 9     &	 \     &	      &	 �     7  7  7  &	 W    &	     7  &	 }    &	 9    7  7  7   7  7  7  &		 �	    &	
 �
    �� $	 0,0&�$	 1,0&�.��� $ DarkRed��$	 1.0Q�
� .��� $ DarkRed��$ 1Q�
� .��� $ DarkRed��$ 1Q�
� .��� $ DarkRed��$ 1Q��� " ��.R�� .+�A� $��PART_Ellipse��$��15��$��15��
���   �8��  �� $��PART_ContentPresenter��$��Content��$��0,0,0,3q�$��Center=�$��Center=�
�������$��16(�$
��Bold"� P�  �@J�IsMouseOver . . ��� $	 PART_Ellipse��8
   � ���� $	 PART_ContentPresenter�� � ��

 �����P�  � �� . . ��� $	 PART_Ellipse��8
   � ���� $	 PART_ContentPresenter�� � ��

 ������� " ��.���  �@J�SnapsToDevicePixels
 . ��  �@�OverridesDefaultStyle
 . ��  � ��
 .  ��  � |�
 .  ��  � ��
 �� " ��.R��� 
������ �� " ��.���  �@J�SnapsToDevicePixels
 . ��  �@�OverridesDefaultStyle
 . ��  � ��8
   �� " n�.���  �@J�SnapsToDevicePixels
 . ��  �@�OverridesDefaultStyle
 .  ��  � ��$
 20����  � ��$
 15����  � ��
 �� " n�.R��� .+�F� $��Ellipse��$��0,5,0,0q�=���� z ��- �    ��� �    ��� ���� ��� ���� ��� � z ��- 	
���   ����#EAE9E4 P�  �@J�IsMouseOver . . ��� $	 Ellipse�� � ��
 �#EAE9E4P�  � {� .  . ��� $	 Ellipse�� � ��
 �#EAE9E4�� " ��.���  �@�OverridesDefaultStyle
 . ��  � ��
 �� " ��.R��  �� $
��auto ��� $	 row��$
��auto ��� $
��auto � �� $
��auto ��� $ column��$��* ��� $
��auto �.+��� $��PART_DecreaseRepeatButton��$��1��$��0��8��  $��-��$��Slider.DecreaseSmall���� $��PART_IncreaseRepeatButton��$��1��$��2��8�� $��+��$��Slider.IncreaseSmall���� $��PART_Border��
���   �$��1q�$ 2q�$ 5��$��1��$��1��#��z��#��z��8�� $��Stretch=�$��Center=�]� $��
PART_Track��$��Stretch=�$��Center=�$��1��$��1��#��z��#��z�� �� $��Slider.DecreaseLarge��8��  n� 8��  �� $��Slider.IncreaseLarge��8��  P�  �@��Orientation$ Vertical=�. ��� $	 PART_Border�� � ��$
 Center=��� $	 PART_Border�� � ��$
 Stretch=��� $	 
PART_Track�� � ��$
 Center=��� $	 
PART_Track�� � ��$
 Stretch=��� $		 row�� � ��$
 * ��� $	 column�� � ��$

 auto ��� $	 PART_DecreaseRepeatButton�� � ��$
 2���� $	 PART_DecreaseRepeatButton�� � ��$
 1���� $	 PART_IncreaseRepeatButton�� � ��$
 0���� $	 PART_IncreaseRepeatButton�� � ��$
 1���� " ��.���  �@�OverridesDefaultStyle
 . ��  � ��
 �� " ��.R�� #��z��.+��� $ MyContentPresenter��#��z��$��Center=�$��Center=��� " ��.���  � ��

 ���� ��  � ��$
 Center=���  � ��$
 Center=���  � ��

 �������  � ��
 �� " ��.R��� $ bg��#��z��._��� #��z��#��z�� P�  �@J�IsMouseOver . . ��� $	 bg�� � ��
 �	#FFB8B8B8