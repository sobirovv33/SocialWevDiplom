   M S B A M L   `   `   `  ����D  @SocialWeb, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SocialWeb.ViewsSocialWeb.Views  5      %    SocialWeb.Views.EditProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SocialWeb.Views     5      A =Wpf.Ui, Version=3.0.5.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5        N� Title$  EditProfilePage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� -   5         ��Name$ BTBack��5      $	��←��5      
������ 
������ 5   !   �� 5   
   $/��)Редактировать профиль��6   
�������$��Center=�5      $
��Bold"�61   $��20(�6C   � 5   
   $��1��6   .+�5      �� .+�5      � .+�5      �� $
��Left=�6!   .+�5      �� $��Имя:��6    $��5q�6/   $
��Bold"�6:     Wpf.Ui.Controls.TextBox  5      -   5          Name$ TbName��5   H   $	��300��6%   $��5q�61   $��5q�6<   ��5   "   �� *Name+�� 5      -   5        $��NameErrorText��5   $   
���  ��$y�	Collapsed=�6J   $��10,5,0,0q�6a   $��10(�6s   �� 5!      $��Фамилия:��6    $
��Bold"�63   $��5q�6E     5"      -   5        $ 	TbSurname��5"   %   $��5q�68   ��6D   �� *	Surname+�� 5#      -   5        $��SurnameErrorText��5#   $   
���  ��$y�	Collapsed=�6M   $��10,5,0,0q�6d   $��10(�6v   �� 5%      $��Отчествео:��6    $
��Bold"�65   $��5q�6G     5&      -   5        $ 
TbLastName��5&   %   $��5q�6S   ��69   �� *
LastName+6S   �� 5'      -   5        $��LastNameErrorText��5'   $   
���  ��$y�	Collapsed=�6N   $��10,5,0,0q�6e   $��10(�6w   �� 5)      $"��Номер телефона:��6    $
��Bold"�6:   $��5q�6L     5*      -   5        $ TbPhoneNumber��5*   %   $��5q�6<   ��6H   �� *PhoneNumber+�� 5+      -	   5        $��PhoneNumberErrorText��5+   $   
���  ��$y�	Collapsed=�6Q   $��10,5,0,0q�6h   $��10(�6z   �� 5-      $ ��Дата рождения:��6    $
��Bold"�69   $��5q�6K   (  "System.Windows.Controls.DatePicker  5.      -
   5          Name$ 
DpBirthday��5.   %   $��5q�6_      SelectedDate 69   �� *DataBirthDay+6_   �� 5/      -   5        $��DpBirhDayErrorText��5/   $   
���  ��$y�	Collapsed=�6O   $��10,5,0,0q�6f   $��10(�6x   �� 51      $3��-Адрес электронной почти:��6    $
��Bold"�6C   $��5q�6U   �� 52      -   5         ��Name$ TbEmail��52   "   $��5q�6J   ��63   �� *Email+6J   �� 53      -   5        $��EmailErrorText��53   $   
���  ��$y�	Collapsed=�6K   $��10,5,0,0q�6b   $��10(�6t   55      �� 57      $��Center=�6!   $��Right=�6<   $��	250 0 0 0q�6X   .+�58      A� $	��200��6"   $	��200��6.   ��59      �� 5:   "    �� ImageSource 6-   �� *	ImageUser+5<      �� 5=      -   5         ��Name$ 
TBAddImage��5=   $   $��Изменить фото��68   
����  �$
��Bold"�5>   $   $��Center=�6W   5?      5@      � 5B      $��Center=�6   .+�5C      �� -   5        $ BTSave��5C      $��Сохранить��6B   $��5q�6V   $	��250��6a   5D      5E      5F      5G      5H      