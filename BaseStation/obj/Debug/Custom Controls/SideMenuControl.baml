   M S B A M L   `   `   `  ����N  JSideMenuListControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:SideMenuListControl.Custom_Controls#SideMenuListControl.Custom_Controls  5      9    3SideMenuListControl.Custom_Controls.SideMenuControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:SideMenuListControl.Custom_Controls     5      -   5          >�Name$
  this��5       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels	 � ColumnDefinitions
 �� RelativeSource �� Mode �� AncestorType �� Triggers �� Binding �� Value ^� 
Conditions �� Binding �� Value��%,	  '��       '��     �� 5   
   " ��6   .�5      ��  � ��$ 0q�60   �� 5       � ��
 �iii�6+   �� 5       � ��$ Stretch=�64   �� 5       � ��$ Stretch=�62   �� 5       �@��SelectionMode$ Single=�6.   �� 5       � |� .  6*   5      �� 5   
   " ��6   .�5      ��  � ��
 �iii�6+   �� 5       � ��$ 0q�60   �� 5       �@��
IsSelected 6+   �� *IsItemSelected+�� 5       � ��$ 74��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ Bd��6!   #��z��6-   #��z��6Y   #��z��6�   # z��6�    . ._�5$      � $��-4,0,0,0q�6#   	 5%   "   �� 5&   &   $��4 �67   �� 5'   &   $��50 �67   �� 5(   &   $
��Auto �67   .+�5,   "   �� ��5-   &   �� 5.   *   " ��60   .�5/   .   ��  � ��
 �  ��6K   �� 52   .    � y�$ Hidden=�6K   �� 55   .    � �� 6G   �� *Height+
 �� $ FindAncestor=�$ BorderL��� 57   .    � ��$ 4��6F   �� 58   .    � |� .  6J   �� 59   .    � ��$
 Left=�6T    5<   .   �� 5>   2    6>   �� *IsMouseOver+
 �� $ FindAncestor=�$ ListBoxItemL� True6�   .a�5?   6   ��  � y�$ Visible=�6S   5@   3   �� 5A   2    6>   �� *
IsSelected+
 �� $ FindAncestor=�$ ListBoxItemL� True6�   .a�5B   6   ��  � y�$ Visible=�6S   5C   3   5F   +   5H   #   F� 5L   "   $��1��6'   ��5M   &   �� 5N   *   " F�60   .�5O   .   ��  � ��
 �  ��6E   �� 5P   .    �@��Stretch$ Uniform=�6H   �� 5Q   .    � ��$ Stretch=�6T   �� 5R   .    � ��$ 26��6F   �� 5U   .    � �� 6E   �� *
PathData+ 5X   .   ^� 5Z   2    5[   6   �� 5\   :    6D   �� *IsMouseOver+
 �� $ FindAncestor=�$ ListBoxItemL� True6�   �� 5]   :    6D   �� *
IsSelected+
 �� $ FindAncestor=�$ ListBoxItemL� True6�   .0�5_   6   ��  � ��
 �  ��6M   5`   3   5b   +   5d   #   �� 5h   "   $��2��6,   ��5i   &   �� 5j   *   " ��60   .�5k   .   ��  � ��$ Stretch=�6T   �� 5l   .    � ��$ Center=�6R   �� 5m   .    � ��
 �   �6K   �� 5n   .    � �� 6E   �� *
MenuText+5o   +   5q   #   5s      5t      5u      5w      5x      5z      .��5|      �� -   5         ��Name$ 	MyListBox��5|      ��6!   �� *	ItemsList+ �� SelectedIndex 6C   �� *SelectedIndex+ �� ElementName$
 this��5      5�      