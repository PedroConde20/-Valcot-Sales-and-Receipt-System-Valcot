   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ValcotDBValcotDB  5   	       ValcotDB.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ValcotDB     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowState$ Normal=�5       � WindowStyle$
 None=�6    � Title$ 
MainWindow��5      $	��680��6   $
��1273��6%    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5        menuCollapse �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value  menuOpen��%�  &	       &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ gridMenu��6a   .\�5        $	 0��6'   $	
 120Q�63     5      $	 0:0:0:1��6'   $
 60Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ gridMenu��6a   .\�5        $	 0��6'   $
 60Q�63     5      $	 0:0:0:1��6'   $	
 120Q�69   5      5      5        � Triggers 5"      :� 5#   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ btnCollapseMenu��66   .[�5$      �� #��[ 6   5%      :� 5'   
   $ ButtonBase.Click��6   $ btnOpenMenu��66   .[�5(      �� #��[ 6   5)      .��5+      � ���	#FFFFEBC3.+�5-   
   � -   5         �Name$ gridMain��5-      $
��Auto��6!   $
��Auto��6.   ���	#FFFFEBC3$��0,125,125,0q�6S   .+�5.      �� $��/Imagenes/ValcotWines.PNG��6   $
��auto��67   $
��auto��6E   $��-10,-22,-20,-22q�6R   �� 50       �� Orientation$ 
Horizontal=�6   $��	0,0,0,276q�62   53      �� 54      $ 
Horizontal=�6   $��	0,274,0,0q�62   $��Right=�6E   $
��1143��6a   56      57      � 58   
   $	��120��6   $	��Top=�6   ���#2E2A25$��	0,0,0,400q�6L   .+�59      �� $ 
Horizontal=�6   $
��Left=�62   $��0,68,0,0q�6M   .+�5:      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen .  
�������   PopupContent. 5;      �� $	��180��6!   .+�5<      �� -   5         ��Name$ btnChangePassword��5<   A   $��Cambiar tu contraseña��6!   6\   �� 5=      -   5        $ btnOlvidoPassword��5=   @   $��Olvido de Contraseña��6!   6[   �� 5>      $��Ayuda��6!   �� 5?      -   5        $ btnAcercaDe��5?   !   $��Acerca de...��66   6M   �� 5@      �� 5A      -   5        $ btnSalir��5A   !   $��Salir��63   6C   5B      5C      �� 5D      -   5         ��Name$ txtUserInfo��5D      $��Usuario : admin��61   
�������$��Center=�6[   $��5q�6v   5E      5F      � 5G   
   $��70��6   $	��Top=�6   ���#E3E1DD.+�5H      �� $�� 600 10 10 10q�6   $ 
Horizontal=�60   5I      �� 5J      -   5         ��Name$ lvwMenu��5J      $��
0,10,573,0q�6(   $��Disabled=�6<   $��Right=�6�   $��93��6�   .@�5K      �� -	   5         ��Name$ itemHome��5K      $��60��61   $��93��6=   $��Right=�6H   .��5L      �� $ 
Horizontal=�6"   .+�5M      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�62   $��25��6>   $��25��6I   
���   �$��Center=�6h   6�   �� 5N      $��Inicio��6$   $��Center=�62   $
��Left=�6M   $��16(�6h   $
��Bold"�6v   $��10 0 0 0q�6�   5O      5P      5Q      �� 5R      -
   5        $ 
lvwCliente��5R      $��0,10,456,-8q�6+   $��Disabled=�6@   $��Right=�6�   $	��108��6�   .@�5S      �� -   5        $ 
itemClient��5S      $��60��63   $	��110��6?   $
��Left=�6K   .��5T      �� $ 
Horizontal=�6!   $��96��6:   .+�5U        $ 	UserBadge=�62   $��25��6C   $��25��6N   
���   �$��Center=�6m   6�   �� 5V      -   5        $��Clientes��5V   $   $��Center=�64   $
��Left=�6O   $��16(�6j   $
��Bold"�6x   $��10 0 0 0q�6�   5W      5X      5Y      �� 5Z      -   5        $ lvwStock��5Z      $��797,10,381,0q�6)   $��Disabled=�6?   $��Right=�6�   $��93��6�   .@�5[      �� -   5        $ 	itemStock��5[       $��60��63   
���   �$��98��6R   $
��Left=�6]   .��5\      �� $ 
Horizontal=�6!   .+�5]        $ 
BottleWine=�62   $��31��6D   $��25��6O   
���   �$��Center=�6n   6�   �� 5^      $��Stock��6$   $��Center=�61   $
��Left=�6L   $��16(�6g   $
��Bold"�6u   $��10 0 0 0q�6�   5_      5`      5a      �� 5b      -   5        $ lvwTransacciones��5b      $��
0,10,227,0q�61   $��Disabled=�6|   $��Right=�6�   $	��149��6�   .@�5c      �� -   5        $ itemTransacciones��5c      $��60��6:   
���   �$	��164��6Y   .��5d      �� $ 
Horizontal=�6!   .+�5e        $ Money=�62   $��25��6?   $��25��6J   
���   �$��Center=�6i   6�   �� 5f      $��Transacciones��6$   $��Center=�69   $
��Left=�6T   $��16(�6o   $
��Bold"�6}   $��10 0 0 0q�6�   5g      5h      5i      �� 5j      -   5        $ lvwUsuarios��5j      $��	0,10,77,0q�6,   $��Disabled=�6?   $��Right=�6�   $	��119��6�   .@�5k      �� -   5        $ itemUsuarios��5k      $��60��65   
���   �$	��131��6T   .��5l      �� $ 
Horizontal=�6!   .+�5m        $
 User=�62   $��25��6>   $��25��6I   
���   �$��Center=�6h   6�   �� 5n      -   5        $��Usuario��5n   $   $��Center=�63   $
��Left=�6N   $��16(�6i   $
��Bold"�6w   $��10 0 0 0q�6�   6�   5o      5p      5q      � 5r      $
��Left=�6   $��0,0,0,-8q�6.   $	��288��6@   .+�5s      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6@   $
��Left=�6O   $��0,0,0,-14.778q�6j   $	��259��6�   5t      5u      � 5v   
   -   5        $ gridMenu��5v      $	��125��6!   $��Right=�6-   ���#2E2A25$��	0,120,0,0q�6^   .+�5w      �� .+�5x      � $	��136��6   .+�5y      �� -   5        $ btnCollapseMenu��5y      $��60��66   $��33��6A   $��Right=�6M   $	��Top=�6i   ��6�   Z� ��6�   Z� .��5z        $ 
ArrowRight=�62   $��25��6D   $��25��6O   
���   �6p   5{      �� 5}      -   5        $ btnOpenMenu��5}      $��60��62   $��60��6=   $��Right=�6I   $	��Top=�6e   $y�	Collapsed=�6�   ��6}   Z� ��6�   Z� .��5~        $
 Menu=�62   $��25��6>   $��25��6I   
���   �6j   5      �� 5�      -   5         ��Name$ 	imgValcot��5�      $��/imagenes/VALCO.ico��6/   $��	0,33,0,10q�6L   5�      5�      �� 5�      -   5        $ lvwMenu2��5�      $��Disabled=�6)   $��0,127,52,361q�6�   .@�5�      �� -   5        $ itemA��5�      .��5�      �� -   5        $ 
btnTiendas��5�      $
��Left=�6J   $	��Top=�6e   $��53��6}   ���	#FF4F17B4���	#FF2B0869$��52��6�   .��5�        $ ShoppingCart=�62   $��25��6F   $��25��6Q   
�������$��Center=�6p   6�   5�      5�      5�      �� 5�      -   5        $ lvwMenuC��5�      $��Disabled=�6*   $��0,180,52,231q�6`   .@�5�      �� -   5        $ itemC��5�      .��5�      �� -   5        $
��Left=�5�   9   $	��Top=�6T   $��53��6l   $	��118��6w   ���	#FF027111���	#FF014204.��5�        $ Planet=�62   $��22��6@   $��25��6K   
�������$��Center=�6j   6�   5�      5�      5�      �� 5�      $��Disabled=�6   $��54,127,0,354q�6N   .@�5�      �� -   5        $ itemB��5�      .��5�      �� $��B��6   $
��Left=�6)   $	��Top=�6D   $��51��6\   $��51��6g    J� RenderTransformOrigin$ 1.113,0.299&�6s   ���	#FF2B0869���	#FF4F17B46�   5�      5�      �� 5�      $��Disabled=�6   $��54,180,0,293q�6N   .@�5�      �� -   5        $ itemD��5�      .��5�      �� -    5        $ 
btnReports��5�   )   $��D��6   $
��Left=�6V   $	��Top=�6q   $��51��6�   $��61��6�   ���	#FF006B05���	#FF012D036�   5�      5�      �� 5�      $��Disabled=�6   $��54,242,0,241q�6N   .@�5�      �� -!   5        $ itemE��5�      $��69��6.   $��72��69   $ 0.5,0.5&�6E   z�5�      V� 5�      .~�5�      �� �� 5�       �� AngleY$ 0.239Q�6,   �� 5�      T� 5�       T� Y$ 0.162Q�61   5�      .��5�      �� -"   5        $
��Left=�5�   5   $	��Top=�6P   $��59��6h   $��56��6s   ���	#FF006B05���	#FF002602.��5�        $ BottleCokeClassic=�62   $��25��6K   $��25��6V   
�������$��Center=�6u   6�   5�      5�      5�      5�      5�      5�      