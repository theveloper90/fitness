   M S B A M L   `   `   `  ����B  >fitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:fitness.Propertiesfitness.Properties  5      5    /fitness.Views.ManageConnectionString.SettingsDB   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      1
properties clr-namespace:fitness.Properties  5      -   5        "   fitness.Properties.Resources    txt_TitleSetingDB � Title# Z  5	      $��352.503��5
      $��550.572��5      $	��300��5      $	��400��5      $	��370��5      $	��550��5       � 
ResizeMode$ CanMinimize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � -   5        ���	#FF0D83DD.+�5   
   �� $��10q�5      $
��Left=�5      $	��Top=�5      .+�5      �� -   5         ��Name$ 	Btn_Close��5      $��70��5      $��40��5      $��10q�5      ��5       Z� ��5!      Z� .��5#      '  !MaterialDesignThemes.Wpf.PackIcon  $��35��5$      $��35��5%         Kind$ CloseCircle=�5&      5'      5(      �� 5)   
   $��Center=�6   .+�5*      �� -   5         ��Name$ txt_TitleSetingDB��5+      $
��0,30q�5,      $��Center=�5-      #��Z  5.      $��Captura Demo)�5/      $��18(�50      
�������51      52      �� 53   
   $��10q�54      $��Right=�55      $	��Top=�56      .+�57      �� -   5        $ Btn_License��58      $��70��59      $��40��5:      $��10q�5;      ��5<      Z� ��5=      Z� .��5?        $��35��5@      $��35��5A      $ License=�5B      5C      5D      �� 5E   
   $��30,30,18,30q�6   .+�5F      �� -   5         ��Name$ PanelDbInfo��5G      $	��444��5H      $��10,40,21,40q�5I      
�������	 �� CornerRadius$	 5��5K      
 J� Effect
 5M      3  -System.Windows.Media.Effects.DropShadowEffect  5N         
BlurRadius$ 20Q�5O         RenderingBias$ Quality=�5P         ShadowDepth$ 1Q�5Q         Color$ 	#FFA2A2A2��5R      ._�5T      �� -   5         ��Name$ Pnl_DBSetting��5T      $��20q�64   .+�5U      �� -   5         ��Name$ txt_ServerName��5V      $��15q�5W         txt_ServerName)  #MaterialDesignThemes.Wpf.HintAssist   Hint# Z 5X       �� 
CaretBrush �	#FF0D83DD %  !MaterialDesignFloatingHintTextBox#��[  5Z       � ToolTip# Z 5[      �� 5\      -	   5        $ 
txt_DBName��5]      $��15q�5^         
txt_DBName# Z 5_       �	#FF0D83DD#��[  5a      # Z 5b      �� 5c      -
   5        $ txt_UserName��5d      $��15q�5e         txt_UserName# Z 5f       �	#FF0D83DD#��[  5h      # Z 5i      G� 5j      -   5         G�Name$ pw_Password��5k      $��15q�5l         pw_Password# Z 5m       G� 
CaretBrush �	#FF0D83DD ) %MaterialDesignFloatingHintPasswordBox#��[ 5o      # Z 5p      �� 5q      $��0,50,0,0q�5r      $��center=�5s       �� Orientation$ 
Horizontal=�5t      .+�5u      �� -   5        $ Btn_Save_DBSetting��5v      $	��120��5w      $��Center=�5x      ���	#FF0D83DD   Btn_Save_DBSetting#��Z 5|      
���������5z      Z� 5}      �� 5~      -   5        $ 
Btn_Cancel��5      $	��120��5�      $��Center=�5�      ���	#FF0D83DD   
Btn_Cancel#��Z 5�      
���������5�      Z� 5�      5�      5�      5�      5�      5�      5�      