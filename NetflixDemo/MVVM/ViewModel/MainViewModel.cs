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

        public DelegateCommand<Window> LoadedCommand { get; set; }
        public MainViewModel()
        {
            LoadedCommand = new DelegateCommand<Window>(Loaded);
        }

        public void Loaded(Window sender)
        {
            LoadedControl = new HomeView();
        }
    }
}
