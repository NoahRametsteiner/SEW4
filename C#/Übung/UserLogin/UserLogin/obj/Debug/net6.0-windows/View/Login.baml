   M S B A M L   `   `   `  ����D  @UserLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:UserLogin.ViewModelUserLogin.ViewModel  5   	       UserLogin.View.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1src!clr-namespace:UserLogin.ViewModel     5   	     � Title$  LoginScreen��5   	   $	��300��6   $	��300��6*   $��14(�66   ���#04c582 � DataContext 5	      #  UserLogin.ViewModel.ViewModel  5
   
   .��5      �� 
���   � �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �� $��20q�6   .+�5      �� $��Login��6   
�������$��25(�67   $��Center=�6E   �� 5      $��Email��6   
�������6$   �� 5      
���   �$��14(�6E   ��6   ��  �� Path$ Email�6E   �� 5      $��Password��6   
�������6'   G� 5      -   5         G� Password$  ��5      
���   �$��14(�6U   �� 5      $��Submit��6   
�������$��60��69   $��1q�6D   ��6O   �� $ Login��� 5      $��Register��6   
�������$��60��6;   $��1q�6F   ��6Q   �� $ Register�5      5      5      