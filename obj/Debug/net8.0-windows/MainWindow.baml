   M S B A M L   `   `   `  ����H  DmessangerChat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:messangerChatmessangerChat  5   	       messangerChat.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:messangerChat     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��500��6)   .��5
      � ���#483D8B � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� 
�������$��1��6%    �� CornerRadius$ 40 40 40 40��62   $��2q�6M   $��20 40 20 40q�6a   �� 5   
   -   5         ��Name$ for_username��5      $��1��6(   $��enter your username��65   ���	#00ABADB3 �� SelectionBrush �	#000078D7
������ 
�������$��Dubai Light)�6�   $
��25px(�6�   $��Center=�6�   $��40q�6�   6   �� 5   
   
�������$��2��6%   $ 40 40 40 40��62   $��2q�6M   $��20 40 20 40q�6a   �� 5   
   -   5        $ for_address��5      $��2��6'   $��enter your IP address��64   ���	#00ABADB3 �	#000078D7
������ 
�������$��Dubai Light)�6�   $
��25px(�6�   $��Center=�6�   $��40q�6�   6!  �� 5   
   $��WELCOME TO MESSENGER��6   $
��35px(�60   
�������$��Center=�6T   $��Bottom=�6q   $��Dubai Light)�6�   �� 5   
   $��3��6   ���#9370DB$ 40 40 40 40��63   $��20,70,20,10q�6N   �� 5   
   -   5         ��Name$ 
for_create��5      $��3��6   $	��Top=�62   $	��Top=�6J   ���#9370DB$��create new chat��6~   $
��25px(�6�   
�������$��Dubai Light)�6�   $��
40,85,49,0q�6�   ���	#00707070$��41��6  6  �� 5    
   $��4��6   ���#9370DB$ 40 40 40 40��63   $��20,10,20,70q�6N   �� 5!   
   -   5        $ for_connect��5!      $��4��6   ���#9370DB$��connect to existing��6H   $
��25px(�6f   
�������$��Dubai Light)�6�   $��49,23,40,90q�6�   ���	#007070706�    � 5#   
   -   5          �Name$ for_chat_frame��5#      $��5��6(   5$      5%      