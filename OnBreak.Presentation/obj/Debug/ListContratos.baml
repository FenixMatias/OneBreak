   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   fCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs  5   	   O KOnBreak.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OnBreak.PresentationOnBreak.Presentation 5   	   S OOnBreak.ViewModelCliente, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:OnBreak.ViewModelCliente;assembly=OnBreak.ViewModelClienteOnBreak.ViewModelCliente 5	   	   (   "OnBreak.Presentation.ListContratos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5   	   4local"clr-namespace:OnBreak.Presentation     5   	   WvmHclr-namespace:OnBreak.ViewModelCliente;assembly=OnBreak.ViewModelCliente     5	   	     � Title$"  OnBreak Listado de Contratos��5   	   $��625.376��6.   $��992.932��6?   
������� � 	Resources 5      ,  &OnBreak.ViewModelCliente.AmiContratoVM   
ContratoVM(  "OnBreak.ViewModelCliente.ClienteVM  cliente��%:   &	        &	        5   
   6     5   
   6   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgdcontrato��5   %      
IsReadOnly . $
��Left=�6:   $	��299��6U   $��	51,37,0,0q�6b   $	��Top=�6u   $	��876��6�   ��6�   �� *
Contralist+ �� Source# [  �� 5   
   $
��Left=�6   $	��134��6+   $��614,393,0,0q�68   $	��Top=�6M   $	��316��6e   $��Imagenes/ON.png��6q   �� 5   
   -   5         ��Name$ btnbuscarevento��5      $��Buscar��6*   $
��Left=�6;   $��354,496,0,0q�6V   $	��Top=�6k   $��75��6�   ��6�   �� *	Eventus+# [  �� 5   
   -   5         ��Name$ 	cboevento��5      $
��Left=�6&   $��214,496,0,0q�6A   $	��Top=�6V   $	��120��6n    J� RenderTransformOrigin$ 0.229,1.104&�6z   ��6�   �� *Even+# [   �� SelectedIndex 6�   �� *SelectedIndexEven+# [  �� 5   
   -   5        $ btnbuscarnumero��5      $��Buscar��6*   $
��Left=�6;   $��354,457,0,0q�6V   $	��Top=�6k   $��75��6�   {�. ��6�   �� *Numcontratus+# [  �� 5   
   -   5        	 ��Name$	 	txtnumero��5      $
��Left=�6%   $��23��6@   $��215,457,0,0q�6L   
 �� TextWrapping$

 Wrap=�6a   $	��Top=�6u   $	��120��6�   ��6�   �� *	NumContra+# [  6�   �� 5   
   $
��Left=�6   $��
99,375,0,0q�6/   $
��Wrap=�6C   $$��SeLECCIONE EL TIPO DE FILTRADO��6W   $	��Top=�6}   ���	#FFFB0606$��Showcard Gothic)�6�   �� 5   
   -   5        $ 
cboempresa��5      $
��Left=�6'   $��215,535,0,0q�6B   $	��Top=�6W   $	��120��6o   $ 0.558,0.061&�6{   ��6�   �� *Moda+# [   �� Text 6�   �� *	Modalidad+# [  �� 5   
   -   5        $ btnbuscarempresa��5      $��Buscar��6+   $
��Left=�6<   $��354,535,0,0q�6W   $	��Top=�6l   $��75��6�   ��6�   �� *Modalidatus+# [  �� 5   
   -   5        $ 	btnvolver��5      $��Volver��6$   $
��Left=�65   $��516,538,0,0q�6P   $	��Top=�6e   $��74��6}   6�   �� 5   
   $
��Left=�6   $��34��6+   $��476,534,0,0q�67   $	��Top=�6L   $��34��6d   $(��"Imagenes/transparenc_ystal_075.png��6o   �� 5   
   $
��Left=�6   $��41��6+   $��
58,361,0,0q�67   $	��Top=�6K   $��49��6c   $��Imagenes/737607.png��6n   $ -1.324,0.732&�6�   �� 5   
   -	   5        $	 txtrut��5      $
��Left=�6"   $��23��6=   $��215,417,0,0q�6I   $

 Wrap=�6^   $	��Top=�6r   $	��120��6�   ��6�   �� *Rut+# [  6�   �� 5   
   -
   5        $ btnbuscarrut��5      $��Buscar��6'   $
��Left=�68   $��354,417,0,0q�6S   $	��Top=�6h   $��75��6�   {�. $ -0.333,0.519&�6�   ��6�   �� *Rutus+# [  �� 5   
   $
��Left=�6   $��30��6+   $��
59,413,0,0q�67   $	��Top=�6K   $��42��6c   $(��"Imagenes/transparenc_ystal_042.png��6n   $ 0.355,0.459&�6�   �� 5    
   $
��Left=�6   $��35��6+   $��
58,449,0,0q�67   $	��Top=�6K   $��33��6c   $��Imagenes/departamento.png��6n   �� 5!   
   $
��Left=�6   $��33��6+   $��
55,489,0,0q�67   $	��Top=�6K   $��42��6c   $(��"Imagenes/transparenc_ystal_162.png��6n   �� 5"   
   $
��Left=�6   $��101,417,0,0q�6/   $
��Wrap=�6D   $��Rut Cliente��6X   $	��Top=�6k   ���	#FFFF0606$��Showcard Gothic)�6�   $��21��6�   $��92��6�   $ -0.022,0.333&�6�   �� 5#   
   $
��Left=�6   $��
99,457,0,0q�6/   $
��Wrap=�6C   $��Numero Contrato��6W   $	��Top=�6n   ���	#FFFF0606$��Showcard Gothic)�6�   $��26��6�   $	��123��6�   �� 5$   
   $
��Left=�6   $��
99,496,0,0q�6/   $
��Wrap=�6C   $��Tipo Evento��6W   $	��Top=�6j   ���	#FFFF0606$��Showcard Gothic)�6�   $��21��6�   $��92��6�   �� 5%   
   $
��Left=�6   $��
99,534,0,0q�6/   $
��Wrap=�6C   $��	Modalidad��6W   $	��Top=�6h   ���	#FFFF0606$��Showcard Gothic)�6�   $��21��6�   $��92��6�   �� 5&   
   -   5        $	 txtalert��5&      $
��Left=�6$   $��23��6?   $��475,455,0,0q�6K   $

 Wrap=�6`   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   ��6t   �� *Alert+# [  6�   �� 5'   
   $
��Left=�6   $��39��6+   $��460,407,0,0q�67   $	��Top=�6L   $��42��6d   $(��"Imagenes/transparenc_ystal_127.png��6o   $ 0.627,0.274&�6�   �� 5(   
   -   5        $ 
btnlimpiar��5(      $��Limpiar��6%   $
��Left=�67   $��516,413,0,0q�6R   $	��Top=�6g   $��75��6   $��31��6�   ��6�   �� *Clear+# [  6�   �� 5)   
   $
��Left=�6   $��43��6+   $��
53,523,0,0q�67   $	��Top=�6K   $��48��6c   $(��"Imagenes/transparenc_ystal_249.png��6n   5+      5,      