   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ValcotDB.StockValcotDB.Stock  5   	   $    ValcotDB.Stock.winIngresoVinos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ValcotDB.Stock     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A   ���	#FF2E2A25$��2q�6o    � Title$ winIngresoVinos��5   	   $	��500��6!   $	��800��6.   .��5      � ���	#FFFFEBC3.+�5   
   �� .+�5      � ���	#FFE3E1DD$��60��6*   .+�5      � $
��Left=�6   $��0,0,0,-8q�62   $	��288��6D   .+�5      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6D   $
��Left=�6S   $��-34,-20,0,-20q�6n   $	��298��6�   5      �� 5      -   5         ��Name$ btnClose��5      $��30��6+   $��30��66   $��Right=�6B   $	��Top=�6^   $��0q�6�   $
��Bold"�6�   ��6v   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��25��6;   $��25��6F   
���   �6g   5      �� 5      -   5         ��Name$ txtTitle��5      $�� _______ Tipos de Vinos��6.   $��Center=�6M   $��Center=�6h   $��10q�6�   $��30(�6�   
���   �$
��Bold"�6�   $��Franklin Gothic Demi Cond)�6�   ��6�   Z� 6�   5      � 5      $��10q�6   	 � RowDefinitions	 5      �� 5       $	��70* �6$   �� 5!      $
��135* �6$   �� 5"      $
��204* �6$   
 � ColumnDefinitions
 5$      �� 5%      �� 5&      .+�5)      �� ���	#FFFFEBC3$��3��64   .+�5*      � 
 5+      �� 5,      �� 5-      	 5/      �� 50      �� 51      �� 52      �� 53      �� 54      �� 55      �� 56      �� 57      .+�5:      �� $��Categoria de Vino:��6    
���   �$
��Bold"�6P   �� 5;      -   5         ��Name$ cbxCategoryWine��5;   #   {�.  $��1��6N   6�   �� 5=      $��1��6    $��Nombre del Vino:��6-   
���   �$
��Bold"�6[   �� 5>      -   5         ��Name$ txtNombreVino��5>   A   {�.  $��1��64   $��1��6X   6j   �� 5@      $��2��6    $��Precio(Bs):��6-   
���   �$
��Bold"�6V   �� 5A      -   5        $ 	txtPrecio��5A   A   {�.  $��2��64   $��1��6T   6f   �� 5C      $��3��6    $��Stock:��6-   
���   �$
��Bold"�6Q   �� 5D      -   5        $ txtStock��5D   A   {�.  $��3��64   $��1��6S   6e   �� 5F      $��4��6    $��Descripcion:��6-   
���   �$
��Bold"�6W   �� 5G      -   5        $ txtDescripcion��5G   W   {�.  $��2��64   $��5��6I    �� TextWrapping$
 Wrap=�6p    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6�   6�   5H      �� 5I      $��10q�6!   .+�5J      ��  �� Orientation$ 
Horizontal=�6%   $��Right=�6?   $	��358��6[   .+�5K      �� -	   5        $ txtPhoto��5K   K   {�.  $��0 0 20 0q�68   $	��116��6]   �� 5L      $��0 0 20 0q�6$   $��Selecciona una Imagen:��66   
���   �$
��Bold"�6j   �� 5M      -
   5        $ btnAgregarImagen��5M   e   {�.  $��. . .��67   $��30��6G   $��	20 0 0 0 q�6R   $��30��6�   $��Right=�6�   $	��Top=�6�   ���	#FF2E2A25���	#FF2E2A25$��0q�6  
�������$
��Bold"�6,  5N      �� 5P      -   5         ��Name$ imgFoto��5P       $��10q�62   $	��120��6?   6N   5Q      5R      �� 5S      ���	#FF2E2A25$��1��64   $��3��6D   .+�5T      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvDatos��5T   6   ���	#FFFFEBC3$��auto ��6H   $��10q�6V   $	��300��6b      
IsReadOnly .    CanUserAddRows .  6�   5U      5V      �� 5W      $ 
Horizontal=�6   $��Right=�62   .+�5X      �� -   5        $ btnSave��5X      $��10q�6*   $��Guardar��67   $��84��6_   ���	#FF0271116j   �� 5Y      -   5        $ btnCancelar��5Y      $��10q�6.   $��Cancelar��6:   $��80��6M   ���	#FF0271116o   �� 5Z      -   5        $ btnInsertar��5Z      $��10q�6.   $��Insertar��6:   $��85��6M   6X   �� 5[      -   5        $ 	btnUpdate��5[      $��10q�6,   $��	Morificar��69   6M   �� 5\      -   5        $ 	btnDelete��5\      $��Eliminar��6-   6@   5]      5^      5_      5`      