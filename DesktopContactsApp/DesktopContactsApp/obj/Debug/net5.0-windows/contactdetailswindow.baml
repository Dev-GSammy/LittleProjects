   M S B A M L   `   `   `  ����M  IDesktopContactsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DesktopContactsAppDesktopContactsApp  5   	   -    'DesktopContactsApp.contactdetailswindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DesktopContactsApp     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ contactdetailswindow��5
   	   $	��300��6&   $	��300��63   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��173* �6   �� 5      $
��127* �6   .+�5   
   �� $��10q�6   $��2��6!   .+�5      �� $
��Name��6   �� 5      -   5         ��Name$ Nametextbox��5      $��0,0,0,10q�5      �� 5      $��Email��6   �� 5      -   5        $ Emailtextbox��5      $��0,0,0,10q�5      �� 5      $��Phone��6   �� 5      -   5        $ Phonenumbertextbox��5      $��0,0,0,10q�5      �� 5      -   5         ��Name$ UpdateButton��5      $��Update��5      
����  �$��0,0,0,5q�5      �� 5      -   5        $ DeleteButton��5       $��Delete��5      
�������
���  ��$��0,0,0,5q�5$      5%      5&      5'      