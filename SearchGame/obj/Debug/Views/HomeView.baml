   M S B A M L   `   `   `  ����E  ASearchGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SearchGame.ViewsSearchGame.Views  5      ;"clr-namespace:SearchGame.ViewModelSearchGame.ViewModel  5      3clr-namespace:SearchGame.ViewsSearchGame.Views  5          SearchGame.Views.HomeView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:SearchGame.Views     5      8	viewModel"clr-namespace:SearchGame.ViewModel     5      0viewsclr-namespace:SearchGame.Views     5        � 	Resources  5         DesktopIconListTemplate �� Orientation �� RelativeSource �� AncestorType �� 
TargetType  QuestListTemplate  	BoolToVis �� DataType,   &SearchGame.ViewModel.InternetViewModel#   SearchGame.Views.InternetView*   $SearchGame.ViewModel.SocialViewModel!   SearchGame.Views.SocialView(   "SearchGame.ViewModel.MailViewModel   SearchGame.Views.MailView��%�  &	        &	 �    &	 �    (�� �    51      *, +)(�� 0    55      *, +)(�� b    59      *, +)�� 5   
   .R�5      �� $ Vertical=�6   $��5q�60   .+�5      �� 
������ 
������ $��0q�5   L   ��5      �� *DataContext.OpenIcon+ �� *FindAncestor+" ��.��5      �� $��40��6;   $��40��6F   ��6   �� *ImageSource+6F   ��5      �� 5      " ��6*   .R�5      �� #��z��6/   5      5      �� 5      $��Center=�67   ��6   �� *	ImageName+67   5      5      �� 5    
   .R�5!      �� .+�5"      �� 
������ 
������ $��0q�6j   $��20(�6~   ��6   �� *	QuestName+��5#      �� *DataContext.LoadQuestView+ �� *FindAncestor+" ����5$      �� 5%      " ��6*   .R�5&      �� #��z��6/   5'      5)      5*      5+      �� 5-   
   6'   �� 51   
   "  6   .R�52        53      �� 55   
   "  6   .R�56        57      �� 59   
   "  6   .R�5:        5;      5=      .��5?      � 
������� � ColumnDefinitions 5@   
   �� 5A      $	��85* �6   �� 5B      $
��474* �6   �� 5C      $
��242* �6    � RowDefinitions 5E   
   �� 5F      $	��68* �6   �� 5G      $��7* �6   .+�5J   
   �� $7��1C:/Users/tuuna/Desktop/Search/Image/wallpaper.png��6   $��1��6K   $��0��6[   $
��Fill=�6h   �� 5M   
   $ Vertical=�6   $��0��6,   $��0��6<   
�������.+�5N      �� #��[  6    �� SelectedItem 5O      �� *SelectedIcon+��5P      �� *DesktopIconLists+5R      5S      �� 5U   
   $��0��6   $��1��6!   $��Option��6.   $��20(�6?   $
��Bold"�6M   $��Center=�6_   $��85��6|   ��5V      �� *
ExitGame+�� 5X   
   $��1��6   $��1��6%   $ 
Horizontal=�62   
�������5Z      ]� 5]   
   $��2��6   $��2��6$   
�������.+�5^      �� $	��Top=�6   $��Quest��6*   $��55��6:   
����p����5_      �� *LoadQuestList+�� 5`      $	��Top=�6   #��[ 6+   
������ 
������ $��20q�5b   p   ��5a      �� *
QuestLists+ 5b      �� *SelectedQuest+5d      5e      � 5h   
   $��1��6   $��0��6   y�6,   �� *QuestViewOpen+	 �� 	Converter#	 [  5i      �� 5j      $	��12* �6    �� 5k      $
��109* �6    �� 5l      $	��15* �6    .+�5o      �� $��0��6   $��0��6)   ���#681BAD$��0,0,0,0q�6K   .+�5p      �� $��35��6   $��35��6%   
������ 
������ $��Right=�6d   $��Center=�6�   ��5q      �� *CloseQuestView+.��5r      �� $3��-C:/Users/tuuna/Desktop/Search/Image/close.png��6   5s      5t      �� 5v      $��0��6   $��1��6%   
�������._�5w      �� .+�5x      �� ��6    �� *
QuestTitle+
 �� Mode$
 TwoWay=��� 5y      ��6    �� *QuestContent+$
 TwoWay=�5z      5{      ]� 5|      $��1��6   $��2��6(   
�������.+�5}      �� $	��382��6\   $��0,0,0,0q�6h   
���������6   �� *QuestAnswer+ �� UpdateSourceTrigger$ PropertyChanged=�6y   �� 5~      $��확인��6   $��20(�6&   $
��Bold"�64   
�������
��� ���
������ 6n   5      5�      � 5�   
   $��3��6   $��3��6#   .+�5�      �� ��6   �� *ContentView+5�      5�      5�      