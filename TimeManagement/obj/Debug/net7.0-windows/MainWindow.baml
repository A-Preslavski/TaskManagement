   M S B A M L   `   `   `  ����I  ETimeManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TimeManagementTimeManagement  5   	       TimeManagement.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TimeManagement     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1600��6)   .��5	      ��  +� FocusedElement 6   ��  �� ElementName$	 Box��.+�5
   
   � .+�5      �� $
��Left=�6   $	��673��63   $��
950,57,0,0q�6@   
���   �$	��Top=�6c   $	��613��6{   �� 5      -   5         ��Name$ 
TaskHeader��5      $
��Left=�6*   $	��165��6E   $��
977,70,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��556��6�   6�   �� 5      -   5        $ TaskDescription��5      $
��Left=�6/   $	��213��6J   $��977,240,0,0q�6W   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��556��6�   6�   �� 5      -   5         ��Name$ 
SaveButton��5      $��Запази��6)   $
��Left=�6:   $��36��6U   $��1242,676,0,0q�6a   $	��Top=�6w   $	��142��6�   6�   �� 5      -   5        $ DeleteButton��5      $��Изтрий��6+   $
��Left=�6<   $��1394,676,0,0q�6W   $	��Top=�6m   $��36��6�   $	��139��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	TasksGrid��5         AlternatingRowBackground
 ��ح�$��10,57,655,0q�6g   ��6*   �� 6|   �� 5      -   5        $ 
LoadButton��5      $��Зареди��6)   $
��Left=�6:   $��	10,18,0,0q�6U   $	��Top=�6h   $��28��6�   $��94��6�   �� 5      -   5        $ FromTimeText��5      $
��Left=�6,   $��977,492,0,0q�6G   $
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��279��6�   $��60��6�   6�   �� 5      -   5        $ 
ToTimeText��5      $
��Left=�6*   $��1261,492,0,0q�6E   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��272��6�   $��60��6�   6�   �� 5      $��От:��6   $
��Left=�6"   $��977,458,0,0q�6=   $	��Top=�6R   $��34��6j   $	��101��6v   �� 5      $��До:��6   $
��Left=�6"   $��1261,458,0,0q�6=   $	��Top=�6S   $��34��6k   $	��101��6w   5      5      5      