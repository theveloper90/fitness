   M S B A M L   `   `   `  ����B  >fitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:fitness.Views.Loginfitness.Views.Login  5      7 clr-namespace:fitness.Propertiesfitness.Properties  5	          fitness.Views.Login.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:fitness.Views.Login     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      1
properties clr-namespace:fitness.Properties  5	      -   5          � Title$  Login��5
      $	��400��5      $	��600��5       � 
ResizeMode$ CanMinimize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � -   5        ���	#FF0D83DD.+�5   
   �� $��10q�5      $
��Left=�5      $	��Top=�5      .+�5      �� -   5         ��Name$ 	Btn_Close��5      $��70��5      $��40��5      $��10q�5      ��5      Z� ��5      Z� .��5!      '  !MaterialDesignThemes.Wpf.PackIcon  $��35��5"      $��35��5#         Kind$ CloseCircle=�5$      5%      5&      �� 5'   
   $��10q�5(      $��Right=�5)      $	��Top=�5*      .+�5+      �� -   5        $ Btn_Setting_LoginPage��5,      $��70��5-      $��40��5.      $��10q�5/      ��50      Z� ��51      Z� .��53        $��35��54      $��35��55      $ Settings=�56      57      58      �� 59   
   $��30q�6   .+�5:        $��96��5;      $��96��5<      $��Center=�5=      
�������$ FitnessCenter=�5?      �� 5@      -   5         ��Name$ 	PanelMove��5A      $��10,20q�5B      
������� �� CornerRadius$ 5��5D      $	��373��6"    J� Effect 5E      3  -System.Windows.Media.Effects.DropShadowEffect  5F      	   
BlurRadius$	 20Q�5G      
   RenderingBias$
 Quality=�5H         ShadowDepth$ 1Q�5I         Color$ 	#FFA2A2A2��5J      ._�5L      �� -   5         ��Name$ 	Pnl_Login��5L      $��30q�60   .+�5e      �� -   5         ��Name$ txt_UserName��5f      $��15q�5g      "   fitness.Properties.Resources   txt_UserName)  #MaterialDesignThemes.Wpf.HintAssist   Hint# Z 5h       �� 
CaretBrush �	#FF0D83DD %  !MaterialDesignFloatingHintTextBox#��[  5j      $��0��5k       � ToolTip# Z 5l      G� 5m      -   5         G�Name$ pw_Password��5n      $��15q�5o         pw_Password# Z 5p       G� 
CaretBrush �	#FF0D83DD ) %MaterialDesignFloatingHintPasswordBox#��[ 5r      $��1��5s      # Z 5t      �� 5u      $��center=�6!    �� Orientation$ 
Horizontal=�6>   .+�5v      �� -	   5        $ 	Btn_Login��5w      $��15,50q�5x      $��Center=�5y      ���	#FF0D83DD   	Btn_Login#��Z 5}      
������� �� 	IsDefault . $��2��5�      ��5{      Z� 5�      �� 5�      -
   5        $ 
Btn_Cancel��5�      $��15,50q�5�      $��Center=�5�      ���	#FF0D83DD   
Btn_Cancel#��Z 5�      
������� �� IsCancel . $��3��5�      ��5�      Z� 5�      5�      5�      5�      �� 5�      $��Center=�6   .+�5�      �� $	��0,2q�5�      $��Center=�5�      $
��Lato)�5�      $��18(�5�      
�������$��www.datacode.app��5�      5�      5�      5�      5�      