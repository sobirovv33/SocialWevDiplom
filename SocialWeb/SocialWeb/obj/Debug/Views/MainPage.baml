   M S B A M L   `   `   `  ����D  @SocialWeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SocialWeb.ViewsSocialWeb.Views  5          SocialWeb.Views.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SocialWeb.Views     5      A =Wpf.Ui, Version=3.0.5.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        N� Title$  MainPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ SidebarColumn��5   )   $��0 �6   6)   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ Sidebar��5   3   $��0��6   ���#333$	��200��6D   ._�5      �� $��0 50 0 0q�6   .+�5      �� -   5         ��Name$ BtChats��5         SidebarButtonStyle#��[  5      .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/icoms/message.png��6    $��24��6<   $��24��6G   $
��10,0q�6S   �� 5      $��Чаты��6$   $��Center=�60   $
��10,0q�6K   5      5      �� 5      #��[  6   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��/icoms/settings.png��6    $��24��6=   $��24��6H   $
��10 0q�6T   �� 5      $��Настройки��6$   $��Center=�65   $
��10,0q�6P   5      5       �� 5!      -   5        $ 	BTProfile��5!   E   #��[  6   .��5"      �� $ 
Horizontal=�6!   .+�5#      �� $��/icoms/personal.png��6    $��24��6=   $��24��6H   $
��10 0q�6T   �� 5$      $��Профиль��6$   $��Center=�63   $
��10,0q�6N   5%      5&      �� 5'      -   5        $ BTListFriends��5'   E   #��[  6   .��5(      �� $ 
Horizontal=�6!   .+�5)      �� $��/icoms/friends.png��6    $��24��6<   $��24��6G   $
��10 0q�6S   �� 5*      $��Друзья��6$   $��Center=�62   $
��10 0q�6M   5+      5,      5-      5.      � 50   
   $��1��6   .+�51       � -   5          �Name$ 
EnterFrame��51        � NavigationUIVisibility$ Hidden=�6(   52      �� 53      -   5        $ BTToggleSidebar��53      $	��☰��6.   $
��Left=�6:   $	��Top=�6U   $��40��54      $��40��6    $��1��6J   55      56      