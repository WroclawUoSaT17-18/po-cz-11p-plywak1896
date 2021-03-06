using System.Windows.Shell;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;
using Clientnaokienkach;
// <copyright file="MainWindowFactory.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;

namespace Clientnaokienkach
{
    /// <summary>A factory for Clientnaokienkach.MainWindow instances</summary>
    public static partial class MainWindowFactory
    {
        /// <summary>A factory for Clientnaokienkach.MainWindow instances</summary>
        [PexFactoryMethod(typeof(MainWindow))]
        public static MainWindow Create(
            string tekst_s,
            MainWindow okno_mainWindow1,
            Button button_send_button,
            Button button_con_button1,
            Button button_dis_button2,
            TextBlock txt_sts_textBlock,
            Button button_new_button3,
            TextBlock txa_textBlock1,
            TextBlock txb_textBlock2,
            Button button_clr_button4,
            Button button_1_button5,
            Button button_3_button6,
            Button button_5_button7,
            Button button_2_button8,
            Button button_4_button9,
            Button button_6_button10,
            TextBlock txc_textBlock3,
            TextBlock txd_textBlock4,
            TextBlock statyczny_textBlock5,
            TextBlock cena_textBlock6,
            TaskbarItemInfo value_taskbarItemInfo,
            WindowStartupLocation value_i,
            Window value_window,
            bool? value_nullb,
            Size value_size,
            Size availableSize_size1,
            Rect finalRect_rect
        )
        {
            MainWindow mainWindow = new MainWindow();
            ((ISupportInitialize)mainWindow).BeginInit();
            mainWindow.tekst = tekst_s;
            mainWindow.okno = okno_mainWindow1;
            mainWindow.button_send = button_send_button;
            mainWindow.button_con = button_con_button1;
            mainWindow.button_dis = button_dis_button2;
            mainWindow.txt_sts = txt_sts_textBlock;
            mainWindow.button_new = button_new_button3;
            mainWindow.txa = txa_textBlock1;
            mainWindow.txb = txb_textBlock2;
            mainWindow.button_clr = button_clr_button4;
            mainWindow.button_1 = button_1_button5;
            mainWindow.button_3 = button_3_button6;
            mainWindow.button_5 = button_5_button7;
            mainWindow.button_2 = button_2_button8;
            mainWindow.button_4 = button_4_button9;
            mainWindow.button_6 = button_6_button10;
            mainWindow.txc = txc_textBlock3;
            mainWindow.txd = txd_textBlock4;
            mainWindow.statyczny = statyczny_textBlock5;
            mainWindow.cena = cena_textBlock6;
            ((Window)mainWindow).TaskbarItemInfo = value_taskbarItemInfo;
            ((Window)mainWindow).WindowStartupLocation = value_i;
            ((Window)mainWindow).Owner = value_window;
            ((Window)mainWindow).DialogResult = value_nullb;
            ((UIElement)mainWindow).RenderSize = value_size;
            ((UIElement)mainWindow).Measure(availableSize_size1);
            ((UIElement)mainWindow).Arrange(finalRect_rect);
            ((Window)mainWindow).Show();
            ((ISupportInitialize)mainWindow).EndInit();
            return mainWindow;

            // TODO: Edit factory method of MainWindow
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
