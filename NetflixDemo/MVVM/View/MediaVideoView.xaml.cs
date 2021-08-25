using NetflixDemo.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NetflixDemo.MVVM.View
{
    /// <summary>
    /// Interaction logic for MediaVideoView.xaml
    /// </summary>
    public partial class MediaVideoView : UserControl
    {
        DispatcherTimer timer;
        DispatcherTimer tiempo = new DispatcherTimer();
        double currentVolum = 0;
        MainViewModel main;
        public MediaVideoView()
        {
            InitializeComponent();
            DataContext = new MediaVideoViewModel();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
            mediacontrol.Play();
            main = Application.Current.MainWindow.DataContext as MainViewModel;

            tiempo.Tick += tiempo_Tick;
            tiempo.Interval = new TimeSpan(0, 0, 1);
        }

        private void SliderVideo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            mediacontrol.Position = TimeSpan.FromSeconds(sliderVideo.Value);
            Play();
        }
        private void DragComplete(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            mediacontrol.Position = TimeSpan.FromSeconds(sliderVideo.Value);
            Play();
        }

        int contador = 0;
        private void tiempo_Tick(object sender, EventArgs e)
        {
            contador += 1;
            if (contador == 3)
            {
                BorderMediaControls.Visibility = Visibility.Collapsed;
                tiempo.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                sliderVideo.Value = mediacontrol.Position.TotalSeconds;
                lbTime.Content = mediacontrol.Position.Minutes + ":" + mediacontrol.Position.Seconds + " / " + mediacontrol.NaturalDuration.TimeSpan.Minutes + ":" + mediacontrol.NaturalDuration.TimeSpan.Seconds;
            }
            catch
            {
                timer.Tick -= new EventHandler(timer_Tick);
            }
        }

        private void mediacontrol_MediaOpened(object sender, RoutedEventArgs e)
        {
            TimeSpan ts = mediacontrol.NaturalDuration.TimeSpan;
            sliderVideo.Maximum = ts.TotalSeconds;
            timer.Start();
        }

        private void PauseOrPlayVideo(object sender, RoutedEventArgs e)
        {
            if (PlayButton.Kind == MaterialDesignThemes.Wpf.PackIconKind.Pause)
                Pause();
            else
                Play();
        }

        public void Play()
        {
            PlayButton.Kind = MaterialDesignThemes.Wpf.PackIconKind.Pause;
            mediacontrol.Play();
        }
        public void Pause()
        {
            PlayButton.Kind = MaterialDesignThemes.Wpf.PackIconKind.Play;
            mediacontrol.Pause();
        }

        private void Vol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue == 0)
            {
                Vol_Image.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMute;
            }
            else if (e.NewValue < 0.6)
            {
                Vol_Image.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMedium;
                currentVolum = e.NewValue;
            }
            else
            {
                Vol_Image.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeHigh;
                currentVolum = e.NewValue;
            }
        }

        private void MuteVol(object sender, RoutedEventArgs e)
        {
            if (Vol_Image.Kind == MaterialDesignThemes.Wpf.PackIconKind.VolumeMute)
            {
                slidervol.Value = currentVolum;
            }
            else
            {
                slidervol.Value = 0;
            }
        }

        private void FullScreenClick(object sender, RoutedEventArgs e)
        {
            if (FullscreenImage.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowExpand)
            {
                FullscreenImage.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowCollapse;
                main.HeaderVisibility = Visibility.Collapsed;
                DetailPage.Visibility = Visibility.Collapsed;
                mediacontrol.Height = 1080;
                mediacontrol.Stretch = Stretch.UniformToFill;
            }
            else
            {
                FullscreenImage.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowExpand;
                main.HeaderVisibility = Visibility.Visible;
                DetailPage.Visibility = Visibility.Visible;
                mediacontrol.Height = 800;
                mediacontrol.Stretch = Stretch.Uniform;
            }
        }

        private void MediaElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (PlayButton.Kind == MaterialDesignThemes.Wpf.PackIconKind.Pause)
                Pause();
            else
                Play();

            if (e.ClickCount == 2 && FullscreenImage.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowExpand)
            {
                FullscreenImage.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowCollapse;
                main.HeaderVisibility = Visibility.Collapsed;
                DetailPage.Visibility = Visibility.Collapsed;
                mediacontrol.Height = 1080;
                mediacontrol.Stretch = Stretch.UniformToFill;

                if (PlayButton.Kind == MaterialDesignThemes.Wpf.PackIconKind.Pause)
                    Play();
                else
                    Pause();
            }
            else if (e.ClickCount == 2 && FullscreenImage.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowCollapse)
            {
                FullscreenImage.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowExpand;
                main.HeaderVisibility = Visibility.Visible;
                DetailPage.Visibility = Visibility.Visible;
                mediacontrol.Height = 800;
                mediacontrol.Stretch = Stretch.Uniform;

                if (PlayButton.Kind == MaterialDesignThemes.Wpf.PackIconKind.Pause)
                    Play();
                else
                    Pause();
            }
        }

        private void mediacontrol_MouseMove(object sender, MouseEventArgs e)
        {
            tiempo.Start();
            contador = 0;
            BorderMediaControls.Visibility = Visibility.Visible;
        }
        private void listView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
            {
                MainScroll.ScrollToVerticalOffset(MainScroll.VerticalOffset + 40);
            }
            else if (e.Delta > 0)
            {
                MainScroll.ScrollToVerticalOffset(MainScroll.VerticalOffset - 40);
            }
        }

        private void MoreDetailClick(object sender, RoutedEventArgs e)
        {
            if (StackPanelDetail.Height == 400)
            {
                StackPanelDetail.Height = 700;
            }
            else
            {
                StackPanelDetail.Height = 400;
            }
        }
    }
}
