   M S B A M L   `   `   `  ����D  @SocialWeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SocialWeb.ViewsSocialWeb.Views  5          SocialWeb.Views.ChatsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SocialWeb.Views     5      A =Wpf.Ui, Version=3.0.5.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        N� Title$  	ChatsPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ 
BorderMain��5   %   ���#49a078 �� CornerRadius$ 	20 20 0 0��5   &   $��3��5      $��30��5      ._�5      � .+�5      �� $��Все��6   $
��Left=�6'   $
��15 0q�6B   $��Center=�5      
�������$��22(�5      $
��Bold"�6*   5      5       � 5"   
   $��1��6   $	��406��6    5#      �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $
��auto �6    �� 5'      .+�5*      � $
��15 0q�6   $��75��6!    5+      �� 5,      $
��auto �6'   �� 5-      $
��auto �6'   �� 5.      $��40 �6'   �� 5/      $��40 �6'   .+�52      �� $��Чаты��6   $
��Left=�6(   $��Center=�6C   $��20(�53      $��SemiBold"�6*     Wpf.Ui.Controls.Button  54      -   5          Name$ BTSearchChats��54      
������ 
������ $��2��55      .��56      �� $��/icoms/search.png��6   $��20��67   $��20��6C   57      d� 58      -   5         d�Name$ BTMoreOption��58      $��3��65   
������ $��0q�59      .��5:      �� $��/icoms/moreBT.png��6   $��20��67   5;      5<      �� 5>      -   5        $ SearchBorderBox��5>   -   $��20q�6   $��50��6!   $ 15��6F   ���#dce1de$��1��5?   *   ._�5@        Wpf.Ui.Controls.TextBox  -   5          Name$ TbSearchQuery��5@      $
��12 0q�64   
������ $��0q�5A         PlaceholderText$ Поиск...��61   $��Center=�6L   $��Center=�5B      5C      5D      5E      5F      