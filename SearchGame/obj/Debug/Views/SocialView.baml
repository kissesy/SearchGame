   M S B A M L   `   `   `  ����E  ASearchGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SearchGame.ViewsSearchGame.Views  5      3clr-namespace:SearchGame.ViewsSearchGame.Views  5      ;"clr-namespace:SearchGame.ViewModelSearchGame.ViewModel  5      !    SearchGame.Views.SocialView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SearchGame.Views     5      0viewsclr-namespace:SearchGame.Views     5      8	viewModel"clr-namespace:SearchGame.ViewModel     5        � 	Resources  5         SoicalUrlListTemplate �� CornerRadius �� RelativeSource �� AncestorType � Triggers :� RoutedEvent �� TargetProperty	 �� To �� Orientation  UserTwitTemplate	 �� DataType(   "SearchGame.ViewModel.HomeViewModel   SearchGame.Views.HomeView  	BoolToVis��%�  &	        &	 �    (��     5/      *, +)&	 Q    �� 5   
   .R�5      �� $ 7��6   
�������$��10q�6=   ._�5      �� 
������ 
������ ��5      �� *DataContext.ClickUrl+ �� *FindAncestor+" �� 5      :� 5      $ 
MouseEnter��6'   .[�5      �� .��5   "   �� .��5   &   �� $1 +(Button.Background).(SolidColorBrush.Color)�65   $ 	CadetBlueX�6}   5   #   5      5      .��5      �� $ 
Horizontal=�6!   .+�5      �� $��70��6@   $��70��6K   ��6    �� *ProfileImage+6K   �� 5      $��20(�6A   
������ $
��Bold"�6h   $��Center=�6z   $��Center=�6�   ��6$   �� *ProfileName+6�   5      5      5      5       �� 5"   
   .R�5#      �� 
������ $	��500��6.   $��70��6:   ._�5$      �� $ Vertical=�6   .+�5%      �� $ 5��6   
�������$��5q�6E   ._�5&      �� ��6$   �� *
TwitDate+5'      �� 5(      $ 1��6   ���#9398B9$��5q�6C   ._�5)      �� $��20(�6A   $
��Bold"�6O   ��6$   �� *TwitContent+6O   5*      5+      5,      5-      �� 5/   
   "	  6   .R�50        51      �� 53   
   6'   54      .��56      � 
�������
 � RowDefinitions
 57   
   �� 58      $	��17* �6   �� 59      $	��78* �6   �� 5:      $
��355* �6   .+�5>   
   � $��0��6   ���#681BAD.+�5?      �� $��20��6   $��20��6!   
������ 
������ $��Right=�6`   $��Center=�6|   ��5@      �� *CloseSocialView+.��5A      �� $3��-C:/Users/tuuna/Desktop/Search/Image/close.png��6   5B      5C      �� 5E   
   $��0��6   $��1��6!   ���#1F375F$��0q�6C   ._�5F      � .+�5G      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5I      �� $	��400��6J   $��30��6V   
���������6   �� *SearchContent+ �� Mode$ TwoWay=�6b   �� 5J      $��검색��6   $��50��6*   $��30��65   
������ 
������ 
�������$
��Bold"�5K   0   $��20(�6B   ��5L      �� *Search+5M      5N      5O      � 5R   
   $��2��6   ���#1F375Fy�61   �� *
OnSearch+ �� 	Converter# [ .+�5T      �� $ Vertical=�6   $��Center=�60   $��10q�6M   .+�5V      �� #��[  6   
������ 
������ $��20q�5Y   M   $��Stretch=�6Y   ��5W      �� *SocialUrlLists+ �� SelectedItem 5X      �� *SelectedUrl+5[      5\      5]      � 5`   
   $��2��6   ���#1F375Fy�61   �� *OnUser+# [ 
 5a      �� 5b      $��6* �6    �� 5c      $	��40* �6    .+�5f      � $��0��6   .+�5g      �� $ 
Horizontal=�6   .+�5h      �� $ 20��6   
�������$��20, 0, 0, 0q�6B   ._�5i      �� ��6    �� *	UserImage+5j      �� 5k      $ 20��6   
�������$��20,0,0,0q�6F   ._�5l      �� $��Center=�6>   $
��Bold"�6Y   $��20(�6k   ��6$   �� *
UserName+6k   5m      5n      5o      � 5q      $��1��6   .+�5r      �� $ Vertical=�6   $��10q�64   .+�5s      �� #��[ 6   
������ 
������ $��20q�5v   Q   ��5t      �� *UserTwitLists+ 5u      �� *SelectedTwit+5x      5y      5z      5{      � 5}   
   $��3��6   $��3��6#   .+�5~      �� ��6   �� *ContentView+5      5�      5�      