   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ValcotDB.ClienteValcotDB.Cliente  5   	   *    $ValcotDB.Cliente.winFindClientByName   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ValcotDB.Cliente     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A   ���	#FF2E2A25$��2q�6o    � Title$ winFindClientByName��5   	   $	��500��6%   $	��600��62   .��5      � ���	#FF2E2A25.+�5   
   �� .+�5      � ���	#FFE3E1DD$��74��6*   .+�5      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6A   $
��Left=�6P   $��250,-10,0,-28q�6k   $	��270��6�   �� 5      -   5         ��Name$ btnClose��5      $��30��6+   $��30��66   $��Right=�6B   $	��Top=�6^   $��0q�6�   $
��Bold"�6�   ��6v   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��30��6;   $��40��6F   
���   �6g   5      5      (  "MaterialDesignThemes.Wpf.ColorZone  5      $��54��6(   ���	#FF2E2A25.��5      �� 
�������$��Center=�6/   $��38(�6J   $
��Bold"�6X   $��	96,0,61,8q�6j   $��Center=�6}   $	��439��6�   �� 6�   $�Busqueda de ��6�   �� 6�   $�Producto��6�   6�   5      �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�66   $��10,10,44,10q�6O   .+�5        $ Account=�6*   $��25��69   $��25��6E   $��5q�6P   �� 5      -   5        	 ��Name$	 txtFind��5   -   
�������$	��212��6>   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Nombre del Producto��6J      
IsFloating . 6�   5       �� 5!      .+�5"      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvDatos��5"   2   ���	#FFFFEBC3$��auto ��6D   $��10q�6R   $	��235��6^      
IsReadOnly .    CanUserAddRows .  6�   5#      �� 5$      $ 
Horizontal=�6   $��Center=�62   .+�5%      �� -   5        $ Select��5%      $��Seleccionar��6)   $	��120��6?   $��10q�6K   ���	#FF0271116n   �� 5&      -   5        $	 txtQuantity��5&   9   $��10q�6   
�������$	��212��6N   $
 Cantidad��6Z    . 6�   5'      5(      5)      5*      