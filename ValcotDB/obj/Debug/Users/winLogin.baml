   M S B A M L   `   `   `  ����C  ?ValcotDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ValcotDB.UsersValcotDB.Users  5   	       ValcotDB.Users.winLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ValcotDB.Users     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.1.2567, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  winLogin��5   	   $	��500��6   $	��700��6'    � WindowStartupLocation$ CenterScreen=�63   
������� � 
ResizeMode$ NoResize=�6l      MaterialDesignBody#���   5
   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � WindowState$ Normal=�5       � WindowStyle$
 None=�6"   .��5      � ���	#FFF3E0BA.+�5   
   �� .+�5      � ���	#FFE3E1DD$��74��6*   .+�5      �� $$��/Imagenes/VALCOTSOLOLETRAS.png��6   $
��Fill=�6@   $
��Left=�6O   $��208,-10,0,-28q�6j   $	��270��6�   �� 5      -   5         ��Name$ btnClose��5      $��30��6+   $��30��66   $��Right=�6B   $	��Top=�6^   $��0q�6�   $
��Bold"�6�   ��6v   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��30��6;   $��40��6F   
���   �6g   5      5      (  "MaterialDesignThemes.Wpf.ColorZone  5      $��54��6(   ���	#FF2E2A25.��5      �� $��
Bienvenido��6   
�������$��Center=�6A   $��38(�6\   $
��Bold"�6j   $��
248,4,10,4q�6|   5      �� 5      $��227,10,207,10q�6   $	��281��60   ���	#FFFFEBC3.+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��10,10,44,10q�66   .+�5        $ Account=�6.   $��25��6=   $��25��6I   $��5q�6T   �� 5       -   5        
 ��Name$
 txtUser��5       $	��212��6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre de Usuario��6;      
IsFloating . 6n   5!      �� 5#      $	 
Horizontal=�6   $��10,10,44,10q�66   .+�5$        $	 Key=�6.   $��25��69   $��25��6E   $��5q�6P   G� 5%      -   5         G�Name$ txtPassword��5%   "   $	��218��67   $ Contraseña��6C    . 6o   5&      �� 5'      $	 
Horizontal=�6   $
��Left=�66   $��20q�6Q   .+�5(      �� -   5        $ btnLogin��5(      $��Ingresar��6/   $	��120��6B   $��0 0 10 0q�6N   6`   5)      5*      )  #MaterialDesignThemes.Wpf.DialogHost  5-      -   5          Name$ dhChangePassword��5-   N   $y�	Collapsed=�6(      IsOpen .     DialogContent 5.      �� 5/      $	��250��6!   $	��250��6.   $��Center=�6:   $��Center=�6U   .+�50      �� $��20q�6$   $%��DEBES ACTUALIZAR TU CONTRASEÑA��60   $��Center=�6V    �� TextAlignment$ Center=�6s   $��Bottom=�6�   $
��Wrap=�6�   6�   G� 51      -   5        $ pwNewPassword��51   &   $ Nueva Contraseña��6=    . $��40��6�   
���   �6�   G� 52      -   5        $ pwConfirmPassword��52   &   $ CONRIFMAR CONTRASEÑA��6A    . $��40��6�   
���   �6�   �� 53      -   5        $ 	btnChange��53   !   $��	CONFIRMAR��6L   $��30��6`   $	��115��6l   
�������
��� � �$��Center=�6�   $��	0 15 0 20q�6�   ���	#FF26BD176�   �� 54      -	   5         ��Name$ txtMessagePassword��54   $   $��5q�6@   $��NoWrap=�6K   55      57      58      �� 59   
   $��10,417,10,10q�6   .+�5:      #  MaterialDesignThemes.Wpf.Card  ���	#FFFFEBC3$��
10,10,0,10q�6:   $��60��6N    � Cursor$
 Hand��6Z   $��Center=�6h   $	��424��6�   .��5;      �� -
   5        $ txtInfo��5;   (    �� Padding$ 2q�6      MaterialDesignTitleTextBlock#���  69   $��20(�6p   $��Center=�6~   $
 Hand��6�   �� 6�   $0�*Por seguridad, jamas revele su contraseña��6�   6�   5<      5=      5>      5?      