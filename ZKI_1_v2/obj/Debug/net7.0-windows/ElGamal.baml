   M S B A M L   `   `   `  ����>  :ZKI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ZKI_1_v2ZKI_1_v2  5   	       ZKI_1_v2.ElGamal   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ZKI_1_v2     5   	     � Title$  ElGamal��5   	   $	��592��6   $	��800��6&   .��5	      � .+�5
   
   �� -   5        $��Start��5
      $
��Left=�6!   $��215,301,0,0q�6<   $	��Top=�6Q   $	��142��6i   6u   �� 5   
   -   5         ��Name$ checkBoxEncrypt��5      $��Encript��6,   $
��Left=�6>   $��213,265,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5        $ checkBoxDecrypt��5      $��Decript��6,   $
��Left=�6>   $��299,265,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5         ��Name$ textWord��5      $
��Left=�6$   $��213,100,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $��Enter word or select file��6h   $	��Top=�6�   $	��144��6�   $��45��6�   �� 5   
   -   5        $ textP��5      $
��Left=�6!   $��
25,101,0,0q�6<   $
 Wrap=�6P   $��Enter P��6d   $	��Top=�6s   $	��144��6�    �� 	MaxLength$ 8��6�   6�   �� 5   
   -   5        $��	Load File��5      $
��Left=�6%   $��213,150,0,0q�6@   $	��Top=�6U   $	��144��6m   6y   �� 5   
   -   5        $ 
textResult��5      $
��Left=�6&   $��213,192,0,0q�6A   $
 Wrap=�6V   $	��Top=�6k   $��Result��6�   $	��144��6�   ${�False��6�   $��68��6�   �� 5   
   $��El Gamal��6   $��Center=�6#   $��0,10,0,0q�6@   $	��Top=�6R   $	��224��6j   $��82��6v   $��55(�6�   �� 5   
   -   5        $
��MENU��5      $
��Left=�6    $��215,326,0,0q�6;   $	��Top=�6P   $	��142��6h   6t   �� 5   
   -	   5        $ textX��5      $
��Left=�6!   $��
25,124,0,0q�6<   $
 Wrap=�6P   $��Enter X��6d   $	��Top=�6s   $	��144��6�   $ 26��6�   6�   �� 5   
   -
   5        $ textG��5      $
��Left=�6!   $��
25,148,0,0q�6<   $
 Wrap=�6P   $
��G = ��6d   $	��Top=�6p   $	��144��6�   $ 4��6�   ${�False��6�   �� 5   
   -   5        $ textK��5      $
��Left=�6!   $��
25,171,0,0q�6<   $
 Wrap=�6P   $
��K = ��6d   $	��Top=�6p   $	��144��6�   $ 4��6�   ${�False��6�   �� 5   
   -   5        $ textY��5      $
��Left=�6!   $��
25,194,0,0q�6<   $
 Wrap=�6P   $
��Y = ��6d   $	��Top=�6p   $	��144��6�   $ 4��6�   ${�False��6�   �� 5   
   -   5        $��	Calculate��5      $
��Left=�6%   $��
27,226,0,0q�6@   $	��Top=�6T   $	��142��6l   6x   5      5      