   M S B A M L   `   `   `  ����G  CLesson12Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lesson12TaskLesson12Task  5   	       Lesson12Task.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lesson12Task     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)   $	��550��65   $	��800��6E   .��5	      � .+�5
   
   �� $-��'Управление клиентами��6   $
��Left=�6/   $��45��6J   $��
100,20,0,0q�6V   $	��Top=�5      $	��600��6(   $��Center=�64   $��24(�6X   $
��Bold"�6f   $��Italic$�6x   �� 5   
   
���   �$��2q�6%   $��Center=�69   $��5��6V   $��0,85,0,0q�5      $	��Top=�6#   $	��800��6;   �� 5   
   
���   �$��2q�6%   $
��Left=�69   $	��445��6T   $��
220,90,0,0q�5      $	��Top=�6%   $��3��6=   �� 5   
   -   5        $%��Добавить клиента��5      $
��Left=�6,   $��40��6G   $��
20,120,0,0q�6S   $	��Top=�5      $	��180��6)   65   �� 5   
   -   5        $)��#Управление счетами��5      $
��Left=�6.   $��40��6I   $��
20,190,0,0q�6U   $	��Top=�5      $	��180��6)   65   �� 5   
   -   5        $#��Удалить клиента��5      $
��Left=�6+   $��40��6F   $��
20,260,0,0q�6R   $	��Top=�5      $	��180��6)   65   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridClients��5   Z   $
��Left=�5      $	��445��6.   $��
220,90,0,0q�6;      AutoGenerateColumns .     
IsReadOnly . $	��Top=�5      $	��580��6+   ��67   �� *
ClientList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *FIO+6J     5      $! Номер Паспорта��6%   $	 180 6Z    6=   �� *
Passport+6Z   5      5      5       