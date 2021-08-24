using System;
using System.Windows;
using System.Windows.Input;

namespace NetflixDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BorderDrag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Close_ButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void Minimize_ButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        //private void WindowState_ButtonClick(object sender, RoutedEventArgs e)
        //{
        //    if (App.Current.MainWindow.WindowState == WindowState.Normal)
        //        Application.Current.MainWindow.WindowState = WindowState.Maximized;
        //    else
        //        Application.Current.MainWindow.WindowState = WindowState.Normal;
        //}
    }
}
