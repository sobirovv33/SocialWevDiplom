   M S B A M L   `   `   `  ����D  @SocialWeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SocialWeb.ViewsSocialWeb.Views  5      %    SocialWeb.Views.ListFriendsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SocialWeb.Views     5      A =Wpf.Ui, Version=3.0.5.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        N� Title$  ListFriendsPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��Список друзей��6   $��Center=�6)   $��30(�6F   
�������$
��Bold"�5   '   � 5   
   $��1��6   $��Right=�6   $	��250��68   .+�5      �� -   5         ��Name$ BtAddFriend��5   J   $��1��6   $��Right=�6"   $	��200��6>   $��35��5      $��5q�6!   $��Добавить��6,   6?   5      � 5   
   $��1��6   $	��400��6   $
��Left=�6(   $��	20 10 0 0q�6C   .+�5        Wpf.Ui.Controls.TextBox  -   5          Name$ TBSearch��5      $��Center=�6+   $��30,0,5,0q�6F      PlaceholderText$  Поиск друзей...��5      ���#333333
����������#555555$��5q�5   B   5      �� 5       $��/icoms/search.png��6   $��16��6/   $��16��6:   $��8,0,0,0q�6F   $��Center=�5!      $
��Left=�6'   5"      �� 5#   
   -   5         ��Name$ TbFriendText��5#      $,��&У вас пока нет друзей��6*   $��30(�6G   
�������$
��Bold"�5$   &   $��Center=�68   $��Center=�5%      $��2��6/   $y�	Collapsed=�6<     Wpf.Ui.Controls.ListView  5&   
   -   5          Name$ 	LVFriends��5&      $��2��6)   $��20q�66   ���#444444$��0q�5'      
���������5)      �� 5*      .R�5+      �� $��0,0,0,1q�6   ���#555555 �� Padding$ 10q�6M   ._�5,      �  � ColumnDefinitions 5-      �� 5.   "   $
��Auto �63   �� 5/   "   $��* �63   �� 50   "   $
��Auto �63   .+�52      � .+�54      ��    ProfileImageStyle#��[  6A   ��6$   �� *	ImageUser+6A   �� 56      $��16(�6U   $��Center=�6c   $
��Bold"�57   (   
�������$��1��6M   ��56   (   �� *	Surname+	 �� StringFormat$		 {0}��57   M   �� 58      $��16(�6T   $��Center=�6b   $
��Bold"�59   (   
�������$��1��6M   ��58   (   �� *Name+$	   {0}��59   M   5:        Wpf.Ui.Controls.Button  5;      $��Right=�6(   $��	750 0 0 0q�6D   
������ 
�������.��5=   "   � $��0 0 0 0q�6,   .+�5>   &   �� $��/icoms/message.png��6,   $��30��6H   $��30��6S   5?   #   5@        5A      
  Name$
 BTAddFriend��5B   (   $��Right=�5A   (   
������ 
������ .��5C   "     Wpf.Ui.Controls.Image     Source$ /icoms/addfriend.png��6+   $��30��6I   $��30��6T   $��0 0 70 0q�5D   +   5E      5F      5G      5H      5J      5K      5L      