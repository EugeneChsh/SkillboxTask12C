   M S B A M L   `   `   `  ����G  CLesson12Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lesson12TaskLesson12Task  5   	   $    Lesson12Task.TransactionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Lesson12Task     5   	     � Title$.  (Перевод между счетами��5   	   $	��450��6'   $	��800��64   $	��450��6@   $	��800��6P   .��5	      � .+�5
   
   �� $#��Счет для снятия:��6   $
��Left=�6+   $��30��6F   $��	35,35,0,0q�5      $	��Top=�6#   $	��180��6;   $��16(�6G   �� 5   
   -   5         ��Name$ ComboBoxAccountForMinus��5   F   $
��Left=�5      $��30��6.   $��
250,35,0,0q�6:   $	��Top=�6N   $	��450��6f   ��5      �� *FirstAccountList+��5      �� 5      .R�5      �� ��6    �� *DisplayValue+5      5      �� 5   
   $+��%Счет для пополнения:��6   $
��Left=�6/   $��30��6J   $��
35,125,0,0q�5      $	��Top=�6$   $	��180��6<   $��16(�6H   �� 5   
   -   5        $# ComboBoxAccountForTransaction��5   L   $
��Left=�5      $��30��6.   $��250,125,0,0q�6:   $	��Top=�6O   $	��450��6g   ��5      �� *SecondAccountList+��5      �� 5      .R�5      �� ��6    �� *DisplayValue+5      5       �� 5"   
   $"��Сумма перевода:��6   $
��Left=�6*   $��30��6E   $��
35,215,0,0q�5#      $	��Top=�6$   $	��180��6<   $��16(�6H   �� 5$   
   -   5         ��Name$ TextBoxTransactionSumm��5%   6   $
��Left=�5$      $��30��6-   $��250,215,0,0q�69    �� TextWrapping$
 Wrap=�6N   $�� ��6b   $	��Top=�5%      $	��450��6*   $��16(�6V   �� 5'   
   -   5        $��Перевести��5'      $
��Left=�6%   $��30��6@   $��230,360,0,0q�6L   $	��Top=�6a   $	��285��5(      $��16(�6   6+   5*      5+      