   M S B A M L   `   `   `  ����C  ?Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PracticePractice  5   	       Practice.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Practice     5   	     � 
ResizeMode$  CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ 
MainWindow��5
   	   $	��450��6   $	��300��6)   $	��400��65   $	��300��6E   
�������.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Times New Roman)�5      
�������$"��Авторизоваться��5      $��Center=�5      $��Center=�5      $��30(�5      �� 5   
   -   5         ��Name$ Login��5%      
�������$��Center=�5       $��Times New Roman)�5!      $��
Логин��5"      $��1��5#      $��20(�5$      $��0,10,0,0q�5%      �� 5'   
   -   5         ��Name$ loginBox��5)      
�������$��2��5+      $��30��5,      $��10q�5-      ��5*      �� *Login+.��5-      5.      �� 5/   
   -   5        $ Password��55      
�������$��Times New Roman)�51      $��Center=�52      $��3��53      $��20(�54      $��Пароль��56      G� 58   
   -   5         G�Name$ passwordBox��5;      
�������$��4��5<      $��30��5=      $��10q�5>      �� 5C   
   -   5        $��Autorization��5C   d   $��Times New Roman)�6   $��
Войти��6.   $��16(�6>   $	��120��6L   $��40��6X   $��5��6x   $��Right=�6�   $��	0,20,10,0q�6�   ��5D      �� 5E       �� 
TargetType" ��6   .�5F      ��  �� Property � ��	 �� Value	 5G      �� 5H      
 �� EndPoint$	
 0,1&�62    �� 
StartPoint$	 0,0&�6A   .��5I   "   �  � Color$ 	#FF000000��6/    � Offset$ 0Q�6A   � 5J   "   $ 	#FF4B4B4B��6/   $ 1Q�6A   5K      5M      �� 5N       � ��
	 �����63   �� 5O       � ��	 5P      �� 5Q       �� 
TargetType" ��6.   .R�5R   "   ��  �� CornerRadius$ 10��6)   #��z��6;   
���   �$��2q�6y   ._�5S   &   �� $��Center=�67   $��Center=�6T   5T   #   5U      5W      5X      5Z      5[      5\      