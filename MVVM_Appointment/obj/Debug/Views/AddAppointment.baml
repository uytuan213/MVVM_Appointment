   M S B A M L   `   `   `  ����K  GMVVM_Appointment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MVVM_Appointment.ViewsMVVM_Appointment.Views  5      +    %MVVM_Appointment.Views.AddAppointment   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:MVVM_Appointment.Views     5        N� Title$  AddAppointment��5	      .��5      ]� .+�5   
   �� $	��Top=�6      HeaderBorder#��[  6&   ._�5      ��   HeaderLabel#��[ 6   ��69   �� *DisplayName+5      �� 5   
   $��Bottom=�6   $��Center=�6-    �� Orientation$ 
Horizontal=�6J   .+�5      �� $��Total Appointments: ��6   �� 5      ��6   �� *Appointments.Count+5      �� 5   
   $��Center=�6   $��10q�5      .+�5      �� -   5        $��lstCustomers��5      $	��400��5      $	��150��5      ��5      �� *	Customers+ �� SelectedItem 5      �� *SelectedCustomer+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ Stretch=�6G   �� 5       � ��$ Center=�6@   5       �� View 5       �� 5!      .P�5"      ��  �� Width$	 150��5#   )    �� DisplayMemberBinding 5"   )   �� *CustFirstName+��5$      �� 5%   "   $��
First name��67   
	 � Tag$	 CustFirstName��6L   ��6`   �� *cmdColumnSort+��5&   &   �� 5'   *   
 �� Path$	
 Tag�6Y    �� RelativeSource 62   �� *Self+6Y   5)   #   5+      �� 5-      $	 150��5.   )    5-   )   �� *CustLastName+��5/      �� 50   "   $��	Last name��67   $	 CustLastName��6K   ��6^   �� *cmdColumnSort+��51   &   �� 52   *   $	
 Tag�6Y    62   �� *Self+6Y   54   #   56      57      59      �� 5:      $��10q�6   $ 
Horizontal=�6%   .+�5;      �� $��Selected Customer:��6   �� 5<      ��6   ��  �� ElementName$ lstCustomers��$ 
 SelectedItem.CustFirstName��� 5=      $
��10,0q�6f   ��6   �� $ lstCustomers��$
 SelectedItem.CustLastName�6f   5>      �� 5?      $
��10,5q�6   $ 
Horizontal=�6'   .+�5@      �� $��Date of Appointment:��6   (  "System.Windows.Controls.DatePicker  5A      $	��150��6      SelectedDate 6)   �� *SelectedDate+5B      �� 5C      $
��10,5q�6   $ 
Horizontal=�6'   .+�5D      �� $��Time of Appointment:��6   �� 5E      $	��150��5G      ��5E      �� *AppointmentTimes+ 5F      �� *SelectedTime+5G      5H      �� 5I      $��10q�6   $��Add Appointment��6!   $	��150��6;   ��6G   �� *cmdAddAppointment+5J      5K      5L      