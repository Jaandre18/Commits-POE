   M S B A M L   `   `   `  ����G  CRecipes_Menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Recipes_Menu.ViewsRecipes_Menu.Views  5          Recipes_Menu.Views.HomePg   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Recipes_Menu.Views     5        N� Title$  HomePg��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��73* �6   �� 5      $
��269* �6   �� 5      $	��92* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Welcome to the Home Page��6   $��Center=�63   $��0,40,0,0q�6P   $	��Top=�6b   $	��171��6z   �� 5   
   $��Recipe Name��6   $
��Left=�6&   $��	55,23,0,0q�6A   $��1��6T   $	��Top=�6a   �� 5   
   $��Ingredients��6   $
��Left=�6&   $��	55,54,0,0q�6A   $��1��6T   $	��Top=�6a   $��80��6y   �� 5   
   $��Steps��6   $
��Left=�6    $��	55,84,0,0q�6;   $��1��6N   $	��Top=�6[   �� 5   
   $��
Food Group��6   $
��Left=�6%   $��
55,117,0,0q�6@   $��1��6T   $	��Top=�6a   �� 5   
   $��Calories��6   $
��Left=�6#   $��
55,150,0,0q�6>   $��1��6R   $	��Top=�6_   �� 5   
   -   5         ��Name$ txtRecipeName��5      $
��Left=�6)   $��
156,27,0,0q�6D   $��1��6X    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtIngredients��5      $
��Left=�6*   $��
156,62,0,0q�6E   $��1��6Y   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtSteps��5      $
��Left=�6$   $��
156,88,0,0q�6?   $��1��6S   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -   5         ��Name$ Groups��5      $
��Left=�6#   $��156,121,0,0q�6>   $��1��6S   $	��Top=�6`   $	��120��6x   6�   �� 5   
   -   5        $ txtCalories��5      $
��Left=�6'   $��156,154,0,0q�6B   $��1��6W   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5    
   -   5        $��Create��5       $
��Left=�6"   $��121,199,0,0q�6=   $��1��6R   $	��Top=�6_   6w   �� 5!   
   -   5        $��Clear��5!      $��Center=�6!   $��	0,199,0,0q�6>   $��1��6Q   $	��Top=�6^   6v   5"      5#      