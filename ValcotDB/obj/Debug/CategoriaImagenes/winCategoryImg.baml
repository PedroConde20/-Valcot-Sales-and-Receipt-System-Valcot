   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ValcotDB.CategoriaImagenesValcotDB.CategoriaImagenes  5   	   /    )ValcotDB.CategoriaImagenes.winCategoryImg   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ValcotDB.CategoriaImagenes     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A   ���	#FF2E2A25$��2q�6o    � Title$ winCategoryImg��5   	   $	��550��6    $	��800��6-   .��5      � ���	#FF2E2A25.+�5   
   �� .+�5      � ���	#FFE3E1DD$��60��6*   .+�5      � $
��Left=�6   $��0,0,0,-8q�62   $	��288��6D   .+�5      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6D   $
��Left=�6S   $��-34,-20,0,-20q�6n   $	��298��6�   5      �� 5      -   5         ��Name$ btnClose��5      $��30��6+   $��30��66   $��Right=�6B   $	��Top=�6^   $��0q�6�   $
��Bold"�6�   ��6v   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��25��6;   $��25��6F   
���   �6g   5      �� 5      $��Center=�6   $��Center=�67   $��240,16,140,9q�6T   $��30(�6j   
���   �$
��Bold"�6�   $��Franklin Gothic Demi Cond)�6�   ��6�   Z� �� 6�   $� Administrar ��6�   �� 6�   $�Categoria de Vinos��6�   6  5      �� 5       �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5       �� $��Nombre de la Imagen:��6   ���	#FFE3E1DD$��14(�6N   $
��Bold"�6\   $��5q�6n   �� 5!      -   5        	 ��Name$	 txtCategoryWine��5!   1   ���	#FFE3E1DD$	��250��6J   {�.  6V   �� 5"      $��5q�6   $��Categoria a Ingresar:��6#   
�������$
��Bold"�6V   �� 5#      -   5        
 ��Name$
 cbxCategoryWine��5#      {�.  
�������$	��190��6y   6�   5$      �� 5%      $ 
Horizontal=�6   $
��Left=�62   $	��796��6M   $	��116��6Y   .+�5&      �� -   5        $	 txtPhoto��5&   @   {�.  $��	0,0,20,86q�6,   $	��116��6R   �� 5'      $��	0,0,20,86q�6   $��Selecciona una Imagen:��6+   
�������$
��Bold"�6_   �� 5(      -   5        $ btnAgregarImagen��5(   Y   {�.  $��. . .��6+   $��30��6;   $��	20 0 0 0 q�6F   $��30��6�   $��Right=�6�   $	��Top=�6�   ���	#FF2E2A25���	#FF2E2A25$��0q�6  
�������$
��Bold"�6   �� 5)      -   5         ��Name$ imgFoto��5)      $��
10,10,10,0q�6*   $	��181��6>   5*      �� 5+      .+�5,      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvDatos��5,   2   ���	#FFFFEBC3$��auto ��6D   $��10q�6R   $	��180��6^      
IsReadOnly .    CanUserAddRows .  6�   5-      �� 5.      $ 
Horizontal=�6   $��10q�62   $��Center=�6>   .+�5/      �� -	   5        $ 	btnInsert��5/      $��Intertar��6,   $	��110��6?   $��5q�6K   ���	#FF4F17B46n   �� 50      -
   5        $ 	btnUpdate��50      $��	Modificar��6,   $	��110��6@   $��5q�6L   ���	#FF4F17B46o   �� 51      -   5        $ 	btnDelete��51      $��Eliminar��6,   $	��110��6?   $��5q�6K   ���	#FF4F17B46n   �� 52      -   5        $ btnSave��52      $��Guardar��6*   $	��110��6<   $��5q�6H   {�.  ���	#FF027111���	#FF04BD196�   �� 53      -   5        $ btnCancerlar��53      $��Cancelar��6/   $	��110��6B   $��5q�6N   {�.  ���	#FF027111���	#FF04BD196�   54      55      56      57      