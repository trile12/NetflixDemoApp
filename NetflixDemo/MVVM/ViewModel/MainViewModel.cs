using NetflixDemo.Core;
using NetflixDemo.MVVM.View;
using Prism.Commands;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NetflixDemo.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private UserControl _LoadedControl;

        public UserControl LoadedControl
        {
            get { return _LoadedControl; }
            set
            {
                _LoadedControl = value;
                OnPropertyChanged();
            }
        }
        private Visibility _HeaderVisibility;

        public Visibility HeaderVisibility
        {
            get { return _HeaderVisibility; }
            set
            {
                _HeaderVisibility = value;
                OnPropertyChanged();
            }
        }


        public DelegateCommand<Window> LoadedCommand { get; set; }
        public DelegateCommand HomeCommand { get; set; }
        public MainViewModel()
        {
            LoadedCommand = new DelegateCommand<Window>(Loaded);
            HomeCommand = new DelegateCommand(HomeClick);
        }

        public void Loaded(Window sender)
        {
            LoadedControl = new HomeView();
        }
        public void HomeClick()
        {
            LoadedControl = new HomeView();
        }
    }
}
