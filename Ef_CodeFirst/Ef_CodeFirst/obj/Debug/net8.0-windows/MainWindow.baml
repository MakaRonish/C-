   M S B A M L   `   `   `  ����G  CEf_CodeFirst, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Ef_CodeFirstEf_CodeFirst  5   	       Ef_CodeFirst.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Ef_CodeFirst     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grdStudents��5
      $	��356��6(   $	��368��65    �� Left$ 32��6A   
 �� Top$ 35��6R      
IsReadOnly$
 True��6b   �� 5   
   -   5         ��Name$ btnLoadData��5      $��	Load Data��6&   $	 434��6:   $ 35��6L   $��40��6\   $	��187��6h   $��20(�6t   $
��Bold"�6�   �� 5   
   -   5        $ 	btnInsert��5      $��Insert��6$   $	 434��65   $	 351��6G   $��40��6X   $��94��6d   $��20(�6o   $
��Bold"�6}   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $	 553��65   $	 351��6G   $��40��6X   $��94��6d   $��20(�6o   $
��Bold"�6}   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $	 674��65   $	 351��6G   $��40��6X   $��94��6d   $��20(�6o   $
��Bold"�6}   �� 5   
   -   5        $ btnClearData��5      $��
Clear Data��6'   $	 650��6<   $ 35��6N   $��40��6^   $	��118��6j   $��20(�6v   $
��Bold"�6�   �� 5   
   $��ID��6   $	 495��6   $	 142��6/   $��20(�6@   $
��Bold"�6N   $��Center=�6`   $��Center=�6}   �� 5   
   $
��Name��6   $	 460��6   $	 192��61   $��20(�6B   $
��Bold"�6P   $��Center=�6b   $��Center=�5      �� 5   
   -   5         ��Name$ txtId��5      $	 532��6!   $	 146��63    �� TextWrapping$
 Wrap=�6D   $��89��6X   $��20(�6c   $
��Bold"�6q   $��Center=�5      $��Center=�6   �� 5   
   -	   5        $ txtName��5      $	 532��6#   $	 200��65   $
 Wrap=�6F   $��89��6Z   $��20(�6e   $
��Bold"�6s   $��29��6�   $��Center=�5      $��Center=�6   �� 5   
   -
   5        $ btnFind��5      $
��Find��6"   $	 650��61   $	 146��6C   $��29��6T   $	��118��6`   $��20(�6l   $
��Bold"�6z   $��Center=�5      $��Center=�6   69   �� 5   
   -   5        $ 	btnSearch��5      $��Search��6$   $	 650��65   $	 200��6G   $��29��6X   $	��118��6d   $��20(�6p   $
��Bold"�6~   $��Center=�5      $��Center=�6   �� 5   
   $��Standard��6   $	 431��6#   $	 250��65   $��20(�6F   $
��Bold"�6T   $��Center=�6f   $��Center=�5      �� 5   
   -   5         ��Name$ cmbStandard��5      $	 532��6(   $	 254��6:   $	��236��6K   $��20(�6W   $
��Bold"�6e   $��Center=�6w   $��Center=�5      5      5       