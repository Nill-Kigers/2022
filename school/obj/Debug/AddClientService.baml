   M S B A M L   `   `   `  ����A  =school, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:schoolschool  5          school.AddClientService   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:school     5        N� Title$  AddClientService��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $��Наименование��6   $��15 0 0 0q�6(   $��Century Gothic)�6:   6X   �� 5!   
   $��Длительность��6   $��1��6(   $��15 0 0 0q�65   $��Century Gothic)�6G   6e   �� 5"   
   $��ФИО��6   $��2��6   $��15 0 0 0q�6,   $��Century Gothic)�6>   6\   �� 5$   
   -   5         ��Name$ Title��5$   ,   $��0��6;   $��1��6H   $	��300��6X   $
��Left=�6d   ��6   �� *Title+6�   �� 5%   
   -   5        $ Duration��5%   8   $��1��6J   $��1��6Z   $	��300��6g   $
��left=�6s   ��6   �� *DurationInSeconds+6�   �� 5&   
   $��2��6   $��1��6    ��5'      `� 5)       �� StringFormat$ {0} {1} {2}��6#   .1�5*      ��  �� Path$ LastName�6"   �� 5+      $ 	FirstName�6"   �� 5,      $ 
MiddleName�6"   5-      50      �� 51   
    �� Orientation$ Vertical=�6   $��2��52      $��30��53      .+�54      &   System.Windows.Controls.Calendar  -   5          Name$ 	calendar1��54         FirstDayOfWeek$ Monday=�6*   $	��165��55   >   	   BlackoutDates	 56      /  )System.Windows.Controls.CalendarDateRange  57      
   Start$
 1/1/2022��6(   
   End$ 
12/31/2022��69   59      �� 5:      $��Дата и время��6   $��Century Gothic)�6,   $��40��6H   $	��200��6T    �� TextAlignment$ Center=�6`   $��Center=�6w   5;      �� 5<   
   -   5        $��BtnSave��5<   T   $��Сохранить��6   $��2��6%   $	��100��6;   $��5��6G   ���	#FFFFE9F9$��	200 5 0 0q�6�   $��Century Gothic)�6�   6�   �� 5=   
   $ Vertical=�6   6.   5>      5?      