   M S B A M L   `   `   `  ����N  JRechnungsverwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Rechnungsverwaltung.ViewModelRechnungsverwaltung.ViewModel  5   	   #    Rechnungsverwaltung.View.View   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;src+clr-namespace:Rechnungsverwaltung.ViewModel     5   	     � Title$
  View��5   	   $	��450��6   $	��800��6#    � DataContext 5	      7  1Rechnungsverwaltung.ViewModel.RechnungenViewModel  5
   
   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��3* �6   6*   �� 5      $��2* �6   6*   �� 5      $��3* �6   6*   �� 5      $	��10* �6   6+   .+�5   
   �� $��0��6   $��0��6"   $��Center=�6u   $��Center=�6�   ��6/   ��  �� Path$ 
ChosenName� �� UpdateSourceTrigger$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5   
   $��15(�5      $��5q�5      $��Center=�5          SelectedDateFormat$ Short=�5!      $��0��5"      $��1��5#         SelectedDate 5$      �� $ 
ChosenDate�$ PropertyChanged=��� 5'   
   $��2��6   $��0��6"   $��Center=�6w   $��Center=�6�   ��6/   �� $ ChosenAdress�$ PropertyChanged=�6�   �� 5(   
   $��3��6   $��0��6"   $��Center=�6w   $��Center=�6�   ��6/   �� $ ChosenAmount�$ PropertyChanged=�6�   �� 5)   
   $��4��6   $��0��6"   $��Center=�6t   $��Center=�6�   ��6/   �� $ 	ChosenVat�$ PropertyChanged=�6�   �� 5*   
   $��0��6   $��5��6   ��6.   �� $ 
AddCommand�.��6R   Add6W   �� 5,   
   $��0��6   $��1��6    $��Center=�6-   $��20(�6Q   .��6_   Name6e   �� 5-   
   $��1��6   $��1��6    $��Center=�6-   $��20(�6Q   .��6_   Date6e   �� 5.   
   $��2��6   $��1��6    $��Center=�6-   $��20(�6Q   .��6_   Adress6g   �� 5/   
   $��3��6   $��1��6    $��Center=�6-   $��20(�6Q   .��6_   Amount6g   �� 50   
   $��4��6   $��1��6    $��Center=�6-   $��20(�6Q   .��6_   VAT6d   �� 52   
   $��0��6   $��2��6#   $��6��60   $��2��6D   ��6U   �� $ List.InvoiceLists�$ PropertyChanged=� �� SelectedItem 53      �� $ CurrentInvoice�	 � ContextMenu	 54      �� 55      .@�56      m� $��Löschen��6   
 m� Command
 6,   �� $ DeleteCommand�6U   m� 57      $
��Send��6   
 6)   �� $ SendCommand�6P   58       �� View 5:      �� 5<      .P�5=      �� $��ID��6%    �� Width$	 130��61    �� DisplayMemberBinding 6=   �� $ ID�$ PropertyChanged=��� 5>      $
��Name��6%   $	 130��63    6?   �� $ CustomerName�$ PropertyChanged=��� 5?      $��Adress��6%   $	 130��65    6A   �� $ CustomerAdress�$ PropertyChanged=��� 5@      $
��Date��6%   $	 130��63    6?   �� $ InvoiceDate�$ PropertyChanged=��� 5A      $��Amount��6%   $	 130��65    6A   �� $ Amount�$ PropertyChanged=��� 5B      $	��Vat��6%   $	 130��62    6>   �� $	 Vat�$ PropertyChanged=�5C      5E      5F      5G      