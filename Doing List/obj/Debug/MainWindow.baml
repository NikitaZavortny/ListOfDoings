   M S B A M L   `   `   `  ����E  ADoing List, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Doing_List
Doing_List  5   	   ;"clr-namespace:Doing_List.ViewModelDoing_List.ViewModel  5   	       Doing_List.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Doing_List     5   	   1vm"clr-namespace:Doing_List.ViewModel     5   	     � Title$  
Doing List��5	   	   $��858.943��5
   	   $��532.195��6    � Cursor$ Arrow��6*    � DataContext 5      (  "Doing_List.ViewModel.MainViewModel  5   
   .��5      ]� .+�5   
   o� $	��Top=�6   $��29��6$   .@�5      m� $
��File��6   .@�5      m� $
��Save��68    m� Command 6   �� *
SaveData+68   m� 5      $
��Load��68    6   �� *
OpenData+68   5      m� 5      $��Sth else��6   5      �� 5   
   .@�5      �� $
��Main��6   ���	#FFACACAC
���   ����	#FFAAAAAA.��5      �  � ColumnDefinitions 5      �� 5      $
��191* �6+   �� 5      $
��532* �6+   �� 5      $	��63* �6+    � RowDefinitions 5      �� 5       $	��24* �6(   �� 5!      $
��157* �6(   .+�5#      &   System.Windows.Controls.DataGrid  $��1��6g   $��1��6w   $��2��6�      AutoGenerateColumns .  
���   ����	#FFD0D8DE���	#FF99A7B6 �� SelectedItem 6   �� *SelectedThing+��6F   �� *
ListToDo+   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn	   
IsReadOnly	 . 
   Header$
 Doings��6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   ��  �� Path$
 Name�6b   4  .System.Windows.Controls.DataGridCheckBoxColumn  5&      $
 Is Done��6W    65   ��  �� XPath$ IsDone��6W     5'      	 . $

 Date��6e    6C   �� $ Dedline�6e     5(      	 . $

 User��6f    6C   �� $ Who.Name�6f   5*      �� 5+      $��-��6   $��3��6H   $��0��6X   $��36(�6e   $��Segoe UI Black)�6s   ���	#FFF76F6F
���������6)   �� *
DeleteToDo+6�   5,      5-      �� 5.      $��	Add doing��6   .��5/      �  50      �� 51      $
��117* �6+   �� 52      $
��191* �6+   �� 53      $
��297* �6+   �� 54      $
��149* �6+    56      �� 57      $	��70* �6(   �� 58      $	��37* �6(   �� 59      $
��175* �6(   �� 5:      $	��37* �6(   �� 5;      $
��136* �6(   .+�5=      �� $
��Name��6    $��1��6,   $��Bottom=�6<   $��Right=�6W   �� 5>      $��Deadline��6    $��1��60   $��2��6@   $��Bottom=�6M   $��Right=�6h   �� 5?      $��1��66   $��1��6F   $��Times New Roman)�6S   $��14(�6p   ��6   �� *DoName+6p   �� 5@      $��1��66   $��3��6F   $��Times New Roman)�6S   $��14(�6p   ��6   �� *Dedlin+6p   �� 5A      $��+��6   $��3��6H   $��4��6X   $��36(�6e   $��Segoe UI Black)�6s   ���	#FF6CC55E
���������6)   �� *
CreateToDo+6�   5B      5C      �� 5E      $��Add User��6   .��5F      �  5G      �� 5H      $	��81* �6+   �� 5I      $
��264* �6+   �� 5J      $
��333* �6+   �� 5K      $
��167* �6+    5M      �� 5N      $	��70* �6(   �� 5O      $	��37* �6(   �� 5P      $
��175* �6(   �� 5Q      $	��37* �6(   �� 5R      $
��136* �6(   .+�5T      �� $
��Name��6    $��2��6,   $��Bottom=�6<   $��Right=�6W   $��16��6s   $��32��6   �� 5U      $��Surname��6    $��2��6/   $��2��6?   $��Bottom=�6L   $��Right=�6g   $��16��6�   $��47��6�   �� 5V      $��2��68   $��1��6H   $��Times New Roman)�6U   $��14(�6r   ��6   �� *
UserName+6r   �� 5W      $��2��6;   $��3��6K   $��Times New Roman)�6X   $��14(�6u   ��6   �� *UserSurName+6u     5X      $��0��6c   $��0��6s   $��2��6�   $��5��6�    .  
���   ����	#FFD0D8DE���	#FF99A7B6 6   �� *SelectedUser+��6E   �� *Users+ 5Y        5Z      	 . $

 Name��6b    6C   �� $
 Name�6b     5[      	 . $
 Surname��6e    6C   �� $ Surname�6e   5]      �� 5^      $��   -   ��6   $��2��6N   $��4��6^   $��36(�6k   $��Segoe UI Black)�6y   ���	#FFF76F6F
�������$��Bottom=�6�   $��Right=�6�   ��6/   �� *
DeleteUser+6�   �� 5_      $��+��6   $��3��6H   $��4��6X   $��36(�6e   $��Segoe UI Black)�6s   ���	#FF6CC55E
���������6)   �� *
CreateUser+6�   5`      5a      5b      5c      5e      