   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ValcotDB.TransaccionesValcotDB.Transacciones  5   	   h dSAPBusinessObjects.WPF.Viewer, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304tRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.ViewerSAPBusinessObjects.WPF.Viewer 5   	   +    %ValcotDB.Transacciones.winTransaction   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ValcotDB.Transacciones     5   	   amyRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.Viewer     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5           MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A   ���	#FF2E2A25$��2q�6o    � Title$ winTransaction��5   	   $��807.883��6    $��1321.038��61   .��5      � ���	#FF2E2A25.+�5   
   �� .+�5      � ���	#FFE3E1DD$��60��6*   .+�5      � $
��Left=�6   $��0,0,0,-8q�62   $	��288��6D   .+�5      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6D   $
��Left=�6S   $��-34,-20,0,-20q�6n   $	��298��6�   5      �� 5      -   5         ��Name$ btnClose��5      $��30��6+   $��30��66   $��Right=�6B   $	��Top=�6^   $��0q�6�   $
��Bold"�6�   ��6v   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��25��6;   $��25��6F   
���   �6g   5      �� 5      -   5         ��Name$ txtTitle��5      $��Detalles de la Compra��6.   $��Center=�6K   $��Center=�6f   $��10q�6�   $��30(�6�   
���   �$
��Bold"�6�   $��Franklin Gothic Demi Cond)�6�   ��6�   Z� 6�   5      � 5       $��10q�6   	 � ColumnDefinitions	 5!      �� 5"      �� 5#      .+�5%      � 	 5&      �� 5'      �� 5(      
 � RowDefinitions
 5*      �� 5+      �� 5,      �� 5-      �� 5.      �� 5/      .+�54      �� $��	5,11,5,10q�6   $��Cliente:��6/   
�������$
��Bold"�6U   �� 55      -   5         ��Name$ 	cbxClient��55   =   
�������$��5q�62   $��1��6Q   6}   �� 58      $��1��6   $��	5,11,5,10q�6)   $��Tienda:��6<   
�������$
��Bold"�6a   $y�	Collapsed=�6s   �� 59      -   5        $ cbxStore��59   K   
�������$��1��62   $��5q�6@   $��1��6^   $y�	Collapsed=�6n   6�   �� 5;      $��20��6   $��5q�6(   $��2��63   $��Fecha de Venta:��6@   
�������$
��Bold"�6m   (  "System.Windows.Controls.DatePicker  5<      -   5          Name$ dtpSalePicker��5<   F   $��30��6!   $��5q�6-   $��2��69   $��1��6]   6o   �� 5=      -   5        $ btnSave��5=   +   $��3��6   $��Guardar��6<   $	��110��6N   $��5q�6Z   ���	#FF027111���	#FF04BD196�   �� 5>      -   5        $ btnCancerlar��5>   X   $��Center=�6   $��1��6:   $��3��6K   $��Cancelar��6n   $	��110��6�   $��5q�6�   ���	#FF027111���	#FF04BD196�   �� 5?      -	   5        $ 	btnRecibo��5?   o   $��Center=�6   $��1��6:   $��5��6K   $y�	Collapsed=�6X   $��Recibo��6�   $	��110��6�   $��5q�6�   ���	#FF027111���	#FF04BD196�   5@      �� 5A      $��1��6   .+�5B      �� 
�������$)��#SELECCIONE LOS PRODUCTOS A INGRESAR��6/   $
��10,0q�6]   $��14(�6k   $
��Bold"�6y   &   System.Windows.Controls.DataGrid  5C      -
   5          Name$ dgvDatos��5C   6   ���	#FFFFEBC3$��auto ��6H   $��11,10,-1,10q�6V   $	��300��6k      AutoGenerateColumns .     
IsReadOnly .    CanUserAddRows .  ��6  �� *productList+   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      -   5        
dgcProduct��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5E   E      
Visibility$ 	Collapsed=�6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6i   �� *WineID+  5F      -   5        dgcQuantity��$ Cantidad��5F   F    6X   �� *	Quantiy+  5G      -   5        dgcProductName��$ Producto��5G   I      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6[    6g   �� *ProductDescription+  5H      -   5        dgcUnitPrice��$ Precio Unitario��5H   G    6`   �� *Price+ � ContextMenu 5K      �� 5L      .@�5M   "   m� -   5         m�Name$ mitAddProduct��5M   +   $��Agregar Producto��6B   6\   m� 5N   "   -   5        $ 	mitDelete��5N   +   $��Eliminar Producto��6>   6Y   m� 5O   "   -   5        $ mitClear��5O   +   $��Eliminar Todo��6=   6T   5P      5R      5S      5U      8	  2SAPBusinessObjects.WPF.Viewer.CrystalReportsViewer	  5V      -   5         	 Name$ viewer��5V   =   $y�	Collapsed=�6&   $	��602��6M   5W      �� 5X   
   -   5         ��Name$
 Logo��5X      $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6F   $
��Left=�6U   $��	0,408,0,0q�6p   $
��1317��6�   5Y      5Z      