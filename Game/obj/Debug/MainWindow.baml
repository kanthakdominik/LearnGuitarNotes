   M S B A M L   `   `   `  ����?  ;Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GameGame  5   	   clr-namespace:GameGame  5   	       Game.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Game     5   	   !myclr-namespace:Game     5   	   -   5          � Title$  My Game��5	   	   $	��768��6   $
��1366��6&    � 
ResizeMode$ CanMinimize=�63    � WindowStartupLocation$ CenterScreen=�6L    � Icon$ Images/icon.ico��6q   $	��768��6�   $
��1364��6�    � WindowStyle$
 None=�6�   ��5
      �� 5   
    �� ImageSource$ Images/background.jpg��6   .��5      � $	��768��6   $
��1366��6    � 	Resources 5   
    �� 
TargetType �� Property	 �� Value
 �� EndPoint �� 
StartPoint � SpreadMethod � ColorInterpolationMode � Color � Offset �� 
TargetType �� Triggers P� Property P� Value   Main_textblock��%�  '��       &	  t    �� 5      " ��6   .�5      ��  � ��$	 	ExtraBold"�6/   �� 5       � ��$	 Times New Roman)�6/   �� 5       � ��$	 45(�6-   �� 5       � ��$	 50��6-   �� 5       � ��	 �	#FF06203E6/   �� 5       � ��	 �	#FFE9ECA960   �� 5       � ��	 5      �� 5      $	
 1,0&�6.   $	 1,1&�6=   $	 Pad=�6N   $ ScRgbLinearInterpolation=�6a   .��5      � $ 	#FFAC5710��6+   $ 0Q�6=   � 5      $ 	#FFE5E6D8��6+   $	 0.5Q�6=   5      5      �� 5       � ��	 5       �� 5!      " ��6*   .R�5"      �� #��z��6%   
���   �$��1q�6c   ._�5#   "   �� $��Center=�63   $��Center=�6P   5$      5%      5'       5(      P� 5)       �@J�IsMouseOver . . �5*      ��  � ��	 �	#FF68275F67   �� 5+       �@J�Opacity$		 0.8Q�64   5,      5.      �� 50      " ��6   .�51      ��  � ��$	 	ExtraBold"�6/   �� 52       � ��$	 Times New Roman)�6/   �� 53       � ��$	 99(�6-   �� 54       � ��$	 50��6-   �� 55       � ��	 �	#FF68275F6/   �� 56       �@J�Opacity$
	 0.85Q�6,   �� 57       �@��TextAlignment$	 Center=�62   58      59      .+�5;   
   �� -   5         ��Name$ exit_button��5;      $��70��6&   $��70��62   $��Right=�6=   $	��Top=�6Y   $��0,5,5,0q�6q   ��5<      �� 5=      .R�5>      �� $��Center=�6   $��Center=�6:   ._�5?      �� $��Images/exit.png��6    $��70��69   $��70��6D   5@      5A      5C      �� 5E   
   -   5        $ minimize_button��5E      $��70��6*   $��70��66   $��Right=�6A   $	��Top=�6]   $��0,5,80,0q�6u   ��5F      �� 5G      .R�5H      �� $��Center=�6   $��Center=�6:   ._�5I      �� $��Images/minimize.png��6    $��70��6=   $��70��6H   5J      5K      5M      �� 5O   
   -   5        $	��150��5O      $	��300��6   $��548,444,510,143q�6+   .��6b   
NOWA GRA6l   �� 5P   
   -   5        $	��150��5P      $	��300��6   $��86,444,972,143q�6+   .��6]   
UCZ SIĘ6f   �� 5Q   
   #��[  6   $
��Left=�6<   $	��264��6W   $��	86,46,0,0q�6d   $
��Wrap=�6w   $��LEARN GUITAR NOTES��6�   $	��Top=�6�   $	��762��6�   �� 5R   
   $
��Left=�6   $��32��6/   $��	0,736,0,0q�6;   $
��Wrap=�6N    �� TextAlignment$
 Left=�6b   $
��Bold"�6w   $��20(�6�   $��AUTOR: Dominik Kanthak��6�   $	��Top=�6�   $	��245��6�   5S      5T      