   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   fCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs  5   	   O KOnBreak.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OnBreak.PresentationOnBreak.Presentation 5   	   S OOnBreak.ViewModelCliente, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:OnBreak.ViewModelCliente;assembly=OnBreak.ViewModelClienteOnBreak.ViewModelCliente 5	   	   '   !OnBreak.Presentation.AdmiContrato   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5   	   4local"clr-namespace:OnBreak.Presentation     5   	   WvmHclr-namespace:OnBreak.ViewModelCliente;assembly=OnBreak.ViewModelCliente     5	   	     � Title$"  Administración de Contratos��5   	   $��652.376��6-   $��1037.932��6>   
������� � 	Resources 5      ,  &OnBreak.ViewModelCliente.AmiContratoVM   AmiContratoVM(  "OnBreak.ViewModelCliente.ClienteVM  cliente��%:   &	        &	        5   
   6     5   
   6   5      .��5      � $��0,0,7,6q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgdcontrato��5   %      
IsReadOnly . $
��Left=�6:   $	��472��6U   $��
498,28,0,0q�6b   $	��Top=�6v   $	��496��6�    �� SelectedIndex 6�   �� *SelectedIndexContrato+ �� Source# [  ��6�   �� *	contracts+# [  �� 5   
   $
��Left=�6   $��	28,64,0,0q�6/   $
��Wrap=�6B   $��Rut cliente:��6V   $	��Top=�6j   ���	#FFFB0808$��Showcard Gothic)�6�   �� 5   
   $
��Left=�6   $��	27,34,0,0q�6/   $
��Wrap=�6B   $��NUMERO DE CONTRATO:��6V   $	��Top=�6q   ���	#FFFB0808$��Showcard Gothic)�6�   �� 5   
   -   5         ��Name$ txtnumecont��5      $
��Left=�6'   $��22��6B   $��
176,32,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�    �� IsUndoEnabled . ��6�   �� *	NumContra+# [  �� 5   
   $
��Left=�6   $��
26,132,0,0q�6/   $
��Wrap=�6C   $��Fecha creación:��6W   $	��Top=�6n   ���	#FFFD0C0C$��Showcard Gothic)�6�   �� 5   
   $
��Left=�6   $��
28,200,0,0q�6/   $
��Wrap=�6C   $��Fecha termino:��6W   $	��Top=�6m   $��Showcard Gothic)�6�   ���	#FFFF08086�   �� 5   
   $
��Left=�6   $��
31,271,0,0q�6/   $
��Wrap=�6C   $��
Modalidad:��6W   $	��Top=�6i   ���	#FFF90404$��Showcard Gothic)�6�   �� 5   
   -   5        	 ��Name$	 cbomodalidad��5      $
��Left=�6)   $��
24,300,0,0q�6D   $	��Top=�6X   $	��123��6p   
 �� Text
 6|   �� *	Modalidad+# [   6�   �� *	Modalidad+# [  ��6	  �� *	Newmoda+# [  �� 5   
   $
��Left=�6   $��186,268,0,0q�6/   $
��Wrap=�6D   $��TIPO EVENTO:��6X   $	��Top=�6l   $��Showcard Gothic)�6�   ���	#FFF504046�   �� 5   
   -   5        $	 	cboevento��5      $
��Left=�6&   $��187,300,0,0q�6A   $	��Top=�6V   $	��120��6n   ��6z   �� *Even+# [   6�   �� *SelectedIndexEven+# [  �� 5   
   $
��Left=�6   $��
31,340,0,0q�6/   $
��Wrap=�6C   $��ASISTENTES:��6W   $	��Top=�6j   ���	#FFFB0202$��Showcard Gothic)�6�   �� 5   
   -   5        $ txtasistente��5      $
��Left=�6(   $��22��6C   $��
32,371,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   ��6�   �� *
Asistentes+# [  �� 5   
   $
��Left=�6   $��185,342,0,0q�6/   $
��Wrap=�6D   $��PERSONAL ADICIONAL:��6X   $	��Top=�6s   $��Showcard Gothic)�6�   ���	#FFFB08086�   �� 5   
   -   5        $ txtpersonal��5      $
��Left=�6'   $��24��6B   $��186,370,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   ��6�   �� *PerAdicional+# [  �� 5   
   $
