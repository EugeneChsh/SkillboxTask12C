   M S B A M L   `   `   `  ����G  CLesson12Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lesson12TaskLesson12Task  5   	   $    Lesson12Task.AccountFormWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lesson12Task     5   	     � Title$)  #Управление счетами��5   	   $	��450��6$   $	��800��61   $	��450��6=   $	��800��6M   .��5	      � .+�5
   
   �� -   5         ��Name$ LabelOwnerFIO��5      $��ФИО Владельца��5
      $
��Left=�6(   $��40��6C   $��	10,10,0,0q�6O   $	��Top=�6b   $	��700��6z   $��16(�5   '   �� 5   
   $��Счета: ��6   $
��Left=�6"   $��40��6=   $��	10,60,0,0q�6I   $	��Top=�6\   $	��700��6t   $��16(�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridAccounts��5   7   $��Center=�5      $	��245��60   $��	0,105,0,0q�6=   $	��Top=�6P   $	��800��6h      AutoGenerateColumns .     
IsReadOnly . ��5      �� *AccountList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер счета��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *AccountNumber+6\     5      $  Сумма на счете��6%   $	 200 6Y    6=   �� *	Balance+6Y     5      $ Тип счета��6%   $	 200 6X    68   �� *AccountType+6X   5      �� 5   
   -   5        $��Добавить счет��5      $
��Left=�6)   $��35��6D   $��
10,370,0,0q�6P   $	��Top=�6d   $	��100��5      6   �� 5   
   -   5        $��Удалить счет��5      $
��Left=�6(   $��35��6C   $��120,370,0,0q�6O   $	��Top=�6d   $	��100��5      6   �� 5   
   -   5        $;��5Перевод между своими счетами��5      $
��Left=�68   $��35��6S   $��230,370,0,0q�6_   $	��Top=�6t   $	��190��5      6   �� 5   
   -   5        $/��)Перевод на другой счет��5      $
��Left=�62   $��35��6M   $��430,370,0,0q�6Y   $	��Top=�6n   $	��190��5      6   �� 5   
   -   5        $��Вернуться��5      $
��Left=�6%   $��35��6@   $��670,370,0,0q�6L   $	��Top=�6a   $	��100��5      6   5!      5"      