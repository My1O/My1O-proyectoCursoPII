   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.viewsWpfApp1.views  5   	   %    WpfApp1.views.RegistrarProducto   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp1.views     5   	     � Title$  RegistrarProducto��5   	   $	��400��6#   $	��650��60    � WindowStartupLocation$ CenterScreen=�6<    � WindowStyle$
 None=�6a   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��250 �6   $	��450��6+   6<   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��35 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $�� ��6-   $��Center=�68   $��Center=�6S   $��15(�6p   6�   �� 5   
   $��0��6   $��1��6   $�� ��6-   $��Center=�68   $��Center=�6U   6r   �� 5   
   $��1��6   $��0��6   $��Fecha��6-   $��Center=�6=   $��Center=�6X   $��15(�6u   6�   �� 5   
   $��1��6   $��1��6   $��Fecha��6-   $��Center=�6=   $��Center=�6Z   6w   �� 5   
   $��2��6   $��0��6   $��Nombre del Producto��6-   $��Center=�6K   $��Center=�6f   $��15(�6�   6�   �� 5   
   -   5         ��Name$ 	txtNombre��5   r   $��2��6   $��1��6   $��1q�6/   $	��350��6C   $��30��6O   
����  �6�   �� 5   
   $��3��6   $��0��6   $��Cantidad��6-   $��Center=�6@   $��Center=�6[   $��15(�6x   6�   �� 5   
   -   5        $ txtCantidad��5   r   $��3��6   $��1��6   $��1q�6/   $	��350��6C   $��30��6O   
����  �$��25,10,25,10q�6�   6�   �� 5   
   $��4��6   $��0��6   $��Precio Unitario��6-   $��Center=�6G   $��Center=�6b   $��15(�6   6�   �� 5    
   -   5        $ txtPrecioUnitario��5    r   $��4��6   $��1��6   $��1q�6/   $	��350��6C   $��30��6O   
����  �6�   �� 5!   
   $��5��6   $��0��6   $��Precio Total��6-   $��Center=�6D   $��Center=�6_   $��15(�6|   6�   �� 5"   
   -   5         ��Name$ lblPrecioTotal��5"   �   $��5��6   $��1��6   $��Valor precio total��6-   $��Center=�6J   $��Center=�6g   6�   � 5#   
   $��6��6   $��3��6   
������� 5$      �� 5%      6%   �� 5&      6%   �� 5'      6%   .+�5)      �� -   5         ��Name$ 	BtnCargar��5)   e   $��0��6   $��Cargar��6%   $��15q�66   $	��150��6B   
�����_�6z   �� 5*      -   5        $ 
BtnGuardar��5*   f   $��1��6   $��Guardar��6%   $��15q�67   $	��150��6C   
�����_�6|   �� 5+      -   5        $ BtnSalir��5+   d   $��2��6   $��Salir��6%   $��15q�65   $	��150��6A   
�����_�6x   5,      5-      5.      