   M S B A M L   `   `   `  ����  
calculator    Calculator.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Aav2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6G     � Title$  
Calculator��5   	    � SizeToContent$ WidthAndHeight=�5   	   $	��322��6(   $	��257��65   .��5      �� ���	#FF87DDCA.+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��59��6.   .+�5      �� $��10q�6   $��Số thứ 1:��6F   $��29��6Z   $��Times New Roman)�6f   $��13(�6�    �� Target 6    ��  �� ElementName$ txtOp1��6�   �� 5      -   5         ��Name$ txtOp1��5   .   $��10q�6   $	��134��6"   $��34��6>   $��Center=�6J   5      �� 5   
   $ 
Horizontal=�6   $��61��6.   .+�5      �� $��10q�6   $��Số thứ 2:��6F   $��Times New Roman)�6Z   $��13(�6w   $��29��6�    6    �� $ txtOp2��6�   �� 5      -   5        $ txtOp2��5   .   $��10q�6   $	��135��6"   $��34��6>   $��Center=�6J   5      �� 5   
   $��50��6   $ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ btnAdd��5   -   $��10q�6   $	��105��6!   $
��_Add��6R   ���	#FFD7F9F1 J� RenderTransformOrigin$ 0.5,0.5&�6x   $��30��6�   $��Times New Roman)�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5       T� X$	 0.5Q�6-   	 T� Y$		 0.5Q�65   5      5       �� 5!      -   5        $ btnSubtract��5!   !   $	��109��6   $��	_Subtract��6P   ���	#FFD4FCF3$��29��6{   $ 
0.63,0.498&�6�   $��Times New Roman)�6�   z�5"      V� 5#      .~�5$      �� �� 5%      �� 5&      T� 5'      $	 0.5Q�6-   $	 1Q�65   5(      5*      5+      �� 5.   
   $ 
Horizontal=�6   $��49��6.   .+�5/      �� $��10q�6   $��Answer:��6    $��Times New Roman)�62   �� 50      -   5        $ txtAns��50   .   $��10q�6   $	��152��6"   
 �� 
IsReadOnly$

 True��6>   $��27��6P   51      �� 52   
   -   5         ��Name$ 	chkCenter��52      $�� Center Numeric Values��53      $��58��55   1   $��Stretch=�6=   $
��Auto=�6b   $��Center=�6�   $ 0.5,0.5&�6�   $��15,0,0,0q�6�   $��Times New Roman)�6�   z�56      V� 57      .~�58      �� �� 59      �� 5:      T� 5;      $	 0.5Q�6)   5<      5>      5A      5B      