   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   fCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs  5   	   O KOnBreak.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OnBreak.PresentationOnBreak.Presentation 5   	   S OOnBreak.ViewModelCliente, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:OnBreak.ViewModelCliente;assembly=OnBreak.ViewModelClienteOnBreak.ViewModelCliente 5	   	   '   !OnBreak.Presentation.ListClientes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5   	   4local"clr-namespace:OnBreak.Presentation     5   	   WvmHclr-namespace:OnBreak.ViewModelCliente;assembly=OnBreak.ViewModelCliente     5	   	     � Title$!  OnBreak Listado de Clientes��5   	   $��625.376��6-   $��992.932��6>   
������� � 	Resources 5      (  "OnBreak.ViewModelCliente.ClienteVM   cliente��%   &	          5   
   6   5      .��5      � $��0,1,0,-1q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgdcliente��5   %      
IsReadOnly . $
��Left=�69   $	��345��6T   $��	59,27,0,0q�6a   $	��Top=�6t   $	��876��6�   ��6�   �� *
Clientes+ �� Source# [   �� SelectedIndex 6�   �� *SelectedIndexCliente+# [  �� 5   
   -   5         ��Name$ cboactividad��5      $
��Left=�6)   $��220,492,0,0q�6D   $	��Top=�6Y   $	��120��6q   ��6}   �� *Actividades+# [   6�   �� *SelectedFilter+# [  �� 5   
   -   5         ��Name$ btnbuscarrut��5      $��Buscar��6'   $
��Left=�68   $��364,450,0,0q�6S   $	��Top=�6h   $��75��6�   ��6�   �� *RdrutCommand+# [  �� 5   
   -   5         ��Name$ txtrut��5      $
��Left=�6"   $��23��6=   $��219,449,0,0q�6I   	 �� TextWrapping$
	 Wrap=�6^   $	��Top=�6r   $	��120��6�   
 J� 	AllowDrop
 . ��6�   �� *
RutCliente+# [  6�   �� 5   
   $
��Left=�6   $��101,409,0,0q�6/   $
��Wrap=�6D   $$��SeLECCIONE EL TIPO DE FILTRADO��6X   $	��Top=�6~   ���	#FFFB0606$��Showcard Gothic)�6�   �� 5   
   $
��Left=�6   $��41��6+   $��
58,391,0,0q�67   $	��Top=�6K   $��49��6c   $��Imagenes/737607.png��6n    J� RenderTransformOrigin$ -1.324,0.732&�6�   �� 5   
   $
��Left=�6   $��31��6+   $��
60,488,0,0q�67   $	��Top=�6K   $��29��6c   $��Imagenes/competidor.png��6n   �� 5   
   $
��Left=�6   $��35��6+   $��
61,441,0,0q�67   $	��Top=�6K   $��33��6c   $��Imagenes/departamento.png��6n   �� 5   
   $
��Left=�6   $��26��6+   $��
62,533,0,0q�67   $	��Top=�6K   $��26��6c   $��Imagenes/fabrica.png��6n   �� 5   
   -   5        $ 
cboempresa��5      $
��Left=�6'   $��220,535,0,0q�6B   $	��Top=�6W   $	��120��6o   ��6{   �� *Tipos+# [   6�   �� *SelectedFilter+# [  �� 5   
   $
��Left=�6   $	��136��6+   $��614,424,0,0q�68   $	��Top=�6M   $	��316��6e   $��Imagenes/ON.png��6q   �� 5   
   -   5        $ 	btnvolver��5      $��Volver��6$   $
��Left=�65   $��516,538,0,0q�6P   $	��Top=�6e   $��74��6}   6�   �� 5   
   $
��Left=�6   $��34��6+   $��476,534,0,0q�67   $	��Top=�6L   $��34��6d   $(��"Imagenes/transparenc_ystal_075.png��6o   �� 5   
   $
��Left=�6   $��104,455,0,0q�6/   $
��Wrap=�6D   $��RUT CLIENTE��6X   $	��Top=�6k   ���	#FFF90404$��Showcard Gothic)�6�   �� 5   
   $
��Left=�6   $��101,496,0,0q�6/   $
��Wrap=�6D   $��TIPO ACTIVIDAD��6X   $	��Top=�6n   ���	#FFF90404$��Showcard Gothic)�6�   �� 5   
   $
��Left=�6   $��102,542,0,0q�6/   $
��Wrap=�6D   $��TIPO EMPRESA��6X   $	��Top=�6l   ���	#FFF90404$��Showcard Gothic)�6�   �� 5    
   -   5        $ txtalert��5       $
��Left=�6$   $��23��6?   $��443,398,0,0q�6K   $
	 Wrap=�6`   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   ��6t   �� *Alert+# [  6�   �� 5!   
   $
��Left=�6   $��39��6+   $��458,442,0,0q�67   $	��Top=�6L   $��42��6d   $(��"Imagenes/transparenc_ystal_127.png��6o   $ 0.627,0.274&�6�   �� 5"   
   -   5        $ 
btnlimpiar��5"      $��Limpiar��6%   $
��Left=�67   $��512,446,0,0q�6R   $	��Top=�6g   $��75��6   $��31��6�   ��6�   �� *Clear+# [  6�   �� 5#   
   -	   5        $ txtalert_Copy��5#      $
��Left=�6)   $��23��6D   $��907,257,-42,0q�6P   $
	 Wrap=�6g   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   ��6{   �� *Alert+# [  6�   5%      5&      