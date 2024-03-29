﻿using NetflixDemo.Core;
using NetflixDemo.MVVM.Model;
using NetflixDemo.MVVM.View;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NetflixDemo.MVVM.ViewModel
{
    public class HomeViewModel : ObservableObject
    {
        public ObservableCollection<MovieModel> Movies { get; set; }
        public ObservableCollection<CategoryModel> CategoryMovie { get; set; }

        private MovieModel _selectedMovie;

        public MovieModel SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                if (value != null)
                {
                    _selectedMovie = value;
                }
                OnPropertyChanged();
            }
        }

        private Visibility _IsVisibleMainView;

        public Visibility IsVisibleMainView
        {
            get { return _IsVisibleMainView; }
            set
            {
                _IsVisibleMainView = value;
                OnPropertyChanged();
            }
        }
        private double _sliderVideoValue;

        public double sliderVideoValue
        {
            get { return _sliderVideoValue; }
            set
            {
                _sliderVideoValue = value;
                OnPropertyChanged();
            }
        }

        private int _GridImageHeight;

        public int GridImageHeight
        {
            get { return _GridImageHeight; }
            set
            {
                _GridImageHeight = value;
                OnPropertyChanged();
            }
        }


        public RelayCommand SelectCommand { get; set; }
        public RelayCommand ClickPlayButton { get; set; }
        public DelegateCommand CollapseCommand { get; set; }

        public HomeViewModel()
        {
            Movies = new ObservableCollection<MovieModel>();
            CategoryMovie = new ObservableCollection<CategoryModel>();
            CreateDataTest();
            ClickPlayButton = new RelayCommand(Play);
            CollapseCommand = new DelegateCommand(CollapseEvent);
            GridImageHeight = 650;
        }

        private void CollapseEvent()
        {
            if (GridImageHeight == 15)
                GridImageHeight = 650;
            else
                GridImageHeight = 15;
        }

        public void CreateDataTest()
        {
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B1.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B2.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B3.jpg"
            });
            Movies.Add(new MovieModel
            {

                Name = "Stranger Thing",
                Description = "When a young boy vanishes, a small town uncovers a mystery involving secret experiments, terrifying supermatural forces and one strange little girl.",
                ImageSource = "./Icons/BG2.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B5.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B6.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B7.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B8.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B9.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B1.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B2.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B3.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B5.jpg"
            });

            SelectedMovie = Movies[3];
        }

        public void Play(object sender)
        {
            MainViewModel main = Application.Current.MainWindow.DataContext as MainViewModel;
            main.LoadedControl = new MediaVideoView();
        }
    }
}
