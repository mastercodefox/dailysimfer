   M S B A M L   `   `   `  ����I  ESimferopolApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SimferopolApp1SimferopolApp1  5   	       SimferopolApp1.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /tb http://www.hardcodet.net/taskbar     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SimferopolApp1     5   	     � Title$   ��5	   	   $	��410��6    � 
ResizeMode$ NoResize=�6    � SizeToContent$ Height=�64    � Topmost .  � WindowStyle$
 None=�6Z      WindowStyle#���   6m   
���   � � 	Resources 5
       �� 
TargetType �� Triggers :� RoutedEvent	 �� TargetProperty
 W� From	 W� To g� Duration  
ImageStyle��%�  &	        &	 �     �� 5   
   " �6$    5      :� 5      $ Loaded��6   [�5      �� 5      .��5      �� .��5   "   W� $	 Opacity�5   !   $
 0X�5   !   $ 1X�5   !   $ 0:0:3D�5   !   5      5      5      5      �� 5   
   " ��6#    5      :� 5       $ Loaded��6   [�5"      �� 5#      .��5$      �� .��5%   "   W� $	 Opacity�5&   !   $
 0X�5'   !   $ 1X�5(   !   $ 0:0:3D�5)   !   5+      5,      5.      50      51      .��52      � $	��Top=�6    � ColumnDefinitions 54   
   �� 55      $
��auto �6   �� 56      $
��auto �6    � RowDefinitions 58   
   �� 59      �� 5:      .+�5<   
   � $��0��6   
�������$	��200��66   $	��200��6C   $��0,0,5,5q�6O   $	��Top=�6`   .+�5=      �� .��5>      � .+�5?      �� -   5         ��Name$ pogodaimage��5?      $$��image/погодаквад.jpg��61   $��4��6O   �� 5@      -   5         ��Name$ pogoda_date��5@       $
��Bold"�65   $��0��6G   $��Center=�6T   $��BebasNeue Regular)�6o   �� 5A      -   5        $ pogoda_cloud��5A       $
��Bold"�66   $��1��6H   $��Center=�6U   $��BebasNeue Regular)�6p   �� 5B      -   5        $ pogoda_temp��5B       $
��Bold"�65   $��2��6G   $��Center=�6T   $��BebasNeue Regular)�6o   �� 5C      -   5        $ pogoda_wind��5C       $
��Bold"�65   $��3��6G   $��Center=�6T   $��BebasNeue Regular)�6o    5D      �� 5E      �� 5F      �� 5G      �� 5H      5M      5N      5O      � 5P   
   $��1��6   
����� �$	��200��61   $	��200��6>   $��5,0,0,5q�6J   $	��Top=�6[   .+�5Q      �� .��5R      � .+�5S      �� $&�� image/новостиквад.jpg��6   $��4��6;   �� 5T      -   5        $ 
image_rain��5T      $1��+image/10035109425_yagmur_damlaciklari_4.jpg��60   $��4��6e   $y�Hidden=�6v   �� 5U      -   5        $ image_cloud��5U      $ ��image/5327540_original.jpg��61   $��4��6U   $y�Hidden=�6f   �� 5V      -   5        $ image_winter��5V      $��image/748128.jpg��62   $��4��6L   $y�Hidden=�6]   �� 5W      -	   5        $ 	image_sun��5W      $6��0image/Citycons_building_icon-icons.com_67935.ico��6/   $��4��6i   $y�Hidden=�6z    5X      �� 5Y      �� 5Z      �� 5[      �� 5\      5`      5a      5b      � 5c   
   $��1��6   $��1��6   
�������$	��200��6H   $	��200��6U   $��5,5,0,0q�6a   $	��Top=�6r   .+�5d      �� .��5e      � .+�5f      �� $$��image/пробкиквад.jpg��6   $��4��6:    5g      �� 5h      �� 5i      �� 5j      �� 5k      5o      5p      5q      � 5r   
   $��0��6   $��1��6   $	��200��6,   $	��200��69   $��0,5,5,0q�6E   
����i��5t      5x      5y      