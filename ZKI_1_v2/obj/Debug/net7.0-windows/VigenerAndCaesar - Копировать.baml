   M S B A M L   `   `   `  ����>  :ZKI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ZKI_1_v2ZKI_1_v2  5   	       ZKI_1_v2.VigenerAndCaesar   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ZKI_1_v2     5   	     � Title$  VigenerAndCaesar��5   	   $	��592��6"   $	��800��6/   .��5	      � .+�5
   
   �� -   5        $��Start��5
      $
��Left=�6!   $��215,301,0,0q�6<   $	��Top=�6Q   $	��142��6i   6u   �� 5   
   -   5         ��Name$ checkBoxEncrypt��5      $��Encript��6,   $
��Left=�6>   $��213,265,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5        $ checkBoxDecrypt��5      $��Decript��6,   $
��Left=�6>   $��299,265,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5         ��Name$ textBoxWord��5      $
��Left=�6'   $��213,100,0,0q�6B    �� TextWrapping$
 Wrap=�6W   $��Enter word or select file��6k   $	��Top=�6�   $	��144��6�   $
{�True��6�   $��45��6�   �� 5   
   -   5        $ textBoxCaesarKeyNum��5      $
��Left=�6/   $��
25,101,0,0q�6J   $
 Wrap=�6^   $��Caesar key number��6r   $	��Top=�6�   $	��144��6�    �� 	MaxLength$ 8��6�   6�   �� 5   
   -   5        $��	Load File��5      $
��Left=�6%   $��213,150,0,0q�6@   $	��Top=�6U   $	��144��6m   6y   �� 5   
   -   5        $ textBoxResult��5      $
��Left=�6)   $��213,192,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6n   $��Result��6�   $	��144��6�   ${�False��6�   $��68��6�   �� 5   
   $��Vigener and Caesar��6   $��Center=�6-   $��0,10,0,0q�6J   $	��Top=�6\   $	��500��6t   $��82��6�   $��55(�6�   �� 5   
   -   5        $
��MENU��5      $
��Left=�6    $��215,326,0,0q�6;   $	��Top=�6P   $	��142��6h   6t   �� 5   
   -	   5        $ textBoxCaesarKeyWord��5      $
��Left=�60   $��
25,124,0,0q�6K   $
 Wrap=�6_   $��Caesar key word��6s   $	��Top=�6�   $	��144��6�   $ 26��6�   6�   �� 5   
   -
   5        $ textBoxVigenerKeyWord��5      $
��Left=�61   $��
25,148,0,0q�6L   $
 Wrap=�6`   $��Vigener key word��6t   $	��Top=�6�   $	��144��6�   $ 4��6�   6�   �� 5   
   -   5        $! textBoxVigenerСryptosystem��5      $
��Left=�66   $��
460,97,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��198��6�   $	��420��6�   ${�False��6�   5      5      