��Left=�6   $��
33,412,0,0q�6/   $
��Wrap=�6C   $��OBSERVACIÓNES:��6W   $	��Top=�6m   ���	#FFFF0808$��Showcard Gothic)�6�   �� 5    
   -   5        $ txtobservaciones��5       $
��Left=�6,   $��40��6G   $��
37,442,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��349��6�   ��6�   �� *Observaciones+# [  �� 5!   
   $
��Left=�6   $��
40,501,0,0q�6/   $
��Wrap=�6C   $��VALOR CONTRATO:��6W   $	��Top=�6n   $��Showcard Gothic)�6�   ���	#FFF30A0A6�   �� 5"   
   -   5        $ txtvalor��5"      $
��Left=�6$   $��22��6?   $��
39,527,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   {�.  ��6�   �� *Valor+# [  �� 5#   
   -	   5         ��Name$ chkrealizado��5#      $��evento realizado��6)   $
��Left=�6D   $��296,532,0,0q�6_   $	��Top=�6t   ���	#FFF70808$(��"Showc                   ard Gothic)�6�   ��5$      �� *Ischeckcommand+# [   d� 	IsChecked 6i   �� *
IsSelected+�� 5%   
   -
   5         ��Name$ 
btncalculo��5%      $��Calcular��6%   $
��Left=�68   $��192,528,0,0q�6S   $	��Top=�6h   $��76��6�   ��6�   �� *
CalCommand+# [  �� 5&   
   -   5        $ 
btnagregar��5&      $��Agregar��6%   $
��Left=�67   $��206,572,0,0q�6R   $	��Top=�6g   $��70��6   $��22��6�   ��6�   �� *
AddCommand+# [  �� 5'   
   $
��Left=�6   $��28��6+   $��170,568,0,0q�67   $	��Top=�6L   $��30��6d   $(��"Imagenes/transparenc_ystal_017.png��6o    J� RenderTransformOrigin$ 1.345,0.981&�6�   �� 5(   
   $
��Left=�6   $��253,162,0,0q�6/   $
��Wrap=�6D   $��:��6X   $	��Top=�6a   ���	#FFF90808$��Showcard Gothic)�6�   �� 5)   
   $
��Left=�6   $��254,232,0,0q�6/   $
��Wrap=�6D   $��:��6X   $	��Top=�6a   ���	#FFF90808$��Showcard Gothic)�6�   �� 5*   
   $
��Left=�6   $��200,132,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   ���	#FFFD0C0C$��Showcard Gothic)�6�   �� 6�   $�Hora INICIO��6�   �� 6�   $�:��6�   6�   �� 5+   
   $
��Left=�6   $��197,201,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   ���	#FFFD0C0C$��Showcard Gothic)�6�   �� 6�   $�Hora  TERMINO��6�   �� 6�   $�:��6�   6�   �� 5,   
   $
��Left=�6   $��34��6+   $��858,571,0,0q�67   $	��Top=�6L   $��36��6d   $(��"Imagenes/transparenc_ystal_075.png��6o   $ 3.278,0.735&�6�   �� 5-   
   -   5        $ 	btnvolver��5-      $��Volver��6$   $
��Left=�65   $��904,573,0,0q�6P   $	��Top=�6e   $��94��6}   $��24��6�   $ 	0.19,0.84&�6�   6�   �� 5.   
   -   5         ��Name$ 	txbnombre��5.      $
��Left=�6'   $��
317,92,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   $��Showcard Gothic)�6�   $��20(�6�   ���	#FFFD0A0A6�   �� 5/   
   $
��Left=�6   $��29��6+   $��
44,568,0,0q�67   $	��Top=�6K   $��30��6c   $(��"Imagenes/transparenc_ystal_127.png��6n   $ 0.627,0.274&�6�   �� 50   
   -   5        $ 
btnlimpiar��50      $��Limpiar��6%   $
��Left=�67   $��
80,573,0,0q�6R   $	��Top=�6f   $��70��6~   $��21��6�   ��6�   �� *Clear+# [  �� 51   
   $
��Left=�6   $��35��6+   $��
330,29,0,0q�67   $	��Top=�6K   $��34��6c   $(��"Imagenes/transparenc_ystal_132.png��6n   �� 52   
   -   5        $ txtHora��52      $
��Left=�6#   $��23��6>   $��206,159,0,0q�6J   $
 Wrap=�6_   $	��Top=�6�   $��42��6�   ��6s   �� *	IniHour+# [  6�   �� 53   
   -   5        $ 	txtminuto��53      $
��Left=�6%   $��23��6@   $��262,160,0,0q�6L   $
 Wrap=�6a   $	��Top=�6�   $��42��6�   $ 2.429,0.783&�6�   ��6u   �� *	Iniminute+# [  6�   �� 54   
   -   5        $ 
txthorafin��54      $
��Left=�6&   $��23��6A   $��206,228,0,0q�6M   $
 Wrap=�6b   $	��Top=�6�   $��42��6�   $ 2.429,0.783&�6�   ��6v   �� *	TerHour+# [  6�   �� 55   
   -   5        $ txtminutofin��55      $
��Left=�6(   $��23��6C   $��263,228,0,0q�6O   $
 Wrap=�6d   $	��Top=�6�   $��42��6�   $ 2.429,0.783&�6�   ��6x   �� *	Terminute+# [  6�   �� 56   
   $��Generar N° Contrato��6   $
��Left=�6/   $��429,519,0,0q�6J   $	��Top=�6_   $	��143��6w   $��35��6�   ��6�   �� *	IniDate+# [  �� 57   
   $
��Left=�6   $��309,165,0,0q�6/   $
��Wrap=�6D   $��:��6X   $	��Top=�6a   ���	#FFF90808$��Showcard Gothic)�6�   �� 58   
   $
��Left=�6   $��23��6-   $��318,160,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $��42��6�   ��6b   �� *
IniSegundo+# [  6�   (  "System.Windows.Controls.DatePicker  59   
   $
��Left=�6   $��
26,159,0,0q�60   $	��Top=�6D      SelectedDate 6\   �� *InicioFecha+# [    5:   
   $
��Left=�6   $��
26,227,0,0q�60   $	��Top=�6D   $	��156��6\    6h   �� *Terminofecha+# [  �� 5;   
   $
��Left=�6   $��23��6-   $��322,228,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $��42��6�   ��6b   �� *
TerSegundo+# [  6�   �� 5<   
   $
��Left=�6   $��310,232,0,0q�6/   $
��Wrap=�6D   $��:��6X   $	��Top=�6a   ���	#FFF90808$��Showcard Gothic)�6�   �� 5=   
   -   5        $	 cbomodalidad_Copy��5=      $
��Left=�6.   $��	24,92,0,0q�6I   $	��Top=�6\   $	��123��6t   
 6�   �� *Rut+# [  ��6�   �� *
clientrt+# [  �� 5>   
   $��
Actualizar��6   $
��Left=�6&   $��343,570,0,0q�6A   $	��Top=�6V   $��75��6n   ��6y   �� *Update+# [  �� 5?   
   $
��Left=�6   $��30��6+   $��296,568,0,0q�67   $	��Top=�6L   $��42��6d   $(��"Imagenes/transparenc_ystal_137.png��6o   $ 
-0.167,0.4&�6�   �� 5@   
   -   5        $ txtalert��5@      $
��Left=�6$   $��23��6?   $��
339,34,0,0q�6K   $
 Wrap=�6_   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   ��6s   �� *Alert+# [  6�   �� 5A   
   $
��Left=�6   $��
300,12,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   ���	#FFF70808$��Showcard Gothic)�6�   $��10(�6�   $ 0.208,0.417&�6�   �� 6�   $�Busqueda por ��6�   �� 6�   $�NUmero de Contrato��6�   6  �� 5B   
   -   5        $ 	btnbuscar��5B      $��Buscar��6$   $
��Left=�65   $��
368,34,0,0q�6P   $	��Top=�6d   $��76��6|   ��6�   �� *ReadNumConCommand+# [  �� 5C   
   $
��Left=�6   $��28��6+   $��432,570,0,0q�67   $	��Top=�6L   $��38��6d   $(��"Imagenes/transparenc_ystal_240.png��6o   $ 0.474,0.083&�6�   �� 5D   
   -   5        $ btneliminar��5D      $��Terminar��6&   $
��Left=�69   $��474,570,0,0q�6T   $	��Top=�6i   $��76��6�   ��6�   �� *TerNumConCommand+# [  5F      5G      