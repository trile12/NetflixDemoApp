   M S B A M L   `   `   `  ���� R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   NormalBrush  �� Color  PressedBrush  DisabledForegroundBrush  NormalBorderBrush �� 
StartPoint �� EndPoint � Color � Offset  ScrollBarLineButton �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius
 �� Path �� RelativeSource J� Opacity �� Triggers P� Property P� Value �� 
TargetName  ScrollBarPageButton  ScrollBarThumb  CustomListBoxItem �� Padding J� SnapsToDevicePixels $  ListBoxWithAutoScroll_Horizontal ��Name ��Name �� Orientation ]�Name ]� DecreaseRepeatButton ]� IncreaseRepeatButton ]� Thumb �Name � ColumnDefinitions ��Name �� Interval �� Delay �� LineLeftCommand  �� 	ClickMode! �� ElementName" �� LineRightCommand# ]� 
Conditions$ �� Property% �� Value& �� 
SourceName' N� EnterActions( �� 
TargetName) �� TargetProperty	* W� To+ g� Duration, N� ExitActions- $� Orientation "	 ListBoxWithAutoScroll_Vertical. �� VerticalOffset/ � Value0 �� ScrollableHeight1 � Maximum2 �� ViewportHeight3 �� ViewportSize*4 �� #ComputedVerticalScrollBarVisibility5 � RowDefinitions6 �� LineUpCommand7 �� LineDownCommand�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %  &	        &	      &	 *     &	 :     &	 �     7   7  7  7  &	 =    &	 �    &	 �    &	 `    7  7  7  7  7  7  &		 a
    7  7  7  7  7  7  �� $  	#FFCCCCCC���� $  	#FFEEEEEE���� $
  #888���� $	 0,0&�$	 0,1&���� � $
 #CCC��$	 0.0Q�� $
 #444��$	 1.0Q��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � |� .  ��  � �� �� " ��.R��� $��Border��$	 2��8��  8�� ._�F� $��Center=�$��Center=�
����������� $
 Content� �� *TemplatedParent+ �� $
 Opacity� �� *TemplatedParent+ P�  � �� . . ��� $ Border��8   � ��P�  � {� .  . ��� 8   � ���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " ��.R��� 
������ �� " n�.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " n�.R��� $	 2��#��z��#��z��$��1q��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� �� " ��.R��� $��Border��$ 1q� . ._��� �� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � ��$
 Auto=���  � ��$
 Auto=���  � �� .  ��  � ��
 ���� ��  � ��8   ��  � �� �� .R�� .+��� $ scrollviewer������ " ��.R�� .+��� $ PART_HorizontalScrollBar��$ 
Horizontal=����� .R�]� $ 
PART_Track�� �� $��ScrollBar.PageLeftCommand��8��  �� $ ��ScrollBar.PageRightCommand��8��  n� 8�� 
�������$	 0.8Q�$
��0,-1q��� $	��0,2q�$
��Auto��$��Center=�.���� � $ Panel��$	��0,2q� �� $
��Auto ��� $��* ��� $
��Auto �.+��� $ LineLeftButton��$��0��$��30��$ 0Q�$y�Visible=�8�� $ 1��$ 0��$��M 8 0 L 8 32 L 0 16 Z��#��Z $  Press=����� $! scrollviewer���� $ LineRightButton��$��2��$��30��$ 0Q�$y�Visible=�8�� $ 1��$ 0��$��M 0 0 L 8 16 L 0 32 Z��#��Z" $  Press=����� $! scrollviewer�� ]� # �� $ �@J�IsMouseOver% . �� $& scrollviewer��-$ �@��%ComputedHorizontalScrollBarVisibility$% Visible=�/��� $ LineLeftButton�� � y�$ Visible=��� $ LineRightButton�� � y�$ Visible=�' �� .���� .��W� $( LineLeftButton��$) Opacity�$	* 0.8X�$+ 0:0:0.30D�W� $( LineRightButton��$) Opacity�$	* 0.8X�$+ 0:0:0.30D�, �� .���� .��W� $( LineLeftButton��$) Opacity�$* 0X�$+ 0:0:0.30D�W� $( LineRightButton��$) Opacity�$* 0X�$+ 0:0:0.30D���  � �� �� .R�$� $- 
Horizontal=��� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � ��$
 Auto=���  � ��$
 Auto=���  � �� . ��  � ��
 ���� ��  � ��8   ��  � �� �� .R�� .+��� $ scrollviewer������ " ��.R�� .+��� $ PART_VerticalScrollBar��$ Vertical=�#/ z. #1 z0 #3 z2 #y�z4 ���� *Width+$! Panel������ .R�]� $ 
PART_Track����.  �� $��ScrollBar.PageUpCommand��8��  �� $��ScrollBar.PageDownCommand��8��  n� 8�� 
�������$	 0.8Q�$
��-1,0q��� $	��2,0q�$
��Auto��$��Center=�.���� � $ Panel��$	��2,0q�5 �� $
��Auto ��� $��* ��� $
��Auto �.+��� $ LineUpButton��$��0��$��20��$ 0Q�$y�	Collapsed=�8�� $��M 0 8 L 32 8 L 16 0 Z��#��Z6 $  Hover=����� $! scrollviewer���� $ LineDownButton��$��2��$��20��$ 0Q�$y�	Collapsed=�8�� $��M 0 0 L 16 8 L 32 0 Z��#��Z7 $  Hover=����� $! scrollviewer�� ]� # �� $ �@J�IsMouseOver% . �� $& scrollviewer��+$ �@��#ComputedVerticalScrollBarVisibility$% Visible=�/��� $ LineUpButton�� � y�$ Visible=��� $ LineDownButton�� � y�$ Visible=�' �� .���� .��W� $( LineUpButton��$) Opacity�$	* 0.8X�$+ 0:0:0.25D�W� $( LineDownButton��$) Opacity�$	* 0.8X�$+ 0:0:0.25D�, �� .���� .��W� $( LineUpButton��$) Opacity�$* 0X�$+ 0:0:0.25D�W� $( LineDownButton��$) Opacity�$* 0X�$+ 0:0:0.25D���  � �� �� .R�$� $- Vertical=