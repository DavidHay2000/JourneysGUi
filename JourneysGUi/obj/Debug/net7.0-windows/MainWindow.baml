   M S B A M L   `   `   `  ����F  BJourneysGUi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:JourneysGUiJourneysGUi  5   	       JourneysGUi.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:JourneysGUi     5   	     � Title$  Vehicles��5   	   $	��450��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.1* �6   �� 5      .+�5   
   �� -   5         ��Name$ vehicle_LBX��5      $��3��6M   $��0��6^   ��6'   �� *vehicleString+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 10q�6/   5      5      �� 5   
   $��Meghírdetett utak:��6   $��1��6-   $��Center=�6=   �� 5   
   -   5         ��Name$ journeys_CBX��5      $��1��6R   $��1��6b   ��6)   �� *FilteredJourneys+6b   �� 5   
   -   5         ��Name$ description_TBX��5      $��1��6+   $��2��6h   ��6;   �� *SelectedJourney.description+6h   5      5       