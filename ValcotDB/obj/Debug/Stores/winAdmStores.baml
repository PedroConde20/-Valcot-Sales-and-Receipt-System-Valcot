   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5   	   C ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ValcotDB.StoresValcotDB.Stores 5   	   "   ValcotDB.Stores.winAdmStores   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   /localclr-namespace:ValcotDB.Stores     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
   -   5           MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A   ���	#FF2E2A25$��2q�6o    � Title$ winAdmStores��5   	   $	��700��6   $
��1100��6+   .��5      � ���	#FFFFEBC3.+�5   
   �� .+�5      � ���	#FFE3E1DD$��60��6*   .+�5      � $
��Left=�6   $��0,0,0,-8q�62   $	��288��6D   .+�5      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6D   $
��Left=�6S   $��-34,-20,0,-20q�6n   $	��298��6�   5      �� 5      -   5         ��Name$ btnClose��5      $��30��6+   $��30��66   $��Right=�6B   $	��Top=�6^   $��0q�6�   $
��Bold"�6�   ��6v   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��25��6;   $��25��6F   
���   �6g   5      �� 5      $#�� Administrar Tiendas de Envio��6   $��Center=�6A   $��Center=�6\   $��10q�6y   $��30(�6�   
���   �$
��Bold"�6�   $��Franklin Gothic Demi Cond)�6�   ��6�   Z� 6�   5      � 5       $��10q�6    � RowDefinitions 5!      �� 5"      $	��70* �6$   �� 5#      $
��135* �6$   �� 5$      $
��204* �6$   	 � ColumnDefinitions	 5&      �� 5'      �� 5(      .+�5+      �� ���	#FFFFEBC3$��3��64   .+�5,      � 	 5-      �� 5.      �� 5/       51      �� 52      �� 53      �� 54      �� 55      �� 56      �� 57      �� 58      �� 59      .+�5;      �� $��Nombre de la Tienda:��6    
���   �$��14(�6R   $
��Bold"�6`   $��5q�6r   �� 5<      -   5        
 ��Name$
 txtNombreTienda��5<   #   $	��200��6<   {�.  $��5q�6Z   $��1��6e   �� 5>      $��1��6    $��
Direccion:��6-   
���   �$��14(�6U   $
��Bold"�6c   $��5q�6u   �� 5?      -   5        $
 txtDireccion��5?   ?   $��1��6"   $��1��6/   $	��200��6U   {�.  $��5q�6s   �� 5A      $��2��6    $��E-Mail:��6-   
���   �$��14(�6R   $
��Bold"�6`   $��5q�6r   �� 5B      -   5        $
 txtemail��5B   @   $��2��6"   $��1��6/   $	��200��6R   {�.  $��5q�6p   �� 5C      $��3��6    $��Latitud:��6-   
���   �$��14(�6S   $
��Bold"�6a   $��5q�6s   �� 5D      -   5        $
 
txtLatitud��5D   /   $��3��6"   {�.  $��	80,5,35,5q�6U   �� 5E      $��3��6    $��	Longitud:��6-   $��1��6A   
���   �$��14(�6d   $
��Bold"�6r   $��5q�6�   �� 5F      -   5        $
 txtLongitud��5F   @   $��3��6"   $��1��6/   {�.  $��	79,5,21,5q�6g   &   System.Windows.Controls.DataGrid  5G      -   5          Name$ dgvDatos��5G   [   $��4��6#   $��2��60   ���	#FFFFEBC3$��auto ��6m   $��10q�6{   $	��300��6�      
IsReadOnly .    CanUserAddRows .  6�   �� 5H      -	   5        $ 	btnInsert��5H   .   $��5��6!   $��Intertar��6A   $	��110��6T   $��5q�6`   ���	#FF4F17B46�   �� 5I      -
   5        $ 	btnUpdate��5I   >   $��5��6!   $��1��6.   $��	Modificar��6Q   $	��110��6e   $��5q�6q   ���	#FF4F17B46�   �� 5J      -   5        $ 	btnDelete��5J   .   $��6��6!   $��Eliminar��6A   $	��110��6T   $��5q�6`   ���	#FF4F17B46�   �� 5K      -   5        $ btnSave��5K   >   $��6��6!   $��1��6.   $��Guardar��6O   $	��110��6a   $��5q�6m   {�.  ���	#FF027111���	#FF04BD196�   �� 5L      -   5        $ btnCancerlar��5L   _   $��Center=�6!   $��2��6>   $��6��6R   $��Cancelar��6u   $	��110��6�   $��5q�6�   {�.  ���	#FF027111���	#FF04BD196�   5M      5N      �� 5P      ���	#FF2E2A25$��1��64   $��3��6D   .+�5Q      '   !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$ MyMap��5Q   F   $	��500��6U   +   %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT   NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AgCcfwhRHX5lWgbPQYdrqWIC5jeyCuf06OH_b3Bnj6ZaLDFtoTm6iH13w06FBQh7 6b      Center<   6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ -17.392174, -66.159075 6�      	ZoomLevel$ 14Q�6�   �� 5R       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5S      �� -   5        $ btnAereo��5S   !   $��10q�63   $��Aereo��6@   $��84��6g   ���	#FF0271116r   �� 5T      -   5        $ 	btnCalles��5T   !   $��10q�64   $��Calles��6@   $��80��6i   ���	#FF0271116t   �� 5U      -   5        $ 
btnzoommas��5U   !   $��10q�65   $��Zoom +��6A   $��85��6R   6]   �� 5V      -   5        $ btnzoommenos��5V   !   $��10q�67   $��Zoom -��6D   6U   5W      5Y      5Z      5\      5]      5^      