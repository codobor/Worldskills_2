   M S B A M L   `   `   `  ����C  ?hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:hospitalhospital  5   	       hospital.Clients   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:hospital     5   	     � Title$  Patients��5   	   $	��450��6   $	��800��6'   .��5	      � $	��419��6   $��Bottom=�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridClients��5
      ���	#FFFBDED1   AutoGenerateColumns .  $
��0,60q�6_      
IsReadOnly . $
��Left=�6   $	��792��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
clientID+6B     5      $ Фамилия��6A    6%   �� *	Surname+6A     5      $ Имя��6>    6%   �� *Name+6>     5      $ Паспорт��6B    6%   �� *
Passport+6B     5      $ ОМС��6=    6%   �� *OMS+6=     5      $ Профессия��6=    6%   �� *Job+6=   5      �� 5   
   -   5         ��Name$ buttonDelete��5      $��Удалить��6'   $
��Left=�69   $��450,380,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ 
buttonEdit��5      $��Изменить��6%   $
��Left=�68   $��350,380,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ 	buttonAdd��5      $��Добавить��6$   $
��Left=�67   $��250,380,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $ buttonRefresh��5      $��Обновить��6(   $
��Left=�6;   $��
130,20,0,0q�6V   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $ 
buttonBack��5      $��
Назад��6%   $
��Left=�65   $��	30,20,0,0q�6P   $	��Top=�6c   $��75��6{   6�   5      5      