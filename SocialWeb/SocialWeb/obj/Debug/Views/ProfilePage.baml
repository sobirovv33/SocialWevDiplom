   M S B A M L   `   `   `  ����D  @SocialWeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SocialWeb.ViewsSocialWeb.Views  5      !    SocialWeb.Views.ProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SocialWeb.Views     5      A =Wpf.Ui, Version=3.0.5.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5      -   5          N� Title$  ProfilePage��5
      .��5      �� .��5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $
��Left=�6   $��	60 30 0 0q�68   .+�5      A� $	��150��6   $	��150��6+   ��5      �� 5      -   5        	UserImage�� �� ImageSource 5   <   �� *	UserImage+5      � 5      .+�5      �� $��5q�6=   $
��Bold"�6H   
���������6$   �� *	Surname+6Z   �� 5       $��5q�6:   $
��Bold"�6E   
���������6$   �� *Name+6W   5!      5"      � 5$      $��1��6   $��Center=�6,   $��Center=�6I   .+�5%      �� $��5q�6!   .+�5&      �� $��10��6$   $��Center=�6.   
�������$
��Bold"�6^   �� 5'      $��Публикации��6    $
��Bold"�65   5(      �� 5*      $��5q�6!   .+�5+      �� $��20��6$   $��Center=�6.   
�������$
��Bold"�6^   �� 5,      $��Друзья��6    $
��Bold"�61   5-      �� 5/      $��5q�6!   .+�50      �� $��30��6$   
�������$��Center=�6A   $
��Bold"�6^   �� 51      $��Подписчики��6    $
��Bold"�65   52      53      54      � 55      $��1��6   .+�56      � $��Center=�6   $��5q�69   .+�57      �� -   5         ��Name$ BTEditProfile��57      $	��350��58      $��30��6)   $��0 0 50 0q�65   $
��Bold"�6G   .��59      � .+�5:      �� $��/icoms/edit.png��6$   �� 5;      $/��)Редактировать профиль��6(   $��	15 0 00 0q�6E   5<      5=      �� 5>      -   5        $ 	BTAddPost��5>      $	��350��5?      $��30��6)   $��0 0 50 0q�65   $
��Bold"�6G   .��5@      � .+�5A      �� $��/icoms/add.png��6$   �� 5B      $+��%Добавить публикацию��6(   $��15 0 0 0q�6C   
�������5C   (   5D      5E      5F      5G      5H      5I      5J      