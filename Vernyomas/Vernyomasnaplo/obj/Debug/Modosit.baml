   M S B A M L   `   `   `  ����I  EVernyomasnaplo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VernyomasnaploVernyomasnaplo  5   	       Vernyomasnaplo.Modosit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Vernyomasnaplo     5   	   -   5          � Title$  Módosítás��5   	   $	��300��6   $	��320��6(    � 
ResizeMode$ NoResize=�64   $��16(�6J   .��5	      �  � RowDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��20q�6;   .+�5      �� .+�5      �� $��Dátum(ÉÉÉÉ-HH-NN):��6   �� 5      $��Idő(óó:pp):��6   �� 5      $��Szisztolés:��6   �� 5      $��Diasztolés:��6   �� 5      $��Pulzus:��6   5      �� 5      .+�5      �� -   5         ��Name$ tbDatum��5      $��90��6+   $��0 5 0 3q�66   �� 5      -   5        $ tbIdo��5      $��50��6)   $��0 5 0 3q�64   $
��Left=�6E   �� 5      -   5        $ tbSzisztoles��5      $��50��60   $��0 5 0 3q�6;   $
��Left=�6L   �� 5      -   5        $ tbDiasztoles��5      $��50��60   $��0 5 0 3q�6;   $
��Left=�6L   �� 5      -   5        $ tbPulzus��5      $��50��6,   $��0 5 0 0q�67   $
��Left=�6H   5      5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��0 0 0 10q�6X   .+�5      �� -   5         ��Name$ 	btnVissza��5      $��Vissza��6(   $��	0 10 0 10q�69   6L   �� 5       -   5        $ btnOK��5       $��OK��6$   $��
40 10 0 10q�61   6E   5!      5"      5#      