   M S B A M L   `   `   `  ����B  >Agendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:NavigationDrawerPopUpMenu2NavigationDrawerPopUpMenu2  5   	   +    %NavigationDrawerPopUpMenu2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:NavigationDrawerPopUpMenu2     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��760��5      $
��1280��6'   
�������  � 
ResizeMode$  NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]    � WindowStyle$
 None=�6�    � 	Resources 5	         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5
   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 70Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5      � ���	#FFDEDEDE.+�5    
   � -   5         �Name$ GridMain��5       $��Right=�6!   $��Bottom=�6=   $	��700��6X   $
��1210��6e   � 5!   
   $��60��6   $	��Top=�6   ���	#FF2196F3 � ColumnDefinitions 5"      �� 5#      $��7* �6#   �� 5$      $	��38* �6#    J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�5)      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��1��6N   .+�5+      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen .  $��10q�6e      PopupContent. 5,      �� $	��150��6!   .+�5-      �� $��Settings��6!   �� 5.      -   5        $��
BtnUsuario��5.   4   $��Usuarios��6!   6F   �� 5/      -   5        $��	BtnUSobre��5/   1   $��Sobre��6!   6B   �� 50      �� 51      -   5        $��	BtnLogOut��51   2   $��Logout��6!   6C   �� 52      -   5        $��BtnSair��52   0   $
��Sair��6!   6?   53      54      55      �� 56      $��Center=�6   $��Center=�65   $��22(�6P   $��1��6^   $��271,15,438,15q�6n   Bristol Zanibini Hotel6�   57      � 58   
   -   5        $ GridMenu��58      $��65��6!   $
��Left=�6,   ���	#FF33288B 59        5:      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�5<      �� .+�5=      � $	��123��6   
������� J� RenderTransformOrigin$ 0.5,0.5&�67   z�5>      V� 5?      .~�5@      �� �� 5A      �� 5B      T� 5C      5D      .+�5F      �� -   5         ��Name$ ButtonOpenMenu��5F      $��60��65   $��60��6A   $��0,0,5,0q�6L   $��Right=�6]   $	��Top=�6y    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF2196F3��6�   Z� ��6�   Z� .��5G      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�62   $��25��6>   $��25��6I   5H      �� 5I      -   5        $ ButtonCloseMenu��5I      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5J        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5K      �� 5M      $��55��6   $��Bottom=�6(   $��Images/logo.jpeg��6C   $��0,0,0,3q�6]   5N      �� 5O      -	   5         ��Name$ ListViewMenu��5O      ���	#FF5C99D6$��Disabled=�6H   .@�5Q      �� -
   5         ��Name$ ItemHome��5Q   #   $��60��65   
�������.��5R      �� $ 
Horizontal=�6%   .+�5S        $ ViewDashboard=�66   $��25��6K   $��25��6W   $��10q�6b   
�������6n   �� 5T      $
��Home��6(   $��Center=�64   $��20 10q�6O   
�������6^   5U      5V      �� 5X      -   5        $ ItemCalendario��5X   #   $��60��6;   
�������.��5Y      �� $ 
Horizontal=�6%   .+�5Z        $ Calendar=�66   $��25��6F   $��25��6R   $��10q�6]   
������� � IsSharedSizeScope . 6|   �� 5[      $��
Calendario��6(   $��Center=�6:   $��20 10q�6U   
�������6d   5\      5]      �� 5_      -   5        $ ItemReserva��5_   #   $��60��68    � ForceCursor . 
������� . .��5`      �� $ 
Horizontal=�6%   .+�5a        $ ContentSaveAll=�66   $��25��6L   $��25��6X   $��10q�6c   
������� . 6�   �� 5b      $��Reserva��6(   $��Center=�67   $��20 10q�6S   
�������6b   5c      5d      �� 5f      -   5        $ 
ItemStatus��5f   #   $��60��67    . 
������� . .��5g      �� $ 
Horizontal=�6%   .+�5h        $ CheckAll=�66   $��25��6F   $��25��6R   $��10q�6]   
������� . 6|   �� 5i      $��status��6(   $��Center=�66   $��20 10q�6R   
�������6a   5j      5k      �� 5m      -   5        $ ItemHorario��5m   #   $��60��68   
������� . .��5n      �� $ 
Horizontal=�6%   .+�5o        $ Clock=�66   $��25��6C   $��25��6O   $��10q�6Z   
�������6f   �� 5p      $��Horario��6(   $��Center=�67   $��20 10q�6S   
�������6b   5q      5r      �� 5t      -   5        $ ItemRelatorio��5t   #   $��60��6:    . 
������� . .��5u      �� $ 
Horizontal=�6%   .+�5v        $ FileDocument=�66   $��25��6J   $��25��6V   $��10q�6a   
������� . 6�   �� 5w      $��	Relatorio��6(   $��Center=�69   $��20 10q�6U   
�������6d   5x      5y      �� 5{      -   5        $ 
ItemBranco��5{   #   $��60��67   
�������.��5|      �� $ 
Horizontal=�6%   .+�5}        $ 
DesktopMac=�66   $��25��6H   $��25��6T   $��10q�6_   
�������6k   �� 5~      $
��Home��6(   $��Center=�64   $��20 10q�6O   
�������6^   5      5�      5�      5�      5�      5�      5�      