   M S B A M L   `   `   `  ����U  QKrivec_UporabniskiVmesniki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Krivec_UporabniskiVmesnikiKrivec_UporabniskiVmesniki  5   	   +    %Krivec_UporabniskiVmesniki.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Krivec_UporabniskiVmesniki     5   	     � Title$  
MainWindow��5	   	   $
��auto��6   $	��400��5
   	   $
��1200��6    � SizeToContent$ WidthAndHeight=�5   	    � 	Resources 5         ListViewItemStyle1 �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%K  &	        �� 5   
   " ��6+    5      P� 5       �@J�IsMouseOver$
 true��62   . �5      ��  � ��
 ��ح�63   �� 5       � ��
 ��  �63   5      P� 5       �@��
IsSelected$
 true��61   . �5      ��  � ��
 � � �63   �� 5       � ��
 ��+��63   5      5       54      .��56      �   GridBackround#��[ 6   	 � RowDefinitions	 57   
   �� 58      $
��auto �6   �� 59      $��6* �6   �� 5:      $��5 �6   �� 5;      $	��100 �6   �� 5<      $
��auto �6   �� 5=      $
��auto �6   �� 5>      $
��auto �6   
 � ColumnDefinitions
 5@   
   �� 5A      $��* �6   .+�5C   
   �� $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62     StackPanel_Backround#��[ 6K   .+�5D      o� -   5        $
��Menu��5D        Menu_Backround#��[ 6   .@�5T      m� $
��Menu��6   .@�5U      m� $��Datoteka��6   .@�5V      m� -   5        $��Izhod��5V   #   6Q   m� 5W      -   5        $��Uvozi��5W   #   6H   m� 5X      -   5        $��Izvozi��5X   #   6J   5Y      m� 5Z      $��Seznam��6   .@�5[      m� -   5        $��Dodaj��5[   #   6H   m� 5\      -   5        $��Odstrani��5\   #   6N   m� 5]      -   5        $��Uredi��5]   #   6H   5^      m� 5_      $��Orodja��6   .@�5`      m� -   5        $��
Nastavitve��5`   #   6R   5a      5b      5c      5e      �� 5g   
   $��1��6   $��0��6#     StackPanel_MediaElement#��[ 64   .+�5h      r� -	   5        $��MediaElement��5h       r� LoadedBehavior$ Manual=�6c    r� Stretch$ UniformToFill=�6}    r� Source 6I   �� *strngs+6}   5i      �� 5k   
   $��2��6     GridSplitter_Properties#��[ 6$   6W   �� 5m   
     StackPanel_ListView#��[ 6   $��3��6B   $��0��6O   .+�5n      �� -
   5        $��Video��5n      $��2��6B     ListView_Properties#��[ 6V   #��[  6�   ��6$   �� *files+ � ContextMenu 5o      �� 5p      .@�5q      m� -   5        $��Dodaj��5q   #   6H   m� 5r      -   5        $��Odstrani��5r   #   6N   m� 5s      -   5        $��Uredi��5s   #   6H   5t      ��5v      �� 5w      .R�5x      ��  ��Name$
 meja��6!     Border_Properties#��[ 6/   ._�5y      �� $��Playlist��6)    	 ListView_StackPanel#��[	 69   .+�5z   "   ��  "
 ListView_StackPanel_StackPanel#��[
 6-   .+�5{   &   �� $��Id��60     ListView_TextBlock_width1#��[ 6:   �� 5|   &   $	��Ime��60     ListView_TextBlock_width4#��[ 6;   �� 5}   &   $
��Zanr��60     ListView_TextBlock_width3#��[ 6<   �� 5~   &   $��Image��60     ListView_TextBlock_width2#��[ 6=   �� 5   &   $��Lenghth��60   #��[ 6?   �� 5�   &   $	��Pot��60     ListView_TextBlock_width5#��[ 6;   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��1q�6F   .+�5�   &   �� $��Id��6D   #��[ 6O   ��60   �� *id+6O   �� 5�   &   $
��Name��6F   #��[ 6S   ��60   �� *Name+6S   �� 5�   &   $
��Zanr��6F   #��[ 6S   ��60   �� *Zanr+6S   �� 5�   &   $��Image��6E     ListView_Image#��[ 6R   ��6,   �� *Image+6|   �� 5�   &   $��Lenghth��6I   #��[ 6Y   ��60   �� *	Lenghth+6Y   �� 5�   &   $	��Pot��6E   #��[ 6Q   ��60   �� *Pot+6Q   5�   #   5�      5�      5�      5�      5�      � 5�   
   $��5��6   $��0��6   .+�5�      �� -   5        $��casovnik��5�   <     	Casovnik1#��[ 6   6N   5�      � 5�   
   $��4��6   $��0��6   .+�5�      ]�   DockPanel_casovnik#��[ 6   .+�5�      �� -   5        $��CasPredvajanja��5�   X     casovnik#��[ 6�   ��6   ��  �� Path$ ActualWidth� �� ElementName$ MediaElement��6�   5�      5�      � 5�   
   $��5��6   $��0��6   .+�5�      �� -   5        $	��Cas��5�   ;     	Casovnik2#��[ 6   6H   5�      ]� 5�   
   $��6��6   $��0��6!     DockPanel_UserControll#��[ 61   .+�5�      -   'Krivec_UporabniskiVmesniki.UserControl1  -   5          Name$ UporabniskiGradnik��5�   !   5�      ]� 5�   
     DockPanel_Slider#��[ 6   $��6��6?   $��0��6L   .+�5�      �� -   5        $��volumen��5�        volumen#��[ 6@   5�      5�      5     5     