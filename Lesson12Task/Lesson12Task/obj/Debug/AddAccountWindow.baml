   M S B A M L   `   `   `  ����G  CLesson12Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lesson12TaskLesson12Task  5   	   #    Lesson12Task.AddAccountWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lesson12Task     5   	     � Title$0  *Создание Счета Клиента��5   	   $	��300��6(   $	��600��65   $	��300��6A   $	��600��6Q   .��5	      � .+�5
   
   �� -   5         ��Name$ LabelOwnerFIO��5      $��ФИО Владельца��5
      $��Center=�6(   $��40��6E   $��	10,10,0,0q�6Q   $	��Top=�6d   $	��580��6|   5      �� 5   
   $$��Начальная Сумма:��6   $
��Left=�6+   $��30��6F   $��	10,50,0,0q�6R   $	��Top=�6e   $	��120��6}   �� 5   
   -   5         ��Name$ TextBoxAmount��5   6   $
��Left=�5      $��30��6-   $��
160,50,0,0q�69    �� TextWrapping$
 Wrap=�6M   $��0��6a   $	��Top=�5      $	��430��6*   66   �� 5   
   -   5        $��Сохранить��5      $
��Left=�6%   $��35��6@   $��
10,220,0,0q�6L   $	��Top=�6`   $	��100��6x   5      	� 5   
   -   5         	�Name$ RadioButtonNonDeposit��5      $��Недепозитный��5      $
��Left=�6-   $��
10,120,0,0q�6H   $	��Top=�6\    d� 	IsChecked$
 TrueY�5   Y   	� 5   
   -   5        $ RadioButtonDeposit��5      $��Депозитный��5      $
��Left=�6+   $��180,120,0,0q�6F   $	��Top=�6[   5   2   5      5      