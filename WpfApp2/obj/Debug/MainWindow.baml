   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          �Name$  paperPad��5   	    � Title$ Untitled- PaperPad��5   	   $��Consolas)�6$   $	��450��6;   $	��725��6H   $��16(�6T    � WindowStartupLocation$ CenterScreen=�6b   $��Center=�6�    � Icon$3 -Resources/Hopstarter-Sleek-Xp-Basic-Notes.ico��6�   .��5	      ]� .+�5
   
   o� $	��Top=�6   $��Consolas)�6$   $��13(�6:   .@�5      m� $��_File��6   .@�5      m� -   5         m�Name$ menunew��5      $
��_New��6,    m� InputGestureText$ Ctrl+N��6:    m� Icon 5      �� 5      $#��./Resources/new-file-icon.png��6    6I   5      m� 5      -   5        $ menuopen��5      $��_Open...��6-   $ Ctrl+O��6?    5      �� 5      $&�� ./Resources/folder-open-icon.png��6    6L   5      m� 5      -   5        $ menusave��5      $��_Save��6-   $ Ctrl+S��6<    5      �� 5      $0��*./Resources/Actions-document-save-icon.png��6    6V   5      m� 5      -   5        $ 
menusaveas��5      $��_Save As...��6/   5      �� 5      m� 5      -   5        $ 	menusetup��5      $��_Page Setup...��6.   5      m� 5       -   5        $ 	menuprint��5       $��	_Print...��6.   $ Ctrl+P��6A    5!      �� 5"      $ ��./Resources/print-icon.png��6    6F   5$      �� 5%      m� 5&      -   5        $ menuexit��5&      $��_Exit��6-    5'      �� 5(      $.��(./Resources/Actions-edit-delete-icon.png��6    6T   5*      5+      m� 5,      $
��Edit��6   .@�5-      m� -	   5        $ menuUndo��5-      $��_Undo��6-   $ Ctrl+Z��6<   5.      �� 5/      m� 50      -
   5        $ menucut��50      $
��_Cut��6,    m� Command$ ApplicationCommands.Cut��6:   $ Ctrl+X��6]   51      m� 52      -   5        $ menucopy��52      $��_Copy��6-   $ ApplicationCommands.Copy��6<   $ Ctrl+C��6_   53      m� 54      -   5        $ 	menupaste��54      $��_Paste��6.   $ ApplicationCommands.Paste��6>   $ Ctrl+V��6b   55      m� 56      -   5        $ 
menudelete��56      $��_Delete��6/   $	 Del��6@   57      �� 58      m� 59      -   5        $ menufind��59      $��_Find...��6-   $ Ctrl+F��6?   5:      m� 5;      -   5        $ menufindnxt��5;      $��
_Find Next��60   $ F3��6D   5<      m� 5=      -   5        $ menureplace��5=      $��_Replace...��60   $ Ctrl+H��6E   5>      m� 5?      -   5        $ menugoto��5?      $��	_Go To...��6-   $ Ctrl+G��6@   5@      �� 5A      m� 5B      -   5        $ 
menuselall��5B      $��_Select All��6/   $ Ctrl+A��6D   5C      m� 5D      -   5        $ menutimedate��5D      $��
_Time/Date��61   $ F5��6E   5E      5F      m� 5G      $��Format��6   .@�5H      m� -   5        $ menuwordwrap��5H      $��
_Word Wrap��61   6b   m� 5I      -   5        $ menufont��5I      $��_Font...��6-   .@�5J      m� -   5        $ menuFontsize��5J      $��	Font Size��65   .@�5K      m� -   5        $ 	menusize5��5K   #   $	��5px��66    m� IsCheckable . 	 m� StaysOpenOnClick	 . 6�   m� 5L      -   5        $ 
menusize10��5L   #   $
��10px��67    . 	 . 6�   m� 5M      -   5        $ 
menusize15��5M   #   $
��15px��67    . 	 . 6�   m� 5N      -   5        $ 
menusize20��5N   #   $
��20px��67    . 	 . 6�   5O      m� 5P      -   5        $ menuFontstyle��5P      $
��Font��66   .@�5Q      m� -   5        $ menuFontConsolas��5Q   #   $��Consolas��6=    . 	 . 6�   m� 5R      -   5        $ menuFontTimes��5R   #   $��Times��6:    . 	 . 6�   m� 5S      -   5        $ menuFontArial��5S   #   $��Arial��6:    . 	 . 6�   m� 5T      -   5        $ menuFontCourier��5T   #   $��Courier��6<    . 	 . 6�   5U      5V      5W      m� 5X      $
��View��6   .@�5Y      m� -    5        $ menustatbar��5Y      $��_Status Bar��60   6G   5Z      m� 5[      $
��Help��6   .@�5\      m� -!   5        $ menuviewhelp��5\      $��
_View Help��61   6G   �� 5]      m� 5^      -"   5        $ 	menuabout��5^      $��_About PaperPad��6.   6I   5_      5`      �� 5a   
   -#   5        
 ��Name$
 
textboxDoc��5a      $ �� HorizontalScrollBarVisibility$ Visible=�6O   " �� VerticalScrollBarVisibility$ Visible=�6w    �� 
AcceptsTab .  �� AcceptsReturn .  �� 
LineHeight$ 2��6�   5b      5c      