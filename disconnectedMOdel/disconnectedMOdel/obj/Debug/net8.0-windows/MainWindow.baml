   M S B A M L   `   `   `  ����L  HdisconnectedMOdel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:disconnectedMOdeldisconnectedMOdel  5   	   "    disconnectedMOdel.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:disconnectedMOdel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grdProducts��5
      $	��356��6(   $	��368��65    �� Left$ 32��6A   
 �� Top$ 35��6R   �� 5   
   -   5         ��Name$ btnLoadAllProducts��5      $��Load All Products��6-   $	 434��6I   $ 35��6[   $��40��6k   $	��187��6w   $��20(�5      $
��Bold"�6   6!   �� 5   
   $��ID��6   $	 495��6   $	 110��6/   $��20(�6@   $
��Bold"�6N   �� 5   
   $
��Name��6   $	 460��6   $	 152��61   $��20(�6B   $
��Bold"�6P   �� 5   
   $��Price��6   $	 470��6    $	 194��62   $��20(�6C   $
��Bold"�6Q   �� 5   
   $��Quantity��6   $	 434��6#   $	 236��65   $��20(�6F   $
��Bold"�6T   �� 5   
   -   5         ��Name$ txtId��5      $	 532��6!   $	 114��63    �� TextWrapping$
 Wrap=�6D   $��89��6X   $��20(�6c   $
��Bold"�6q   �� 5   
   -   5        $ txtName��5      $	 532��6#   $	 160��65   $
 Wrap=�6F   $	��236��6Z   $��20(�6f   $
��Bold"�6t   �� 5   
   -   5        $ txtPrice��5      $	 531��6$   $	 202��66   $
 Wrap=�6G   $	��237��6[   $��20(�6g   $
��Bold"�6u   �� 5   
   -   5        $ txtQuantity��5      $	 532��6'   $	 244��69   $
 Wrap=�6J   $	��236��6^   $��20(�6j   $
��Bold"�5      �� 5   
   -   5        $ btnFind��5      $
��Find��6"   $	 650��61   $	 114��6C   $��29��6T   $	��118��6`   $��20(�6l   $
��Bold"�5      6   �� 5   
   -   5        $ 	btnInsert��5      $��Insert��6$   $	 434��65   $	 294��6G   $��40��6X   $��94��6d   $��20(�6o   $
��Bold"�5      6   �� 5   
   -	   5        $ 	btnUpdate��5      $��Update��6$   $	 553��65   $	 294��6G   $��40��6X   $��94��6d   $��20(�6o   $
��Bold"�5      6   �� 5   
   -
   5        $ 	btnDelete��5      $��Delete��6$   $	 674��65   $	 294��6G   $��40��6X   $��94��6d   $��20(�6o   $
��Bold"�5      6   �� 5   
   -   5        $ btnClearData��5      $��
Clear Data��6'   $	 650��6<   $ 35��6N   $��40��6^   $	��118��6j   $��20(�6v   $
��Bold"�5      �� 5    
   -   5        $ btnShowWindow2��5       $��Show Window 2��6)   $	 433��6A   $	 351��6S   $��40��6d   $	��334��6p   $��20(�5!      $
��Bold"�6   6!   5"      5#      