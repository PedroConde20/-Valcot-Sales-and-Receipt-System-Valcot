   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ValcotDB.UsuariosValcotDB.Usuarios  5           ValcotDB.Usuarios.Usuarios   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ValcotDB.Usuarios     5      b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5           MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � 
�������.+�5   
   � $��61��6   $	��Top=�6   ���	#FFFFEBC3.+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��0,10,0,0q�6M   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Tools=�6*   $��66��67   $��48��6B   
���   �$��Center=�6a   $��0,0,0,8q�6|   6�   �� 5      $��Configuracion��6   $��Center=�61   $
��Left=�6L   $��20(�6g   $
��Bold"�6u   $��	10,10,0,5q�6�   $��31��6�   $	��142��6�   5      5      �� 5   
   $��0,61,0,0q�6   ���	#FFFFEBC3.+�5      �� $ 
Horizontal=�6   $��10q�62   $��Center=�6>   .+�5      �� $��Nombre:��6   
���   �$��14(�6=   $
��Bold"�6K   $��5q�6]   $��30��6h   �� 5      -   5         ��Name$ 	txtNombre��5      $	��111��6.   {�.  $��5q�6L   $��25��6W   �� 5      $��	Apellido:��6   
���   �$��14(�6?   $
��Bold"�6M   $��5q�6_   $��35��6j   �� 5      -   5        $ txtApellido��5      $	��111��60   {�.  $��5q�6N   $��27��6Y   �� 5      $
��Rol:��6   
���   �$��14(�6:   $
��Bold"�6H   $��5q�6Z   $��38��6e   �� 5       -   5        $ txtRol��5       $	��102��6+   {�.  $��5q�6I   $��33��6T   �� 5!      $��E-Mail:��6   
���   �$��14(�6=   $
��Bold"�6K   $��5q�6]   $��32��6h   �� 5"      -   5        $ txtemail��5"      $	��162��6-   {�.  $��5q�6K   $��26��6V   �� 5#      -   5        $
��Foto��5#   D   
���   �$��14(�6f   $
��Bold"�6t   $��5q�6�   $��28��6�   �� 5$      -   5         ��Name$ btnFoto��5$      $��
Sacar Foto��6+   $	��100��6@   $��5q�6L   6W   �� 5%      -   5         ��Name$ image1��5%      $	��200��6(   $	��152��64   5'      �� 5(      $ 
Horizontal=�6   $��10q�62   $��Center=�6>   .+�5)      �� -	   5        $��Nombre de Usuario��5)   D   
���   �$��14(�6s   $
��Bold"�6�   $��5q�6�   �� 5*      -
   5        $ txtNombreusuario��5*      $	��128��65   {�.  $��5q�6S   �� 5+      -   5        $��Contraseña:��5+   F   
���   �$��14(�6o   $
��Bold"�6}   $��5q�6�   �� 5,      -   5        $ txtContraseña��5,      $��98��62   {�.  $��5q�6O   �� 5-      $	��CI:��6   
���   �$��14(�69   $
��Bold"�6G   $��5q�6Y   �� 5.      -   5        $ txtCi��5.      $	��102��6*   {�.  $��5q�6H   �� 5/      $��	5,11,5,10q�6   $��Dispositivo:��6+   $
��Bold"�6C   �� 50      -   5         ��Name$ cbxDispositivo��50   /   
�������$��31��6G   $	��175��6S   �� 51      -   5        $ 	btnCargar��51      $��Cargar��6-   $	��100��6>   $��5q�6J   6U   52      �� 54      .+�55      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvDatos��55   C   
���   ����#795548$��auto ��6U   $
��0,10q�6c   $	��125��6q   	   
IsReadOnly	 . 
   CanUserAddRows
 .  6�   56      �� 57      $ 
Horizontal=�6   $��10q�62   .+�58      �� -   5        $ 	btnInsert��58      $��Intertar��6,   $	��110��6?   $��5q�6K   ���	#FF4F17B46n   �� 59      -   5        $ 	btnUpdate��59      $��	Modificar��6,   $	��110��6@   $��5q�6L   ���	#FF4F17B46o   �� 5:      -   5        $ 	btnDelete��5:      $��Eliminar��6,   $	��110��6?   $��5q�6K   ���	#FF4F17B46n   �� 5;      -   5        $ btnSave��5;      $��Guardar��6*   $	��110��6<   $��5q�6H   {�.  ���	#FF027111���	#FF04BD196�   �� 5<      -   5        $ btnCancerlar��5<      $��Cancelar��6/   $	��110��6B   $��5q�6N   {�.  ���	#FF027111���	#FF04BD196�   5=      5>      5?      5@      